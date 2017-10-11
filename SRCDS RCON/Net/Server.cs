using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRCDS_RCON.Net
{
	public enum ServerType
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

		public string Hostname { get; set; }
		public int Port { get; set; }
		public ServerType Type { get; set; }

		/// <summary>
		/// Gets a unique ID suitable for identification
		/// </summary>
		/// <returns></returns>
		public string GetId()
		{
			SHA256 sha = SHA256.Create();
			// add some unique data
			List<byte> rawData = new List<byte>(Encoding.Unicode.GetBytes(Hostname));
			rawData.AddRange(BitConverter.GetBytes(Port));

			// hash it
			byte[] hash = sha.ComputeHash(rawData.ToArray());

			// turn it into a string
			string friendlyHash = Encoding.Unicode.GetString(hash);
			return friendlyHash;
		}
	}
}
