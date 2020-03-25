namespace Kursach
{
	partial class MainMenu
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.Indications_button = new System.Windows.Forms.Button();
			this.CalculationElectricity_button = new System.Windows.Forms.Button();
			this.Information_button = new System.Windows.Forms.Button();
			this.Report_button = new System.Windows.Forms.Button();
			this.Receipts_button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Indications_button
			// 
			this.Indications_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Indications_button.Location = new System.Drawing.Point(3, 3);
			this.Indications_button.Name = "Indications_button";
			this.Indications_button.Size = new System.Drawing.Size(41, 44);
			this.Indications_button.TabIndex = 0;
			this.Indications_button.UseVisualStyleBackColor = true;
			this.Indications_button.Click += new System.EventHandler(this.Indications_button_Click);
			// 
			// CalculationElectricity_button
			// 
			this.CalculationElectricity_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CalculationElectricity_button.Location = new System.Drawing.Point(3, 53);
			this.CalculationElectricity_button.Name = "CalculationElectricity_button";
			this.CalculationElectricity_button.Size = new System.Drawing.Size(41, 44);
			this.CalculationElectricity_button.TabIndex = 1;
			this.CalculationElectricity_button.UseVisualStyleBackColor = true;
			this.CalculationElectricity_button.Click += new System.EventHandler(this.Calculation_button_Click);
			// 
			// Information_button
			// 
			this.Information_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Information_button.Location = new System.Drawing.Point(3, 203);
			this.Information_button.Name = "Information_button";
			this.Information_button.Size = new System.Drawing.Size(41, 46);
			this.Information_button.TabIndex = 2;
			this.Information_button.UseVisualStyleBackColor = true;
			this.Information_button.Click += new System.EventHandler(this.Information_button_Click);
			// 
			// Report_button
			// 
			this.Report_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Report_button.Location = new System.Drawing.Point(3, 103);
			this.Report_button.Name = "Report_button";
			this.Report_button.Size = new System.Drawing.Size(41, 44);
			this.Report_button.TabIndex = 3;
			this.Report_button.UseVisualStyleBackColor = true;
			this.Report_button.Click += new System.EventHandler(this.Report_button_Click);
			// 
			// Receipts_button
			// 
			this.Receipts_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Receipts_button.Location = new System.Drawing.Point(3, 153);
			this.Receipts_button.Name = "Receipts_button";
			this.Receipts_button.Size = new System.Drawing.Size(41, 44);
			this.Receipts_button.TabIndex = 4;
			this.Receipts_button.UseVisualStyleBackColor = true;
			this.Receipts_button.Click += new System.EventHandler(this.Receipts_button_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Ввести показания";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Расчёт электроэнергии";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Распечатать отчёт (список)";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(50, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Распечатать квитанции";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(50, 219);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(160, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Дополнительная информация";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.Information_button, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.Report_button, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.CalculationElectricity_button, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.Indications_button, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.Receipts_button, 0, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 252);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 276);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Главное меню";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Indications_button;
		private System.Windows.Forms.Button CalculationElectricity_button;
		private System.Windows.Forms.Button Information_button;
		private System.Windows.Forms.Button Report_button;
		private System.Windows.Forms.Button Receipts_button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

