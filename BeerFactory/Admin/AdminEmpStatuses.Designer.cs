namespace BeerFactory
{
	partial class AdminEmpStatuses
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
			this.dgwEmpStatuses = new System.Windows.Forms.DataGridView();
			this.bBack = new System.Windows.Forms.Button();
			this.lNoStatuses = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgwEmpStatuses)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwEmpStatuses
			// 
			this.dgwEmpStatuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwEmpStatuses.Location = new System.Drawing.Point(12, 37);
			this.dgwEmpStatuses.Name = "dgwEmpStatuses";
			this.dgwEmpStatuses.Size = new System.Drawing.Size(732, 162);
			this.dgwEmpStatuses.TabIndex = 0;
			this.dgwEmpStatuses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEmpStatuses_CellClick);
			// 
			// bBack
			// 
			this.bBack.Location = new System.Drawing.Point(12, 8);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(63, 23);
			this.bBack.TabIndex = 1;
			this.bBack.Text = "Назад";
			this.bBack.UseVisualStyleBackColor = true;
			this.bBack.Click += new System.EventHandler(this.bBack_Click);
			// 
			// lNoStatuses
			// 
			this.lNoStatuses.AutoSize = true;
			this.lNoStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lNoStatuses.Location = new System.Drawing.Point(12, 37);
			this.lNoStatuses.Name = "lNoStatuses";
			this.lNoStatuses.Size = new System.Drawing.Size(282, 47);
			this.lNoStatuses.TabIndex = 2;
			this.lNoStatuses.Text = "Нет запросов";
			// 
			// AdminEmpStatuses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 450);
			this.Controls.Add(this.lNoStatuses);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.dgwEmpStatuses);
			this.Name = "AdminEmpStatuses";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminEmpStatuses_FormClosing);
			this.Load += new System.EventHandler(this.AdminEmpStatuses_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwEmpStatuses)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwEmpStatuses;
		private System.Windows.Forms.Button bBack;
		private System.Windows.Forms.Label lNoStatuses;
	}
}