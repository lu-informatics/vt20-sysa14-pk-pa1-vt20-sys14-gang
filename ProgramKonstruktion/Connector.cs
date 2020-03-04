using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProgramKonstruktion
{
   public class Connector

    {

        private string connectionString = "Data Source = SYST4DEV01; Initial Catalog = STOREITNEW; User Id = tgang; Password = tgang1;";

        public SqlConnection Connection {
            get; private set;
        }

        public Connector()
        {
            GetConnection();
        }

        public void GetConnection()
        {
            try
            {
                Connection = new SqlConnection(connectionString);
            }
            catch (SqlException sqlE)
            {
                //Errorhantering
            }
            
        }

        public void CloseConnector(SqlConnection con)
        {
            con.Close();
        }

    }
}