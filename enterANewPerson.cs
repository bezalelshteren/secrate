using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secrate
{
    public class enterANewPerson
    {

        public string query { get; set; }
        public string strintConn = "server=localhost;username=root;password=;database=murder;";
        public List<agant> GetParemeterFromSql(string query, string[] parameter)
        {
            List<agant> getParameters = new List<agant>();
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
                    agant agen = new agant
                    {
                        id = reader.GetInt32("id"),
                        firstName = reader.GetString(reader.GetOrdinal("first_name")),
                        lastName = reader.GetString(reader.GetOrdinal("last_name")),
                        secretCode = reader.GetString(reader.GetOrdinal("secret_code")),
                        type = reader.GetString(reader.GetOrdinal("type")),
                        numReports = reader.GetInt32(reader.GetOrdinal("num_reports")),
                        numMentions = reader.GetInt32(reader.GetOrdinal("num_mentions"))
                    };
                    getParameters.Add(agen);
                    }
                
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.GetType());
                sqlConnection.Close();
            }
            return getParameters;
        }
    }
}
