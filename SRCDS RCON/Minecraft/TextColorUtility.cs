using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCDS_RCON.Minecraft
{
	public static class TextColorUtility
	{
		/// <summary>
		/// The byte used to define the start of a color identifier.
		/// </summary>
		public const byte ColorByte = 0xA7;

		/// <summary>
		/// Returns a map of <see cref="StyledString"/>s from a Bukkit response<para/>
		/// each string contains a single "color", following all the same rules as Bukkit
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static StyledString[] GetStyledStrings(byte[] input)
		{
			List<StyledString> strings = new List<StyledString>();
			StyledString currentString = new StyledString();
			List<byte> currentStringRaw = new List<byte>();

			for (int i = 0; i < input.Length; i++)
			{
				// new color here
				if (input[i] == ColorByte)
				{
					clipString();

					currentString.Color = GetMinecraftColor(input[i + 1]);
					continue;
				}

				currentStringRaw.Add(input[i]);
			}

			// clip it once more to "push" the data to the list
			clipString();

			return strings.ToArray();

			// finish up the latest currentstring and add it to the collection
			void clipString()
			{
				currentString.Content = Encoding.Unicode.GetString(currentStringRaw.ToArray());

				strings.Add(currentString);
				currentString = new StyledString();
			}
		}

		private static ConsoleColor GetMinecraftColor(byte colorByte)
		{
			Dictionary<int, ConsoleColor> colors = new Dictionary<int, ConsoleColor>()
			{
				{ 0, ConsoleColor.Black },			// BLACK
				{ 1, ConsoleColor.DarkBlue },		// DARK BLUE
				{ 2, ConsoleColor.DarkGreen },		// DARK GREEN
				{ 3, ConsoleColor.DarkCyan },		// DARK CYAN
				{ 4, ConsoleColor.DarkRed },		// DARK RED
				{ 5, ConsoleColor.DarkMagenta },    // DARK PURPLE
				{ 6, ConsoleColor.DarkYellow },     // DARK YELLOW
				{ 7, ConsoleColor.Gray },           // LIGHT GRAY
				{ 8, ConsoleColor.DarkGray },       // DARK GRAY
				{ 9, ConsoleColor.Blue },           // LIGHT BLUE
				{ 10, ConsoleColor.Green },         // LIGHT GREEN
				{ 11, ConsoleColor.Cyan },          // LIGHT CYAN
				{ 12, ConsoleColor.Red },           // LIGHT RED
				{ 13, ConsoleColor.Magenta },       // LIGHT PURPLE
				{ 14, ConsoleColor.Yellow },        // LIGHT YELLOW
				{ 15, ConsoleColor.White },			// WHITE
			};

			if (!colors.TryGetValue(colorByte, out ConsoleColor color))
				color = ConsoleColor.Black;

			return color;
		}
	}

	public class StyledString
	{
		public ConsoleColor Color { get; set; }
		public string Content { get; set; } = string.Empty;
	}
}
