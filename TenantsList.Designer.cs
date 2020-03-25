namespace Kursach
{
	partial class TenantsList
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
			this.Back_button = new System.Windows.Forms.Button();
			this.tenantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tenants = new Kursach.Tenants();
			this.tenantsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tenantsTableAdapter = new Kursach.TenantsTableAdapters.tenantsTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tenants)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// Back_button
			// 
			this.Back_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Back_button.Location = new System.Drawing.Point(13, 398);
			this.Back_button.Name = "Back_button";
			this.Back_button.Size = new System.Drawing.Size(843, 40);
			this.Back_button.TabIndex = 0;
			this.Back_button.Text = "Назад в меню";
			this.Back_button.UseVisualStyleBackColor = true;
			this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
			// 
			// tenantsBindingSource
			// 
			this.tenantsBindingSource.DataMember = "tenants";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.dataGridView1.DataSource = this.tenantsBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(13, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(843, 379);
			this.dataGridView1.TabIndex = 1;
			// 
			// tenants
			// 
			this.tenants.DataSetName = "Tenants";
			this.tenants.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tenantsBindingSource1
			// 
			this.tenantsBindingSource1.DataMember = "tenants";
			this.tenantsBindingSource1.DataSource = this.tenants;
			// 
			// tenantsTableAdapter
			// 
			this.tenantsTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "tenant_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Номер жильца";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "flat_number";
			this.dataGridViewTextBoxColumn2.HeaderText = "Кв";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "fio_tenant";
			this.dataGridViewTextBoxColumn3.HeaderText = "ФИО";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "area_flat";
			this.dataGridViewTextBoxColumn4.HeaderText = "Площадь кв";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "residents_num";
			this.dataGridViewTextBoxColumn5.HeaderText = "Кол-во жильцов";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "lgota";
			this.dataGridViewTextBoxColumn6.HeaderText = "Номер льготы";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "lgota_tenant_id";
			this.dataGridViewTextBoxColumn7.HeaderText = "Номер льготника";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "tenant_id2";
			this.dataGridViewTextBoxColumn8.HeaderText = "Номер ПКО";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// TenantsList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Back_button);
			this.Name = "TenantsList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TenantsList";
			this.Load += new System.EventHandler(this.TenantsList_Load);
			((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tenants)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Back_button;
		private System.Windows.Forms.BindingSource tenantsBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenantidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn flatnumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fiotenantDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn areaflatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn residentsnumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lgotaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lgotatenantidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tenantid2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private Tenants tenants;
		private System.Windows.Forms.BindingSource tenantsBindingSource1;
		private TenantsTableAdapters.tenantsTableAdapter tenantsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
	}
}