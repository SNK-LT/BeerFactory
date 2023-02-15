namespace BeerFactory
{
	partial class EmpForm
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
			this.bProfile = new System.Windows.Forms.Button();
			this.bMyStatus = new System.Windows.Forms.Button();
			this.bExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bProfile
			// 
			this.bProfile.Location = new System.Drawing.Point(66, 29);
			this.bProfile.Name = "bProfile";
			this.bProfile.Size = new System.Drawing.Size(108, 49);
			this.bProfile.TabIndex = 0;
			this.bProfile.Text = "Профиль";
			this.bProfile.UseVisualStyleBackColor = true;
			this.bProfile.Click += new System.EventHandler(this.bProfile_Click);
			// 
			// bMyStatus
			// 
			this.bMyStatus.Location = new System.Drawing.Point(66, 92);
			this.bMyStatus.Name = "bMyStatus";
			this.bMyStatus.Size = new System.Drawing.Size(108, 49);
			this.bMyStatus.TabIndex = 1;
			this.bMyStatus.Text = "Мой статус";
			this.bMyStatus.UseVisualStyleBackColor = true;
			this.bMyStatus.Click += new System.EventHandler(this.bMyStatus_Click);
			// 
			// bExit
			// 
			this.bExit.Location = new System.Drawing.Point(82, 174);
			this.bExit.Name = "bExit";
			this.bExit.Size = new System.Drawing.Size(75, 26);
			this.bExit.TabIndex = 2;
			this.bExit.Text = "ВЫХОД";
			this.bExit.UseVisualStyleBackColor = true;
			this.bExit.Click += new System.EventHandler(this.bExit_Click);
			// 
			// EmpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(243, 212);
			this.Controls.Add(this.bExit);
			this.Controls.Add(this.bMyStatus);
			this.Controls.Add(this.bProfile);
			this.Name = "EmpForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fEmp_Closing);
			this.Load += new System.EventHandler(this.EmpForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bProfile;
		private System.Windows.Forms.Button bMyStatus;
		private System.Windows.Forms.Button bExit;
	}
}