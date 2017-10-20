using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SRCDS_RCON.Net
{
	/// <summary>
	/// Handles all network connection and provides an interface for interacting with the server
	/// </summary>
	public class Protocol : IDisposable
	{
		/// <summary>
		/// The amount of empty bytes at the end of a packet.<para/>
		/// See https://developer.valvesoftware.com/wiki/Source_RCON_Protocol#Empty_String
		/// </summary>
		public const int PacketSuffixSize = 2;

		private TcpClient _client;
		private CancellationTokenSource _cancellationtokenSource;
		private Task _listenTask;

		private readonly object ReadLock = new object();
		private readonly object WriteLock = new object();

		private Server _currentServer = null;

		/// <summary>
		/// Occurs when the server sends the client a message, like the resposne to a comment
		/// </summary>
		public event EventHandler<MessageReceivedEventArgs> MessageReceived;

		/// <summary>
		/// Occurs when the client is connected and ready to send data
		/// </summary>
		public event EventHandler<EventArgs> Ready;

		/// <summary>
		/// Occurs when the client is disconnected
		/// </summary>
		public event EventHandler<EventArgs> Disconnected;

		/// <summary>
		/// Whether the client is connected or not
		/// </summary>
		public bool Connected
		{
			get
			{
				if (_client != null)
				{
					return _client.Connected;
				}
				else
				{
					return false;
				}
			}
		}

		public Protocol()
		{

		}

		~Protocol()
		{
			Dispose();
		}

		public void Connect(Server server)
		{
			if (Connected)
				Disconnect();

			_cancellationtokenSource = new CancellationTokenSource();

			_currentServer = server;

			_client = new TcpClient();
			try
			{
				_client.Connect(server.Hostname, server.Port);
			}
			catch (SocketException e)
			{
				Disconnect();

				throw new ConnectionFailedException(e.Message, e);
			}

			// send auth packet
			Packet authPacket = new Packet()
			{
				Type = PacketType.AUTH,
				Payload = server.Password
			};

			SendPacket(authPacket);

			// receive auth packet
			Packet authResponse;
			while (true)
			{
				Packet newPacket = ReadNextPacket();
				if (newPacket.Type != PacketType.AUTH_RESPONSE)
				{
					HandlePacket(newPacket);
					continue;
				}
				else
				{
					authResponse = newPacket;
					break;
				}
			}

			if (authResponse.PacketID == -1)
				throw new InvalidCredentialsException("Server rejected password");

			// set up everything else
			_listenTask = new Task(() =>
			{
				Listen();
			}, _cancellationtokenSource.Token);
			_listenTask.Start();

			Ready?.Invoke(this, new EventArgs());
		}

		public void Dispose()
		{
			Disconnect();
		}

		/// <summary>
		/// Disconnects the client safely and gets everything ready for another connection
		/// </summary>
		public void Disconnect()
		{
			_cancellationtokenSource?.Cancel();
			_client?.Close();
			_client = null;

			Disconnected?.Invoke(this, new EventArgs());
		}

		/// <summary>
		/// Sends a command to the server
		/// </summary>
		/// <param name="command"></param>
		public void SendCommand(string command)
		{
			if (!Connected)
				throw new Exception("Not connected to a server");

			Packet packet = new Packet()
			{
				Type = PacketType.COMMAND,
				Payload = command
			};

			SendPacket(packet);
		}

		/// <summary>
		/// Listens to the server on a loop, sending all packets to <see cref="HandlePacket"/>
		/// </summary>
		private void Listen()
		{
			while (Connected && !_cancellationtokenSource.IsCancellationRequested)
			{
				try
				{
					HandlePacket(ReadNextPacket());
				}
				catch (DisconnectedException)
				{
					Disconnect();
					return;
				}
			}
		}

		/// <summary>
		/// Handles a packet from the server, used if it's not already handled
		/// </summary>
		private void HandlePacket(Packet packet)
		{
			switch (packet.Type)
			{
				case PacketType.COMMAND_RESPONSE:
					MessageReceived?.Invoke(this, new MessageReceivedEventArgs()
					{
						Message = packet.Payload,
						Server = _currentServer
					});
					break;
				default:
					throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Sends a packet
		/// </summary>
		/// <param name="packet"></param>
		private void SendPacket(Packet packet)
		{
			lock (WriteLock)
			{
				byte[] buffer = packet.Raw;
				_client.GetStream().Write(buffer, 0, buffer.Length);
				_client.GetStream().Flush();
			}
		}

		/// <summary>
		/// Reads the next packet from the stream
		/// </summary>
		/// <returns></returns>
		private Packet ReadNextPacket()
		{
			lock (ReadLock)
			{
				// read length
				byte[] lengthBuffer = new byte[sizeof(int)];
				ReadFromStream(lengthBuffer, 0, lengthBuffer.Length);
				int length = BitConverter.ToInt32(lengthBuffer.ReverseLittleEndian(), 0);

				// read the rest of the packet
				byte[] packetBuffer = new byte[length];
				ReadFromStream(packetBuffer, 0, packetBuffer.Length);
				List<byte> packetBufferList = new List<byte>(packetBuffer);

				Packet packet = new Packet()
				{
					PacketID = getNextInt(packetBufferList),
					Type = (PacketType)getNextInt(packetBufferList),
					Body = packetBufferList.Take(packetBufferList.Count - PacketSuffixSize).ToArray()
				};

				return packet;
			}

			int getNextInt(List<byte> buffer)
			{
				int number = BitConverter.ToInt32(buffer.Take(4).ToArray().ReverseLittleEndian(), 0);
				buffer.RemoveRange(0, sizeof(int));
				return number;
			}
		}

		/// <summary>
		/// Reads from the client stream
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="offset"></param>
		/// <param name="size"></param>
		private void ReadFromStream(byte[] buffer, int offset, int size)
		{
			int bytesRead = 0;
			while (bytesRead < size)
			{
				int newBytesRead = _client.GetStream().Read(buffer, offset + bytesRead, size - bytesRead);
				if (newBytesRead == 0)
				{
					Disconnect();
					throw new DisconnectedException("Connection closed");
				}

				bytesRead += newBytesRead;
			}
		}
	}

	public class MessageReceivedEventArgs : EventArgs
	{
		public string Message { get; set; }
		public Server Server { get; set; }
	}

	/// <summary>
	/// This exception is thrown when the credentials supplied are not valid
	/// </summary>
	[Serializable]
	public class InvalidCredentialsException : Exception
	{
		public InvalidCredentialsException() { }
		public InvalidCredentialsException(string message) : base(message) { }
		public InvalidCredentialsException(string message, Exception inner) : base(message, inner) { }
		protected InvalidCredentialsException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}

	/// <summary>
	/// This exception is thrown when the Protocol is not used properly
	/// </summary>
	[Serializable]
	public class ProtocolException : Exception
	{
		public ProtocolException() { }
		public ProtocolException(string message) : base(message) { }
		public ProtocolException(string message, Exception inner) : base(message, inner) { }
		protected ProtocolException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}

	/// <summary>
	/// This exception is thrown when the client is forcibly disconnected
	/// </summary>
	[Serializable]
	public class DisconnectedException : Exception
	{
		public DisconnectedException() { }
		public DisconnectedException(string message) : base(message) { }
		public DisconnectedException(string message, Exception inner) : base(message, inner) { }
		protected DisconnectedException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}

	[Serializable]
	public class ConnectionFailedException : Exception
	{
		public ConnectionFailedException() { }
		public ConnectionFailedException(string message) : base(message) { }
		public ConnectionFailedException(string message, Exception inner) : base(message, inner) { }
		protected ConnectionFailedException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
