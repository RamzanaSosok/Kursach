using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
	public partial class TenantsList : Form
	{
		public TenantsList(AdditionalInformation f)
		{
			InitializeComponent();
			Owner = f;
		}

		private void Back_button_Click(object sender, EventArgs e)
		{
			AdditionalInformation f1 = (AdditionalInformation) Owner;
			f1.Show();
			Close();
		}

		private void TenantsList_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "tenants.tenants". При необходимости она может быть перемещена или удалена.
			this.tenantsTableAdapter.Fill(this.tenants.tenants);

		}
	}
}
