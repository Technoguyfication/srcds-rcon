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
		private MainForm mainForm;

		public ConnectionForm(MainForm mainForm)
		{
			this.mainForm = mainForm;
			InitializeComponent();
		}

		/// <summary>
		/// Closes the form and connects to the server
		/// </summary>
		/// <param name="server"></param>
		private void Connect(Server server)
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
		}

		#endregion

		private void ConnectButtonContextMenuStrip_Opening(object sender, EventArgs e)
		{
			bool serverSelected = IsServerSelected();

			connectButtonDirectConnectItem.Enabled = serverSelected;
		}
	}
}
