using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using SRCDS_RCON.Net;

namespace SRCDS_RCON
{
	// Settings that stick the second you set them, used for actions that don't require confirmation
	public class PersistentSettings : ISettings
	{
		/// <summary>
		/// The base key where the program should store everything
		/// </summary>
		private static RegistryKey _baseKey = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("Technoguyfication").CreateSubKey("SRCDS RCON");

		/// <summary>
		/// The basic color used for miscellaneous console text
		/// </summary>
		public Color DefaultConsoleColor
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
		public Color SentConsoleColor
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
		public Color ProgramConsoleColor
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
		private static  void SetConsoleColor(string colorName, Color color)
		{
			_baseKey.CreateSubKey("Console").SetValue(colorName, color.ToArgb(), RegistryValueKind.DWord);
		}

		/// <summary>
		/// Whether the console should try and use the custom colors from a Minecraft (Bukkit) server
		/// </summary>
		public bool UseMinecraftColors
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
		public bool LogToFile
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
		public string LogFilePath
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
		public bool ReconnectOnConnectionLost
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
		/// The list of user-defined servers
		/// </summary>
		public List<Server> Servers
		{
			get
			{
				List<Server> servers = new List<Server>();

				RegistryKey serverBaseKey = _baseKey.CreateSubKey("Servers");

				foreach (string serverName in serverBaseKey.GetSubKeyNames())
				{
					try
					{
						RegistryKey serverKey = serverBaseKey.CreateSubKey(serverName);

						string hostname = (string)serverKey.GetValue("Hostname", string.Empty);
						int port = (int)serverKey.GetValue("Port", 0);
						ServerType type = (ServerType)Enum.Parse(typeof(ServerType), (string)serverKey.GetValue("Type", ServerType.SRCDS.ToString()));

						Server server = new Server()
						{
							Hostname = hostname,
							Port = port,
							Type = type
						};

						servers.Add(server);
					}
					catch (Exception)
					{
						continue;
					}
				}

				return servers;
			}
			set
			{
				_baseKey.DeleteSubKeyTree("Servers");
				RegistryKey serverBaseKey = _baseKey.CreateSubKey("Servers");
				foreach (Server server in value)
				{
					RegistryKey serverKey = serverBaseKey.CreateSubKey(server.GetHashCode().ToString());

					serverKey.SetValue("Hostname", server.Hostname, RegistryValueKind.String);
					serverKey.SetValue("Port", server.Port, RegistryValueKind.DWord);
					serverKey.SetValue("Type", server.Type.ToString(), RegistryValueKind.String);
				}
			}
		}

		/// <summary>
		/// The width of the main RCON window
		/// </summary>
		public int MainWindowWidth
		{
			get
			{
				return (int)_baseKey.GetValue("MainWindowWidth", DefaultSettings.MainWindowWidth);
			}
			set
			{
				_baseKey.SetValue("MainWindowWidth", value, RegistryValueKind.DWord);
			}
		}

		/// <summary>
		/// The height of the main RCON window
		/// </summary>
		public int MainWindowHeight
		{
			get
			{
				return (int)_baseKey.GetValue("MainWindowHeight", DefaultSettings.MainWindowHeight);
			}
			set
			{
				_baseKey.SetValue("MainWindowHeight", value, RegistryValueKind.DWord);
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
	public static class DefaultSettings
	{
		/*
		 * Static classes cannot implement interfaces, therefore, it is extremely important this class is kept up-to-date
		 * */

		public static Color DefaultConsoleColor { get; } = SystemColors.ControlText;
		public static Color SentConsoleColor { get; } = Color.FromKnownColor(KnownColor.LimeGreen);
		public static Color ProgramConsoleColor { get; } = Color.Blue;
		public static bool UseMinecraftColors { get; } = true;

		public static bool LogToFile { get; } = false;
		public static string LogFilePath { get; } = "logs\\{0}.log";

		public static bool ReconnectOnConnectionLost { get; } = false;

		public static List<Server> Servers { get; } = new List<Server>();

		public static int MainWindowWidth { get; } = 420;
		public static int MainWindowHeight { get; } = 225;
	}

	/// <summary>
	/// Basic temporary class to work with settings
	/// </summary>
	public class Settings : ISettings
	{
		public  Color DefaultConsoleColor { get; set; }
		public  Color SentConsoleColor { get; set; }
		public  Color ProgramConsoleColor { get; set; }
		public  bool UseMinecraftColors { get; set; }

		public  bool LogToFile { get; set; }
		public  string LogFilePath { get; set; }

		public  bool ReconnectOnConnectionLost { get; set; }

		public  List<Server> Servers { get; set; }

		public  int MainWindowWidth { get; set; }
		public  int MainWindowHeight { get; set; }

		/// <summary>
		/// Copies the properties of one <see cref="ISettings"/> onto another
		/// </summary>
		public static void Copy(ISettings source, ISettings target)
		{
			Type type = typeof(ISettings);

			// copy properties
			foreach (var sourceProperty in type.GetProperties())
			{
				// if the property exists on the target
				if (type.GetProperty(sourceProperty.Name) != null)
				{
					var targetProperty = type.GetProperty(sourceProperty.Name);
					targetProperty.SetValue(target, sourceProperty.GetValue(source));
				}
			}
		}
	}

	/// <summary>
	/// Interface for settings
	/// </summary>
	public interface ISettings
	{
		Color DefaultConsoleColor { get; set; }
		Color SentConsoleColor { get; set; }
		Color ProgramConsoleColor { get; set; }
		bool UseMinecraftColors { get; set; }

		bool LogToFile { get; set; }
		string LogFilePath { get; set; }

		bool ReconnectOnConnectionLost { get; set; }

		List<Server> Servers { get; set; }

		int MainWindowWidth { get; set; }
		int MainWindowHeight { get; set; }
	}
}
