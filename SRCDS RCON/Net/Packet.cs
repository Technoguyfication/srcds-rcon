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
		public int Length
		{
			get
			{
				return (sizeof(int) * 2 + Payload.Length + Padding.Length);	// int*2 is for packet id + packet type
			}
		}

		/// <summary>
		/// Used for matching requests to their responses, randomly generated for each packet
		/// </summary>
		public int PacketID { get; set; }

		/// <summary>
		/// Type of the packet<para/>
		/// See https://developer.valvesoftware.com/wiki/Source_RCON_Protocol#Packet_Type
		/// </summary>
		public PacketType Type { get; set; }

		/// <summary>
		/// Body of the packet, an encoded version of <see cref="Payload"/>
		/// </summary>
		public byte[] Body
		{
			get
			{
				return Encoding.ASCII.GetBytes(Payload);
			}
			set
			{
				Payload = Encoding.ASCII.GetString(value);
			}
		}

		/// <summary>
		/// The data contained inside the packet, usually a command or password.
		/// </summary>
		public string Payload { get; set; } = string.Empty;

		/// <summary>
		/// The padding at the end of the packet, basically a suffix.<para />
		/// See https://developer.valvesoftware.com/wiki/Source_RCON_Protocol#Empty_String
		/// </summary>
		public byte[] Padding
		{
			get
			{
				return new byte[Protocol.PacketSuffixSize];
			}
		}

		/// <summary>
		/// Fully assembled packet, suitable for sending
		/// </summary>
		public byte[] Raw
		{
			get
			{
				List<byte> builder = new List<byte>();

				builder.AddRange(BitConverter.GetBytes(Length).ReverseLittleEndian());
				builder.AddRange(BitConverter.GetBytes(PacketID).ReverseLittleEndian());
				builder.AddRange(BitConverter.GetBytes((int)Type).ReverseLittleEndian());
				builder.AddRange(Body);
				builder.AddRange(Padding);

				return builder.ToArray();
			}
		}

		public Packet()
		{
			PacketID = new Random().Next();
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
