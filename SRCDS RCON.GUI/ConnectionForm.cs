using SRCDS_RCON.Net;
using SRCDS_RCON.Utility;
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
	public partial class ConnectionForm : Form
	{
		/// <summary>
		/// Fired when the user connects to a server
		/// </summary>
		public event EventHandler<ServerConnectEventArgs> ServerConnect;

		public ConnectionForm()
		{
			InitializeComponent();

			LoadServers();
		}

		/// <summary>
		/// Closes the form and connects to the server
		/// </summary>
		/// <param name="server"></param>
		private void Connect(Server server)
		{
			ServerConnect?.Invoke(this, new ServerConnectEventArgs() { Server = server });
			DialogResult = DialogResult.OK;
		}

		/// <summary>
		/// Opens the create server dialog
		/// </summary>
		private void CreateServer()
		{
			using (CreateServerForm form = new CreateServerForm())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					LoadServers();
				}
			}
		}

		/// <summary>
		/// Opens the create server dialog and removes the old one on success
		/// </summary>
		/// <param name="server"></param>
		private void EditServer(Server server)
		{
			using (CreateServerForm form = new CreateServerForm(server))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					DeleteServer(server);
				}
			}
		}

		/// <summary>
		/// Deletes a server from the config
		/// </summary>
		/// <param name="server"></param>
		private void DeleteServer(Server server)
		{
			List<Server> servers = SrcdsRcon.Settings.Servers;
			servers.Remove(server);
			SrcdsRcon.Settings.Servers = servers;

			LoadServers();
		}

		/// <summary>
		/// (Re)load server list
		/// </summary>
		public void LoadServers()
		{
			serverListView.Items.Clear();
			foreach (Server server in SrcdsRcon.Settings.Servers)
			{
				ListViewItem item = new ListViewItem(new string[]
					{
						server.Hostname,
						server.Port.ToString(),
						Server.GetFriendlyTypeName(server.Type)
					})
				{
					Tag = server
				};


				serverListView.Items.Add(item);
			}
		}

		/// <summary>
		/// Gets the selected server from the list
		/// </summary>
		/// <returns></returns>
		private Server GetSelectedServer()
		{
			return (Server)GetSelectedItem().Tag;
		}

		/// <summary>
		/// Gets whether or not a server is selected in the list
		/// </summary>
		/// <returns></returns>
		private bool IsServerSelected()
		{
			return GetSelectedItem() != null;
		}

		/// <summary>
		/// Gets the selected item from the server list
		/// </summary>
		/// <returns></returns>
		private ListViewItem GetSelectedItem()
		{
			if (serverListView.SelectedItems.Count == 0)
				return null;
			else
				return serverListView.SelectedItems[0];
		}

		#region Event Handlers

		private void ServerListView_MouseDown(object sender, MouseEventArgs e)
		{
			// check for right click
			if (e.Button == MouseButtons.Right)
			{
				bool isClickingOnServer = false;
				foreach (ListViewItem server in serverListView.Items)
				{
					if (server.Bounds.Contains(e.Location))
					{
						isClickingOnServer = true;
						break;
					}
				}

				// right clicking on server entry
				if (isClickingOnServer)
				{
					serverContextMenuStrip.Show(Cursor.Position);
				}
				// right clicking on blank space
				else
				{
					serverListContextMenuStrip.Show(Cursor.Position);
				}
			}
		}

		private void ConnectionForm_KeyDown(object sender, KeyEventArgs e)
		{
			// check for key combos
			if (e.KeyCode == Keys.N && e.Control)	// new
			{
				e.Handled = true;
				CreateServer();
			}
			else if (e.KeyCode == Keys.Delete)		// delete
			{
				if (IsServerSelected())
				{
					DeleteServer(GetSelectedServer());
					e.Handled = true;
				}
			}
		}

		private void ServerListView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (IsServerSelected() && serverListView.FocusedItem.Bounds.Contains(e.Location))
				Connect(GetSelectedServer());
		}

		private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (IsServerSelected())
				Connect(GetSelectedServer());
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void ConnectButton_Click(object sender, EventArgs e)
		{
			if (IsServerSelected())
				Connect(GetSelectedServer());
		}

		private void ConnectButtonConnectItem_Click(object sender, EventArgs e)
		{
			if (IsServerSelected())
				Connect(GetSelectedServer());
		}

		private void ConnectButtonDirectConnectItem_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void EditButtonContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			bool serverSelected = IsServerSelected();

			editToolStripMenuItem1.Enabled = serverSelected;
			deleteToolStripMenuItem1.Enabled = serverSelected;
		}

		private void EditToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (IsServerSelected())
				EditServer(GetSelectedServer());
		}

		private void ConnectButtonContextMenuStrip_Opening(object sender, EventArgs e)
		{
			bool serverSelected = IsServerSelected();

			connectButtonDirectConnectItem.Enabled = serverSelected;
		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			CreateServer();
		}

		private void EditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (IsServerSelected())
				EditServer(GetSelectedServer());
		}

		private void NewToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			CreateServer();
		}

		private void NewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CreateServer();
		}

		private void NewToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			CreateServer();
		}

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (IsServerSelected())
				DeleteServer(GetSelectedServer());
		}

		private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (IsServerSelected())
				DeleteServer(GetSelectedServer());
		}

		#endregion
	}

	public class ServerConnectEventArgs : EventArgs
	{
		public Server Server { get; set; }
	}
}
