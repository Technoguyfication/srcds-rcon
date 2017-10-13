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
	public class PersistentSettings : Settings, ISettings
	{
		private DefaultSettings _defaultSettings = new DefaultSettings();

		/// <summary>
		/// The base key where the program should store everything
		/// </summary>
		private static RegistryKey _baseKey = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("Technoguyfication").CreateSubKey("SRCDS RCON");

		/// <summary>
		/// The basic color used for miscellaneous console text
		/// </summary>
		new public Color DefaultConsoleColor
		{
			get
			{
				return GetConsoleColor("DefaultColor", _defaultSettings.DefaultConsoleColor);
			}
			set
			{
				SetConsoleColor("DefaultColor", value);
			}
		}

		/// <summary>
		/// The color to use for outgoing RCON commands
		/// </summary>
		new public Color SentConsoleColor
		{
			get
			{
				return GetConsoleColor("SentColor", _defaultSettings.SentConsoleColor);
			}
			set
			{
				SetConsoleColor("SentColor", value);
			}
		}

		/// <summary>
		/// The color to use for program messages in the console
		/// </summary>
		new public Color ProgramConsoleColor
		{
			get
			{
				return GetConsoleColor("ProgramColor", _defaultSettings.ProgramConsoleColor);
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
		new public bool UseMinecraftColors
		{
			get
			{
				return GetBoolean("UseMinecraftColors", _defaultSettings.UseMinecraftColors, _baseKey.CreateSubKey("Console"));
			}
			set
			{
				SetBoolean("UseMinecraftColors", value, _baseKey.CreateSubKey("Console"));
			}
		}

		/// <summary>
		/// Whether or not a console log should be saved to a file
		/// </summary>
		new public bool LogToFile
		{
			get
			{
				return GetBoolean("LogToFile", _defaultSettings.LogToFile);
			}
			set
			{
				SetBoolean("LogToFile", value);
			}
		}

		/// <summary>
		/// Where the console log should be saved (if enabled)
		/// </summary>
		new public string LogFilePath
		{
			get
			{
				return (string)_baseKey.GetValue("LogFilePath", _defaultSettings.LogFilePath);
			}
			set
			{
				_baseKey.SetValue("LogFilePath", value, RegistryValueKind.String);
			}
		}

		/// <summary>
		/// Whether or not the program should try to reconnect on unplanned connection loss
		/// </summary>
		new public bool ReconnectOnConnectionLost
		{
			get
			{
				return GetBoolean("ReconnectOnConnectionLost", _defaultSettings.ReconnectOnConnectionLost);
			}
			set
			{
				SetBoolean("ReconnectOnConnectionLost", value);
			}
		}

		/// <summary>
		/// The list of user-defined servers
		/// </summary>
		new public List<Server> Servers
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
		new public int MainWindowWidth
		{
			get
			{
				return (int)_baseKey.GetValue("MainWindowWidth", _defaultSettings.MainWindowWidth);
			}
			set
			{
				_baseKey.SetValue("MainWindowWidth", value, RegistryValueKind.DWord);
			}
		}

		/// <summary>
		/// The height of the main RCON window
		/// </summary>
		new public int MainWindowHeight
		{
			get
			{
				return (int)_baseKey.GetValue("MainWindowHeight", _defaultSettings.MainWindowHeight);
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
	public  class DefaultSettings : IBaseSettings
	{
		public  Color DefaultConsoleColor { get; set; } = SystemColors.ControlText;
		public Color SentConsoleColor { get; set; } = Color.FromKnownColor(KnownColor.LimeGreen);
		public Color ProgramConsoleColor { get; set; } = Color.Blue;
		public bool UseMinecraftColors { get; set; } = true;

		public bool LogToFile { get; set; } = false;
		public string LogFilePath { get; set; } = "logs\\{0}.log";

		public bool ReconnectOnConnectionLost { get; set; } = false;

		public List<Server> Servers { get; set; } = new List<Server>();

		public int MainWindowWidth { get; set; } = 420;
		public int MainWindowHeight { get; set; } = 225;
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
		/// Copies the properties of a <see cref="IBaseSettings"/> to a <see cref="ISettings"/>
		/// </summary>
		public static void Copy(IBaseSettings source, ISettings target)
		{
			Type sourceType = typeof(IBaseSettings);
			Type targetType = typeof(ISettings);

			// copy properties
			foreach (var sourceProperty in sourceType.GetProperties())
			{
				// if the property exists on the target
				if (sourceType.GetProperty(sourceProperty.Name) != null)
				{
					var targetProperty = targetType.GetProperty(sourceProperty.Name);
					targetProperty.SetValue(target, sourceProperty.GetValue(source));
				}
			}
		}
	}

	/// <summary>
	/// Interface for gettable and settable settings
	/// </summary>
	public interface ISettings : IBaseSettings
	{
		new Color DefaultConsoleColor { get; set; }
		new Color SentConsoleColor { get; set; }
		new Color ProgramConsoleColor { get; set; }
		new bool UseMinecraftColors { get; set; }

		new bool LogToFile { get; set; }
		new string LogFilePath { get; set; }

		new bool ReconnectOnConnectionLost { get; set; }

		new List<Server> Servers { get; set; }

		new int MainWindowWidth { get; set; }
		new int MainWindowHeight { get; set; }
	}

	/// <summary>
	/// Interface for gettable settings
	/// </summary>
	public interface IBaseSettings
	{
		Color DefaultConsoleColor { get; }
		Color SentConsoleColor { get; }
		Color ProgramConsoleColor { get; }
		bool UseMinecraftColors { get; }

		bool LogToFile { get; }
		string LogFilePath { get; }

		bool ReconnectOnConnectionLost { get; }

		List<Server> Servers { get; }

		int MainWindowWidth { get; }
		int MainWindowHeight { get; }
	}
}
