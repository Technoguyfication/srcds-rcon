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
			this.serverListView = new System.Windows.Forms.ListView();
			this.addressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.portHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.serverContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.serverListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            listViewItem1});
			this.serverListView.Location = new System.Drawing.Point(12, 12);
			this.serverListView.Name = "serverListView";
			this.serverListView.Size = new System.Drawing.Size(279, 114);
			this.serverListView.TabIndex = 0;
			this.serverListView.UseCompatibleStateImageBehavior = false;
			this.serverListView.View = System.Windows.Forms.View.Details;
			this.serverListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ServerListView_KeyDown);
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(216, 132);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(135, 132);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
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
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 6);
			// 
			// serverListContextMenuStrip
			// 
			this.serverListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1});
			this.serverListContextMenuStrip.Name = "serverListContextMenuStrip";
			this.serverListContextMenuStrip.Size = new System.Drawing.Size(153, 48);
			// 
			// newToolStripMenuItem1
			// 
			this.newToolStripMenuItem1.Image = global::SRCDS_RCON.Properties.Resources.add;
			this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
			this.newToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.newToolStripMenuItem1.Text = "New...";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Image = global::SRCDS_RCON.Properties.Resources.connect;
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
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
			// ConnectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 261);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ContextMenuStrip serverContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip serverListContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
	}
}