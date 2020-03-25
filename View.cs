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

namespace Kursach
{
	public partial class View : Form
	{
		private string PD, CD, M;
		private List<string> flats = new List<string>();
		private List <int> results = new List<int>();

		private List<decimal> flats_areas = new List<decimal>();
		private int size, index, index_page;
		private decimal tarif;
		private void View_Load(object sender, EventArgs e)
		{
			
		}

		private void Next_button_Click(object sender, EventArgs e)
		{

		}

		private void Previous_button_Click(object sender, EventArgs e)
		{

		}

		public View(string PreviousDate, string CurrentDate, string Month, Calculation f)
		{
			InitializeComponent();
			Owner = f;
			this.PD = PreviousDate;
			this.CD = CurrentDate;
			this.M = Month;
			var con = new Connection().Connect();
			if (con == null)
				return;
			var Sql = "SELECT DISTINCT flat_id FROM kursach.pokazaniya;";
			var command = new Connection().Command(Sql, con);
			var Reader = command.ExecuteReader();
			foreach (DbDataRecord record in Reader)
			{
				flats.Add(record.GetValue(0).ToString());
			}

			size = flats.Count/2;
			index_page = 1;
			index = 0;

			Page_textbox.Text = index_page.ToString() + '/' + size.ToString();

			for (int i = 0; i < Convert.ToInt32(size); i++)
			{
				results.Add(FindMax(flats[i]) - FindMin(flats[i]));
			}
			SetResults();
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
					SecondName1_combobox.Items.Add(record.GetValue(0).ToString().Split(' ')[0]);
				}
				Reader.Close();

				FlatId1_textbox.Text = flats[index].ToString();
				DifferenceFlat1_textbox.Text = results[index].ToString();
				FlatIdPay1_textbox.Text = "";
				AreaFlat1_textbox.Text = GetArea(flats[index]).ToString();
			}
		}

		private void SecondName_combobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			
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

		}
	}
}
