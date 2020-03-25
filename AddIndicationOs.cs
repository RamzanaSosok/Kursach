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
	public partial class AddIndicationOs : Form
	{
		private string DateSql = DateTime.Today.ToString("yyyy-MM-dd");
		public AddIndicationOs(Indications f)
		{
			InitializeComponent();
			Date_textbox.Text = DateSql;
			Owner = f;
		}

		private void Cancel_button_Click(object sender, EventArgs e)
		{
			Indications f1 = (Indications)Owner;
			f1.Show();
			Close();
		}

		private void AddIndicationOs_button_Click(object sender, EventArgs e)
		{
			if (Indications_textbox.TextLength != 0 && Scht_combobox.SelectedItem.ToString() != "")
			{
				var con = new Connection().Connect();
				if (con == null)
					return;
				var Indications = Indications_textbox.Text;
				var Scht = Scht_combobox.SelectedItem.ToString();
				DateSql = Date_textbox.Text;
				var Sql = "INSERT INTO `kursach`.`pokazanyia_os` (`scht_id`, `pokazanyia`, `date_os`) VALUES ('" +
				          Scht + "', '" + Indications + "', '" + DateSql + "');";
				var command = new Connection().Command(Sql, con);
				command.ExecuteNonQuery();
				Indications f1 = (Indications)Owner;
				f1.Show();
				Close();
			}
			else
			{
				MessageBox.Show("Введите все данные");
			}
		}
	}
}
