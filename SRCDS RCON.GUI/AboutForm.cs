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
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{
			versionNumberLabel.Text = Application.ProductVersion;
		}

		private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MainForm.ShowDocumenation();
		}
	}
}
