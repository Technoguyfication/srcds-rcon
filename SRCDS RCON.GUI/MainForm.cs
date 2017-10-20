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
using SRCDS_RCON.Minecraft;

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

			UpdateGui();
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
			if (protocol.Connected)
				protocol.Disconnect();

			WriteToConsole($"Connecting to {server.Hostname}:{server.Port}...", SrcdsRcon.Settings.DefaultConsoleColor);

			// run connect async so it doens't hold up the gui

			Task connectTask = new Task(() =>
			{
				try
				{
					protocol.Connect(server);
				}
				catch (InvalidCredentialsException)
				{
					WriteToConsole("Incorrect password");
				}
				catch (ConnectionFailedException e)
				{
					WriteToConsole($"Connection failed: {e.Message}");
				}
				catch (Exception e)
				{
					WriteToConsole($"Unhandled exception: {e.Message}\n{e.StackTrace}");
				}
			});

			connectTask.Start();
		}

		private void Protocol_Ready(object sender, EventArgs e)
		{
			WriteToConsole("Connected!");
			UpdateGui();
		}

		private void Protocol_Disconnected(object sender, EventArgs e)
		{
			WriteToConsole("Disconnected.");
			UpdateGui();
		}

		private void Protocol_MessageReceived(object sender, MessageReceivedEventArgs e)
		{
			if (string.IsNullOrEmpty(e.Message))
				return;

			switch (e.Server?.Type)
			{
				case ServerType.MINECRAFT:
					if (!SrcdsRcon.Settings.UseMinecraftColors)
						goto default;

					StyledString[] strings = TextColorUtility.GetStyledStrings(e.Message);
					foreach (StyledString str in strings)
					{
						WriteToConsole(str.Content, TextColorUtility.GetColorFromConsoleColor(str.Color), false);
					}
					break;
				case ServerType.SRCDS:
				case null:
				default:
					WriteToConsole(e.Message);
					break;
			}
		}

		/// <summary>
		/// Updates buttons on the GUI to reflect the current program state
		/// </summary>
		private void UpdateGui()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)delegate { UpdateGui(); });
				return;
			}

			bool connected = protocol.Connected;

			// send button
			sendButton.Enabled = connected;

			// disconnect buttons
			disconnectToolStripMenuItem.Enabled = disconnectToolStripMenuItem1.Enabled = connected;
		}

		/// <summary>
		/// Writes a string to the console, thread safe.
		/// </summary>
		/// <param name="text">Text to print</param>
		/// <param name="textColor">Color of the text to print. Defaults to the user-defined color for basic text.</param>
		public void WriteToConsole(string text, Color? textColor = null, bool newline = true)
		{

			if (consoleTextBox.InvokeRequired)
			{
				consoleTextBox.Invoke((MethodInvoker)delegate { WriteToConsole(text, textColor, newline); });
				return;
			}

			if (textColor == null)
				textColor = SrcdsRcon.Settings.DefaultConsoleColor;

			// start selection at end of text
			consoleTextBox.SelectionStart = consoleTextBox.TextLength;
			consoleTextBox.SelectionLength = 0;

			// set color and write text
			consoleTextBox.SelectionColor = (Color)textColor;
			consoleTextBox.AppendText(text + ((newline) ? Environment.NewLine : ""));

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
		/// Sends the command in the input box and optionally clears the box
		/// </summary>
		/// <param name="clear"></param>
		private void SendCommand(bool clear = true)
		{
			if (!protocol.Connected)
				return;

			protocol.SendCommand(inputTextBox.Text);

			if (clear)
				inputTextBox.Text = string.Empty;
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
			Application.Exit();
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

		private void SendButton_Click(object sender, EventArgs e)
		{
			SendCommand();
		}

		private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			protocol.Disconnect(true);
		}

		private void DisconnectToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			protocol.Disconnect(true);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (protocol.Connected)
				protocol.Disconnect();
		}

		#endregion

		private void AboutSRCDSRCONToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (AboutForm form = new AboutForm())
			{
				form.ShowDialog();
			}
		}
	}
}
