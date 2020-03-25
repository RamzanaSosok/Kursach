namespace Kursach
{
	partial class AddIndicationOs
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
			this.Cancel_button = new System.Windows.Forms.Button();
			this.AddIndicationOs_button = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Date_textbox = new System.Windows.Forms.TextBox();
			this.Indications_textbox = new System.Windows.Forms.TextBox();
			this.Scht_combobox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// Cancel_button
			// 
			this.Cancel_button.Location = new System.Drawing.Point(161, 55);
			this.Cancel_button.Name = "Cancel_button";
			this.Cancel_button.Size = new System.Drawing.Size(145, 23);
			this.Cancel_button.TabIndex = 15;
			this.Cancel_button.Text = "Отмена";
			this.Cancel_button.UseVisualStyleBackColor = true;
			this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
			// 
			// AddIndicationOs_button
			// 
			this.AddIndicationOs_button.Location = new System.Drawing.Point(9, 55);
			this.AddIndicationOs_button.Name = "AddIndicationOs_button";
			this.AddIndicationOs_button.Size = new System.Drawing.Size(146, 23);
			this.AddIndicationOs_button.TabIndex = 14;
			this.AddIndicationOs_button.Text = "Подтвердить и добавить";
			this.AddIndicationOs_button.UseVisualStyleBackColor = true;
			this.AddIndicationOs_button.Click += new System.EventHandler(this.AddIndicationOs_button_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(158, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Дата";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Показания";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Счётчик";
			// 
			// Date_textbox
			// 
			this.Date_textbox.Location = new System.Drawing.Point(161, 28);
			this.Date_textbox.Name = "Date_textbox";
			this.Date_textbox.Size = new System.Drawing.Size(145, 20);
			this.Date_textbox.TabIndex = 10;
			// 
			// Indications_textbox
			// 
			this.Indications_textbox.Location = new System.Drawing.Point(68, 28);
			this.Indications_textbox.Name = "Indications_textbox";
			this.Indications_textbox.Size = new System.Drawing.Size(87, 20);
			this.Indications_textbox.TabIndex = 9;
			// 
			// Scht_combobox
			// 
			this.Scht_combobox.FormattingEnabled = true;
			this.Scht_combobox.Items.AddRange(new object[] {
            "дом",
            "лифт",
            "кв"});
			this.Scht_combobox.Location = new System.Drawing.Point(9, 28);
			this.Scht_combobox.Name = "Scht_combobox";
			this.Scht_combobox.Size = new System.Drawing.Size(53, 21);
			this.Scht_combobox.TabIndex = 16;
			// 
			// AddIndicationOs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 94);
			this.Controls.Add(this.Scht_combobox);
			this.Controls.Add(this.Cancel_button);
			this.Controls.Add(this.AddIndicationOs_button);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Date_textbox);
			this.Controls.Add(this.Indications_textbox);
			this.Name = "AddIndicationOs";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddIndicationOs";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Cancel_button;
		private System.Windows.Forms.Button AddIndicationOs_button;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Date_textbox;
		private System.Windows.Forms.TextBox Indications_textbox;
		private System.Windows.Forms.ComboBox Scht_combobox;
	}
}