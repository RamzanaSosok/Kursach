using System;
using System.Windows.Forms;

namespace Kursach
{
	public partial class TenantsInformation : Form
	{
		public TenantsInformation(AdditionalInformation f)
		{
			InitializeComponent();
			Owner = f;
		}

		//Данная функция позволяет скрывать или показывать панель, куда нужно вводить данные льготников
		private void Lgota_checkbox_CheckedChanged(object sender, EventArgs e)
		{
			HidePanel.Visible = Lgota_checkbox.Checked;
		}

		private void AddTenant_button_Click(object sender, EventArgs e)
		{
			//Данный if проверяет, отмечали ли мы, что новый житель будет льготником
			if (!Lgota_checkbox.Checked)
			{
				//Проверяем, что все поля заполнены
				if (FlatArea_textbox.TextLength != 0 
				    && FlatId_textbox.TextLength != 0
				    && SecondName_textbox.TextLength != 0 &&
				    Name_textbox.TextLength != 0
				    && Otch_textbox.TextLength != 0 &&
				    TenantsNumber_textbox.TextLength != 0)
				{
					//Создаём подключение к базе
					var con = new Connection().Connect();
					if (con == null)
						return;
					//Парсим введёные данные
					var fio = SecondName_textbox.Text + ' ' + Name_textbox.Text + '.' + Otch_textbox.Text + '.';
					var flat = FlatId_textbox.Text;
					var flatarea = FlatArea_textbox.Text;
					var residents_num = TenantsNumber_textbox.Text;
					//Вставляем данные в SQL комманду
					var Sql = "INSERT INTO `kursach`.`tenants` (`flat_number`, `fio_tenant`, `area_flat`, `residents_num`) VALUES ('"+
					          flat+ "', '"+ fio +"', '"+ flatarea + "', '"+residents_num+"');";
					//Выполянем комманду
					var command = new Connection().Command(Sql, con);
					command.ExecuteNonQuery();
					//Очищаем все текст боксы
					ClearTextBoxes();
				}
				else
				{
					MessageBox.Show("Заполните все поля");
					ClearTextBoxes();
				}
			}
			else
			{
				//Проверяем, что все поля заполнены
				if (FlatArea_textbox.TextLength != 0
				    && FlatId_textbox.TextLength != 0
				    && SecondName_textbox.TextLength != 0 &&
				    Name_textbox.TextLength != 0
				    && Otch_textbox.TextLength != 0 &&
				    TenantsNumber_textbox.TextLength != 0
				    && LgotaName_textbox.TextLength != 0
				    && LgotNumber_textbox.TextLength != 0
				    && Formula_textbox.TextLength != 0)
				{
					//Создаём подключение к базе
					var con = new Connection().Connect();
					if (con == null)
						return;

					//Парсим введёные данные
					var fio = SecondName_textbox.Text + ' ' + Name_textbox.Text + '.' + Otch_textbox.Text + '.';
					var flat = FlatId_textbox.Text;
					var flatarea = FlatArea_textbox.Text;
					var residents_num = TenantsNumber_textbox.Text;
					var formula = Formula_textbox.Text;
					var lgot_num = LgotNumber_textbox.Text;
					var lgota_name = LgotaName_textbox.Text;
					var sub = Sub_textbox.Text;

					//Вставляем данные в SQL комманду, т.к. первая у нас будет добавляться новая льгота, то именно
					//её данные мы заполним и отдадим базе.
					var Sql = "INSERT INTO `kursach`.`lgoty` (`lgota_name`, `lgota_formula`) VALUES ('"+lgota_name+
					          "', '"+formula+"');";
					var command = new Connection().Command(Sql, con);
					command.ExecuteNonQuery();

					//У класса Connection().Command() унаследанного от MySqlConnection есть атрибут LastInsertedId,
					//что позволяет нам получить id новой льготы, не обращаясь к самой базе
					var id = command.LastInsertedId;
					//Теперь мы вставляем нового льготника в таблицу льготников. После выполнения также берем lastinsertedid
					Sql = "INSERT INTO `kursach`.`lgot_tenants` (`lgota_id`, `tenants_num`, `lgot_num`, `lgot_sub`) VALUES ('"+ id
					          +"', '"+residents_num+"', '"+lgot_num+"', '"+sub+"');";
					command = new Connection().Command(Sql, con);
					command.ExecuteNonQuery();

					var lgot_tenant_id = command.LastInsertedId;
					//Теперь, имея id льготы и льготника, которые мы только что добавили, вставим нового жителя в базу
					Sql = "INSERT INTO `kursach`.`tenants` (`flat_number`, `fio_tenant`, `area_flat`, `residents_num`, `lgota`, `lgota_tenant_id`) " +
					      "VALUES ('"+flat+"', '"+fio+"', '"+flatarea+"', '"+residents_num+"', '"+id+"', '"+lgot_tenant_id+"');";
					command = new Connection().Command(Sql, con);
					command.ExecuteNonQuery();
					ClearTextBoxes();

				}
				else
				{
					MessageBox.Show("Заполните все поля");
					ClearTextBoxes();
				}
			}
		}

		private void ClearTextBoxes()
		{
			FlatId_textbox.Text = "";
			FlatId_textbox.Text = "";
			SecondName_textbox.Text = "";
			Name_textbox.Text = "";
			Otch_textbox.Text = "";
			TenantsNumber_textbox.Text = "";
			LgotNumber_textbox.Text = "";
			LgotaName_textbox.Text = "";
			Formula_textbox.Text = "";
			Sub_textbox.Text = "";
			FlatArea_textbox.Text = "";
		}

		private void Back_button_Click(object sender, EventArgs e)
		{
			AdditionalInformation f1 = (AdditionalInformation) Owner;
			f1.Show();
			Close();
		}
	}
}
