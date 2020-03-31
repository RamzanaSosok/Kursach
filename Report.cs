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
using Kursach.Properties;
using MySql.Data.MySqlClient;

namespace Kursach
{
	public partial class Report : Form
	{
		private string PD, CD, M;
		private List<string> flats = new List<string>();
		private List<string> tenants = new List<string>();
		private List<int> results = new List<int>();
		private List<decimal> SummList = new List<decimal>();
		private List<decimal> CommonSumm = new List<decimal>();
		private List<decimal> CommonLightList = new List<decimal>();
		private List<decimal> FlatsAreas = new List<decimal>();
		private List<decimal> Lgoty = new List<decimal>();
		private decimal Tarif, TarifOs, CommonArea, PerMeter;
		private int t;
		private void Back_button_Click(object sender, EventArgs e)
		{
			if (t == 1)
			{
				Calculation2 f1 = (Calculation2) Owner;
				f1.Show();
				this.Close();
			}

			else if (t == 2)
			{
				View f1 = (View) Owner;
				f1.Show();
				this.Close();
			}
		}

		public Report(string PreviousDate, string CurrentDate, string Month, Calculation2 f, int target)
		{
			InitializeComponent();
			Owner = f;
			t = target;
			Month_textbox.Text = Month;
			Year_textbox.Text = CurrentDate.Split('-')[0];
			CD = CurrentDate;
			PD = PreviousDate;
			Indications_CD.HeaderText = Indications_CD.HeaderText + ' ' + CD;
			Indications_PD.HeaderText = Indications_PD.HeaderText + ' ' + PD;



			var Sql = "SELECT MAX(date_Tarif) AS date_Tarif FROM kursach.Tarif WHERE date_Tarif <= '" + CD + "'";
			var con = new Connection().Connect();
			if (con == null)
				return;
			var command = new Connection().Command(Sql, con);
			var Reader = command.ExecuteReader();
			Reader.Read();
			var FindDate = Reader.GetDateTime(0).ToString();
			string[] separators = {" 0:00:00"};
			FindDate = FindDate.Split(separators, StringSplitOptions.None)[0];
			DateTime parsed;
			parsed = DateTime.Parse(FindDate);
			FindDate = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			Sql = "SELECT flat_Tarif, OC FROM kursach.Tarif WHERE date_Tarif = '" + FindDate + "';";
			con = new Connection().Connect();
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();

			Tarif = Convert.ToDecimal(Reader.GetValue(0));
			TarifOs = Convert.ToDecimal(Reader.GetValue(1));

			Reader.Close();

			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT flat_number, fio_tenant FROM kursach.tenants;";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			foreach (DbDataRecord record in Reader)
			{
				flats.Add(record.GetValue(0).ToString());
				tenants.Add(record.GetValue(1).ToString());
			}

			Reader.Close();


			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MAX(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os <= '" +
			      CD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			var FindDateMax = Reader.GetDateTime(0).ToString();
			FindDateMax = FindDateMax.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMax);
			FindDateMax = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MIN(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os >= '" +
			      PD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			var FindDateMin = Reader.GetDateTime(0).ToString();
			FindDateMin = FindDateMin.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMin);
			FindDateMin = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os = '" + FindDateMax +
			      "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			var MaxOs = Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os = '" + FindDateMin +
			      "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			var MinOs = Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MAX(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os <= '" +
			      CD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			FindDateMax = Reader.GetDateTime(0).ToString();
			FindDateMax = FindDateMax.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMax);
			FindDateMax = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MIN(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os >= '" +
			      PD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			FindDateMin = Reader.GetDateTime(0).ToString();
			FindDateMin = FindDateMin.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMin);
			FindDateMin = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os = '" + FindDateMax +
			      "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MaxOs += Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os = '" + FindDateMin +
			      "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MinOs += Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();


			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MAX(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os <= '" +
			      CD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			FindDateMax = Reader.GetDateTime(0).ToString();
			FindDateMax = FindDateMax.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMax);
			FindDateMax = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MIN(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os >= '" +
			      PD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			FindDateMin = Reader.GetDateTime(0).ToString();
			FindDateMin = FindDateMin.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMin);
			FindDateMin = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os = '" + FindDateMax +
			      "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MaxOs += Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os = '" + FindDateMin +
			      "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MinOs += Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			decimal Sum = 0;
			decimal SumPay = 0;


			for (int i = 0; i < Convert.ToInt32(flats.Count); i++)
			{
				results.Add(FindMax(flats[i]) - FindMin(flats[i]));
				Sum += results[i];
				SumPay += results[i] * Tarif;
			}

			SumPay = Decimal.Round(SumPay, 2);
			CommonArea = Settings.Default.AreaSize;
			PerMeter = Decimal.Round((MaxOs - MinOs) * TarifOs / CommonArea, 2);
			PerMeter_textbox.Text = PerMeter.ToString();
			for (int i = 0; i < Convert.ToInt32(flats.Count); i++)
			{
				CommonLightList.Add(results[i] * PerMeter);
				FlatsAreas.Add(GetArea(flats[i]));
				SetSumm(tenants[i], i);
				Lgoty.Add(Convert.ToDecimal(results[i]) * Tarif - SummList[i]);
			}
			for (int i = 0; i < SummList.Count; i++)
			{
				Report_view.Rows.Add();
				Report_view.Rows[i].Cells[0].Value = flats[i];
				Report_view.Rows[i].Cells[1].Value = tenants[i];
				Report_view.Rows[i].Cells[2].Value = FlatsAreas[i].ToString();
				Report_view.Rows[i].Cells[3].Value = FindMax(flats[i]).ToString();
				Report_view.Rows[i].Cells[4].Value = FindMin(flats[i]).ToString();
				Report_view.Rows[i].Cells[5].Value = results[i].ToString();
				Report_view.Rows[i].Cells[6].Value = SummList[i].ToString();
				Report_view.Rows[i].Cells[7].Value = CommonLightList[i].ToString();
				Report_view.Rows[i].Cells[8].Value = Lgoty[i].ToString();
				Report_view.Rows[i].Cells[9].Value = CommonSumm[i].ToString();
			}
		}
		public Report(string PreviousDate, string CurrentDate, string Month, View f, int target)
		{
			InitializeComponent();
			Owner = f;
			t = target;
			Month_textbox.Text = Month;
			Year_textbox.Text = CurrentDate.Split('-')[0];
			CD = CurrentDate;
			PD = PreviousDate;
			Indications_CD.HeaderText = Indications_CD.HeaderText + ' ' + CD;
			Indications_PD.HeaderText = Indications_PD.HeaderText + ' ' + PD;



			var Sql = "SELECT MAX(date_Tarif) AS date_Tarif FROM kursach.Tarif WHERE date_Tarif <= '" + CD + "'";
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

			Sql = "SELECT flat_Tarif, OC FROM kursach.Tarif WHERE date_Tarif = '" + FindDate + "';";
			con = new Connection().Connect();
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();

			Tarif = Convert.ToDecimal(Reader.GetValue(0));
			TarifOs = Convert.ToDecimal(Reader.GetValue(1));

			Reader.Close();

			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT flat_number, fio_tenant FROM kursach.tenants;";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			foreach (DbDataRecord record in Reader)
			{
				flats.Add(record.GetValue(0).ToString());
				tenants.Add(record.GetValue(1).ToString());
			}

			Reader.Close();


			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MAX(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os <= '" +
				  CD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			var FindDateMax = Reader.GetDateTime(0).ToString();
			FindDateMax = FindDateMax.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMax);
			FindDateMax = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MIN(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os >= '" +
				  PD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			var FindDateMin = Reader.GetDateTime(0).ToString();
			FindDateMin = FindDateMin.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMin);
			FindDateMin = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os = '" + FindDateMax +
				  "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			var MaxOs = Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os = '" + FindDateMin +
				  "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			var MinOs = Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MAX(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os <= '" +
				  CD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			FindDateMax = Reader.GetDateTime(0).ToString();
			FindDateMax = FindDateMax.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMax);
			FindDateMax = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MIN(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os >= '" +
				  PD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			FindDateMin = Reader.GetDateTime(0).ToString();
			FindDateMin = FindDateMin.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMin);
			FindDateMin = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os = '" + FindDateMax +
				  "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MaxOs += Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os = '" + FindDateMin +
				  "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MinOs += Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();


			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MAX(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os <= '" +
				  CD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			FindDateMax = Reader.GetDateTime(0).ToString();
			FindDateMax = FindDateMax.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMax);
			FindDateMax = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MIN(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os >= '" +
				  PD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			FindDateMin = Reader.GetDateTime(0).ToString();
			FindDateMin = FindDateMin.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMin);
			FindDateMin = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os = '" + FindDateMax +
				  "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MaxOs += Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os = '" + FindDateMin +
				  "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MinOs += Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			decimal Sum = 0;
			decimal SumPay = 0;


			for (int i = 0; i < Convert.ToInt32(flats.Count); i++)
			{
				results.Add(FindMax(flats[i]) - FindMin(flats[i]));
				Sum += results[i];
				SumPay += results[i] * Tarif;
			}

			SumPay = Decimal.Round(SumPay, 2);
			CommonArea = Settings.Default.AreaSize;
			PerMeter = Decimal.Round((MaxOs - MinOs) * TarifOs / CommonArea, 2);
			PerMeter_textbox.Text = PerMeter.ToString();
			for (int i = 0; i < Convert.ToInt32(flats.Count); i++)
			{
				CommonLightList.Add(results[i] * PerMeter);
				FlatsAreas.Add(GetArea(flats[i]));
				SetSumm(tenants[i], i);
				Lgoty.Add(Convert.ToDecimal(results[i]) * Tarif - SummList[i]);
			}
			for (int i = 0; i < SummList.Count; i++)
			{
				Report_view.Rows.Add();
				Report_view.Rows[i].Cells[0].Value = flats[i];
				Report_view.Rows[i].Cells[1].Value = tenants[i];
				Report_view.Rows[i].Cells[2].Value = FlatsAreas[i].ToString();
				Report_view.Rows[i].Cells[3].Value = FindMax(flats[i]).ToString();
				Report_view.Rows[i].Cells[4].Value = FindMin(flats[i]).ToString();
				Report_view.Rows[i].Cells[5].Value = results[i].ToString();
				Report_view.Rows[i].Cells[6].Value = SummList[i].ToString();
				Report_view.Rows[i].Cells[7].Value = CommonLightList[i].ToString();
				Report_view.Rows[i].Cells[8].Value = Lgoty[i].ToString();
				Report_view.Rows[i].Cells[9].Value = CommonSumm[i].ToString();
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
			int res = Convert.ToInt32(Reader.GetValue(0).ToString());
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
			var Sql = "SELECT area_flat FROM kursach.tenants WHERE flat_number = '" + val + "'";
			var command = new Connection().Command(Sql, con);
			var Reader = command.ExecuteReader();
			Reader.Read();
			return Convert.ToDecimal(Reader.GetValue(0).ToString());
		}
		private void SetSumm(string fio, int index)
		{
			var Sql = "SELECT lgota FROM kursach.tenants WHERE fio_tenant = '" +
			          fio + "';";
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
				SummList.Add(Decimal.Round(Tarif * koef * Convert.ToDecimal(results[index]), 2));
				CommonSumm.Add(Convert.ToDecimal(CommonLightList[index]) + Convert.ToDecimal(SummList[index]));
			}
			catch
			{
				Reader.Close();
				SummList.Add(Tarif * Convert.ToDecimal(results[index]));
				CommonSumm.Add(Convert.ToDecimal(CommonLightList[index]) + Convert.ToDecimal(SummList[index]));
			}
		}
	}
}
