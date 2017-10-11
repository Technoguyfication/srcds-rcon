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

		private void ServerListView_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				// right clicking on server entry
				if (serverListView.FocusedItem.Bounds.Contains(e.Location))
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
			if (serverListView.FocusedItem.Bounds.Contains(e.Location))
				ConnectToSelectedServer();
		}

		private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ConnectToSelectedServer();
		}

		private void ConnectToSelectedServer()
		{
			ConnectToListViewItem(serverListView.FocusedItem);
		}

		private void ConnectToListViewItem(ListViewItem item)
		{
			throw new NotImplementedException();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void ConnectButton_Click(object sender, EventArgs e)
		{
			ConnectToSelectedServer();
		}
	}
}
