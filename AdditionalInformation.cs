using System;
using System.Windows.Forms;

namespace Kursach
{
	public partial class AdditionalInformation : Form
	{
		public AdditionalInformation(MainMenu f)
		{
			InitializeComponent();
			Owner = f;
		}

		private void Back_button_Click(object sender, EventArgs e)
		{
			MainMenu f1 = (MainMenu) Owner;
			f1.Show();
			Close();
		}

		private void Information_button_Click(object sender, EventArgs e)
		{
			Information f1 = new Information();
			f1.ShowDialog();
		}

		private void TenantsList_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			TenantsList f = new TenantsList(this);
			f.ShowDialog();
		}

		private void TenantsInformation_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			TenantsInformation f1 = new TenantsInformation(this);
			f1.ShowDialog();
		}
	}
}
