namespace Kursach
{
	partial class AddIndication
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
			this.FlatId_textbox = new System.Windows.Forms.TextBox();
			this.Indications_textbox = new System.Windows.Forms.TextBox();
			this.Date_textbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.AddIndication_button = new System.Windows.Forms.Button();
			this.Cancel_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FlatId_textbox
			// 
			this.FlatId_textbox.Location = new System.Drawing.Point(6, 34);
			this.FlatId_textbox.Name = "FlatId_textbox";
			this.FlatId_textbox.Size = new System.Drawing.Size(37, 20);
			this.FlatId_textbox.TabIndex = 0;
			// 
			// Indications_textbox
			// 
			this.Indications_textbox.Location = new System.Drawing.Point(52, 34);
			this.Indications_textbox.Name = "Indications_textbox";
			this.Indications_textbox.Size = new System.Drawing.Size(100, 20);
			this.Indications_textbox.TabIndex = 1;
			// 
			// Date_textbox
			// 
			this.Date_textbox.Location = new System.Drawing.Point(158, 34);
			this.Date_textbox.Name = "Date_textbox";
			this.Date_textbox.Size = new System.Drawing.Size(145, 20);
			this.Date_textbox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "№ Кв";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Показания";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(155, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Дата";
			// 
			// AddIndication_button
			// 
			this.AddIndication_button.Location = new System.Drawing.Point(6, 61);
			this.AddIndication_button.Name = "AddIndication_button";
			this.AddIndication_button.Size = new System.Drawing.Size(146, 23);
			this.AddIndication_button.TabIndex = 6;
			this.AddIndication_button.Text = "Подтвердить и добавить";
			this.AddIndication_button.UseVisualStyleBackColor = true;
			this.AddIndication_button.Click += new System.EventHandler(this.AddIndication_button_Click);
			// 
			// Cancel_button
			// 
			this.Cancel_button.Location = new System.Drawing.Point(158, 61);
			this.Cancel_button.Name = "Cancel_button";
			this.Cancel_button.Size = new System.Drawing.Size(145, 23);
			this.Cancel_button.TabIndex = 7;
			this.Cancel_button.Text = "Отмена";
			this.Cancel_button.UseVisualStyleBackColor = true;
			this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
			// 
			// AddIndication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 97);
			this.Controls.Add(this.Cancel_button);
			this.Controls.Add(this.AddIndication_button);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Date_textbox);
			this.Controls.Add(this.Indications_textbox);
			this.Controls.Add(this.FlatId_textbox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddIndication";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddIndication";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox FlatId_textbox;
		private System.Windows.Forms.TextBox Indications_textbox;
		private System.Windows.Forms.TextBox Date_textbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button AddIndication_button;
		private System.Windows.Forms.Button Cancel_button;
	}
}