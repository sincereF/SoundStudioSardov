﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace SoundStudio.Classes
{
    class Connection
    {   
            public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
            {
                DataTable dataTable = new DataTable("dataBase"); // создаём таблицу в приложении
                SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-7NIK29D\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=SoundStudio;");
                sqlConnection.Open(); // открываем базу данных
                SqlCommand sqlCommand = sqlConnection.CreateCommand(); // создаём команду
                sqlCommand.CommandText = selectSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
                sqlDataAdapter.Fill(dataTable); // возращаем таблицу с результатом
                return dataTable;
            }
    }
}
