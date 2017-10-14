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

namespace SRCDS_RCON.GUI
{
	public partial class MainForm : Form
	{
		private Protocol protocol;
		private ConnectionForm connectionForm;

		public MainForm()
		{
			InitializeComponent();

			Width = SrcdsRcon.Settings.MainWindowWidth;
			Height = SrcdsRcon.Settings.MainWindowHeight;

			connectionForm = new ConnectionForm();
			connectionForm.ServerConnect += ConnectionForm_ServerConnect;

			protocol = new Protocol();

			protocol.Ready += Protocol_Ready;
			protocol.Disconnected += Protocol_Disconnected;
			protocol.MessageReceived += Protocol_MessageReceived;
		}

		private void ConnectionForm_ServerConnect(object sender, ServerConnectEventArgs e)
		{
			Connect(e.Server);
		}

		/// <summary>
		/// Starts an RCON connection
		/// </summary>
		/// <param name="server"></param>
		public void Connect(Server server)
		{
			WriteToConsole($"Connecting to {server.Hostname}:{server.Port}...", SrcdsRcon.Settings.DefaultConsoleColor);

			try
			{
				protocol.Connect(server);
			}
			catch (InvalidCredentialsException)
			{
				WriteToConsole("Incorrect password");
			}
			catch (Exception e)
			{
				WriteToConsole($"Unhandled exception: {e.Message}\n{e.StackTrace}");
			}
		}

		private void Protocol_Ready(object sender, EventArgs e)
		{
			WriteToConsole("Connected!");
		}

		private void Protocol_Disconnected(object sender, EventArgs e)
		{
			WriteToConsole("Disconnected.");
		}

		private void Protocol_MessageReceived(object sender, MessageReceivedEventArgs e)
		{
			WriteToConsole($"rcon: {e.Message}");
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
				textColor = SrcdsRcon.Settings.DefaultConsoleColor;

			// start selection at end of text
			consoleTextBox.SelectionStart = consoleTextBox.TextLength;
			consoleTextBox.SelectionLength = 0;

			// set color and write text
			consoleTextBox.SelectionColor = (Color)textColor;
			consoleTextBox.AppendText(text + Environment.NewLine);
		}

		/// <summary>
		/// Clears all text from the console
		/// </summary>
		public void ClearConsole()
		{
			consoleTextBox.Clear();
		}

		/// <summary>
		/// Copies the selected text from the console
		/// </summary>
		private void CopyConsoleSelection()
		{
			if (consoleTextBox.SelectionLength > 0)
				Clipboard.SetText(consoleTextBox.SelectedText);
		}

		/// <summary>
		/// Opens up the documenation for the program in a new window
		/// </summary>
		private void ShowDocumenation()
		{
			System.Diagnostics.Process.Start(Program.DocumentationUrl);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			// CTRL+, for settings menu item
			if (keyData == (Keys.Control | Keys.Oemcomma))
			{
				settingsToolStripMenuItem.PerformClick();
				return false;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		#region Control Event Handlers

		private void MainForm_ResizeEnd(object sender, EventArgs e)
		{
			SrcdsRcon.Settings.MainWindowHeight = Height;
			SrcdsRcon.Settings.MainWindowWidth = Width;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			consoleTextBox.Clear();
			WriteToConsole(Program.StartupText, SrcdsRcon.Settings.ProgramConsoleColor);
		}

		private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClearConsole();
		}

		private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			connectionForm.ShowDialog();
		}

		private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SettingsForm form = new SettingsForm())
			{
				form.ShowDialog();
			}
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void ClearToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ClearConsole();
		}

		private void ViewDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowDocumenation();
		}

		private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
			ShowDocumenation();
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CopyConsoleSelection();
		}

		#endregion
	}
}
