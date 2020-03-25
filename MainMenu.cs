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
			Indications f = new Indications(this);
			f.ShowDialog();
		}

		private void Calculation_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			Calculation f = new Calculation(this);
			f.ShowDialog();
		}

		private void Report_button_Click(object sender, EventArgs e)
		{

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
