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
	public class Protocol : IDisposable
	{
		private TcpClient _client;
		private CancellationTokenSource _cancellationtokenSource;
		private Task _listenTask;

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
		public event EventHandler<EventArgs> Stopped;

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
			

			throw new NotImplementedException();
		}

		public void Dispose()
		{
			Disconnect();
		}

		public void Disconnect()
		{
			_cancellationtokenSource?.Cancel();
			_client?.Close();
		}

		private void Listen()
		{
			throw new NotImplementedException();
		}

		private void SendAuthentication()
		{

		}
	}

	public class MessageReceivedEventArgs : EventArgs
	{
		public string Message { get; set; }
	}


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
}
