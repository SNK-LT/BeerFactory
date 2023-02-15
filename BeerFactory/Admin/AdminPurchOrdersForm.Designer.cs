namespace BeerFactory
{
	partial class AdminPurchOrdersForm
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
			this.dgwPurchOrders = new System.Windows.Forms.DataGridView();
			this.bBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwPurchOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwPurchOrders
			// 
			this.dgwPurchOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwPurchOrders.Location = new System.Drawing.Point(12, 41);
			this.dgwPurchOrders.Name = "dgwPurchOrders";
			this.dgwPurchOrders.Size = new System.Drawing.Size(910, 211);
			this.dgwPurchOrders.TabIndex = 0;
			this.dgwPurchOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPurchOrders_CellClick);
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
			// AdminPurchOrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 264);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.dgwPurchOrders);
			this.Name = "AdminPurchOrdersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPurchOrdersForm_FormClosing);
			this.Load += new System.EventHandler(this.AdminPurchOrdersForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwPurchOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwPurchOrders;
		private System.Windows.Forms.Button bBack;
	}
}