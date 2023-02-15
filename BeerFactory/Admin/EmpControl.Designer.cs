namespace BeerFactory.Admin
{
	partial class EmpControl
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
			this.dgwEMPS = new System.Windows.Forms.DataGridView();
			this.bBack = new System.Windows.Forms.Button();
			this.bNewAcc = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwEMPS)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwEMPS
			// 
			this.dgwEMPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwEMPS.Location = new System.Drawing.Point(12, 45);
			this.dgwEMPS.Name = "dgwEMPS";
			this.dgwEMPS.Size = new System.Drawing.Size(801, 233);
			this.dgwEMPS.TabIndex = 0;
			this.dgwEMPS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEMPS_CellContentClick);
			// 
			// bBack
			// 
			this.bBack.Location = new System.Drawing.Point(12, 12);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(75, 23);
			this.bBack.TabIndex = 1;
			this.bBack.Text = "Назад";
			this.bBack.UseVisualStyleBackColor = true;
			this.bBack.Click += new System.EventHandler(this.bBack_Click);
			// 
			// bNewAcc
			// 
			this.bNewAcc.Location = new System.Drawing.Point(299, 284);
			this.bNewAcc.Name = "bNewAcc";
			this.bNewAcc.Size = new System.Drawing.Size(221, 31);
			this.bNewAcc.TabIndex = 2;
			this.bNewAcc.Text = "Создать новый акаунт сотрудника";
			this.bNewAcc.UseVisualStyleBackColor = true;
			this.bNewAcc.Click += new System.EventHandler(this.bNewAcc_Click);
			// 
			// EmpControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(825, 323);
			this.Controls.Add(this.bNewAcc);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.dgwEMPS);
			this.Name = "EmpControl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpControl_FormClosing);
			this.Load += new System.EventHandler(this.EmpControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwEMPS)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwEMPS;
		private System.Windows.Forms.Button bBack;
		private System.Windows.Forms.Button bNewAcc;
	}
}