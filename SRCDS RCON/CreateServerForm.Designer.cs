namespace SRCDS_RCON
{
	partial class CreateServerForm
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
			this.hostTextBox = new System.Windows.Forms.TextBox();
			this.portTextBox = new System.Windows.Forms.TextBox();
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.portLabel = new System.Windows.Forms.Label();
			this.hostLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// hostTextBox
			// 
			this.hostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hostTextBox.Location = new System.Drawing.Point(50, 13);
			this.hostTextBox.Name = "hostTextBox";
			this.hostTextBox.Size = new System.Drawing.Size(177, 20);
			this.hostTextBox.TabIndex = 1;
			// 
			// portTextBox
			// 
			this.portTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.portTextBox.Location = new System.Drawing.Point(268, 13);
			this.portTextBox.Name = "portTextBox";
			this.portTextBox.Size = new System.Drawing.Size(62, 20);
			this.portTextBox.TabIndex = 3;
			// 
			// typeComboBox
			// 
			this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.typeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.typeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Location = new System.Drawing.Point(50, 40);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(131, 21);
			this.typeComboBox.TabIndex = 5;
			// 
			// portLabel
			// 
			this.portLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.portLabel.AutoSize = true;
			this.portLabel.Location = new System.Drawing.Point(233, 16);
			this.portLabel.Name = "portLabel";
			this.portLabel.Size = new System.Drawing.Size(29, 13);
			this.portLabel.TabIndex = 2;
			this.portLabel.Text = "Port:";
			// 
			// hostLabel
			// 
			this.hostLabel.AutoSize = true;
			this.hostLabel.Location = new System.Drawing.Point(12, 16);
			this.hostLabel.Name = "hostLabel";
			this.hostLabel.Size = new System.Drawing.Size(32, 13);
			this.hostLabel.TabIndex = 0;
			this.hostLabel.Text = "Host:";
			// 
			// typeLabel
			// 
			this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(12, 43);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(38, 13);
			this.typeLabel.TabIndex = 4;
			this.typeLabel.Text = "Game:";
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(187, 40);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(61, 23);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.Location = new System.Drawing.Point(254, 40);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(76, 23);
			this.saveButton.TabIndex = 7;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CreateServerForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(342, 75);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.hostLabel);
			this.Controls.Add(this.portLabel);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.portTextBox);
			this.Controls.Add(this.hostTextBox);
			this.MaximizeBox = false;
			this.Name = "CreateServerForm";
			this.Text = "CreateServerForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox hostTextBox;
		private System.Windows.Forms.TextBox portTextBox;
		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.Label portLabel;
		private System.Windows.Forms.Label hostLabel;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button saveButton;
	}
}