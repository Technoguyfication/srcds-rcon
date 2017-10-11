namespace SRCDS_RCON
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
			this.sendColorPickerButton = new System.Windows.Forms.Button();
			this.settingsToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.logEnabledCheckBox = new System.Windows.Forms.CheckBox();
			this.logPathTextBox = new System.Windows.Forms.TextBox();
			this.reconnectCheckBox = new System.Windows.Forms.CheckBox();
			this.firewallButton = new System.Windows.Forms.Button();
			this.systemGroupBox = new System.Windows.Forms.GroupBox();
			this.logSubstituteLabel = new System.Windows.Forms.Label();
			this.logBrowseButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.saveChangesButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.colorGroupBox.SuspendLayout();
			this.systemGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// colorGroupBox
			// 
			this.colorGroupBox.Controls.Add(this.defaultColorLabel);
			this.colorGroupBox.Controls.Add(this.programColorLabel);
			this.colorGroupBox.Controls.Add(this.sentColorLabel);
			this.colorGroupBox.Controls.Add(this.defaultColorPickerButton);
			this.colorGroupBox.Controls.Add(this.useMinecraftColorsCheckBox);
			this.colorGroupBox.Controls.Add(this.programColorPickerButton);
			this.colorGroupBox.Controls.Add(this.sendColorPickerButton);
			this.colorGroupBox.Location = new System.Drawing.Point(216, 12);
			this.colorGroupBox.Name = "colorGroupBox";
			this.colorGroupBox.Size = new System.Drawing.Size(194, 132);
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
			this.defaultColorPickerButton.Location = new System.Drawing.Point(6, 19);
			this.defaultColorPickerButton.Name = "defaultColorPickerButton";
			this.defaultColorPickerButton.Size = new System.Drawing.Size(75, 23);
			this.defaultColorPickerButton.TabIndex = 0;
			this.defaultColorPickerButton.UseVisualStyleBackColor = false;
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
			// 
			// programColorPickerButton
			// 
			this.programColorPickerButton.BackColor = System.Drawing.Color.Blue;
			this.programColorPickerButton.Location = new System.Drawing.Point(6, 48);
			this.programColorPickerButton.Name = "programColorPickerButton";
			this.programColorPickerButton.Size = new System.Drawing.Size(75, 23);
			this.programColorPickerButton.TabIndex = 2;
			this.programColorPickerButton.UseVisualStyleBackColor = false;
			// 
			// sendColorPickerButton
			// 
			this.sendColorPickerButton.BackColor = System.Drawing.Color.LimeGreen;
			this.sendColorPickerButton.Location = new System.Drawing.Point(6, 77);
			this.sendColorPickerButton.Name = "sendColorPickerButton";
			this.sendColorPickerButton.Size = new System.Drawing.Size(75, 23);
			this.sendColorPickerButton.TabIndex = 4;
			this.sendColorPickerButton.UseVisualStyleBackColor = false;
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
			// 
			// logPathTextBox
			// 
			this.logPathTextBox.Location = new System.Drawing.Point(7, 42);
			this.logPathTextBox.Name = "logPathTextBox";
			this.logPathTextBox.Size = new System.Drawing.Size(118, 20);
			this.logPathTextBox.TabIndex = 2;
			this.logPathTextBox.Text = "logs\\{0}.log";
			this.settingsToolTip.SetToolTip(this.logPathTextBox, "Path to the log file.\r\nThis can be relative to the executable, or an absolute pat" +
        "h.");
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
			// 
			// firewallButton
			// 
			this.firewallButton.Location = new System.Drawing.Point(7, 43);
			this.firewallButton.Name = "firewallButton";
			this.firewallButton.Size = new System.Drawing.Size(185, 23);
			this.firewallButton.TabIndex = 1;
			this.firewallButton.Text = "Allow through Windows Firewall";
			this.settingsToolTip.SetToolTip(this.firewallButton, "This is only needed if the prorgam is being blocked by the firewall.");
			this.firewallButton.UseVisualStyleBackColor = true;
			// 
			// systemGroupBox
			// 
			this.systemGroupBox.Controls.Add(this.logSubstituteLabel);
			this.systemGroupBox.Controls.Add(this.logBrowseButton);
			this.systemGroupBox.Controls.Add(this.logPathTextBox);
			this.systemGroupBox.Controls.Add(this.logEnabledCheckBox);
			this.systemGroupBox.Location = new System.Drawing.Point(12, 12);
			this.systemGroupBox.Name = "systemGroupBox";
			this.systemGroupBox.Size = new System.Drawing.Size(198, 88);
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
			this.logBrowseButton.Location = new System.Drawing.Point(131, 40);
			this.logBrowseButton.Name = "logBrowseButton";
			this.logBrowseButton.Size = new System.Drawing.Size(61, 23);
			this.logBrowseButton.TabIndex = 3;
			this.logBrowseButton.Text = "Browse...";
			this.logBrowseButton.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.firewallButton);
			this.groupBox1.Controls.Add(this.reconnectCheckBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 107);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 74);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Network";
			// 
			// saveChangesButton
			// 
			this.saveChangesButton.Location = new System.Drawing.Point(308, 154);
			this.saveChangesButton.Name = "saveChangesButton";
			this.saveChangesButton.Size = new System.Drawing.Size(104, 23);
			this.saveChangesButton.TabIndex = 4;
			this.saveChangesButton.Text = "Save Changes";
			this.saveChangesButton.UseVisualStyleBackColor = true;
			this.saveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(218, 154);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(84, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(422, 189);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveChangesButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.systemGroupBox);
			this.Controls.Add(this.colorGroupBox);
			this.Name = "SettingsForm";
			this.Text = "Settings";
			this.colorGroupBox.ResumeLayout(false);
			this.colorGroupBox.PerformLayout();
			this.systemGroupBox.ResumeLayout(false);
			this.systemGroupBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox colorGroupBox;
		private System.Windows.Forms.Button sendColorPickerButton;
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button firewallButton;
		private System.Windows.Forms.CheckBox reconnectCheckBox;
		private System.Windows.Forms.Button saveChangesButton;
		private System.Windows.Forms.Button cancelButton;
	}
}