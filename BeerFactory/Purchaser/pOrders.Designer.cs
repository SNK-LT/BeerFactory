namespace BeerFactory
{
	partial class pOrders
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
			this.dgwOrders = new System.Windows.Forms.DataGridView();
			this.bReturn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwOrders
			// 
			this.dgwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwOrders.Location = new System.Drawing.Point(12, 12);
			this.dgwOrders.Name = "dgwOrders";
			this.dgwOrders.Size = new System.Drawing.Size(618, 221);
			this.dgwOrders.TabIndex = 0;
			this.dgwOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClicked);
			// 
			// bReturn
			// 
			this.bReturn.Location = new System.Drawing.Point(640, 12);
			this.bReturn.Name = "bReturn";
			this.bReturn.Size = new System.Drawing.Size(75, 23);
			this.bReturn.TabIndex = 1;
			this.bReturn.Text = "Назад";
			this.bReturn.UseVisualStyleBackColor = true;
			this.bReturn.Click += new System.EventHandler(this.bReturn_Clicked);
			// 
			// pOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 242);
			this.Controls.Add(this.bReturn);
			this.Controls.Add(this.dgwOrders);
			this.Name = "pOrders";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fPOrders_Closing);
			this.Load += new System.EventHandler(this.pOrders_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwOrders;
		private System.Windows.Forms.Button bReturn;
	}
}