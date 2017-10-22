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
	public partial class CreateServerForm : Form
	{
		private int _originalHash = 0;

		public CreateServerForm()
		{
			InitializeComponent();

			PopulateTypeBox();
		}

		public CreateServerForm(Server server)
		{
			InitializeComponent();

			_originalHash = server.GetHashCode();

			hostTextBox.Text = server.Hostname;
			portTextBox.Text = server.Port.ToString();
			passwordTextBox.Text = server.Password;

			PopulateTypeBox();

			typeComboBox.SelectedIndex = typeComboBox.Items.IndexOf(Server.GetFriendlyTypeName(server.Type));
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

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(portTextBox.Text, out int _))
			{
				MessageBox.Show(
					"The port you entered is invalid.\n" +
					$"Please enter a valid IANA port number.",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);

				return;
			}

			Server newServer = new Server()
			{
				Hostname = hostTextBox.Text,
				Port = int.Parse(portTextBox.Text),
				Type = (ServerType)Enum.Parse(typeof(ServerType), Enum.GetName(typeof(ServerType), typeComboBox.SelectedIndex)),
				Password = passwordTextBox.Text
			};
			
			// has the server been edited at all?
			if (_originalHash != newServer.GetHashCode())
			{
				List<Server> servers = SrcdsRcon.Settings.Servers;
				servers.Add(newServer);
				SrcdsRcon.Settings.Servers = servers;

				DialogResult = DialogResult.OK;
			}
			else
			{
				DialogResult = DialogResult.Cancel;
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void HostTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.OemSemicolon && e.Shift)  // semicolon
			{
				portTextBox.Select();
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}
	}
}
