namespace SRCDS_RCON.GUI
{
	partial class DirectConnectForm
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
			this.hostnameTextBox = new System.Windows.Forms.TextBox();
			this.portTextBox = new System.Windows.Forms.TextBox();
			this.hostnameLabel = new System.Windows.Forms.Label();
			this.portLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.connectButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// hostnameTextBox
			// 
			this.hostnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hostnameTextBox.Location = new System.Drawing.Point(50, 12);
			this.hostnameTextBox.Name = "hostnameTextBox";
			this.hostnameTextBox.Size = new System.Drawing.Size(287, 20);
			this.hostnameTextBox.TabIndex = 1;
			// 
			// portTextBox
			// 
			this.portTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.portTextBox.Location = new System.Drawing.Point(50, 38);
			this.portTextBox.Name = "portTextBox";
			this.portTextBox.Size = new System.Drawing.Size(93, 20);
			this.portTextBox.TabIndex = 3;
			// 
			// hostnameLabel
			// 
			this.hostnameLabel.AutoSize = true;
			this.hostnameLabel.Location = new System.Drawing.Point(12, 15);
			this.hostnameLabel.Name = "hostnameLabel";
			this.hostnameLabel.Size = new System.Drawing.Size(32, 13);
			this.hostnameLabel.TabIndex = 0;
			this.hostnameLabel.Text = "Host:";
			// 
			// portLabel
			// 
			this.portLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.portLabel.AutoSize = true;
			this.portLabel.Location = new System.Drawing.Point(12, 41);
			this.portLabel.Name = "portLabel";
			this.portLabel.Size = new System.Drawing.Size(29, 13);
			this.portLabel.TabIndex = 2;
			this.portLabel.Text = "Port:";
			// 
			// typeLabel
			// 
			this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(149, 41);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(34, 13);
			this.typeLabel.TabIndex = 4;
			this.typeLabel.Text = "Type:";
			// 
			// typeComboBox
			// 
			this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.typeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.typeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Location = new System.Drawing.Point(189, 38);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(79, 21);
			this.typeComboBox.TabIndex = 5;
			// 
			// connectButton
			// 
			this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.connectButton.Location = new System.Drawing.Point(275, 36);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(62, 23);
			this.connectButton.TabIndex = 6;
			this.connectButton.Text = "Connect";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
			// 
			// DirectConnectForm
			// 
			this.AcceptButton = this.connectButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 70);
			this.Controls.Add(this.connectButton);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.portLabel);
			this.Controls.Add(this.hostnameLabel);
			this.Controls.Add(this.portTextBox);
			this.Controls.Add(this.hostnameTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "DirectConnectForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Direct Connect";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DirectConnectForm_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox hostnameTextBox;
		private System.Windows.Forms.TextBox portTextBox;
		private System.Windows.Forms.Label hostnameLabel;
		private System.Windows.Forms.Label portLabel;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.Button connectButton;
	}
}