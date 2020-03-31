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
	public partial class View : Form
	{
		private string PD, CD, M;
		private List<string> flats = new List<string>();
		private List<string> tenants = new List<string>();
		private List <int> results = new List<int>();
		private List<decimal> Summ = new List<decimal>();
		private List<decimal> CommonSumm = new List<decimal>();
		private List<decimal> CommonLight = new List<decimal>();
		private List<decimal> FlatsAreas = new List<decimal>();
		private int size, index, IndexPage;
		private decimal Tarif, TarifOs, CommonArea, PerMeter;
		private void View_Load(object sender, EventArgs e)
		{
			
		}
		public View(string PreviousDate, string CurrentDate, string Month, Calculation2 f)
		{
			InitializeComponent();
			Owner = f;
			this.PD = PreviousDate;
			this.CD = CurrentDate;
			this.M = Month;
			Month_textbox.Text = M;
			Month1_textbox.Text = M;

			var Sql = "SELECT MAX(date_Tarif) AS date_Tarif FROM kursach.Tarif WHERE date_Tarif <= '"+CD+"'";
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
			command = new MySqlCommand(Sql, con);
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
			Sql = "SELECT MAX(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os <= '" +
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
			Sql = "SELECT MIN(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os >= '" +
			      PD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			var FindDateMin = Reader.GetDateTime(0).ToString();
			FindDateMin = FindDateMin.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMin);
			FindDateMin = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os = '"+FindDateMax+"'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			var MaxOs = Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os = '" + FindDateMin + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			var MinOs = Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			LiftDifference_textbox.Text = (MaxOs - MinOs).ToString();
			LiftPay_textbox.Text = (Decimal.Round((MaxOs - MinOs) * TarifOs, 2)).ToString();


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

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os = '" + FindDateMax + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MaxOs = Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os = '" + FindDateMin + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MinOs = Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			HouseDifference_textbox.Text = (MaxOs - MinOs).ToString();
			HousePay_textbox.Text = (Decimal.Round((MaxOs - MinOs) * TarifOs, 2)).ToString();


			con = new Connection().Connect();
			if (con == null)
				return;
			Sql = "SELECT MAX(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os <= '" +
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
			Sql = "SELECT MIN(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os >= '" +
			      PD + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			FindDateMin = Reader.GetDateTime(0).ToString();
			FindDateMin = FindDateMin.Split(separators, StringSplitOptions.None)[0];
			parsed = DateTime.Parse(FindDateMin);
			FindDateMin = parsed.ToString("yyyy-MM-dd");
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os = '" + FindDateMax + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MaxOs = Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os = '" + FindDateMin + "'";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			Reader.Read();
			MinOs = Convert.ToInt32(Reader.GetValue(0));
			Reader.Close();

			FlatDifference_textbox.Text = (MaxOs - MinOs).ToString();
			FlatPay_textbox.Text = (Decimal.Round((MaxOs - MinOs) * TarifOs, 2)).ToString();

			SumDifference_textbox.Text = (Convert.ToInt32(FlatDifference_textbox.Text) +
			                              Convert.ToInt32(LiftDifference_textbox.Text) +
			                              Convert.ToInt32(HouseDifference_textbox.Text)).ToString();
			SumPay_textbox.Text = Decimal.Round(Convert.ToDecimal(LiftPay_textbox.Text) 
			                       + Convert.ToDecimal(HousePay_textbox.Text)
			                       + Convert.ToDecimal(FlatPay_textbox.Text), 2).ToString();

			size = flats.Count / 2;
			IndexPage = 1;
			index = 0;

			Page_textbox.Text = IndexPage.ToString() + '/' + size.ToString();

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
			CommonArea_textbox.Text = CommonArea.ToString();
			PerMeter = Decimal.Round((Convert.ToDecimal(SumPay_textbox.Text) - SumPay) / CommonArea, 2);
			DiffPay_textbox.Text = SumPay.ToString();
			DiffSum_textbox.Text = Sum.ToString();
			PerMeter_textbox.Text = PerMeter.ToString();
			for (int i = 0; i < Convert.ToInt32(flats.Count); i++)
			{
				CommonLight.Add(results[i] * PerMeter);
				FlatsAreas.Add(GetArea(flats[i]));
				SetSumm(tenants[i], i);
			}
			SetResults();
		}

		private void Next_button_Click(object sender, EventArgs e)
		{
			if (index + 2 < flats.Count)
			{
				ClearFields();
				index += 2;
				IndexPage++;
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
				IndexPage--;
				SetResults();
			}
			else
			{
				MessageBox.Show("Ошибка");
			}
		}

		public void UpdateData()
		{
			flats.Clear();
			tenants.Clear();
			results.Clear();
			Summ.Clear();
			CommonSumm.Clear();
			CommonLight.Clear();
			FlatsAreas.Clear();
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
				command = new MySqlCommand(Sql, con);
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
				Sql = "SELECT MAX(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os <= '" +
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
				Sql = "SELECT MIN(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os >= '" +
					  PD + "'";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				Reader.Read();
				var FindDateMin = Reader.GetDateTime(0).ToString();
				FindDateMin = FindDateMin.Split(separators, StringSplitOptions.None)[0];
				parsed = DateTime.Parse(FindDateMin);
				FindDateMin = parsed.ToString("yyyy-MM-dd");
				Reader.Close();

				Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os = '" + FindDateMax + "'";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				Reader.Read();
				var MaxOs = Convert.ToInt32(Reader.GetValue(0));
				Reader.Close();

				Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'лифт' AND date_os = '" + FindDateMin + "'";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				Reader.Read();
				var MinOs = Convert.ToInt32(Reader.GetValue(0));
				Reader.Close();

				LiftDifference_textbox.Text = (MaxOs - MinOs).ToString();
				LiftPay_textbox.Text = (Decimal.Round((MaxOs - MinOs) * TarifOs, 2)).ToString();


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

				Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os = '" + FindDateMax + "'";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				Reader.Read();
				MaxOs = Convert.ToInt32(Reader.GetValue(0));
				Reader.Close();

				Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'дом' AND date_os = '" + FindDateMin + "'";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				Reader.Read();
				MinOs = Convert.ToInt32(Reader.GetValue(0));
				Reader.Close();

				HouseDifference_textbox.Text = (MaxOs - MinOs).ToString();
				HousePay_textbox.Text = (Decimal.Round((MaxOs - MinOs) * TarifOs, 2)).ToString();


				con = new Connection().Connect();
				if (con == null)
					return;
				Sql = "SELECT MAX(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os <= '" +
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
				Sql = "SELECT MIN(date_os) AS date_os FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os >= '" +
					  PD + "'";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				Reader.Read();
				FindDateMin = Reader.GetDateTime(0).ToString();
				FindDateMin = FindDateMin.Split(separators, StringSplitOptions.None)[0];
				parsed = DateTime.Parse(FindDateMin);
				FindDateMin = parsed.ToString("yyyy-MM-dd");
				Reader.Close();

				Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os = '" + FindDateMax + "'";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				Reader.Read();
				MaxOs = Convert.ToInt32(Reader.GetValue(0));
				Reader.Close();

				Sql = "SELECT pokazanyia FROM kursach.pokazanyia_os  WHERE scht_id = 'кв' AND date_os = '" + FindDateMin + "'";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				Reader.Read();
				MinOs = Convert.ToInt32(Reader.GetValue(0));
				Reader.Close();

				FlatDifference_textbox.Text = (MaxOs - MinOs).ToString();
				FlatPay_textbox.Text = (Decimal.Round((MaxOs - MinOs) * TarifOs, 2)).ToString();

				SumDifference_textbox.Text = (Convert.ToInt32(FlatDifference_textbox.Text) +
											  Convert.ToInt32(LiftDifference_textbox.Text) +
											  Convert.ToInt32(HouseDifference_textbox.Text)).ToString();
				SumPay_textbox.Text = Decimal.Round(Convert.ToDecimal(LiftPay_textbox.Text)
									   + Convert.ToDecimal(HousePay_textbox.Text)
									   + Convert.ToDecimal(FlatPay_textbox.Text), 2).ToString();

				size = flats.Count / 2;
				IndexPage = 1;
				index = 0;

				Page_textbox.Text = IndexPage.ToString() + '/' + size.ToString();

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
				CommonArea_textbox.Text = CommonArea.ToString();
				PerMeter = Decimal.Round((Convert.ToDecimal(SumPay_textbox.Text) - SumPay) / CommonArea, 2);
				DiffPay_textbox.Text = SumPay.ToString();
				DiffSum_textbox.Text = Sum.ToString();
				PerMeter_textbox.Text = PerMeter.ToString();
				for (int i = 0; i < Convert.ToInt32(flats.Count); i++)
				{
					CommonLight.Add(results[i] * PerMeter);
					FlatsAreas.Add(GetArea(flats[i]));
					SetSumm(tenants[i], i);
				}
				SetResults();
		}
		private void Otch_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			Report f = new Report(PD, CD, M, this, 2);
			f.ShowDialog();
		}

		private void TenantsList_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			TenantsList f = new TenantsList(this,2);
			f.ShowDialog();
		}

		private void Change_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			Indications f = new Indications(this, 2);
			f.ShowDialog();
		}

		private void SetResults()
		{
			FIO_textbox.Text = tenants[index];
			FlatId_textbox.Text = flats[index].ToString();
			DifferenceFlat_textbox.Text = results[index].ToString();
			FlatIdPay_textbox.Text = Summ[index].ToString();
			AreaFlat_textbox.Text = FlatsAreas[index].ToString();
			CommonLight_textbox.Text = Decimal.Round(Convert.ToDecimal(AreaFlat_textbox.Text) * TarifOs, 2).ToString();
			Sum_textbox.Text = CommonSumm[index].ToString();

			if (index + 1 < flats.Count)
			{
				index++;

				FIO1_textbox.Text = tenants[index];
				FlatId1_textbox.Text = flats[index].ToString();
				DifferenceFlat1_textbox.Text = results[index].ToString();
				FlatIdPay1_textbox.Text = Summ[index].ToString();
				AreaFlat1_textbox.Text = FlatsAreas[index].ToString();
				CommonLight1_textbox.Text = Decimal.Round(Convert.ToDecimal(AreaFlat1_textbox.Text) * TarifOs, 2).ToString();
				Sum1_textbox.Text = CommonSumm[index].ToString();

				index--;
			}
			Page_textbox.Text = IndexPage.ToString() + '/' + size.ToString();
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
				Sql = "SELECT lgota_formula FROM kursach.lgoty WHERE lgota_id = '"+lgota+"';";
				command = new Connection().Command(Sql, con);
				Reader = command.ExecuteReader();
				Reader.Read();
				var formula = Reader.GetValue(0).ToString();
				Reader.Close();
				var split = formula.Split('/');
				var koef = Convert.ToDecimal(split[0][split[0].Length - 1].ToString())
				                             /Convert.ToDecimal(split[1][0].ToString());
				Summ.Add(Decimal.Round(Tarif * koef * Convert.ToDecimal(results[index]), 2));
				CommonSumm.Add(Convert.ToDecimal(CommonLight[index]) + Convert.ToDecimal(Summ[index]));
			}
			catch
			{
				Reader.Close();
				Summ.Add(Tarif * Convert.ToDecimal(results[index]));
				CommonSumm.Add(Convert.ToDecimal(CommonLight[index]) + Convert.ToDecimal(Summ[index]));
			}
		}

		private void Back_button_Click(object sender, EventArgs e)
		{
			Calculation2 f1 = (Calculation2) Owner;
			f1.Show();
			this.Close();
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
			FIO_textbox.Text = "";
			FIO1_textbox.Text = "";
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
