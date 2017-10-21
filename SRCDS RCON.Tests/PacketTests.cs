using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRCDS_RCON.Net;

namespace SRCDS_RCON.Tests
{
	[TestCategory("Packet")]
	[TestClass]
	public class PacketTests
	{
		/// <summary>
		/// Test the packet constructor
		/// </summary>
		[TestMethod]
		public void Constructor_OK()
		{
			Packet p = new Packet();
		}

		[TestMethod]
		public void Dispose_OK()
		{
			Packet p = new Packet();
			p.Dispose();
		}

		/// <summary>
		/// Test whether we can set and retreive an identical payload from the packet
		/// </summary>
		[TestMethod]
		public void SetRetreivePayload_OK()
		{
			string payload = "test string!";

			Packet p = new Packet()
			{
				Payload = payload
			};

			Assert.AreEqual(p.Payload, payload);
		}

		/// <summary>
		/// Test whether the packet generates an ID
		/// </summary>
		[TestMethod]
		public void Id_OK()
		{
			Packet p = new Packet();
			Assert.IsNotNull(p.PacketID);
		}
	}
}
