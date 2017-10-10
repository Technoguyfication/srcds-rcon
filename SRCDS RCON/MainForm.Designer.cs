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
			this.connectMenuItem = new System.Windows.Forms.MenuItem();
			this.reconnectMenuItem = new System.Windows.Forms.MenuItem();
			this.fileSeparator1 = new System.Windows.Forms.MenuItem();
			this.settingsMenuItem = new System.Windows.Forms.MenuItem();
			this.fileSeparator2 = new System.Windows.Forms.MenuItem();
			this.exitMenuItem = new System.Windows.Forms.MenuItem();
			this.consoleMenuItem = new System.Windows.Forms.MenuItem();
			this.clearMenuItem = new System.Windows.Forms.MenuItem();
			this.consoleSeparator1 = new System.Windows.Forms.MenuItem();
			this.findMenuItem = new System.Windows.Forms.MenuItem();
			this.findNextMenuItem = new System.Windows.Forms.MenuItem();
			this.helpMenuItem = new System.Windows.Forms.MenuItem();
			this.documentationMenuItem = new System.Windows.Forms.MenuItem();
			this.helpSeparator1 = new System.Windows.Forms.MenuItem();
			this.aboutMenuItem = new System.Windows.Forms.MenuItem();
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
            this.fileSeparator1,
            this.settingsMenuItem,
            this.fileSeparator2,
            this.exitMenuItem});
			this.fileMenuItem.Text = "&File";
			// 
			// connectMenuItem
			// 
			this.connectMenuItem.Index = 0;
			this.connectMenuItem.Text = "&Connect";
			// 
			// reconnectMenuItem
			// 
			this.reconnectMenuItem.Index = 1;
			this.reconnectMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftR;
			this.reconnectMenuItem.Text = "&Reconnect";
			// 
			// fileSeparator1
			// 
			this.fileSeparator1.Index = 2;
			this.fileSeparator1.Text = "-";
			// 
			// settingsMenuItem
			// 
			this.settingsMenuItem.Index = 3;
			this.settingsMenuItem.Text = "Settings...\tCtrl+,";
			// 
			// fileSeparator2
			// 
			this.fileSeparator2.Index = 4;
			this.fileSeparator2.Text = "-";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Index = 5;
			this.exitMenuItem.Text = "E&xit";
			// 
			// consoleMenuItem
			// 
			this.consoleMenuItem.Index = 1;
			this.consoleMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.clearMenuItem,
            this.consoleSeparator1,
            this.findMenuItem,
            this.findNextMenuItem});
			this.consoleMenuItem.Text = "Console";
			// 
			// clearMenuItem
			// 
			this.clearMenuItem.Index = 0;
			this.clearMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
			this.clearMenuItem.Text = "Clea&r";
			// 
			// consoleSeparator1
			// 
			this.consoleSeparator1.Index = 1;
			this.consoleSeparator1.Text = "-";
			// 
			// findMenuItem
			// 
			this.findMenuItem.Index = 2;
			this.findMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
			this.findMenuItem.Text = "Find...";
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
			// documentationMenuItem
			// 
			this.documentationMenuItem.Index = 0;
			this.documentationMenuItem.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.documentationMenuItem.Text = "View Documentation";
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 274);
			this.Menu = this.mainMenu;
			this.Name = "MainForm";
			this.Text = "SRCDS RCON";
			this.ResumeLayout(false);

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
		private System.Windows.Forms.MenuItem consoleSeparator1;
		private System.Windows.Forms.MenuItem findMenuItem;
		private System.Windows.Forms.MenuItem findNextMenuItem;
		private System.Windows.Forms.MenuItem helpMenuItem;
		private System.Windows.Forms.MenuItem documentationMenuItem;
		private System.Windows.Forms.MenuItem helpSeparator1;
		private System.Windows.Forms.MenuItem aboutMenuItem;
	}
}

