namespace BeerFactory
{
	partial class editOrderStatus
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.bSave = new System.Windows.Forms.Button();
			this.bCancel1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Изменить статус заказа";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(232, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(166, 28);
			this.comboBox1.TabIndex = 1;
			// 
			// bSave
			// 
			this.bSave.Location = new System.Drawing.Point(323, 53);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(75, 23);
			this.bSave.TabIndex = 3;
			this.bSave.Text = "Сохранить";
			this.bSave.UseVisualStyleBackColor = true;
			this.bSave.Click += new System.EventHandler(this.bSave_Click);
			// 
			// bCancel1
			// 
			this.bCancel1.Location = new System.Drawing.Point(242, 53);
			this.bCancel1.Name = "bCancel1";
			this.bCancel1.Size = new System.Drawing.Size(75, 23);
			this.bCancel1.TabIndex = 4;
			this.bCancel1.Text = "Отмена";
			this.bCancel1.UseVisualStyleBackColor = true;
			this.bCancel1.Click += new System.EventHandler(this.bCancel_Click_1);
			// 
			// editOrderStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 88);
			this.Controls.Add(this.bCancel1);
			this.Controls.Add(this.bSave);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Name = "editOrderStatus";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.editOrderStatus_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button bSave;
		private System.Windows.Forms.Button bCancel1;
	}
}