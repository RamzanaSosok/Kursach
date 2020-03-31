using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace Kursach
{
	public partial class View : Form
	{
		private string PD, CD, M;
		private List<string> flats = new List<string>();
		private List <int> results = new List<int>();

		private List<decimal> flats_areas = new List<decimal>();
		private int size, index, index_page;
		private decimal tarif, tarif_os;
		private void View_Load(object sender, EventArgs e)
		{
			
		}
		public View(string PreviousDate, string CurrentDate, string Month, Calculation f)
		{
			InitializeComponent();
			Owner = f;
			this.PD = PreviousDate;
			this.CD = CurrentDate;
			this.M = Month;
			var Sql = "SELECT MAX(date_tarif) AS date_tarif FROM kursach.tarif WHERE date_tarif <= '"+CD+"'";
			var con = new Connection().Connect();
			if (con == null)
				return;
			var command = new Connection().Command(Sql, con);
			var Reader = command.ExecuteReader();
			Reader.Read();
			var FindDate = Reader.GetDateTime(0).ToString();
			string[] separators = { " 0:00:00" };
			FindDate = FindDate.Split(separators, StringSplitOptions.None)[0];
			DateTime parsed;
			parsed = DateTime.Parse(FindDate);
			FindDate = parsed.ToString("yyyy-MM-dd");
			Reader.Close();
			Sql = "SELECT flat_tarif, OC FROM kursach.tarif WHERE date_tarif = '" + FindDate + "';";
			con = new Connection().Connect();
			command = new MySqlCommand(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			tarif = Convert.ToDecimal(Reader.GetValue(0));
			tarif_os = Convert.ToDecimal(Reader.GetValue(1));
			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT DISTINCT flat_id FROM kursach.pokazaniya;";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			foreach (DbDataRecord record in Reader)
			{
				flats.Add(record.GetValue(0).ToString());
			}

			size = flats.Count/2;
			index_page = 1;
			index = 0;

			Page_textbox.Text = index_page.ToString() + '/' + size.ToString();

			for (int i = 0; i < Convert.ToInt32(flats.Count); i++)
			{
				results.Add(FindMax(flats[i]) - FindMin(flats[i]));
			}
			SetResults();
		}

		private void Next_button_Click(object sender, EventArgs e)
		{
			if (index + 2 < flats.Count)
			{
				ClearFields();
				index += 2;
				SetResults();
			}
			else
			{
				MessageBox.Show("Ошибка");
			}
		}

		private void Previous_button_Click(object sender, EventArgs e)
		{
			if (index - 2 >= 0)
			{
				ClearFields();
				index -= 2;
				SetResults();
			}
			else
			{
				MessageBox.Show("Ошибка");
			}
		}

		
		private void SetResults()
		{
			var con = new Connection().Connect();
			if (con == null)
				return;
			var Sql = "SELECT fio_tenant FROM kursach.tenants WHERE flat_number = '" + flats[index] + "';";
			var command = new Connection().Command(Sql, con);
			var Reader = command.ExecuteReader();
			foreach (DbDataRecord record in Reader)
			{
				SecondName_combobox.Items.Add(record.GetValue(0).ToString());
			}
			Reader.Close();

			FlatId_textbox.Text = flats[index].ToString();
			DifferenceFlat_textbox.Text = results[index].ToString();
			FlatIdPay_textbox.Text = "";
			AreaFlat_textbox.Text = GetArea(flats[index]).ToString();
			if (index + 1 < flats.Count)
			{
				index++;
				Sql = "SELECT fio_tenant FROM kursach.tenants WHERE flat_number = '" + flats[index] + "';";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				foreach (DbDataRecord record in Reader)
				{
					SecondName1_combobox.Items.Add(record.GetValue(0).ToString());
				}
				Reader.Close();

				FlatId1_textbox.Text = flats[index].ToString();
				DifferenceFlat1_textbox.Text = results[index].ToString();
				FlatIdPay1_textbox.Text = "";
				AreaFlat1_textbox.Text = GetArea(flats[index]).ToString();

				index--;
			}
		}

		private void SecondName_combobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var Sql = "SELECT lgota FROM kursach.tenants WHERE fio_tenant = '" +
			      SecondName_combobox.SelectedItem + "';";
			var con = new Connection().Connect();
			if (con == null)
				return;
			var command = new Connection().Command(Sql, con);
			var Reader = command.ExecuteReader();
			Reader.Read();
			try
			{
				var lgota = Reader.GetValue(0).ToString();
				Reader.Close();
				Sql = "SELECT lgota_formula FROM kursach.lgoty WHERE lgota_id = '"+lgota+"';";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				Reader.Read();
				var formula = Reader.GetValue(0).ToString();
				Reader.Close();
				var split = formula.Split('/');
				var koef = Convert.ToDecimal(split[0][split[0].Length - 1].ToString())
				                             /Convert.ToDecimal(split[1][0].ToString());
				FlatIdPay_textbox.Text = (tarif * koef * Convert.ToDecimal(DifferenceFlat_textbox.Text)).ToString();
				return;
			}
			catch
			{
				Reader.Close();
				FlatIdPay_textbox.Text = (tarif * Convert.ToDecimal(DifferenceFlat_textbox.Text)).ToString();
				return;
			}
		}

		private void Back_button_Click(object sender, EventArgs e)
		{
			Calculation f1 = (Calculation) Owner;
			f1.Show();
			this.Close();
		}

		private void SecondName1_combobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			var Sql = "SELECT lgota FROM kursach.tenants WHERE fio_tenant = '" +
			      SecondName1_combobox.SelectedItem + "';";
			var con = new Connection().Connect();
			if (con == null)
				return;
			var command = new Connection().Command(Sql, con);
			var Reader = command.ExecuteReader();
			Reader.Read();
			try
			{
				var lgota = Reader.GetValue(0).ToString();
				Reader.Close();
				Sql = "SELECT lgota_formula FROM kursach.lgoty WHERE lgota_id = '" + lgota + "';";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				Reader.Read();
				var formula = Reader.GetValue(0).ToString();
				Reader.Close();
				var split = formula.Split('/');
				var koef = Convert.ToDecimal(split[0][split[0].Length - 1].ToString())
				           / Convert.ToDecimal(split[1][0].ToString());
				FlatIdPay1_textbox.Text = (tarif * koef * Convert.ToDecimal(DifferenceFlat1_textbox.Text)).ToString();
				return;
			}
			catch
			{
				Reader.Close();
				FlatIdPay1_textbox.Text = (tarif * Convert.ToDecimal(DifferenceFlat1_textbox.Text)).ToString();
				return;
			}
		}

		private int FindMin(string val)
		{
			var con = new Connection().Connect();
			if (con == null)
				return 0;
			var Sql =
				"SELECT MIN(pokazaniya.pokazanyia_date) AS pokazanyia_date FROM kursach.pokazaniya WHERE flat_id = '" +
				val + "' AND pokazanyia_date " +
				">= '" + PD + "'";
			var command = new Connection().Command(Sql, con);
			var Reader = command.ExecuteReader();
			Reader.Read();
			var FindDate = Reader.GetDateTime(0).ToString();
			string[] separators = { " 0:00:00" };
			FindDate = FindDate.Split(separators, StringSplitOptions.None)[0];
			DateTime parsed;
			parsed = DateTime.Parse(FindDate);
			FindDate = parsed.ToString("yyyy-MM-dd");
			Reader.Close();
			Sql = "SELECT pokazanyia FROM kursach.pokazaniya WHERE pokazanyia_date = '" + FindDate +
			      "' AND flat_id = '" + val + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			int res =  Convert.ToInt32(Reader.GetValue(0).ToString());
			return res;
		}

		private int FindMax(string val)
		{
			var con = new Connection().Connect();
			if (con == null)
				return 0;
			var Sql =
				"SELECT MAX(pokazaniya.pokazanyia_date) AS pokazanyia_date FROM kursach.pokazaniya WHERE flat_id = '" +
				val + "' AND pokazanyia_date " +
				"<= '" + CD + "'";
			var command = new Connection().Command(Sql, con);
			var Reader = command.ExecuteReader();
			Reader.Read();
			var FindDate = Reader.GetDateTime(0).ToString();
			string[] separators = { " 0:00:00" };
			FindDate = FindDate.Split(separators, StringSplitOptions.None)[0];
			DateTime parsed;
			parsed = DateTime.Parse(FindDate);
			FindDate = parsed.ToString("yyyy-MM-dd");
			Reader.Close();
			Sql = "SELECT pokazanyia FROM kursach.pokazaniya WHERE pokazanyia_date = '" + FindDate +
			      "' AND flat_id = '" + val + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			int res = Convert.ToInt32(Reader.GetValue(0).ToString());
			return res;
		}

		private decimal GetArea(string val)
		{
			var con = new Connection().Connect();
			if (con == null)
				return 0;
			var Sql = "SELECT area_flat FROM kursach.tenants WHERE flat_number = '"+val+"'";
			var command = new Connection().Command(Sql, con);
			var Reader = command.ExecuteReader();
			Reader.Read();
			return Convert.ToDecimal(Reader.GetValue(0).ToString());
		}

		private void ClearFields()
		{
			FlatId_textbox.Text = "";
			FlatId1_textbox.Text = "";
			SecondName_combobox.SelectedIndex = -1;
			SecondName1_combobox.SelectedIndex = -1;
			SecondName_combobox.Items.Clear();
			SecondName1_combobox.Items.Clear();
			DifferenceFlat_textbox.Text = "";
			DifferenceFlat1_textbox.Text = "";
			AreaFlat_textbox.Text = "";
			AreaFlat1_textbox.Text = "";
			CommonLight_textbox.Text = "";
			CommonLight1_textbox.Text = "";
			Sum_textbox.Text = "";
			Sum1_textbox.Text = "";
			FlatIdPay_textbox.Text = "";
			FlatIdPay1_textbox.Text = "";
		}
	}
}
