namespace SRCDS_RCON.GUI
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.titleLabel = new System.Windows.Forms.Label();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.githubLabel = new System.Windows.Forms.Label();
			this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
			this.versionLabel = new System.Windows.Forms.Label();
			this.versionNumberLabel = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(88, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(241, 50);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "SRCDS RCON";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(29, 70);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(358, 65);
			this.descriptionLabel.TabIndex = 1;
			this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
			// 
			// githubLabel
			// 
			this.githubLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.githubLabel.AutoSize = true;
			this.githubLabel.Location = new System.Drawing.Point(29, 156);
			this.githubLabel.Name = "githubLabel";
			this.githubLabel.Size = new System.Drawing.Size(41, 13);
			this.githubLabel.TabIndex = 2;
			this.githubLabel.Text = "Github:";
			// 
			// githubLinkLabel
			// 
			this.githubLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.githubLinkLabel.AutoSize = true;
			this.githubLinkLabel.Location = new System.Drawing.Point(76, 156);
			this.githubLinkLabel.Name = "githubLinkLabel";
			this.githubLinkLabel.Size = new System.Drawing.Size(242, 13);
			this.githubLinkLabel.TabIndex = 3;
			this.githubLinkLabel.TabStop = true;
			this.githubLinkLabel.Text = "https://github.com/Technoguyfication/srcds-rcon";
			// 
			// versionLabel
			// 
			this.versionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.versionLabel.AutoSize = true;
			this.versionLabel.Location = new System.Drawing.Point(29, 180);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(45, 13);
			this.versionLabel.TabIndex = 2;
			this.versionLabel.Text = "Version:";
			// 
			// versionNumberLabel
			// 
			this.versionNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.versionNumberLabel.AutoSize = true;
			this.versionNumberLabel.Location = new System.Drawing.Point(76, 180);
			this.versionNumberLabel.Name = "versionNumberLabel";
			this.versionNumberLabel.Size = new System.Drawing.Size(65, 13);
			this.versionNumberLabel.TabIndex = 2;
			this.versionNumberLabel.Text = "X.X.XX.XXX";
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Location = new System.Drawing.Point(330, 196);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 4;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// AboutForm
			// 
			this.AcceptButton = this.closeButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(417, 231);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.githubLinkLabel);
			this.Controls.Add(this.versionNumberLabel);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.githubLabel);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.titleLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About SRCDS RCON";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.Label githubLabel;
		private System.Windows.Forms.LinkLabel githubLinkLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label versionNumberLabel;
		private System.Windows.Forms.Button closeButton;
	}
}