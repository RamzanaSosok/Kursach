using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void Indications_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			Indications f = new Indications(this, 1);
			f.ShowDialog();
		}

		private void Calculation_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			Calculation2 f = new Calculation2(this, 1);
			f.ShowDialog();
		}

		private void Report_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			Calculation2 f = new Calculation2(this, 2);
			f.ShowDialog();
		}

		private void Receipts_button_Click(object sender, EventArgs e)
		{

		}

		private void Information_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			AdditionalInformation f1 = new AdditionalInformation(this);
			f1.ShowDialog();
		}
	}
}
