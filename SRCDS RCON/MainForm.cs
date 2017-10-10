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
		public MainForm()
		{
			InitializeComponent();
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
	}
}
