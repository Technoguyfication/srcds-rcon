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
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reconnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findNextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearConsoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.documentationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.consoleMenuItem,
            this.helpMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(408, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileMenuItem
			// 
			this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMenuItem,
            this.reconnectMenuItem,
            this.fileSeparator1,
            this.settingsMenuItem,
            this.fileSeparator2,
            this.exitMenuItem});
			this.fileMenuItem.Name = "fileMenuItem";
			this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileMenuItem.Text = "&File";
			// 
			// connectMenuItem
			// 
			this.connectMenuItem.Name = "connectMenuItem";
			this.connectMenuItem.Size = new System.Drawing.Size(162, 22);
			this.connectMenuItem.Text = "&Connect...";
			// 
			// reconnectMenuItem
			// 
			this.reconnectMenuItem.Name = "reconnectMenuItem";
			this.reconnectMenuItem.Size = new System.Drawing.Size(162, 22);
			this.reconnectMenuItem.Text = "&Reconnect";
			// 
			// fileSeparator1
			// 
			this.fileSeparator1.Name = "fileSeparator1";
			this.fileSeparator1.Size = new System.Drawing.Size(159, 6);
			// 
			// settingsMenuItem
			// 
			this.settingsMenuItem.Name = "settingsMenuItem";
			this.settingsMenuItem.ShortcutKeyDisplayString = "Ctrl+,";
			this.settingsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
			this.settingsMenuItem.Size = new System.Drawing.Size(162, 22);
			this.settingsMenuItem.Text = "Settings...";
			// 
			// fileSeparator2
			// 
			this.fileSeparator2.Name = "fileSeparator2";
			this.fileSeparator2.Size = new System.Drawing.Size(159, 6);
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(162, 22);
			this.exitMenuItem.Text = "E&xit";
			// 
			// editMenuItem
			// 
			this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findMenuItem,
            this.findNextMenuItem});
			this.editMenuItem.Name = "editMenuItem";
			this.editMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editMenuItem.Text = "&Edit";
			// 
			// findMenuItem
			// 
			this.findMenuItem.Name = "findMenuItem";
			this.findMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.findMenuItem.Size = new System.Drawing.Size(146, 22);
			this.findMenuItem.Text = "Find...";
			// 
			// findNextMenuItem
			// 
			this.findNextMenuItem.Name = "findNextMenuItem";
			this.findNextMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.findNextMenuItem.Size = new System.Drawing.Size(146, 22);
			this.findNextMenuItem.Text = "Find Next";
			// 
			// consoleMenuItem
			// 
			this.consoleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearConsoleMenuItem});
			this.consoleMenuItem.Name = "consoleMenuItem";
			this.consoleMenuItem.Size = new System.Drawing.Size(62, 20);
			this.consoleMenuItem.Text = "&Console";
			// 
			// clearConsoleMenuItem
			// 
			this.clearConsoleMenuItem.Name = "clearConsoleMenuItem";
			this.clearConsoleMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.clearConsoleMenuItem.Size = new System.Drawing.Size(142, 22);
			this.clearConsoleMenuItem.Text = "Clea&r";
			// 
			// helpMenuItem
			// 
			this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationMenuItem,
            this.helpSeparator1,
            this.aboutMenuItem});
			this.helpMenuItem.Name = "helpMenuItem";
			this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpMenuItem.Text = "&Help";
			// 
			// documentationMenuItem
			// 
			this.documentationMenuItem.Name = "documentationMenuItem";
			this.documentationMenuItem.Size = new System.Drawing.Size(185, 22);
			this.documentationMenuItem.Text = "View Documentation";
			// 
			// helpSeparator1
			// 
			this.helpSeparator1.Name = "helpSeparator1";
			this.helpSeparator1.Size = new System.Drawing.Size(182, 6);
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(185, 22);
			this.aboutMenuItem.Text = "About SRCDS RCON";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 274);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainForm";
			this.Text = "SRCDS RCON";
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consoleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
		private System.Windows.Forms.ToolStripSeparator fileSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reconnectMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearConsoleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem documentationMenuItem;
		private System.Windows.Forms.ToolStripSeparator helpSeparator1;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findNextMenuItem;
		private System.Windows.Forms.ToolStripSeparator fileSeparator2;
	}
}

