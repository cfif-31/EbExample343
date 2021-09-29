using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbExample343.Classes
{
    class DbConnector
    {
        public static DataTable Select(string sql) {
            //Генерация строки подключения к БД (описываем параметры)
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            //Сервер
            builder.Server = "192.168.201.12";
            builder.Port = 3306;
            builder.Database = "testuser_EFTest434";
            builder.UserID = "testuser";
            builder.Password = "test234";
            builder.CharacterSet = "utf8";

            //Описываем подключение к базе
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            //Описываем комманду
            MySqlCommand command = new MySqlCommand(sql, connection);
            //Создаем таблицу для загрузки результатов
            DataTable table = new DataTable();

            //Открываем соединение
            connection.Open();
            //Загружаем данные в таблицу
            table.Load(command.ExecuteReader());
            //Закрываем соединение
            connection.Close();

            return table;
        }
    }
}
