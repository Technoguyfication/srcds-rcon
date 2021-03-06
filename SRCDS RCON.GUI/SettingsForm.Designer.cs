﻿namespace SRCDS_RCON
{
	partial class SettingsForm
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
			this.colorGroupBox = new System.Windows.Forms.GroupBox();
			this.defaultColorLabel = new System.Windows.Forms.Label();
			this.programColorLabel = new System.Windows.Forms.Label();
			this.sentColorLabel = new System.Windows.Forms.Label();
			this.defaultColorPickerButton = new System.Windows.Forms.Button();
			this.useMinecraftColorsCheckBox = new System.Windows.Forms.CheckBox();
			this.programColorPickerButton = new System.Windows.Forms.Button();
			this.sentColorPickerButton = new System.Windows.Forms.Button();
			this.settingsToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.logEnabledCheckBox = new System.Windows.Forms.CheckBox();
			this.logPathTextBox = new System.Windows.Forms.TextBox();
			this.reconnectCheckBox = new System.Windows.Forms.CheckBox();
			this.firewallButton = new System.Windows.Forms.Button();
			this.systemGroupBox = new System.Windows.Forms.GroupBox();
			this.logSubstituteLabel = new System.Windows.Forms.Label();
			this.logBrowseButton = new System.Windows.Forms.Button();
			this.networkGroupBox = new System.Windows.Forms.GroupBox();
			this.saveChangesButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.defaultsButton = new System.Windows.Forms.Button();
			this.colorGroupBox.SuspendLayout();
			this.systemGroupBox.SuspendLayout();
			this.networkGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// colorGroupBox
			// 
			this.colorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.colorGroupBox.Controls.Add(this.defaultColorLabel);
			this.colorGroupBox.Controls.Add(this.programColorLabel);
			this.colorGroupBox.Controls.Add(this.sentColorLabel);
			this.colorGroupBox.Controls.Add(this.defaultColorPickerButton);
			this.colorGroupBox.Controls.Add(this.useMinecraftColorsCheckBox);
			this.colorGroupBox.Controls.Add(this.programColorPickerButton);
			this.colorGroupBox.Controls.Add(this.sentColorPickerButton);
			this.colorGroupBox.Location = new System.Drawing.Point(238, 12);
			this.colorGroupBox.Name = "colorGroupBox";
			this.colorGroupBox.Size = new System.Drawing.Size(243, 131);
			this.colorGroupBox.TabIndex = 2;
			this.colorGroupBox.TabStop = false;
			this.colorGroupBox.Text = "Console Colors";
			// 
			// defaultColorLabel
			// 
			this.defaultColorLabel.AutoSize = true;
			this.defaultColorLabel.Location = new System.Drawing.Point(87, 24);
			this.defaultColorLabel.Name = "defaultColorLabel";
			this.defaultColorLabel.Size = new System.Drawing.Size(65, 13);
			this.defaultColorLabel.TabIndex = 1;
			this.defaultColorLabel.Text = "Default Text";
			// 
			// programColorLabel
			// 
			this.programColorLabel.AutoSize = true;
			this.programColorLabel.Location = new System.Drawing.Point(87, 53);
			this.programColorLabel.Name = "programColorLabel";
			this.programColorLabel.Size = new System.Drawing.Size(92, 13);
			this.programColorLabel.TabIndex = 3;
			this.programColorLabel.Text = "Program Message";
			// 
			// sentColorLabel
			// 
			this.sentColorLabel.AutoSize = true;
			this.sentColorLabel.Location = new System.Drawing.Point(87, 82);
			this.sentColorLabel.Name = "sentColorLabel";
			this.sentColorLabel.Size = new System.Drawing.Size(79, 13);
			this.sentColorLabel.TabIndex = 5;
			this.sentColorLabel.Text = "Sent Command";
			// 
			// defaultColorPickerButton
			// 
			this.defaultColorPickerButton.BackColor = System.Drawing.SystemColors.ControlText;
			this.defaultColorPickerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.defaultColorPickerButton.Location = new System.Drawing.Point(6, 19);
			this.defaultColorPickerButton.Name = "defaultColorPickerButton";
			this.defaultColorPickerButton.Size = new System.Drawing.Size(75, 23);
			this.defaultColorPickerButton.TabIndex = 0;
			this.defaultColorPickerButton.UseVisualStyleBackColor = false;
			this.defaultColorPickerButton.Click += new System.EventHandler(this.DefaultColorPickerButton_Click);
			// 
			// useMinecraftColorsCheckBox
			// 
			this.useMinecraftColorsCheckBox.AutoSize = true;
			this.useMinecraftColorsCheckBox.Checked = true;
			this.useMinecraftColorsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.useMinecraftColorsCheckBox.Location = new System.Drawing.Point(6, 106);
			this.useMinecraftColorsCheckBox.Name = "useMinecraftColorsCheckBox";
			this.useMinecraftColorsCheckBox.Size = new System.Drawing.Size(163, 17);
			this.useMinecraftColorsCheckBox.TabIndex = 6;
			this.useMinecraftColorsCheckBox.Text = "Show Minecraft server colors";
			this.settingsToolTip.SetToolTip(this.useMinecraftColorsCheckBox, "For Minecraft / Bukkit servers only.");
			this.useMinecraftColorsCheckBox.UseVisualStyleBackColor = true;
			this.useMinecraftColorsCheckBox.CheckedChanged += new System.EventHandler(this.UseMinecraftColorsCheckBox_CheckedChanged);
			// 
			// programColorPickerButton
			// 
			this.programColorPickerButton.BackColor = System.Drawing.Color.Blue;
			this.programColorPickerButton.Location = new System.Drawing.Point(6, 48);
			this.programColorPickerButton.Name = "programColorPickerButton";
			this.programColorPickerButton.Size = new System.Drawing.Size(75, 23);
			this.programColorPickerButton.TabIndex = 2;
			this.programColorPickerButton.UseVisualStyleBackColor = false;
			this.programColorPickerButton.Click += new System.EventHandler(this.ProgramColorPickerButton_Click);
			// 
			// sentColorPickerButton
			// 
			this.sentColorPickerButton.BackColor = System.Drawing.Color.LimeGreen;
			this.sentColorPickerButton.Location = new System.Drawing.Point(6, 77);
			this.sentColorPickerButton.Name = "sentColorPickerButton";
			this.sentColorPickerButton.Size = new System.Drawing.Size(75, 23);
			this.sentColorPickerButton.TabIndex = 4;
			this.sentColorPickerButton.UseVisualStyleBackColor = false;
			this.sentColorPickerButton.Click += new System.EventHandler(this.SendColorPickerButton_Click);
			// 
			// logEnabledCheckBox
			// 
			this.logEnabledCheckBox.AutoSize = true;
			this.logEnabledCheckBox.Location = new System.Drawing.Point(7, 19);
			this.logEnabledCheckBox.Name = "logEnabledCheckBox";
			this.logEnabledCheckBox.Size = new System.Drawing.Size(118, 17);
			this.logEnabledCheckBox.TabIndex = 1;
			this.logEnabledCheckBox.Text = "Save Console Logs";
			this.settingsToolTip.SetToolTip(this.logEnabledCheckBox, "Enable saving logs of all RCON commands and responses?");
			this.logEnabledCheckBox.UseVisualStyleBackColor = true;
			this.logEnabledCheckBox.CheckedChanged += new System.EventHandler(this.LogEnabledCheckBox_CheckedChanged);
			// 
			// logPathTextBox
			// 
			this.logPathTextBox.Location = new System.Drawing.Point(7, 42);
			this.logPathTextBox.Name = "logPathTextBox";
			this.logPathTextBox.Size = new System.Drawing.Size(140, 20);
			this.logPathTextBox.TabIndex = 2;
			this.logPathTextBox.Text = "logs\\{0}.log";
			this.settingsToolTip.SetToolTip(this.logPathTextBox, "Path to the log file.\r\nThis can be relative to the executable, or an absolute pat" +
        "h.");
			this.logPathTextBox.TextChanged += new System.EventHandler(this.LogPathTextBox_TextChanged);
			// 
			// reconnectCheckBox
			// 
			this.reconnectCheckBox.AutoSize = true;
			this.reconnectCheckBox.Location = new System.Drawing.Point(7, 20);
			this.reconnectCheckBox.Name = "reconnectCheckBox";
			this.reconnectCheckBox.Size = new System.Drawing.Size(171, 17);
			this.reconnectCheckBox.TabIndex = 0;
			this.reconnectCheckBox.Text = "Reconnect on connection loss";
			this.settingsToolTip.SetToolTip(this.reconnectCheckBox, "Whether the program should reconnect automatically if the connection is dropped.");
			this.reconnectCheckBox.UseVisualStyleBackColor = true;
			this.reconnectCheckBox.CheckedChanged += new System.EventHandler(this.ReconnectCheckBox_CheckedChanged);
			// 
			// firewallButton
			// 
			this.firewallButton.Location = new System.Drawing.Point(16, 43);
			this.firewallButton.Name = "firewallButton";
			this.firewallButton.Size = new System.Drawing.Size(160, 23);
			this.firewallButton.TabIndex = 1;
			this.firewallButton.Text = " Allow through Firewall";
			this.settingsToolTip.SetToolTip(this.firewallButton, "This is only needed if the prorgam is being blocked by the firewall.");
			this.firewallButton.UseVisualStyleBackColor = true;
			this.firewallButton.Click += new System.EventHandler(this.FirewallButton_Click);
			// 
			// systemGroupBox
			// 
			this.systemGroupBox.Controls.Add(this.logSubstituteLabel);
			this.systemGroupBox.Controls.Add(this.logBrowseButton);
			this.systemGroupBox.Controls.Add(this.logPathTextBox);
			this.systemGroupBox.Controls.Add(this.logEnabledCheckBox);
			this.systemGroupBox.Location = new System.Drawing.Point(12, 12);
			this.systemGroupBox.Name = "systemGroupBox";
			this.systemGroupBox.Size = new System.Drawing.Size(220, 88);
			this.systemGroupBox.TabIndex = 0;
			this.systemGroupBox.TabStop = false;
			this.systemGroupBox.Text = "System";
			// 
			// logSubstituteLabel
			// 
			this.logSubstituteLabel.AutoSize = true;
			this.logSubstituteLabel.Location = new System.Drawing.Point(4, 66);
			this.logSubstituteLabel.Name = "logSubstituteLabel";
			this.logSubstituteLabel.Size = new System.Drawing.Size(174, 13);
			this.logSubstituteLabel.TabIndex = 3;
			this.logSubstituteLabel.Text = "Substitute {0} for the time and date.";
			// 
			// logBrowseButton
			// 
			this.logBrowseButton.Location = new System.Drawing.Point(153, 40);
			this.logBrowseButton.Name = "logBrowseButton";
			this.logBrowseButton.Size = new System.Drawing.Size(61, 23);
			this.logBrowseButton.TabIndex = 3;
			this.logBrowseButton.Text = "Browse...";
			this.logBrowseButton.UseVisualStyleBackColor = true;
			// 
			// networkGroupBox
			// 
			this.networkGroupBox.Controls.Add(this.firewallButton);
			this.networkGroupBox.Controls.Add(this.reconnectCheckBox);
			this.networkGroupBox.Location = new System.Drawing.Point(12, 106);
			this.networkGroupBox.Name = "networkGroupBox";
			this.networkGroupBox.Size = new System.Drawing.Size(214, 74);
			this.networkGroupBox.TabIndex = 1;
			this.networkGroupBox.TabStop = false;
			this.networkGroupBox.Text = "Network";
			// 
			// saveChangesButton
			// 
			this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveChangesButton.Location = new System.Drawing.Point(389, 193);
			this.saveChangesButton.Name = "saveChangesButton";
			this.saveChangesButton.Size = new System.Drawing.Size(92, 23);
			this.saveChangesButton.TabIndex = 4;
			this.saveChangesButton.Text = "Save Changes";
			this.saveChangesButton.UseVisualStyleBackColor = true;
			this.saveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(127, 193);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(72, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// defaultsButton
			// 
			this.defaultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.defaultsButton.Location = new System.Drawing.Point(12, 193);
			this.defaultsButton.Name = "defaultsButton";
			this.defaultsButton.Size = new System.Drawing.Size(109, 23);
			this.defaultsButton.TabIndex = 5;
			this.defaultsButton.Text = "Reset to Defaults";
			this.defaultsButton.UseVisualStyleBackColor = true;
			this.defaultsButton.Click += new System.EventHandler(this.DefaultsButton_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(493, 228);
			this.Controls.Add(this.defaultsButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveChangesButton);
			this.Controls.Add(this.networkGroupBox);
			this.Controls.Add(this.systemGroupBox);
			this.Controls.Add(this.colorGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.colorGroupBox.ResumeLayout(false);
			this.colorGroupBox.PerformLayout();
			this.systemGroupBox.ResumeLayout(false);
			this.systemGroupBox.PerformLayout();
			this.networkGroupBox.ResumeLayout(false);
			this.networkGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox colorGroupBox;
		private System.Windows.Forms.Button sentColorPickerButton;
		private System.Windows.Forms.Label defaultColorLabel;
		private System.Windows.Forms.Label programColorLabel;
		private System.Windows.Forms.Label sentColorLabel;
		private System.Windows.Forms.Button defaultColorPickerButton;
		private System.Windows.Forms.CheckBox useMinecraftColorsCheckBox;
		private System.Windows.Forms.Button programColorPickerButton;
		private System.Windows.Forms.ToolTip settingsToolTip;
		private System.Windows.Forms.GroupBox systemGroupBox;
		private System.Windows.Forms.Label logSubstituteLabel;
		private System.Windows.Forms.Button logBrowseButton;
		private System.Windows.Forms.TextBox logPathTextBox;
		private System.Windows.Forms.CheckBox logEnabledCheckBox;
		private System.Windows.Forms.GroupBox networkGroupBox;
		private System.Windows.Forms.Button firewallButton;
		private System.Windows.Forms.CheckBox reconnectCheckBox;
		private System.Windows.Forms.Button saveChangesButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button defaultsButton;
	}
}