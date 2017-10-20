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
		/// The character is used to define the start of a color identifier.
		/// </summary>
		public const char ColorByte = '\xa7';	// section symbol

		/// <summary>
		/// Returns a map of <see cref="StyledString"/>s from a Bukkit response<para/>
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static StyledString[] GetStyledStrings(string input)
		{
			List<StyledString> strings = new List<StyledString>();
			StyledString currentString = new StyledString();

			for (int i = 0; i < input.Length; i++)
			{
				// new color here
				if (input[i] == ColorByte)
				{
					clipString();

					i++;
					currentString.Color = GetMinecraftColor(input[i]);
					continue;
				}

				currentString.Content += input[i];
			}

			// clip it once more to "push" the data to the list
			clipString();

			return strings.ToArray();

			// finish up the latest currentstring and add it to the collection
			void clipString()
			{
				strings.Add(currentString);
				currentString = new StyledString();
			}
		}

		/// <summary>
		/// Returns the <see cref="ConsoleColor"/> from a Minecraft color character
		/// </summary>
		/// <param name="colorCharacter"></param>
		/// <returns></returns>
		public static ConsoleColor GetMinecraftColor(char colorCharacter)
		{
			colorCharacter = Char.ToLower(colorCharacter);

			Dictionary<char, ConsoleColor> colors = new Dictionary<char, ConsoleColor>()
			{
				{ '0', ConsoleColor.Black },		// BLACK
				{ '1', ConsoleColor.DarkBlue },		// DARK BLUE
				{ '2', ConsoleColor.DarkGreen },	// DARK GREEN
				{ '3', ConsoleColor.DarkCyan },		// DARK CYAN
				{ '4', ConsoleColor.DarkRed },		// DARK RED
				{ '5', ConsoleColor.DarkMagenta },	// DARK PURPLE
				{ '6', ConsoleColor.DarkYellow },	// DARK YELLOW
				{ '7', ConsoleColor.Gray },         // LIGHT GRAY
				{ '8', ConsoleColor.DarkGray },     // DARK GRAY
				{ '9', ConsoleColor.Blue },         // LIGHT BLUE
				{ 'a', ConsoleColor.Green },        // LIGHT GREEN
				{ 'b', ConsoleColor.Cyan },         // LIGHT CYAN
				{ 'c', ConsoleColor.Red },          // LIGHT RED
				{ 'd', ConsoleColor.Magenta },      // LIGHT PURPLE
				{ 'e', ConsoleColor.Yellow },       // LIGHT YELLOW
				{ 'f', ConsoleColor.White },		// WHITE
			};

			if (!colors.TryGetValue(colorCharacter, out ConsoleColor color))
				color = ConsoleColor.Black;

			return color;
		}

		/// <summary>
		/// Returns the closest possible <see cref="Color"/> to a console (Minecraft) color
		/// </summary>
		/// <returns></returns>
		public static Color GetColorFromConsoleColor(ConsoleColor cColor)
		{
			Dictionary<ConsoleColor, Color> colorMap = new Dictionary<ConsoleColor, Color>()
			{
				//TODO: these need to be tweaked to more accurately reflect the minecraft colors

				{ ConsoleColor.Black, Color.Black },
				{ ConsoleColor.DarkBlue, Color.DarkBlue },
				{ ConsoleColor.DarkGreen, Color.DarkGreen },
				{ ConsoleColor.DarkCyan, Color.DarkCyan },
				{ ConsoleColor.DarkRed, Color.DarkRed },
				{ ConsoleColor.DarkMagenta, Color.DarkMagenta },
				{ ConsoleColor.DarkYellow, Color.Yellow },
				{ ConsoleColor.Gray, Color.LightGray },
				{ ConsoleColor.DarkGray, Color.DarkGray },
				{ ConsoleColor.Blue, Color.Blue },
				{ ConsoleColor.Green, Color.Green },
				{ ConsoleColor.Cyan, Color.Cyan },
				{ ConsoleColor.Red, Color.Red },
				{ ConsoleColor.Magenta, Color.Magenta },
				{ ConsoleColor.Yellow, Color.LightYellow },
				{ ConsoleColor.White, Color.White }
			};

			if (!colorMap.TryGetValue(cColor, out Color color))
				color = Color.Black;

			return color;
		}
	}

	public class StyledString
	{
		public ConsoleColor Color { get; set; }
		public string Content { get; set; } = string.Empty;
	}
}
