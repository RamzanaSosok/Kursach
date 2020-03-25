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
	public partial class Information : Form
	{
		public Information()
		{
			InitializeComponent();
			//Считываем данные из параметров программы, чтобы отобразить их,
			//если они есть
			Address_textbox.Text = Properties.Settings.Default.Address;
			Index_textbox.Text = Properties.Settings.Default.Index;
			Name_textbox.Text =Properties.Settings.Default.OrganisationName;
			AreaSize_textbox.Text = Properties.Settings.Default.AreaSize.ToString();
			Country_textbox.Text = Properties.Settings.Default.Country;
			Phone_textbox.Text= Properties.Settings.Default.Phone;
		}

		private void Cancel_button_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Information_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Считываем текст боксы, после чего заносим их значения в параметры программы, чтобы сохранить
			//эти данные для последующей обработки
			Properties.Settings.Default.Address = Address_textbox.Text;
			Properties.Settings.Default.Index = Index_textbox.Text;
			Properties.Settings.Default.OrganisationName = Name_textbox.Text;
			Properties.Settings.Default.AreaSize = Convert.ToDecimal(AreaSize_textbox.Text);
			Properties.Settings.Default.Country = Country_textbox.Text;
			Properties.Settings.Default.Phone = Phone_textbox.Text;
			Properties.Settings.Default.Save();
		}
	}
}
