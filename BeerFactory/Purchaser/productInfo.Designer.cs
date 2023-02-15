namespace BeerFactory
{
	partial class productInfo
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
			this.dgwInfo = new System.Windows.Forms.DataGridView();
			this.bBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwInfo)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwInfo
			// 
			this.dgwInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwInfo.Location = new System.Drawing.Point(12, 12);
			this.dgwInfo.Name = "dgwInfo";
			this.dgwInfo.Size = new System.Drawing.Size(542, 71);
			this.dgwInfo.TabIndex = 0;
			// 
			// bBack
			// 
			this.bBack.Location = new System.Drawing.Point(245, 89);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(75, 23);
			this.bBack.TabIndex = 1;
			this.bBack.Text = "OK";
			this.bBack.UseVisualStyleBackColor = true;
			this.bBack.Click += new System.EventHandler(this.bBack_Click);
			// 
			// productInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 123);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.dgwInfo);
			this.Name = "productInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "productInfo";
			this.Load += new System.EventHandler(this.productInfo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwInfo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwInfo;
		private System.Windows.Forms.Button bBack;
	}
}