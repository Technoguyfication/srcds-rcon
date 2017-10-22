using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRCDS_RCON.GUI
{
	static class Program
	{
		// program constants
		public const string DOCUMENTATION_URL = "https://github.com/Technoguyfication/srcds-rcon/wiki";
		public const string STARTUP_MSG =
			"Welcome to SRCDS RCON!\n" +
			"This program licensed under the Unlicense.\n";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
