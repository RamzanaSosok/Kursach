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

namespace Kursach
{
	public partial class Calculation2 : Form
	{
		private string PD, CD, M;
		private int t;
		public Calculation2(MainMenu f, int target)
		{
			InitializeComponent();
			Owner = f;
			t = target;
			var con = new Connection().Connect();
			if (con == null)
				return;
			var Sql = "SELECT DISTINCT pokazanyia_date FROM kursach.pokazaniya;";
			var command = new Connection().Command(Sql, con);
			var Reader = command.ExecuteReader();
			List<string> Date = new List<string>();
			foreach (DbDataRecord record in Reader)
			{
				Date.Add(record.GetValue(0).ToString());
			}

			Reader.Close();
			Sql = "SELECT DISTINCT date_os FROM kursach.pokazanyia_os;";
			command = new Connection().Command(Sql, con);
			Reader = command.ExecuteReader();
			foreach (DbDataRecord record in Reader)
			{
				Date.Add(record.GetValue(0).ToString());
			}

			var uniq = Date.Distinct();
			List<string> CurrentDates = new List<string>();
			List<string> PreviousDates = new List<string>();
			foreach(string date in uniq)
			{
				string[] separators = {" 0:00:00"};
				CurrentDates.Add(date.Split(separators, StringSplitOptions.None)[0]);
				PreviousDates.Add(date.Split(separators, StringSplitOptions.None)[0]);
			}
			CurrentDates.Sort(Comparison);
			PreviousDates.Sort(Comparison);
			foreach (string r in CurrentDates)
				CurrentDate_combobox.Items.Add(r);
			foreach (string r in PreviousDates)
				PreviousDate_combobox.Items.Add(r);
		}

		private int Comparison(string date1, string date2)
		{
			if (DateTime.Parse(date2) == DateTime.Parse(date1))
				return 0;
			if (DateTime.Parse(date2) < DateTime.Parse(date1))
				return -1;
			if (DateTime.Parse(date2) > DateTime.Parse(date1))
				return 1;
			else
				return 0;
		}

		private bool Compare(string a, string b)
		{
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] < b[i])
					return true;
			}

			return false;
		}
		private void PreviousDate_combobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.PD = PreviousDate_combobox.SelectedItem.ToString();
		}

		private void View_button_Click(object sender, EventArgs e)
		{
			if (Compare(this.PD,this.CD) && M != null && t == 1)
			{
				this.Hide();
				DateTime parsed1, parsed2;
				parsed1 = DateTime.Parse(PD);
				PD = parsed1.ToString("yyyy-MM-dd");
				parsed2 = DateTime.Parse(CD);
				CD = parsed2.ToString("yyyy-MM-dd");
				if (parsed1 < parsed2)
				{
					View f1 = new View(PD, CD, M, this);
					f1.ShowDialog();
				}
				else
				{
					MessageBox.Show("Ошибка");
				}
			}
			else if (Compare(this.PD, this.CD) && M != null && t == 2)
			{
				this.Hide();
				DateTime parsed1, parsed2;
				parsed1 = DateTime.Parse(PD);
				PD = parsed1.ToString("yyyy-MM-dd");
				parsed2 = DateTime.Parse(CD);
				CD = parsed2.ToString("yyyy-MM-dd");
				if (parsed1 < parsed2)
				{
					Report f1 = new Report(PD, CD, M, this, 1);
					f1.ShowDialog();
				}
				else
				{
					MessageBox.Show("Ошибка");
				}
			}
		}

		private void CurrentDate_combobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.CD = CurrentDate_combobox.SelectedItem.ToString();
		}

		private void Month_textbox_TextChanged(object sender, EventArgs e)
		{
			this.M = Month_textbox.Text;
		}

		private void Back_button_Click(object sender, EventArgs e)
		{
			MainMenu f1 = (MainMenu) Owner;
			f1.Show();
			Close();
		}
	}
}
