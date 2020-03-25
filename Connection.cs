using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach
{
	public class Connection
	{
		//Данный класс описывает подключение к MySQL Server
		public MySqlConnection Connect()
		{
			//Данная функция выполняет подключение к базе данных MySQL
			//В этой строке задаются параметры подключения (стандартные)
			var conn = new MySqlConnection("server=" + "LocalHost" + "; user=" + "root" + "; database=" + "kursach" +
			                               "; port=" + "3306" + "; password=" + "12345" + ";charset=utf8;");
			try
			{
				//Открывает соединение с MySQL
				conn.Open();
				return conn;
			}
			//TODO: exception
			catch (Exception ex)
			{
				//Обработка исключений
				MessageBox.Show(@"Ошибка при подключении к базе данных, пожалуйста, проверьте соединение с интернетом",
					@"Нет соединения с сервером!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(ex.Message, @"Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
		public MySqlCommand Command(string sql, MySqlConnection conn)
		{
			//Данная функция отправляет команды SQL на сервер
			try
			{
				return new MySqlCommand(sql, conn);
			}
			catch (Exception ex)
			{
				//Обработка исключений
				MessageBox.Show(@"Ошибка при работе с базой данных: " + ex.Message,
					@"Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
	}
}
