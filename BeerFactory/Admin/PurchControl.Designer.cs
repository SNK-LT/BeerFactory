namespace BeerFactory.Admin
{
	partial class PurchControl
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
			this.dgwPurchControl = new System.Windows.Forms.DataGridView();
			this.bBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwPurchControl)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwPurchControl
			// 
			this.dgwPurchControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwPurchControl.Location = new System.Drawing.Point(12, 12);
			this.dgwPurchControl.Name = "dgwPurchControl";
			this.dgwPurchControl.Size = new System.Drawing.Size(237, 128);
			this.dgwPurchControl.TabIndex = 0;
			this.dgwPurchControl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPurchControl_CellClick);
			this.dgwPurchControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPurchControl_CellContentClick);
			// 
			// bBack
			// 
			this.bBack.Location = new System.Drawing.Point(98, 150);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(64, 23);
			this.bBack.TabIndex = 1;
			this.bBack.Text = "Назад";
			this.bBack.UseVisualStyleBackColor = true;
			this.bBack.Click += new System.EventHandler(this.bBack_Click);
			// 
			// PurchControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(261, 185);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.dgwPurchControl);
			this.Name = "PurchControl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PurchControl_FormClosing);
			this.Load += new System.EventHandler(this.PurchControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwPurchControl)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwPurchControl;
		private System.Windows.Forms.Button bBack;
	}
}