using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace SoundStudio.Classes
{
    class LoadServices
    {
        public class services
        {
            public string titleServices { get; set; }
            public string descriptionServices { get; set; }
            public string costServices { get; set; }
        }

        public void loadServices(SoundStudioWindow SSW)
        {
            Classes.Connection connection = new Classes.Connection();
            DataTable dt_SoundStudioServices = connection.Select("SELECT * FROM [dbo].[Table_services]"); // данные из БД
            for (int i = 0; i < dt_SoundStudioServices.Rows.Count; i++) // перебираем данные
            {
                services dataServices = new services() // создаём экземпляр класса
                {
                    titleServices = dt_SoundStudioServices.Rows[i][0].ToString(),
                    descriptionServices = dt_SoundStudioServices.Rows[i][1].ToString(),
                    costServices = dt_SoundStudioServices.Rows[i][2].ToString(),
                };
                SSW.servicesListView.Items.Add(dataServices); // выводим строку в список
            }
        }
    }
}
