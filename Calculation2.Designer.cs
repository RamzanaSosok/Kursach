namespace Kursach
{
	partial class Calculation2
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
			this.PreviousDate_combobox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CurrentDate_combobox = new System.Windows.Forms.ComboBox();
			this.Month_textbox = new System.Windows.Forms.TextBox();
			this.View_button = new System.Windows.Forms.Button();
			this.Back_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PreviousDate_combobox
			// 
			this.PreviousDate_combobox.FormattingEnabled = true;
			this.PreviousDate_combobox.Location = new System.Drawing.Point(188, 12);
			this.PreviousDate_combobox.Name = "PreviousDate_combobox";
			this.PreviousDate_combobox.Size = new System.Drawing.Size(121, 21);
			this.PreviousDate_combobox.TabIndex = 0;
			this.PreviousDate_combobox.SelectedIndexChanged += new System.EventHandler(this.PreviousDate_combobox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Предыдущая дата";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Текущая дата";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Расчётный месяц";
			// 
			// CurrentDate_combobox
			// 
			this.CurrentDate_combobox.FormattingEnabled = true;
			this.CurrentDate_combobox.Location = new System.Drawing.Point(188, 36);
			this.CurrentDate_combobox.Name = "CurrentDate_combobox";
			this.CurrentDate_combobox.Size = new System.Drawing.Size(121, 21);
			this.CurrentDate_combobox.TabIndex = 4;
			this.CurrentDate_combobox.SelectedIndexChanged += new System.EventHandler(this.CurrentDate_combobox_SelectedIndexChanged);
			// 
			// Month_textbox
			// 
			this.Month_textbox.Location = new System.Drawing.Point(188, 60);
			this.Month_textbox.Name = "Month_textbox";
			this.Month_textbox.Size = new System.Drawing.Size(121, 20);
			this.Month_textbox.TabIndex = 5;
			this.Month_textbox.TextChanged += new System.EventHandler(this.Month_textbox_TextChanged);
			// 
			// View_button
			// 
			this.View_button.Location = new System.Drawing.Point(12, 84);
			this.View_button.Name = "View_button";
			this.View_button.Size = new System.Drawing.Size(126, 23);
			this.View_button.TabIndex = 6;
			this.View_button.Text = "Просмотр";
			this.View_button.UseVisualStyleBackColor = true;
			this.View_button.Click += new System.EventHandler(this.View_button_Click);
			// 
			// Back_button
			// 
			this.Back_button.Location = new System.Drawing.Point(188, 84);
			this.Back_button.Name = "Back_button";
			this.Back_button.Size = new System.Drawing.Size(121, 23);
			this.Back_button.TabIndex = 7;
			this.Back_button.Text = "Назад в меню";
			this.Back_button.UseVisualStyleBackColor = true;
			this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
			// 
			// Calculation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 114);
			this.Controls.Add(this.Back_button);
			this.Controls.Add(this.View_button);
			this.Controls.Add(this.Month_textbox);
			this.Controls.Add(this.CurrentDate_combobox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PreviousDate_combobox);
			this.Name = "Calculation";
			this.Text = "Calculation";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox PreviousDate_combobox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox CurrentDate_combobox;
		private System.Windows.Forms.TextBox Month_textbox;
		private System.Windows.Forms.Button View_button;
		private System.Windows.Forms.Button Back_button;
	}
}