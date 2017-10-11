using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SRCDS_RCON
{
	// User-defined settings, stored in registry but serializable too so you can export and import them.
	public static class Settings
	{
		/// <summary>
		/// The base key where the program should store everything
		/// </summary>
		private static RegistryKey _baseKey = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("Technoguyfication").CreateSubKey("SRCDS RCON");

		/// <summary>
		/// The basic color used for miscellaneous console text
		/// </summary>
		public static Color DefaultConsoleColor
		{
			get
			{
				return GetConsoleColor("DefaultColor", DefaultSettings.DefaultConsoleColor);
			}
			set
			{
				SetConsoleColor("DefaultColor", value);
			}
		}

		/// <summary>
		/// The color to use for outgoing RCON commands
		/// </summary>
		public static Color SentConsoleColor
		{
			get
			{
				return GetConsoleColor("SentColor", DefaultSettings.SentConsoleColor);
			}
			set
			{
				SetConsoleColor("SentColor", value);
			}
		}

		/// <summary>
		/// The color to use for program messages in the console
		/// </summary>
		public static Color ProgramConsoleColor
		{
			get
			{
				return GetConsoleColor("ProgramColor", DefaultSettings.ProgramConsoleColor);
			}
			set
			{
				SetConsoleColor("ProgramColor", value);
			}
		}

		/// <summary>
		/// Gets a console color from the registry
		/// </summary>
		/// <param name="colorName">Name of the color to get</param>
		/// <param name="defaultColor">Default color to use if the color is not found</param>
		/// <returns>Color encoded in Argb</returns>
		private static Color GetConsoleColor(string colorName, Color defaultColor)
		{
			return Color.FromArgb((int)_baseKey.CreateSubKey("Console").GetValue(colorName, defaultColor.ToArgb()));
		}

		/// <summary>
		/// Sets a console color in the registry, encoded as Argb in an int
		/// </summary>
		/// <param name="colorName"></param>
		/// <param name="color"></param>
		private static void SetConsoleColor(string colorName, Color color)
		{
			_baseKey.CreateSubKey("Console").SetValue(colorName, color.ToArgb(), RegistryValueKind.DWord);
		}

		/// <summary>
		/// Whether the console should try and use the custom colors from a Minecraft (Bukkit) server
		/// </summary>
		public static bool UseMinecraftColors
		{
			get
			{
				return GetBoolean("UseMinecraftColors", DefaultSettings.UseMinecraftColors, _baseKey.CreateSubKey("Console"));
			}
			set
			{
				SetBoolean("UseMinecraftColors", value, _baseKey.CreateSubKey("Console"));
			}
		}

		/// <summary>
		/// Whether or not a console log should be saved to a file
		/// </summary>
		public static bool LogToFile
		{
			get
			{
				return GetBoolean("LogToFile", DefaultSettings.LogToFile);
			}
			set
			{
				SetBoolean("LogToFile", value);
			}
		}

		/// <summary>
		/// Where the console log should be saved (if enabled)
		/// </summary>
		public static string LogFilePath
		{
			get
			{
				return (string)_baseKey.GetValue("LogFilePath", DefaultSettings.LogFilePath);
			}
			set
			{
				_baseKey.SetValue("LogFilePath", value, RegistryValueKind.String);
			}
		}

		/// <summary>
		/// Whether or not the program should try to reconnect on unplanned connection loss
		/// </summary>
		public static bool ReconnectOnConnectionLost
		{
			get
			{
				return GetBoolean("ReconnectOnConnectionLost", DefaultSettings.ReconnectOnConnectionLost);
			}
			set
			{
				SetBoolean("ReconnectOnConnectionLost", value);
			}
		}

		/// <summary>
		/// Gets a boolean value from the registry
		/// </summary>
		/// <param name="keyName"></param>
		/// <param name="defaultValue"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		private static bool GetBoolean(string keyName, bool defaultValue, RegistryKey key = null)
		{
			try
			{
				return Convert.ToBoolean(key.GetValue(keyName, defaultValue));
			}
			catch (Exception)
			{
				// reset value because it's invalid
				SetBoolean(keyName, defaultValue);
				return defaultValue;
			}
		}

		/// <summary>
		/// Sets a boolean value in the registry
		/// </summary>
		/// <param name="keyName"></param>
		/// <param name="value"></param>
		/// <param name="key"></param>
		private static void SetBoolean(string keyName, bool value, RegistryKey key = null)
		{
			if (key == null)
				key = _baseKey;

			key.SetValue(keyName, Convert.ToInt32(value), RegistryValueKind.DWord);
		}
	}

	/// <summary>
	/// Gets the default settings for the program to use.
	/// </summary>
	static class DefaultSettings
	{
		public static Color DefaultConsoleColor { get; } = SystemColors.ControlText;
		public static Color SentConsoleColor { get; } = Color.FromKnownColor(KnownColor.LimeGreen);
		public static Color ProgramConsoleColor { get; } = Color.Blue;
		public static bool UseMinecraftColors { get; } = true;

		public static bool LogToFile { get; } = false;
		public static string LogFilePath { get; } = "logs\\{0}.log";


		public static bool ReconnectOnConnectionLost { get; } = false;
	}
}
