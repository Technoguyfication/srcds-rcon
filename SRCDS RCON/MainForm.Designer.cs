namespace SRCDS_RCON
{
	partial class MainForm
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
			this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
			this.fileMenuItem = new System.Windows.Forms.MenuItem();
			this.fileSeparator1 = new System.Windows.Forms.MenuItem();
			this.fileSeparator2 = new System.Windows.Forms.MenuItem();
			this.exitMenuItem = new System.Windows.Forms.MenuItem();
			this.consoleMenuItem = new System.Windows.Forms.MenuItem();
			this.findNextMenuItem = new System.Windows.Forms.MenuItem();
			this.helpMenuItem = new System.Windows.Forms.MenuItem();
			this.helpSeparator1 = new System.Windows.Forms.MenuItem();
			this.aboutMenuItem = new System.Windows.Forms.MenuItem();
			this.consoleTextBox = new System.Windows.Forms.RichTextBox();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.consolePanel = new System.Windows.Forms.Panel();
			this.sendButton = new System.Windows.Forms.Button();
			this.vistaMenu = new wyDay.Controls.VistaMenu(this.components);
			this.consoleContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectMenuItem = new System.Windows.Forms.MenuItem();
			this.reconnectMenuItem = new System.Windows.Forms.MenuItem();
			this.disconnectMenuItem = new System.Windows.Forms.MenuItem();
			this.settingsMenuItem = new System.Windows.Forms.MenuItem();
			this.clearMenuItem = new System.Windows.Forms.MenuItem();
			this.findMenuItem = new System.Windows.Forms.MenuItem();
			this.documentationMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.consolePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vistaMenu)).BeginInit();
			this.consoleContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.consoleMenuItem,
            this.helpMenuItem});
			// 
			// fileMenuItem
			// 
			this.fileMenuItem.Index = 0;
			this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.connectMenuItem,
            this.reconnectMenuItem,
            this.disconnectMenuItem,
            this.fileSeparator1,
            this.settingsMenuItem,
            this.fileSeparator2,
            this.exitMenuItem});
			this.fileMenuItem.Text = "&File";
			// 
			// fileSeparator1
			// 
			this.fileSeparator1.Index = 3;
			this.fileSeparator1.Text = "-";
			// 
			// fileSeparator2
			// 
			this.fileSeparator2.Index = 5;
			this.fileSeparator2.Text = "-";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Index = 6;
			this.exitMenuItem.Text = "Exit";
			// 
			// consoleMenuItem
			// 
			this.consoleMenuItem.Index = 1;
			this.consoleMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.clearMenuItem,
            this.menuItem1,
            this.findMenuItem,
            this.findNextMenuItem});
			this.consoleMenuItem.Text = "Console";
			// 
			// findNextMenuItem
			// 
			this.findNextMenuItem.Index = 3;
			this.findNextMenuItem.Shortcut = System.Windows.Forms.Shortcut.F3;
			this.findNextMenuItem.Text = "Find Next";
			// 
			// helpMenuItem
			// 
			this.helpMenuItem.Index = 2;
			this.helpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.documentationMenuItem,
            this.helpSeparator1,
            this.aboutMenuItem});
			this.helpMenuItem.Text = "Help";
			// 
			// helpSeparator1
			// 
			this.helpSeparator1.Index = 1;
			this.helpSeparator1.Text = "-";
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Index = 2;
			this.aboutMenuItem.Text = "About SRCDS RCON";
			// 
			// consoleTextBox
			// 
			this.consoleTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.consoleTextBox.ContextMenuStrip = this.consoleContextMenuStrip;
			this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consoleTextBox.Location = new System.Drawing.Point(0, 0);
			this.consoleTextBox.Name = "consoleTextBox";
			this.consoleTextBox.ReadOnly = true;
			this.consoleTextBox.Size = new System.Drawing.Size(378, 92);
			this.consoleTextBox.TabIndex = 0;
			this.consoleTextBox.TabStop = false;
			this.consoleTextBox.Text = "Lorem ipsum\ndolor sit amet";
			// 
			// inputTextBox
			// 
			this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inputTextBox.Location = new System.Drawing.Point(13, 112);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(298, 20);
			this.inputTextBox.TabIndex = 1;
			// 
			// consolePanel
			// 
			this.consolePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.consolePanel.AutoScroll = true;
			this.consolePanel.BackColor = System.Drawing.SystemColors.Window;
			this.consolePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.consolePanel.Controls.Add(this.consoleTextBox);
			this.consolePanel.Location = new System.Drawing.Point(12, 12);
			this.consolePanel.Name = "consolePanel";
			this.consolePanel.Size = new System.Drawing.Size(380, 94);
			this.consolePanel.TabIndex = 0;
			// 
			// sendButton
			// 
			this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.sendButton.Location = new System.Drawing.Point(317, 110);
			this.sendButton.Name = "sendButton";
			this.sendButton.Size = new System.Drawing.Size(75, 23);
			this.sendButton.TabIndex = 2;
			this.sendButton.Text = "Send";
			this.sendButton.UseVisualStyleBackColor = true;
			// 
			// vistaMenu
			// 
			this.vistaMenu.ContainerControl = this;
			// 
			// consoleContextMenuStrip
			// 
			this.consoleContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripMenuItem1,
            this.disconnectToolStripMenuItem,
            this.reconnectToolStripMenuItem,
            this.toolStripMenuItem2,
            this.copyToolStripMenuItem});
			this.consoleContextMenuStrip.Name = "consoleContextMenuStrip";
			this.consoleContextMenuStrip.Size = new System.Drawing.Size(134, 104);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Image = global::SRCDS_RCON.Properties.Resources.disconnect;
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			// 
			// reconnectToolStripMenuItem
			// 
			this.reconnectToolStripMenuItem.Image = global::SRCDS_RCON.Properties.Resources.arrow_refresh;
			this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
			this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.reconnectToolStripMenuItem.Text = "Reconnect";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 6);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Image = global::SRCDS_RCON.Properties.Resources.page_refresh;
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			// 
			// connectMenuItem
			// 
			this.vistaMenu.SetImage(this.connectMenuItem, global::SRCDS_RCON.Properties.Resources.connect);
			this.connectMenuItem.Index = 0;
			this.connectMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.connectMenuItem.Text = "&Connect";
			this.connectMenuItem.Click += new System.EventHandler(this.ConnectMenuItem_Click);
			// 
			// reconnectMenuItem
			// 
			this.vistaMenu.SetImage(this.reconnectMenuItem, global::SRCDS_RCON.Properties.Resources.arrow_refresh);
			this.reconnectMenuItem.Index = 1;
			this.reconnectMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftN;
			this.reconnectMenuItem.Text = "&Reconnect";
			// 
			// disconnectMenuItem
			// 
			this.vistaMenu.SetImage(this.disconnectMenuItem, global::SRCDS_RCON.Properties.Resources.disconnect);
			this.disconnectMenuItem.Index = 2;
			this.disconnectMenuItem.Text = "Disconnect";
			// 
			// settingsMenuItem
			// 
			this.vistaMenu.SetImage(this.settingsMenuItem, global::SRCDS_RCON.Properties.Resources.application_form_edit);
			this.settingsMenuItem.Index = 4;
			this.settingsMenuItem.Text = "Settings...\tCtrl+,";
			this.settingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
			// 
			// clearMenuItem
			// 
			this.vistaMenu.SetImage(this.clearMenuItem, global::SRCDS_RCON.Properties.Resources.page_refresh);
			this.clearMenuItem.Index = 0;
			this.clearMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
			this.clearMenuItem.Text = "Clea&r";
			// 
			// findMenuItem
			// 
			this.vistaMenu.SetImage(this.findMenuItem, global::SRCDS_RCON.Properties.Resources.find);
			this.findMenuItem.Index = 2;
			this.findMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
			this.findMenuItem.Text = "Find...";
			// 
			// documentationMenuItem
			// 
			this.vistaMenu.SetImage(this.documentationMenuItem, global::SRCDS_RCON.Properties.Resources.book);
			this.documentationMenuItem.Index = 0;
			this.documentationMenuItem.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.documentationMenuItem.Text = "View Documentation";
			this.documentationMenuItem.Click += new System.EventHandler(this.DocumentationMenuItem_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Text = "-";
			// 
			// MainForm
			// 
			this.AcceptButton = this.sendButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(404, 144);
			this.Controls.Add(this.sendButton);
			this.Controls.Add(this.consolePanel);
			this.Controls.Add(this.inputTextBox);
			this.Menu = this.mainMenu;
			this.MinimumSize = new System.Drawing.Size(180, 150);
			this.Name = "MainForm";
			this.Text = "SRCDS RCON";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.consolePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vistaMenu)).EndInit();
			this.consoleContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem fileMenuItem;
		private System.Windows.Forms.MenuItem connectMenuItem;
		private System.Windows.Forms.MenuItem reconnectMenuItem;
		private System.Windows.Forms.MenuItem fileSeparator1;
		private System.Windows.Forms.MenuItem settingsMenuItem;
		private System.Windows.Forms.MenuItem fileSeparator2;
		private System.Windows.Forms.MenuItem exitMenuItem;
		private System.Windows.Forms.MenuItem consoleMenuItem;
		private System.Windows.Forms.MenuItem clearMenuItem;
		private System.Windows.Forms.MenuItem findMenuItem;
		private System.Windows.Forms.MenuItem findNextMenuItem;
		private System.Windows.Forms.MenuItem helpMenuItem;
		private System.Windows.Forms.MenuItem documentationMenuItem;
		private System.Windows.Forms.MenuItem helpSeparator1;
		private System.Windows.Forms.MenuItem aboutMenuItem;
		private System.Windows.Forms.RichTextBox consoleTextBox;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Panel consolePanel;
		private System.Windows.Forms.Button sendButton;
		private wyDay.Controls.VistaMenu vistaMenu;
		private System.Windows.Forms.ContextMenuStrip consoleContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.MenuItem disconnectMenuItem;
		private System.Windows.Forms.MenuItem menuItem1;
	}
}

