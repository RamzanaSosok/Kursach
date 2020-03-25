namespace Kursach
{
	partial class Indications
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
			this.components = new System.ComponentModel.Container();
			this.pokazaniyaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.Pokazanyia = new Kursach.Pokazanyia();
			this.pokazaniyaTableAdapter = new Kursach.kursachDataSetTableAdapters.pokazaniyaTableAdapter();
			this.pokazanyiaOs = new Kursach.PokazanyiaOs();
			this.pokazanyiaosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.pokazanyia_osTableAdapter = new Kursach.PokazanyiaOsTableAdapters.pokazanyia_osTableAdapter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.MainMenu_button = new System.Windows.Forms.Button();
			this.MetersIndications_tab = new System.Windows.Forms.TabControl();
			this.FlatMetersIndiciations_tab = new System.Windows.Forms.TabPage();
			this.Indications_datagridview = new System.Windows.Forms.DataGridView();
			this.flatidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pokazanyiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pokazanyiadateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GoToFlat_button = new System.Windows.Forms.Button();
			this.AddFlatIndicatons_button = new System.Windows.Forms.Button();
			this.IndicationsOs_tab = new System.Windows.Forms.TabPage();
			this.IndicationsOs_datagridview = new System.Windows.Forms.DataGridView();
			this.schtidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pokazanyiaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GoToOs_button = new System.Windows.Forms.Button();
			this.AddOsIndications_button = new System.Windows.Forms.Button();
			this.AddIndicationTarif_button = new System.Windows.Forms.Button();
			this.Lose_textbox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TarifOs_textbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Tarif_textbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Date_textbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pokazanyiaosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.pokazaniyaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.pokazanyiaosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.pokazanyiaosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pokazaniyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pokazaniyaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pokazaniyaBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Pokazanyia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazanyiaOs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazanyiaosBindingSource3)).BeginInit();
			this.panel1.SuspendLayout();
			this.MetersIndications_tab.SuspendLayout();
			this.FlatMetersIndiciations_tab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Indications_datagridview)).BeginInit();
			this.IndicationsOs_tab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IndicationsOs_datagridview)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pokazanyiaosBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazaniyaBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazanyiaosBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazanyiaosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazaniyaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazaniyaBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// pokazaniyaBindingSource3
			// 
			this.pokazaniyaBindingSource3.DataMember = "pokazaniya";
			this.pokazaniyaBindingSource3.DataSource = this.Pokazanyia;
			// 
			// Pokazanyia
			// 
			this.Pokazanyia.DataSetName = "Pokazanyia";
			this.Pokazanyia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pokazaniyaTableAdapter
			// 
			this.pokazaniyaTableAdapter.ClearBeforeFill = true;
			// 
			// pokazanyiaOs
			// 
			this.pokazanyiaOs.DataSetName = "PokazanyiaOs";
			this.pokazanyiaOs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pokazanyiaosBindingSource3
			// 
			this.pokazanyiaosBindingSource3.DataMember = "pokazanyia_os";
			this.pokazanyiaosBindingSource3.DataSource = this.pokazanyiaOs;
			// 
			// pokazanyia_osTableAdapter
			// 
			this.pokazanyia_osTableAdapter.ClearBeforeFill = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.MainMenu_button);
			this.panel1.Controls.Add(this.MetersIndications_tab);
			this.panel1.Controls.Add(this.AddIndicationTarif_button);
			this.panel1.Location = new System.Drawing.Point(18, 107);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(290, 421);
			this.panel1.TabIndex = 11;
			// 
			// MainMenu_button
			// 
			this.MainMenu_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.MainMenu_button.Location = new System.Drawing.Point(176, 13);
			this.MainMenu_button.Name = "MainMenu_button";
			this.MainMenu_button.Size = new System.Drawing.Size(111, 23);
			this.MainMenu_button.TabIndex = 11;
			this.MainMenu_button.Text = "Вернуться в меню";
			this.MainMenu_button.UseVisualStyleBackColor = true;
			this.MainMenu_button.Click += new System.EventHandler(this.MainMenu_button_Click);
			// 
			// MetersIndications_tab
			// 
			this.MetersIndications_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MetersIndications_tab.Controls.Add(this.FlatMetersIndiciations_tab);
			this.MetersIndications_tab.Controls.Add(this.IndicationsOs_tab);
			this.MetersIndications_tab.Location = new System.Drawing.Point(3, 42);
			this.MetersIndications_tab.Name = "MetersIndications_tab";
			this.MetersIndications_tab.SelectedIndex = 0;
			this.MetersIndications_tab.Size = new System.Drawing.Size(281, 376);
			this.MetersIndications_tab.TabIndex = 0;
			// 
			// FlatMetersIndiciations_tab
			// 
			this.FlatMetersIndiciations_tab.Controls.Add(this.Indications_datagridview);
			this.FlatMetersIndiciations_tab.Controls.Add(this.GoToFlat_button);
			this.FlatMetersIndiciations_tab.Controls.Add(this.AddFlatIndicatons_button);
			this.FlatMetersIndiciations_tab.Location = new System.Drawing.Point(4, 22);
			this.FlatMetersIndiciations_tab.Name = "FlatMetersIndiciations_tab";
			this.FlatMetersIndiciations_tab.Padding = new System.Windows.Forms.Padding(3);
			this.FlatMetersIndiciations_tab.Size = new System.Drawing.Size(273, 350);
			this.FlatMetersIndiciations_tab.TabIndex = 0;
			this.FlatMetersIndiciations_tab.Text = "Показания квартирных счётчиков";
			this.FlatMetersIndiciations_tab.UseVisualStyleBackColor = true;
			// 
			// Indications_datagridview
			// 
			this.Indications_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Indications_datagridview.AutoGenerateColumns = false;
			this.Indications_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Indications_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flatidDataGridViewTextBoxColumn,
            this.pokazanyiaDataGridViewTextBoxColumn,
            this.pokazanyiadateDataGridViewTextBoxColumn});
			this.Indications_datagridview.DataSource = this.pokazaniyaBindingSource3;
			this.Indications_datagridview.Location = new System.Drawing.Point(7, 58);
			this.Indications_datagridview.Name = "Indications_datagridview";
			this.Indications_datagridview.Size = new System.Drawing.Size(266, 289);
			this.Indications_datagridview.TabIndex = 3;
			this.Indications_datagridview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Indications_datagridview_CellValueChanged);
			// 
			// flatidDataGridViewTextBoxColumn
			// 
			this.flatidDataGridViewTextBoxColumn.DataPropertyName = "flat_id";
			this.flatidDataGridViewTextBoxColumn.HeaderText = "Номер квартиры";
			this.flatidDataGridViewTextBoxColumn.Name = "flatidDataGridViewTextBoxColumn";
			this.flatidDataGridViewTextBoxColumn.Width = 60;
			// 
			// pokazanyiaDataGridViewTextBoxColumn
			// 
			this.pokazanyiaDataGridViewTextBoxColumn.DataPropertyName = "pokazanyia";
			this.pokazanyiaDataGridViewTextBoxColumn.HeaderText = "Показания";
			this.pokazanyiaDataGridViewTextBoxColumn.Name = "pokazanyiaDataGridViewTextBoxColumn";
			this.pokazanyiaDataGridViewTextBoxColumn.Width = 70;
			// 
			// pokazanyiadateDataGridViewTextBoxColumn
			// 
			this.pokazanyiadateDataGridViewTextBoxColumn.DataPropertyName = "pokazanyia_date";
			this.pokazanyiadateDataGridViewTextBoxColumn.HeaderText = "Дата";
			this.pokazanyiadateDataGridViewTextBoxColumn.Name = "pokazanyiadateDataGridViewTextBoxColumn";
			this.pokazanyiadateDataGridViewTextBoxColumn.Width = 90;
			// 
			// GoToFlat_button
			// 
			this.GoToFlat_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GoToFlat_button.Location = new System.Drawing.Point(179, 6);
			this.GoToFlat_button.Name = "GoToFlat_button";
			this.GoToFlat_button.Size = new System.Drawing.Size(88, 45);
			this.GoToFlat_button.TabIndex = 2;
			this.GoToFlat_button.Text = "Перейти";
			this.GoToFlat_button.UseVisualStyleBackColor = true;
			// 
			// AddFlatIndicatons_button
			// 
			this.AddFlatIndicatons_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddFlatIndicatons_button.Location = new System.Drawing.Point(6, 6);
			this.AddFlatIndicatons_button.Name = "AddFlatIndicatons_button";
			this.AddFlatIndicatons_button.Size = new System.Drawing.Size(88, 45);
			this.AddFlatIndicatons_button.TabIndex = 1;
			this.AddFlatIndicatons_button.Text = "Добавить показания";
			this.AddFlatIndicatons_button.UseVisualStyleBackColor = true;
			this.AddFlatIndicatons_button.Click += new System.EventHandler(this.AddIndicatons_button_Click);
			// 
			// IndicationsOs_tab
			// 
			this.IndicationsOs_tab.Controls.Add(this.IndicationsOs_datagridview);
			this.IndicationsOs_tab.Controls.Add(this.GoToOs_button);
			this.IndicationsOs_tab.Controls.Add(this.AddOsIndications_button);
			this.IndicationsOs_tab.Location = new System.Drawing.Point(4, 22);
			this.IndicationsOs_tab.Name = "IndicationsOs_tab";
			this.IndicationsOs_tab.Padding = new System.Windows.Forms.Padding(3);
			this.IndicationsOs_tab.Size = new System.Drawing.Size(273, 350);
			this.IndicationsOs_tab.TabIndex = 1;
			this.IndicationsOs_tab.Text = "Показания ОС";
			this.IndicationsOs_tab.UseVisualStyleBackColor = true;
			// 
			// IndicationsOs_datagridview
			// 
			this.IndicationsOs_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IndicationsOs_datagridview.AutoGenerateColumns = false;
			this.IndicationsOs_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.IndicationsOs_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schtidDataGridViewTextBoxColumn,
            this.pokazanyiaDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
			this.IndicationsOs_datagridview.DataSource = this.pokazanyiaosBindingSource3;
			this.IndicationsOs_datagridview.Location = new System.Drawing.Point(7, 57);
			this.IndicationsOs_datagridview.Name = "IndicationsOs_datagridview";
			this.IndicationsOs_datagridview.Size = new System.Drawing.Size(263, 286);
			this.IndicationsOs_datagridview.TabIndex = 2;
			this.IndicationsOs_datagridview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.IndicationsOs_datagridview_CellValueChanged);
			// 
			// schtidDataGridViewTextBoxColumn
			// 
			this.schtidDataGridViewTextBoxColumn.DataPropertyName = "scht_id";
			this.schtidDataGridViewTextBoxColumn.HeaderText = "Счётчик";
			this.schtidDataGridViewTextBoxColumn.Name = "schtidDataGridViewTextBoxColumn";
			this.schtidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.schtidDataGridViewTextBoxColumn.Width = 60;
			// 
			// pokazanyiaDataGridViewTextBoxColumn2
			// 
			this.pokazanyiaDataGridViewTextBoxColumn2.DataPropertyName = "pokazanyia";
			this.pokazanyiaDataGridViewTextBoxColumn2.HeaderText = "Показания";
			this.pokazanyiaDataGridViewTextBoxColumn2.Name = "pokazanyiaDataGridViewTextBoxColumn2";
			this.pokazanyiaDataGridViewTextBoxColumn2.Width = 70;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "date_os";
			this.dataGridViewTextBoxColumn1.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 90;
			// 
			// GoToOs_button
			// 
			this.GoToOs_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GoToOs_button.Location = new System.Drawing.Point(179, 6);
			this.GoToOs_button.Name = "GoToOs_button";
			this.GoToOs_button.Size = new System.Drawing.Size(88, 45);
			this.GoToOs_button.TabIndex = 1;
			this.GoToOs_button.Text = "Перейти";
			this.GoToOs_button.UseVisualStyleBackColor = true;
			// 
			// AddOsIndications_button
			// 
			this.AddOsIndications_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddOsIndications_button.Location = new System.Drawing.Point(6, 6);
			this.AddOsIndications_button.Name = "AddOsIndications_button";
			this.AddOsIndications_button.Size = new System.Drawing.Size(88, 45);
			this.AddOsIndications_button.TabIndex = 0;
			this.AddOsIndications_button.Text = "Добавить показания";
			this.AddOsIndications_button.UseVisualStyleBackColor = true;
			this.AddOsIndications_button.Click += new System.EventHandler(this.AddOsIndications_button_Click);
			// 
			// AddIndicationTarif_button
			// 
			this.AddIndicationTarif_button.Location = new System.Drawing.Point(7, 13);
			this.AddIndicationTarif_button.Name = "AddIndicationTarif_button";
			this.AddIndicationTarif_button.Size = new System.Drawing.Size(163, 23);
			this.AddIndicationTarif_button.TabIndex = 10;
			this.AddIndicationTarif_button.Text = "Добавить запись о тарифе";
			this.AddIndicationTarif_button.UseVisualStyleBackColor = true;
			this.AddIndicationTarif_button.Click += new System.EventHandler(this.AddIndication_button_Click);
			// 
			// Lose_textbox
			// 
			this.Lose_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Lose_textbox.Location = new System.Drawing.Point(149, 81);
			this.Lose_textbox.Name = "Lose_textbox";
			this.Lose_textbox.Size = new System.Drawing.Size(81, 20);
			this.Lose_textbox.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(82, 78);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "%потери";
			// 
			// TarifOs_textbox
			// 
			this.TarifOs_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TarifOs_textbox.Location = new System.Drawing.Point(149, 55);
			this.TarifOs_textbox.Name = "TarifOs_textbox";
			this.TarifOs_textbox.Size = new System.Drawing.Size(81, 20);
			this.TarifOs_textbox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(82, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Тариф ОС:";
			// 
			// Tarif_textbox
			// 
			this.Tarif_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Tarif_textbox.Location = new System.Drawing.Point(149, 29);
			this.Tarif_textbox.Name = "Tarif_textbox";
			this.Tarif_textbox.Size = new System.Drawing.Size(81, 20);
			this.Tarif_textbox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(82, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Тариф:";
			// 
			// Date_textbox
			// 
			this.Date_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Date_textbox.Location = new System.Drawing.Point(85, 3);
			this.Date_textbox.Name = "Date_textbox";
			this.Date_textbox.ReadOnly = true;
			this.Date_textbox.Size = new System.Drawing.Size(223, 20);
			this.Date_textbox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(18, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Дата:";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.Date_textbox);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.Tarif_textbox);
			this.panel2.Controls.Add(this.TarifOs_textbox);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.Lose_textbox);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(334, 533);
			this.panel2.TabIndex = 16;
			// 
			// pokazaniyaBindingSource2
			// 
			this.pokazaniyaBindingSource2.DataMember = "pokazaniya";
			// 
			// pokazanyiaosBindingSource1
			// 
			this.pokazanyiaosBindingSource1.DataMember = "pokazanyia_os";
			// 
			// pokazanyiaosBindingSource
			// 
			this.pokazanyiaosBindingSource.DataMember = "pokazanyia_os";
			// 
			// pokazaniyaBindingSource
			// 
			this.pokazaniyaBindingSource.DataMember = "pokazaniya";
			// 
			// pokazaniyaBindingSource1
			// 
			this.pokazaniyaBindingSource1.DataMember = "pokazaniya";
			// 
			// Indications
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(357, 557);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Indications";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Показания";
			this.Load += new System.EventHandler(this.Indications_Load);
			((System.ComponentModel.ISupportInitialize)(this.pokazaniyaBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Pokazanyia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazanyiaOs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazanyiaosBindingSource3)).EndInit();
			this.panel1.ResumeLayout(false);
			this.MetersIndications_tab.ResumeLayout(false);
			this.FlatMetersIndiciations_tab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Indications_datagridview)).EndInit();
			this.IndicationsOs_tab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.IndicationsOs_datagridview)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pokazanyiaosBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazaniyaBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazanyiaosBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazanyiaosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazaniyaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pokazaniyaBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource pokazanyiaosBindingSource;
		private System.Windows.Forms.BindingSource pokazaniyaBindingSource;
		private System.Windows.Forms.BindingSource pokazaniyaBindingSource1;
		private System.Windows.Forms.BindingSource pokazaniyaBindingSource2;
		private System.Windows.Forms.BindingSource pokazanyiaosBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn pokazanyiaDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateosDataGridViewTextBoxColumn;
		private Pokazanyia Pokazanyia;
		private System.Windows.Forms.BindingSource pokazaniyaBindingSource3;
		private kursachDataSetTableAdapters.pokazaniyaTableAdapter pokazaniyaTableAdapter;
		private System.Windows.Forms.BindingSource pokazanyiaosBindingSource2;
		private PokazanyiaOs pokazanyiaOs;
		private System.Windows.Forms.BindingSource pokazanyiaosBindingSource3;
		private PokazanyiaOsTableAdapters.pokazanyia_osTableAdapter pokazanyia_osTableAdapter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button MainMenu_button;
		private System.Windows.Forms.TabControl MetersIndications_tab;
		private System.Windows.Forms.TabPage FlatMetersIndiciations_tab;
		private System.Windows.Forms.DataGridView Indications_datagridview;
		private System.Windows.Forms.DataGridViewTextBoxColumn flatidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pokazanyiaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pokazanyiadateDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button GoToFlat_button;
		private System.Windows.Forms.Button AddFlatIndicatons_button;
		private System.Windows.Forms.TabPage IndicationsOs_tab;
		private System.Windows.Forms.DataGridView IndicationsOs_datagridview;
		private System.Windows.Forms.DataGridViewTextBoxColumn schtidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pokazanyiaDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.Button GoToOs_button;
		private System.Windows.Forms.Button AddOsIndications_button;
		private System.Windows.Forms.Button AddIndicationTarif_button;
		private System.Windows.Forms.TextBox Lose_textbox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TarifOs_textbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Tarif_textbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Date_textbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
	}
}