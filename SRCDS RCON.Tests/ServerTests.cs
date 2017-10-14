using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRCDS_RCON.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCDS_RCON.Tests
{
	[TestCategory("Server")]
	[TestClass]
	public class ServerTests
	{
		/// <summary>
		/// Test that we can construct a server
		/// </summary>
		[TestMethod]
		public void Constructor_OK()
		{
			Server s = new Server();
		}

		/// <summary>
		/// Test that we can set all the properties of a server
		/// </summary>
		[TestMethod]
		public void SetProperties_OK()
		{
			Server s = new Server()
			{
				 Hostname = "localhost",
				 Port = 500,
				 Password = "secret",
				 Type = ServerType.SRCDS
			};
		}

		/// <summary>
		/// Test that we can get all the properties of a server
		/// </summary>
		[TestMethod]
		public void GetProperties_OK()
		{
			string hostname = "example.com";
			int port = 600;
			string password = "bananas";
			ServerType type = ServerType.SRCDS;

			Server s = new Server()
			{
				Hostname = hostname,
				Port = port,
				Password = password,
				Type = type
			};

			Assert.AreEqual(s.Hostname, hostname);
			Assert.AreEqual(s.Port, port);
			Assert.AreEqual(s.Password, password);
			Assert.AreEqual(s.Type, type);
		}

		/// <summary>
		/// Test that we can get the hash code of a server
		/// </summary>
		[TestMethod]
		public void HashCode_OK()
		{
			Server s = new Server()
			{
				Hostname = "localhost",
				Port = 6501,
				Type = ServerType.SRCDS,
				Password = "verysecure"
			};

			Assert.IsNotNull(s.GetHashCode());
		}
	}
}
