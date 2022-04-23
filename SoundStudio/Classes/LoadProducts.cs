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
    class LoadProducts
    {
        public class products
        {
            public string title { get; set; }
            public string description { get; set; }
            public string cost { get; set; }
        }

        public void loadProducts(SoundStudioWindow SSW)
        {
            Classes.Connection connection = new Classes.Connection();
            DataTable dt_SoundStudioProducts = connection.Select("SELECT * FROM [dbo].[Table_products]"); // данные из БД
            for (int i = 0; i < dt_SoundStudioProducts.Rows.Count; i++) // перебираем данные
            {
                products dataProducts = new products() // создаём экземпляр класса
                {
                    title = dt_SoundStudioProducts.Rows[i][0].ToString(),
                    description = dt_SoundStudioProducts.Rows[i][1].ToString(),
                    cost = dt_SoundStudioProducts.Rows[i][2].ToString(),
                };
                SSW.productsListView.Items.Add(dataProducts); // выводим строку в список
            }
        }
    }
}
