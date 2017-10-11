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

		public SettingsForm()
		{
			InitializeComponent();

			// add uac shield to firewall button
			firewallButton.FlatStyle = FlatStyle.System;
			SendMessage(firewallButton.Handle, BCM_SETSHIELD, 0, 0xFFFFFFFF);
		}

		private void SaveChangesButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
