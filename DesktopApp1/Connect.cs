using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DesktopApp1
{
    class Connect
    {
        private string connectionString = "Data Source=DESKTOP-DIEA2PE;Initial Catalog = Project; Integrated Security = True";

        public ArrayList getFavourite(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM recipes " ;

                using (var command = new SqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    var list = new ArrayList();
                    while(reader.Read())
                    {
                        string Label = reader.GetString(1);
                        //string Ingredients = reader.GetString(2);
                        //string Method = reader.GetString(3);


                        list.Add(Label);
                        //list.Add(Ingredients);
                        //list.Add(Method);
                    }

                    connection.Close();
                    reader.Close();
                    return list;
                }

            }
        }
    }
}
