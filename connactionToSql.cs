using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secrate
{
    public class connactionToSql
    {
        public string query  { get; set; }
        public string strintConn = "server=localhost;username=root;password=;database=murder;";

        public bool ChecktheSql(string query, string[] parameter)
        {
            bool isExist = false;
            MySqlConnection sqlConnection = new MySqlConnection(strintConn);
            this.query = query;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlComman = new MySqlCommand(query, sqlConnection);
                sqlComman.Parameters.AddWithValue(parameter[0], parameter[1]);
                var reader = sqlComman.ExecuteReader();
                while (reader.Read())
                {
                    agant agant = new agant();
                }
            }

            catch (Exception ex) { Console.WriteLine(ex.Message, ex.GetType());
            }
            sqlConnection.Close();
                return isExist;
            
        }
        
    }
}
