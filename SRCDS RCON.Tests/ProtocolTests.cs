using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Sockets;
using System.Net;
using SRCDS_RCON.Net;
using System.Threading.Tasks;
using System.Threading;

namespace SRCDS_RCON.Tests
{
	[TestCategory("Protocol")]
	[TestClass]
	public class ProtocolTests
	{
		/// <summary>
		/// Test that the <see cref="Protocol"/> class constructs correctly
		/// </summary>
		[TestMethod]
		public void Constructor_OK()
		{
			Protocol p = new Protocol();
			Assert.IsNotNull(p);
		}

		/// <summary>
		/// Test that we can connect to a server using the correct password
		/// </summary>
		[TestMethod]
		public void Connect_OK()
		{
			int port = 2500;
			string password = "test";

			StartFakeServer(password, port);

			Server s = new Server()
			{
				Hostname = "localhost",
				Port = port,
				Password = password
			};

			Protocol p = new Protocol();

			// check that the event is fired on connection
			bool eventFired = false;
			p.Ready += (object sender, EventArgs e) =>
			{
				eventFired = true;
			};

			p.Connect(s);

			Assert.IsTrue(eventFired);

			p.Disconnect();
		}

		/// <summary>
		/// Test that <see cref="InvalidCredentialsException"/> is thrown on bad password
		/// </summary>
		[TestMethod]
		public void Connect_BadPassword_Error()
		{
			int port = 2501;
			string serverPassword = "test";
			string clientPassword = "not the password";

			StartFakeServer(serverPassword, port);

			Server s = new Server()
			{
				Hostname = "localhost",
				Port = port,
				Password = clientPassword
			};

			Protocol p = new Protocol();

			// should throw on auth fail
			Assert.ThrowsException<InvalidCredentialsException>(() =>
			{
				p.Connect(s);
			});

			p.Disconnect();
		}

		/// <summary>
		/// Test that the protocol can be disposed of properly
		/// </summary>
		[TestMethod]
		public void Dispose_OK()
		{
			Protocol p = new Protocol();
			p.Dispose();
		}

		/// <summary>
		/// Test that we can connect to a server and Dispose the <see cref="Protocol"/><para/>
		/// This should handle all disconnecting safely.
		/// </summary>
		[TestMethod]
		public void Connect_Dispose_OK()
		{
			int port = 2503;
			string password = "test";

			Server s = new Server()
			{
				Hostname = "localhost",
				Port = port,
				Password = password
			};

			Protocol p = new Protocol();

			StartFakeServer(password, port);

			p.Connect(s);

			p.Dispose();

			try
			{
				// check that the protocol is no longer connected
				Assert.IsFalse(p.Connected);
			}
			catch (ObjectDisposedException)
			{
				// a disposed exception here is perfectly acceptable
			}
		}

		/// <summary>
		/// Test that we can send commands and receive a response back
		/// </summary>
		[TestMethod]
		public void SendRecvCommand_OK()
		{
			int port = 2502;
			string password = "test";

			Server s = new Server()
			{
				Hostname = "localhost",
				Port = port,
				Password = password
			};

			StartFakeServer(password, port);

			Protocol p = new Protocol();

			// set on packet response received
			bool eventFired = false;
			p.MessageReceived += (object sender, MessageReceivedEventArgs e) =>
			{
				eventFired = true;
			};

			// connect and send a command
			p.Connect(s);
			p.SendCommand("test");

			Thread.Sleep(100);  // give the fake server some time to process the packet

			Assert.IsTrue(eventFired);

			// cleanup
			p.Disconnect();
		}

		/// <summary>
		/// Starts a fake server that accepts a client and behaves like a SRCDS server would
		/// </summary>
		/// <param name="password">The password of the fake server</param>
		/// <param name="port">Port for the server to listen on</param>
		private Thread StartFakeServer(string password, int port)
		{
			// blindly accept new clients and authenticate them
			Thread fakeServerThread = new Thread(() =>
			{
				// start fake server
				TcpListener fakeServerListener = new TcpListener(IPAddress.Any, port);
				fakeServerListener.Start();

				// only accept one client
				TcpClient client = fakeServerListener.AcceptTcpClient();
				fakeServerListener.Stop();

				// create a server version of our protocol for easier packet handling
				// and let us access it's private members so we can trick it into doing our bidding
				Protocol serverProtocol = new Protocol();
				PrivateObject privateServerProtocol = new PrivateObject(serverProtocol);

				// set the client so our "protocol" can send and recv packets
				privateServerProtocol.SetField("_client", client);

				bool authenticated = false;
				while (!authenticated)
				{
					// wait for the next packet
					Packet clientPacket;
					try
					{
						clientPacket = (Packet)privateServerProtocol.Invoke("ReadNextPacket");
					}
					catch (DisconnectedException)	// client disconnected
					{
						return;
					}

					// check passwords
					authenticated = clientPacket.Payload == password;

					// write auth response packet
					Packet responsePacket = new Packet()
					{
						Type = PacketType.AUTH_RESPONSE,
						PacketID = authenticated ? clientPacket.PacketID : -1,	// mirror packet ID if authenticated, otherwise -1
					};

					privateServerProtocol.Invoke("SendPacket", responsePacket);
				}

				// fake packet responses
				bool receiving = true;	// maybe: implement fake command for this to stop the server
				while (authenticated && receiving)
				{
					// receive client packets
					Packet clientPacket;
					try
					{
						clientPacket = (Packet)privateServerProtocol.Invoke("ReadNextPacket");
					}
					catch (DisconnectedException)
					{
						return;
					}

					// https://developer.valvesoftware.com/wiki/Source_RCON_Protocol#Multiple-packet_Responses
					if (clientPacket.Type != PacketType.COMMAND)
					{
						privateServerProtocol.Invoke("SendPacket", new Packet()
						{
							Type = PacketType.COMMAND_RESPONSE
						});
						privateServerProtocol.Invoke("SendPacket", new Packet()
						{
							Type = PacketType.AUTH_RESPONSE,
							Body = new byte[4] { 0x00, 0x01, 0x00, 0x00 }
						});
						continue;
					}

					// create generic response packet
					Packet responsePacket = new Packet()
					{
						Type = PacketType.COMMAND_RESPONSE,
						Payload = $"Ran command: {clientPacket.Payload}"
					};

					// send it
					privateServerProtocol.Invoke("SendPacket", responsePacket);
				}

				// "stop" the "server"
				client.Close();
			})
			{
				IsBackground = true,
				Name = "Fake Server Thread"
			};
			fakeServerThread.Start();

			return fakeServerThread;
		}
	}
}
