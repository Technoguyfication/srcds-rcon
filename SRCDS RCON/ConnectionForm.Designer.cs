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
			System.Windows.Forms.ListViewItem serverPreviewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "192.168.0.254",
            "27015",
            "SRCDS"}, -1);
			System.Windows.Forms.ListViewItem serverPreviewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
			"192.168.0.254",
			"27015",
			"SRCDS"}, -1);
			this.serverListView = new System.Windows.Forms.ListView();
			this.addressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.portHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.connectButton = new System.Windows.Forms.Button();
			this.serverContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serverListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelButton = new System.Windows.Forms.Button();
			this.serverContextMenuStrip.SuspendLayout();
			this.serverListContextMenuStrip.SuspendLayout();
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
            serverPreviewItem1, serverPreviewItem2});
			this.serverListView.Location = new System.Drawing.Point(12, 12);
			this.serverListView.Name = "serverListView";
			this.serverListView.Size = new System.Drawing.Size(279, 114);
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
			this.gameHeader.Width = 50;
			// 
			// connectButton
			// 
			this.connectButton.Location = new System.Drawing.Point(216, 132);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(75, 23);
			this.connectButton.TabIndex = 1;
			this.connectButton.Text = "Connect";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
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
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Image = global::SRCDS_RCON.Properties.Resources.server_edit;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.editToolStripMenuItem.Text = "Edit...";
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
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(135, 132);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// ConnectionForm
			// 
			this.AcceptButton = this.connectButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(303, 261);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.connectButton);
			this.Controls.Add(this.serverListView);
			this.MaximizeBox = false;
			this.Name = "ConnectionForm";
			this.Text = "ConnectionForm";
			this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ServerListView_MouseDoubleClick);
			this.serverContextMenuStrip.ResumeLayout(false);
			this.serverListContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView serverListView;
		private System.Windows.Forms.ColumnHeader addressHeader;
		private System.Windows.Forms.ColumnHeader portHeader;
		private System.Windows.Forms.ColumnHeader gameHeader;
		private System.Windows.Forms.Button connectButton;
		private System.Windows.Forms.ContextMenuStrip serverContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip serverListContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
		private System.Windows.Forms.Button cancelButton;
	}
}