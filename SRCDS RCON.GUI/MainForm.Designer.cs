namespace SRCDS_RCON.GUI
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
			this.consoleTextBox = new System.Windows.Forms.RichTextBox();
			this.consoleContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.consolePanel = new System.Windows.Forms.Panel();
			this.sendButton = new System.Windows.Forms.Button();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reconnectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.disconnectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutSRCDSRCONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consoleContextMenuStrip.SuspendLayout();
			this.consolePanel.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// consoleTextBox
			// 
			this.consoleTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.consoleTextBox.ContextMenuStrip = this.consoleContextMenuStrip;
			this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consoleTextBox.Location = new System.Drawing.Point(0, 0);
			this.consoleTextBox.Name = "consoleTextBox";
			this.consoleTextBox.ReadOnly = true;
			this.consoleTextBox.Size = new System.Drawing.Size(378, 102);
			this.consoleTextBox.TabIndex = 0;
			this.consoleTextBox.TabStop = false;
			this.consoleTextBox.Text = "Lorem ipsum\ndolor sit amet";
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
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Image = global::SRCDS_RCON.GUI.Properties.Resources.page_refresh;
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Image = global::SRCDS_RCON.GUI.Properties.Resources.disconnect;
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			// 
			// reconnectToolStripMenuItem
			// 
			this.reconnectToolStripMenuItem.Image = global::SRCDS_RCON.GUI.Properties.Resources.arrow_refresh;
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
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
			// 
			// inputTextBox
			// 
			this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.inputTextBox.Location = new System.Drawing.Point(13, 137);
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
			this.consolePanel.Location = new System.Drawing.Point(12, 27);
			this.consolePanel.Name = "consolePanel";
			this.consolePanel.Size = new System.Drawing.Size(380, 104);
			this.consolePanel.TabIndex = 0;
			// 
			// sendButton
			// 
			this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.sendButton.Location = new System.Drawing.Point(317, 135);
			this.sendButton.Name = "sendButton";
			this.sendButton.Size = new System.Drawing.Size(75, 23);
			this.sendButton.TabIndex = 2;
			this.sendButton.Text = "Send";
			this.sendButton.UseVisualStyleBackColor = true;
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.BackColor = System.Drawing.SystemColors.Window;
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.consoleToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.mainMenuStrip.Size = new System.Drawing.Size(404, 24);
			this.mainMenuStrip.TabIndex = 3;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.connectToolStripMenuItem,
			this.reconnectToolStripMenuItem1,
			this.disconnectToolStripMenuItem1,
			this.toolStripMenuItem3,
			this.settingsToolStripMenuItem,
			this.toolStripMenuItem4,
			this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Image = global::SRCDS_RCON.GUI.Properties.Resources.connect;
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.connectToolStripMenuItem.Text = "&Connect...";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
			// 
			// reconnectToolStripMenuItem1
			// 
			this.reconnectToolStripMenuItem1.Image = global::SRCDS_RCON.GUI.Properties.Resources.arrow_refresh;
			this.reconnectToolStripMenuItem1.Name = "reconnectToolStripMenuItem1";
			this.reconnectToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
			| System.Windows.Forms.Keys.N)));
			this.reconnectToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
			this.reconnectToolStripMenuItem1.Text = "&Reconnect";
			// 
			// disconnectToolStripMenuItem1
			// 
			this.disconnectToolStripMenuItem1.Image = global::SRCDS_RCON.GUI.Properties.Resources.disconnect;
			this.disconnectToolStripMenuItem1.Name = "disconnectToolStripMenuItem1";
			this.disconnectToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.disconnectToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
			this.disconnectToolStripMenuItem1.Text = "&Disconnect";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(202, 6);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Image = global::SRCDS_RCON.GUI.Properties.Resources.application_form_edit;
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+,";
			this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.settingsToolStripMenuItem.Text = "Settings...";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(202, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// consoleToolStripMenuItem
			// 
			this.consoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.clearToolStripMenuItem1,
			this.toolStripMenuItem5,
			this.findToolStripMenuItem,
			this.findNextToolStripMenuItem});
			this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
			this.consoleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.consoleToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.consoleToolStripMenuItem.Text = "&Console";
			// 
			// clearToolStripMenuItem1
			// 
			this.clearToolStripMenuItem1.Image = global::SRCDS_RCON.GUI.Properties.Resources.page_refresh;
			this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
			this.clearToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.clearToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.clearToolStripMenuItem1.Text = "Clea&r";
			this.clearToolStripMenuItem1.Click += new System.EventHandler(this.ClearToolStripMenuItem1_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(149, 6);
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Image = global::SRCDS_RCON.GUI.Properties.Resources.find;
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.findToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.findToolStripMenuItem.Text = "Find...";
			// 
			// findNextToolStripMenuItem
			// 
			this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
			this.findNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.findNextToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.findNextToolStripMenuItem.Text = "Find Next";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.viewDocumentationToolStripMenuItem,
			this.toolStripMenuItem6,
			this.aboutSRCDSRCONToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// viewDocumentationToolStripMenuItem
			// 
			this.viewDocumentationToolStripMenuItem.Image = global::SRCDS_RCON.GUI.Properties.Resources.book;
			this.viewDocumentationToolStripMenuItem.Name = "viewDocumentationToolStripMenuItem";
			this.viewDocumentationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.viewDocumentationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.viewDocumentationToolStripMenuItem.Text = "View Documentation";
			this.viewDocumentationToolStripMenuItem.Click += new System.EventHandler(this.ViewDocumentationToolStripMenuItem_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(201, 6);
			// 
			// aboutSRCDSRCONToolStripMenuItem
			// 
			this.aboutSRCDSRCONToolStripMenuItem.Name = "aboutSRCDSRCONToolStripMenuItem";
			this.aboutSRCDSRCONToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.aboutSRCDSRCONToolStripMenuItem.Text = "About SRCDS RCON";
			// 
			// MainForm
			// 
			this.AcceptButton = this.sendButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(404, 169);
			this.Controls.Add(this.mainMenuStrip);
			this.Controls.Add(this.sendButton);
			this.Controls.Add(this.consolePanel);
			this.Controls.Add(this.inputTextBox);
			this.MainMenuStrip = this.mainMenuStrip;
			this.MinimumSize = new System.Drawing.Size(180, 150);
			this.Name = "MainForm";
			this.Text = "SRCDS RCON";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
			this.consoleContextMenuStrip.ResumeLayout(false);
			this.consolePanel.ResumeLayout(false);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RichTextBox consoleTextBox;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Panel consolePanel;
		private System.Windows.Forms.Button sendButton;
		private System.Windows.Forms.ContextMenuStrip consoleContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewDocumentationToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem aboutSRCDSRCONToolStripMenuItem;
	}
}

