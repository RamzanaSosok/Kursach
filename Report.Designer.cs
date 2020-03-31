namespace Kursach
{
	partial class Report
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
			this.Month_textbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Year_textbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PerMeter_textbox = new System.Windows.Forms.TextBox();
			this.Report_view = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.FlatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AreaFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Indications_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Indications_PD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nachisl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CommonLight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Lgota = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Back_button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Report_view)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(696, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Месяц:";
			// 
			// Month_textbox
			// 
			this.Month_textbox.Location = new System.Drawing.Point(749, 9);
			this.Month_textbox.Name = "Month_textbox";
			this.Month_textbox.ReadOnly = true;
			this.Month_textbox.Size = new System.Drawing.Size(100, 20);
			this.Month_textbox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(855, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Год:";
			// 
			// Year_textbox
			// 
			this.Year_textbox.Location = new System.Drawing.Point(897, 9);
			this.Year_textbox.Name = "Year_textbox";
			this.Year_textbox.ReadOnly = true;
			this.Year_textbox.Size = new System.Drawing.Size(89, 20);
			this.Year_textbox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(773, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "ос на кв. м.";
			// 
			// PerMeter_textbox
			// 
			this.PerMeter_textbox.Location = new System.Drawing.Point(856, 32);
			this.PerMeter_textbox.Name = "PerMeter_textbox";
			this.PerMeter_textbox.ReadOnly = true;
			this.PerMeter_textbox.Size = new System.Drawing.Size(50, 20);
			this.PerMeter_textbox.TabIndex = 5;
			// 
			// Report_view
			// 
			this.Report_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Report_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlatNumber,
            this.FIO,
            this.AreaFlat,
            this.Indications_CD,
            this.Indications_PD,
            this.Diff,
            this.Nachisl,
            this.CommonLight,
            this.Lgota,
            this.Summ});
			this.Report_view.Location = new System.Drawing.Point(12, 96);
			this.Report_view.Name = "Report_view";
			this.Report_view.Size = new System.Drawing.Size(975, 425);
			this.Report_view.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(418, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "ТСЖ \"Пески\"";
			// 
			// FlatNumber
			// 
			this.FlatNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FlatNumber.HeaderText = "№кв.";
			this.FlatNumber.Name = "FlatNumber";
			// 
			// FIO
			// 
			this.FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FIO.HeaderText = "ФИО";
			this.FIO.Name = "FIO";
			// 
			// AreaFlat
			// 
			this.AreaFlat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.AreaFlat.HeaderText = "S(м.кв.)";
			this.AreaFlat.Name = "AreaFlat";
			// 
			// Indications_CD
			// 
			this.Indications_CD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Indications_CD.HeaderText = "показания на";
			this.Indications_CD.Name = "Indications_CD";
			// 
			// Indications_PD
			// 
			this.Indications_PD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Indications_PD.HeaderText = "показания на";
			this.Indications_PD.Name = "Indications_PD";
			// 
			// Diff
			// 
			this.Diff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Diff.HeaderText = "разность";
			this.Diff.Name = "Diff";
			// 
			// Nachisl
			// 
			this.Nachisl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nachisl.HeaderText = "Начислено";
			this.Nachisl.Name = "Nachisl";
			// 
			// CommonLight
			// 
			this.CommonLight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.CommonLight.HeaderText = "Общ. свет";
			this.CommonLight.Name = "CommonLight";
			// 
			// Lgota
			// 
			this.Lgota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Lgota.HeaderText = "Льгота";
			this.Lgota.Name = "Lgota";
			// 
			// Summ
			// 
			this.Summ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Summ.HeaderText = "Итого";
			this.Summ.Name = "Summ";
			// 
			// Back_button
			// 
			this.Back_button.Location = new System.Drawing.Point(13, 8);
			this.Back_button.Name = "Back_button";
			this.Back_button.Size = new System.Drawing.Size(97, 33);
			this.Back_button.TabIndex = 8;
			this.Back_button.Text = "Назад";
			this.Back_button.UseVisualStyleBackColor = true;
			this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
			// 
			// Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(999, 533);
			this.Controls.Add(this.Back_button);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Report_view);
			this.Controls.Add(this.PerMeter_textbox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Year_textbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Month_textbox);
			this.Controls.Add(this.label1);
			this.Name = "Report";
			this.Text = "Report";
			((System.ComponentModel.ISupportInitialize)(this.Report_view)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Month_textbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Year_textbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PerMeter_textbox;
		private System.Windows.Forms.DataGridView Report_view;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn FlatNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn AreaFlat;
		private System.Windows.Forms.DataGridViewTextBoxColumn Indications_CD;
		private System.Windows.Forms.DataGridViewTextBoxColumn Indications_PD;
		private System.Windows.Forms.DataGridViewTextBoxColumn Diff;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nachisl;
		private System.Windows.Forms.DataGridViewTextBoxColumn CommonLight;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lgota;
		private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
		private System.Windows.Forms.Button Back_button;
	}
}