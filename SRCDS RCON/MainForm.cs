using SRCDS_RCON.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRCDS_RCON
{
	public partial class MainForm : Form
	{
		private Protocol protocol;
		private ConnectionForm connectionForm;

		public MainForm()
		{
			InitializeComponent();

			Width = Settings.MainWindowWidth;
			Height = Settings.MainWindowHeight;

			connectionForm = new ConnectionForm();
		}

		/// <summary>
		/// Writes a string to the console, thread safe.
		/// </summary>
		/// <param name="text">Text to print</param>
		/// <param name="textColor">Color of the text to print. Defaults to the user-defined color for basic text.</param>
		public void WriteToConsole(string text, Color? textColor = null)
		{
			if (InvokeRequired)
				Invoke((MethodInvoker)delegate { WriteToConsole(text, textColor); });

			if (textColor == null)
				textColor = Settings.DefaultConsoleColor;

			consoleTextBox.SelectionStart = consoleTextBox.TextLength;
			consoleTextBox.SelectionLength = 0;

			consoleTextBox.SelectionColor = (Color)textColor;
			consoleTextBox.AppendText(text + Environment.NewLine);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			// CTRL+, for settings menu item
			if (keyData == (Keys.Control | Keys.Oemcomma))
			{
				settingsMenuItem.PerformClick();
				return false;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		#region Event Handlers

		private void SettingsMenuItem_Click(object sender, EventArgs e)
		{
			using (var settings = new SettingsForm())
			{
				settings.ShowDialog();  // the form will handle all the hard stuff
			}
		}

		private void ConnectMenuItem_Click(object sender, EventArgs e)
		{
			connectionForm.ShowDialog();
		}

		private void DocumentationMenuItem_Click(object sender, EventArgs e)
		{
			// open documentation in web browser
			System.Diagnostics.Process.Start(Program.DocumentationUrl);
		}

		private void MainForm_ResizeEnd(object sender, EventArgs e)
		{
			Settings.MainWindowHeight = Height;
			Settings.MainWindowWidth = Width;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			consoleTextBox.Clear();
			WriteToConsole("Hi!", Settings.ProgramConsoleColor);
		}

		#endregion
	}
}
