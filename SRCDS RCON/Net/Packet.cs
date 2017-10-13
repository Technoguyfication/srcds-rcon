using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCDS_RCON.Net
{
	public class Packet
	{
		/// <summary>
		/// The length of the entire packet, in bytes
		/// </summary>
		public int Length { get; }

		/// <summary>
		/// Used for matching requests to their responses, randomly generated for each packet
		/// </summary>
		public int PacketID
		{
			get
			{
				return new Random().Next();
			}
		}

		/// <summary>
		/// Type of the packet<para/>
		/// See https://developer.valvesoftware.com/wiki/Source_RCON_Protocol#Packet_Type
		/// </summary>
		public PacketType Type { get; protected set; }

		/// <summary>
		/// Body of the packet
		/// </summary>
		public byte[] Body { get; protected set; }

		/// <summary>
		/// The padding at the end of the packet, basically a suffix.<para />
		/// See https://developer.valvesoftware.com/wiki/Source_RCON_Protocol#Empty_String
		/// </summary>
		public byte[] Padding
		{
			get
			{
				return new byte[] { 0x00, 0x00 };
			}
		}

		/// <summary>
		/// Fully assembled packet, suitable for sending
		/// </summary>
		public byte[] Raw
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}

	/// <summary>
	/// Defines packets sent to and from the server.<para/>
	/// "RESPONSE" packets are sent from S->C, and vice-versa
	/// </summary>
	public enum PacketType : int
	{
		AUTH = 3,
		AUTH_RESPONSE = 2,
		COMMAND = 2,
		COMMAND_RESPONSE = 0
	}
}
