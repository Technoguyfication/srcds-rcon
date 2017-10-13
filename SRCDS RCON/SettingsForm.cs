using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRCDS_RCON
{
	public partial class SettingsForm : Form
	{
		[DllImport("user32.dll")]
		public static extern UInt32 SendMessage
			(IntPtr hWnd, UInt32 msg, UInt32 wParam, UInt32 lParam);

		internal const int BCM_FIRST = 0x1600;	// normal button
		internal const int BCM_SETSHIELD = (BCM_FIRST + 0x000C); //Elevated button

		Settings tSettings = new Settings();

		public SettingsForm()
		{
			Settings.Copy(Program.Settings, tSettings);

			InitializeComponent();

			// add uac shield to firewall button
			firewallButton.FlatStyle = FlatStyle.System;
			SendMessage(firewallButton.Handle, BCM_SETSHIELD, 0, 0xFFFFFFFF);

			UpdateControls();
		}

		private void UpdateControls()
		{
			// logs
			logEnabledCheckBox.Checked = tSettings.LogToFile;
			logPathTextBox.Text = tSettings.LogFilePath;

			// colors
			defaultColorPickerButton.BackColor = tSettings.DefaultConsoleColor;
			sentColorPickerButton.BackColor = tSettings.SentConsoleColor;
			programColorPickerButton.BackColor = tSettings.ProgramConsoleColor;

			// network
			reconnectCheckBox.Checked = tSettings.ReconnectOnConnectionLost;
		}

		/// <summary>
		/// saves the settings from the form to the program settings
		/// </summary>
		private void Save()
		{
			Settings.Copy(tSettings, Program.Settings);
		}

		/// <summary>
		/// Gets a custom color from the user
		/// </summary>
		/// <param name="original"></param>
		/// <returns></returns>
		private Color GetCustomColor(Color original)
		{
			ColorDialog dialog = new ColorDialog()
			{
				AllowFullOpen = true
			};
			DialogResult result = dialog.ShowDialog();

			if (result != DialogResult.OK)
				return original;
			else
				return dialog.Color;
		}

		private void SaveChangesButton_Click(object sender, EventArgs e)
		{
			Save();
			DialogResult = DialogResult.OK;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void DefaultColorPickerButton_Click(object sender, EventArgs e)
		{
			tSettings.DefaultConsoleColor = GetCustomColor(tSettings.DefaultConsoleColor);
			UpdateControls();
		}

		private void ProgramColorPickerButton_Click(object sender, EventArgs e)
		{
			tSettings.ProgramConsoleColor = GetCustomColor(tSettings.ProgramConsoleColor);
			UpdateControls();
		}

		private void SendColorPickerButton_Click(object sender, EventArgs e)
		{
			tSettings.SentConsoleColor = GetCustomColor(tSettings.SentConsoleColor);
			UpdateControls();
		}

		private void LogPathTextBox_TextChanged(object sender, EventArgs e)
		{
			tSettings.LogFilePath = logPathTextBox.Text;
		}

		private void LogEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			tSettings.LogToFile = logEnabledCheckBox.Checked;
		}

		private void ReconnectCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			tSettings.ReconnectOnConnectionLost = reconnectCheckBox.Checked;
		}

		private void UseMinecraftColorsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			tSettings.UseMinecraftColors = useMinecraftColorsCheckBox.Checked;
		}
	}
}
