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
		private int t;
		public TenantsList(View f, int target)
		{
			InitializeComponent();
			t = target;
			Owner = f;
		}
		public TenantsList(AdditionalInformation f, int target)
		{
			InitializeComponent();
			t = target;
			Owner = f;
		}

		private void Back_button_Click(object sender, EventArgs e)
		{
			if (t == 1)
			{
				AdditionalInformation f1 = (AdditionalInformation) Owner;
				f1.Show();
				Close();
			}
			else if (t == 2)
			{
				View f1 = (View) Owner;
				f1.Show();
				Close();
			}
		}

		private void TenantsList_Load(object sender, EventArgs e)
		{
			//данная строка кода позволяет загрузить данные в таблицу "tenants.tenants". При необходимости она может быть перемещена или удалена.
			this.tenantsTableAdapter.Fill(this.tenants.tenants);

		}
	}
}
