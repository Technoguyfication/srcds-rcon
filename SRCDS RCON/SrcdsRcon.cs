using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using NetFwTypeLib;

namespace SRCDS_RCON
{
	public static class SrcdsRcon
	{
		public static PersistentSettings Settings { get; set; } = new PersistentSettings();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine("CLI mode not yet implemented. Sorry!");
		}

		/// <summary>
		/// Ensures an array of bytes is Little Endian, before/after use of the <see cref="BitConverter"/>
		/// </summary>
		/// <param name="buffer"></param>
		/// <returns></returns>
		public static byte[] ReverseLittleEndian(this byte[] buffer)
		{
			if (!BitConverter.IsLittleEndian)
				Array.Reverse(buffer);

			return buffer;
		}

		/// <summary>
		/// Gets the file name of the assembly
		/// </summary>
		/// <returns></returns>
		public static string GetAssemblyFileName()
		{
			return Path.GetFileName(typeof(SrcdsRcon).Assembly.Location);
		}

		/// <summary>
		/// Creates a firewall rule allowing the program through the firewall
		/// </summary>
		private static void CreateAllowFirewallRule()
		{
			INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));

			firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
			firewallRule.Description = "Allow SRCDS RCON tool through the firewall";
			firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
			firewallRule.InterfaceTypes = "All";
			firewallRule.Protocol = 6;  // TCP
			firewallRule.ApplicationName = GetAssemblyFileName();
			firewallRule.Enabled = true;

			INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
			firewallPolicy.Rules.Add(firewallRule);
		}
	}
}
