using MySql.Data.MySqlClient;
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
	public partial class Indications : Form
	{
		private DateTime thisDay = DateTime.Today;
		private bool first_loaded = false;
		private bool second_loaded = false;
		private int t;
		public Indications(View f, int target)
		{
			InitializeComponent();
			Owner = f;
			t = target;
			Date_textbox.Text = this.thisDay.ToString("yyyy-MM-dd"); //Форматируем дату под формат MySQL и вставляем её в textbox
		}
		public Indications(MainMenu f, int target)
		{
			InitializeComponent();
			Owner = f;
			t = target;
			Date_textbox.Text = this.thisDay.ToString("yyyy-MM-dd"); //Форматируем дату под формат MySQL и вставляем её в textbox
		}

		private void Indications_Load(object sender, EventArgs e)
		{
			// Данная строка считывает данные из таблицы pokazanyia_os в DataGridView
			this.pokazanyia_osTableAdapter.Fill(this.pokazanyiaOs.pokazanyia_os);
			first_loaded = true;
			//Данная строка считывает данные из таблицы pokazanyia в DataGridView
			this.pokazaniyaTableAdapter.Fill(this.Pokazanyia.pokazaniya);
			second_loaded = true;
		}

		private void AddIndicatons_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddIndication f = new AddIndication(this);
			f.ShowDialog();
			this.pokazaniyaTableAdapter.Fill(this.Pokazanyia.pokazaniya);
		}

		private void MainMenu_button_Click(object sender, EventArgs e)
		{
			if (t == 1)
			{
				MainMenu f1 = (MainMenu) Owner;
				f1.Show();
				Close();
			}
			else if (t == 2)
			{
				View f1 = (View) Owner;
				f1.UpdateData();
				f1.Show();
				this.Close();
			}
		}

		private void AddIndication_button_Click(object sender, EventArgs e)
		{
			if (Lose_textbox.TextLength != 0 && Tarif_textbox.TextLength != 0 && TarifOs_textbox.TextLength != 0)
			{
				var Lose = Double.Parse(Lose_textbox.Text);
				var Tarif = Double.Parse(Tarif_textbox.Text);
				var TarifOs = Double.Parse(TarifOs_textbox.Text);
				//Считываем данные из texbox
				var con = new Connection().Connect(); //Создаём подключение к базе
				var SqlDate = Date_textbox.Text;
				if (con == null)
					return;
				var Sql = "INSERT INTO `kursach`.`tarif` (`date_tarif`, `flat_tarif`, `OC`, `lose`) VALUES ('" +
				          SqlDate + "', '" +
				          Tarif + "', '" + TarifOs + "', '" + Lose + "');";
				//Sql - Шаблон команды MySQL, которая вставляет данные в таблицу тарифов. Шаблон заполняется полученными раннее данными
				var command = new Connection().Command(Sql, con); //Создаём команду для её последующего исполнения
				command.ExecuteNonQuery(); //Выполняем команду
				Lose_textbox.Clear();
				Tarif_textbox.Clear();
				TarifOs_textbox.Clear();
				//Очищаем все textbox
				Date_textbox.Text = this.thisDay.ToString("yyyy-MM-dd"); //Сверяем дату
			}
			else
			{
				MessageBox.Show("Введите все параметры тарифа");
			}
		}

		private void AddOsIndications_button_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddIndicationOs f = new AddIndicationOs(this);
			f.ShowDialog();
			this.pokazanyia_osTableAdapter.Fill(this.pokazanyiaOs.pokazanyia_os);
		}

		private void Indications_datagridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(!second_loaded)
				return;
			var row = Indications_datagridview.CurrentCell.RowIndex;
			if (Indications_datagridview[0, row].Value.ToString() != "" && Indications_datagridview[1, row].Value.ToString() != "")
			{
				var flat = Indications_datagridview[0, row].Value.ToString();
				var indications = Indications_datagridview[1, row].Value.ToString();
				var con = new Connection().Connect();
				if (con == null)
					return;
				var date = Convert.ToDateTime(Indications_datagridview[2, row].Value);
				var date_string = date.ToString("yyyy-MM-dd");
				var Sql = "UPDATE `kursach`.`pokazaniya` SET `flat_id` = '" + flat + "', `pokazanyia` = '" +
				          indications + "', `pokazanyia_date` ='" + date_string + "' WHERE (`pokazaniya_id` = '" + (row+1).ToString() + "');";
				var command = new Connection().Command(Sql, con);
				command.ExecuteNonQuery();
			}
			else
			{
				MessageBox.Show("Ошибка");
			}
		}

		private void IndicationsOs_datagridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (!first_loaded)
				return;
			var row = IndicationsOs_datagridview.CurrentCell.RowIndex;
			if (IndicationsOs_datagridview[0, row].Value.ToString() == "кв" 
			    || IndicationsOs_datagridview[0, row].Value.ToString() == "лифт" || IndicationsOs_datagridview[0, row].Value.ToString() == "дом")
			{
				if (IndicationsOs_datagridview[1, row].Value.ToString() != "")
				{
					var scht = IndicationsOs_datagridview[0, row].Value.ToString();
					var indications = IndicationsOs_datagridview[1, row].Value.ToString();
					var date = Convert.ToDateTime(IndicationsOs_datagridview[2, row].Value);
					var date_string = date.ToString("yyyy-MM-dd");
					var con = new Connection().Connect();
					if (con == null)
						return;
					var Sql = "UPDATE `kursach`.`pokazanyia_os` SET `scht_id` = '" + scht + "', `pokazanyia` = '" +
					          indications + "', date_os='"+date_string+"' WHERE (`pokazanyia_os_id` = '" + (row+1).ToString() + "');";
					var command = new Connection().Command(Sql, con);
					command.ExecuteNonQuery();
				}
				else
				{
					MessageBox.Show("Ошибка");
				}
			}
			else
			{
				MessageBox.Show("Ошибка");
			}
		}
	}
}
