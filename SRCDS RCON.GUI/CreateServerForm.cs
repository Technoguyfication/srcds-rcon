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
		public CreateServerForm()
		{
			InitializeComponent();

			PopulateTypeBox();
		}

		public CreateServerForm(Server server)
		{
			InitializeComponent();

			hostTextBox.Text = server.Hostname;
			portTextBox.Text = server.Port.ToString();

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
			List<Server> servers = SrcdsRcon.Settings.Servers;

			servers.Add(new Server()
			{
				Hostname = hostTextBox.Text,
				Port = int.Parse(portTextBox.Text),
				Type = (ServerType)Enum.Parse(typeof(ServerType), Enum.GetName(typeof(ServerType), typeComboBox.SelectedIndex))
			});

			SrcdsRcon.Settings.Servers = servers;

			DialogResult = DialogResult.OK;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
