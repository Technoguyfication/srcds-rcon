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
		}

		public CreateServerForm(Server server)
		{
			InitializeComponent();

			hostLabel.Text = server.Hostname;
			portLabel.Text = server.Port.ToString();

			typeLabel.Text = Server.GetFriendlyTypeName(server.Type);
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			Settings.Servers.Add(new Server()
			{
				Hostname = hostTextBox.Text,
				Port = int.Parse(portTextBox.Text),
				Type = (ServerType)Enum.Parse(typeof(ServerType), typeComboBox.Text)
			});

			DialogResult = DialogResult.OK;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
