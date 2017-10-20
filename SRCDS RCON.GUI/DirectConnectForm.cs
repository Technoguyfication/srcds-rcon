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
	public partial class DirectConnectForm : Form
	{
		public DirectConnectForm()
		{
			InitializeComponent();

			PopulateTypeBox();
		}

		private void PopulateTypeBox()
		{
			List<string> serverTypes = new List<string>();
			// these need to stay in order because they are selected by index
			foreach (ServerType type in Enum.GetValues(typeof(ServerType)))
			{
				serverTypes.Add(Server.GetFriendlyTypeName(type));
			}

			typeComboBox.Items.AddRange(serverTypes.ToArray());
			typeComboBox.SelectedIndex = 0;
		}

		private Server GetCurrentServer()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Opens the form as a dialog to connect to a server
		/// </summary>
		/// <returns></returns>
		public Server OpenConnectDialog()
		{
			DialogResult result = ShowDialog();

			if (result == DialogResult.OK)
				return GetCurrentServer();
			else
				return null;
		}

		private void DirectConnectForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				DialogResult = DialogResult.Cancel;
				e.Handled = true;
			}
		}

		private void ConnectButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}
	}
}
