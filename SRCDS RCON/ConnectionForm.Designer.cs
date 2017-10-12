using SRCDS_RCON.Utility;
using SRCDS_RCON.Net;

namespace SRCDS_RCON
{
	partial class ConnectionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "192.168.0.254",
            "27015",
            "SRCDS"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2001:4860:4860::8888",
            "25575",
            "Minecraft"}, -1);
			this.serverListView = new System.Windows.Forms.ListView();
			this.addressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.portHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.serverContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serverListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelButton = new System.Windows.Forms.Button();
			this.connectButtonContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.connectButtonConnectItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.connectButtonDirectConnectItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.newButton = new SRCDS_RCON.Utility.DropdownButton();
			this.connectButton = new SRCDS_RCON.Utility.DropdownButton();
			this.serverContextMenuStrip.SuspendLayout();
			this.serverListContextMenuStrip.SuspendLayout();
			this.connectButtonContextMenuStrip.SuspendLayout();
			this.newContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// serverListView
			// 
			this.serverListView.AllowColumnReorder = true;
			this.serverListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.serverListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addressHeader,
            this.portHeader,
            this.gameHeader});
			this.serverListView.FullRowSelect = true;
			this.serverListView.HideSelection = false;
			this.serverListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.serverListView.Location = new System.Drawing.Point(12, 12);
			this.serverListView.MultiSelect = false;
			this.serverListView.Name = "serverListView";
			this.serverListView.Size = new System.Drawing.Size(304, 85);
			this.serverListView.TabIndex = 0;
			this.serverListView.UseCompatibleStateImageBehavior = false;
			this.serverListView.View = System.Windows.Forms.View.Details;
			this.serverListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ServerListView_MouseDoubleClick);
			this.serverListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServerListView_MouseDown);
			// 
			// addressHeader
			// 
			this.addressHeader.Text = "Address";
			this.addressHeader.Width = 150;
			// 
			// portHeader
			// 
			this.portHeader.Text = "Port";
			// 
			// gameHeader
			// 
			this.gameHeader.Text = "Game";
			this.gameHeader.Width = 70;
			// 
			// serverContextMenuStrip
			// 
			this.serverContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.serverContextMenuStrip.Name = "serverContextMenuStrip";
			this.serverContextMenuStrip.Size = new System.Drawing.Size(120, 98);
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Image = global::SRCDS_RCON.Properties.Resources.connect;
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 6);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = global::SRCDS_RCON.Properties.Resources.add;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.newToolStripMenuItem.Text = "New...";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Image = global::SRCDS_RCON.Properties.Resources.server_edit;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.editToolStripMenuItem.Text = "Edit...";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::SRCDS_RCON.Properties.Resources.server_delete;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// serverListContextMenuStrip
			// 
			this.serverListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1});
			this.serverListContextMenuStrip.Name = "serverListContextMenuStrip";
			this.serverListContextMenuStrip.Size = new System.Drawing.Size(108, 26);
			// 
			// newToolStripMenuItem1
			// 
			this.newToolStripMenuItem1.Image = global::SRCDS_RCON.Properties.Resources.add;
			this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
			this.newToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
			this.newToolStripMenuItem1.Text = "New...";
			this.newToolStripMenuItem1.Click += new System.EventHandler(this.NewToolStripMenuItem1_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(159, 103);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// connectButtonContextMenuStrip
			// 
			this.connectButtonContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectButtonConnectItem,
            this.toolStripMenuItem2,
            this.connectButtonDirectConnectItem});
			this.connectButtonContextMenuStrip.Name = "connectButtonContextMenuStrip";
			this.connectButtonContextMenuStrip.Size = new System.Drawing.Size(163, 54);
			this.connectButtonContextMenuStrip.Opened += new System.EventHandler(this.ConnectButtonContextMenuStrip_Opening);
			// 
			// connectButtonConnectItem
			// 
			this.connectButtonConnectItem.Image = global::SRCDS_RCON.Properties.Resources.connect;
			this.connectButtonConnectItem.Name = "connectButtonConnectItem";
			this.connectButtonConnectItem.Size = new System.Drawing.Size(162, 22);
			this.connectButtonConnectItem.Text = "Connect";
			this.connectButtonConnectItem.Click += new System.EventHandler(this.ConnectButtonConnectItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
			// 
			// connectButtonDirectConnectItem
			// 
			this.connectButtonDirectConnectItem.Name = "connectButtonDirectConnectItem";
			this.connectButtonDirectConnectItem.Size = new System.Drawing.Size(162, 22);
			this.connectButtonDirectConnectItem.Text = "Direct Connect...";
			this.connectButtonDirectConnectItem.Click += new System.EventHandler(this.ConnectButtonDirectConnectItem_Click);
			// 
			// newContextMenuStrip
			// 
			this.newContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem2,
            this.toolStripMenuItem3,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
			this.newContextMenuStrip.Name = "editButtonContextMenuStrip";
			this.newContextMenuStrip.Size = new System.Drawing.Size(153, 98);
			this.newContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.EditButtonContextMenuStrip_Opening);
			// 
			// newToolStripMenuItem2
			// 
			this.newToolStripMenuItem2.Image = global::SRCDS_RCON.Properties.Resources.add;
			this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
			this.newToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.newToolStripMenuItem2.Text = "New...";
			this.newToolStripMenuItem2.Click += new System.EventHandler(this.NewToolStripMenuItem2_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
			// 
			// editToolStripMenuItem1
			// 
			this.editToolStripMenuItem1.Image = global::SRCDS_RCON.Properties.Resources.server_edit;
			this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
			this.editToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.editToolStripMenuItem1.Text = "Edit...";
			this.editToolStripMenuItem1.Click += new System.EventHandler(this.EditToolStripMenuItem1_Click);
			// 
			// deleteToolStripMenuItem1
			// 
			this.deleteToolStripMenuItem1.Image = global::SRCDS_RCON.Properties.Resources.server_delete;
			this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.deleteToolStripMenuItem1.Text = "Delete";
			// 
			// newButton
			// 
			this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.newButton.Location = new System.Drawing.Point(12, 103);
			this.newButton.Menu = this.newContextMenuStrip;
			this.newButton.Name = "newButton";
			this.newButton.Size = new System.Drawing.Size(69, 23);
			this.newButton.SplitStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this.newButton.TabIndex = 4;
			this.newButton.Text = "New   ";
			this.newButton.UseVisualStyleBackColor = true;
			this.newButton.Click += new System.EventHandler(this.NewButton_Click);
			// 
			// connectButton
			// 
			this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.connectButton.Location = new System.Drawing.Point(240, 103);
			this.connectButton.Menu = this.connectButtonContextMenuStrip;
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(76, 23);
			this.connectButton.SplitStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this.connectButton.TabIndex = 3;
			this.connectButton.Text = "Connect    ";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
			// 
			// ConnectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(328, 138);
			this.Controls.Add(this.newButton);
			this.Controls.Add(this.connectButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.serverListView);
			this.MaximizeBox = false;
			this.Name = "ConnectionForm";
			this.Text = "ConnectionForm";
			this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ServerListView_MouseDoubleClick);
			this.serverContextMenuStrip.ResumeLayout(false);
			this.serverListContextMenuStrip.ResumeLayout(false);
			this.connectButtonContextMenuStrip.ResumeLayout(false);
			this.newContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView serverListView;
		private System.Windows.Forms.ColumnHeader addressHeader;
		private System.Windows.Forms.ColumnHeader portHeader;
		private System.Windows.Forms.ColumnHeader gameHeader;
		private System.Windows.Forms.ContextMenuStrip serverContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip serverListContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.ContextMenuStrip connectButtonContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem connectButtonConnectItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem connectButtonDirectConnectItem;
		private Utility.DropdownButton connectButton;
		private Utility.DropdownButton newButton;
		private System.Windows.Forms.ContextMenuStrip newContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
	}
}