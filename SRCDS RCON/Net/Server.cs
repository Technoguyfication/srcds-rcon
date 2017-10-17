﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRCDS_RCON.Net
{
	// don't set the value manually on these
	// the index is linked to the value and it's important
	public enum ServerType : int
	{
		SRCDS,
		MINECRAFT
	}

	public class Server
	{
		public static string GetFriendlyTypeName(ServerType type)
		{
			Dictionary<ServerType, string> typeMap = new Dictionary<ServerType, string>
			{
				{ ServerType.SRCDS, "SRCDS" },
				{ ServerType.MINECRAFT, "Minecraft" }
			};

			return typeMap[type];
		}

		public string Hostname { get; set; } = string.Empty;
		public int Port { get; set; } = 0;
		public ServerType Type { get; set; } = ServerType.SRCDS;
		public string Password { get; set; } = string.Empty;

		public override int GetHashCode()
		{
			string hashable = Hostname + Port.ToString() + Type.ToString() + Password;
			return hashable.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			Server s = (Server)obj;

			// we could compare hashcodes, but this is more reliable
			return (s.Hostname == Hostname && s.Port == Port && s.Type == Type);
		}
	}
}
