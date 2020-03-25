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
	public partial class AddIndication : Form
	{
		private string DateSql = DateTime.Today.ToString("yyyy-MM-dd");
		public AddIndication(Indications f)
		{
			InitializeComponent();
			Date_textbox.Text = DateSql;
			Owner = f;
		}

		private void AddIndication_button_Click(object sender, EventArgs e)
		{
			if (Indications_textbox.TextLength != 0 && FlatId_textbox.TextLength != 0)
			{
				var con = new Connection().Connect();
				if (con == null)
					return;
				var Indications = Indications_textbox.Text;
				var FlatId = FlatId_textbox.Text;
				DateSql = Date_textbox.Text;
				var Sql = "INSERT INTO `kursach`.`pokazaniya` (`flat_id`, `pokazanyia`, `pokazanyia_date`) VALUES ('" +
				          FlatId + "', '" + Indications +"', '"+ DateSql +"');";
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

		private void Cancel_button_Click(object sender, EventArgs e)
		{
			Indications f1 = (Indications)Owner;
			f1.Show();
			Close();
		}
	}
}
