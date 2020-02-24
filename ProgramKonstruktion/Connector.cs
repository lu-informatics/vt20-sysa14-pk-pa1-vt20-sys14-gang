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

        private string connectionString = "Data Source = SYST4DEV01; Initial Catalog = StoreIT2; User Id = tgang; Password = tgang1;";

        public SqlConnection Connection { get; private set; }

        public Connector()
        {
            getConnection();
        }

        public void getConnection()
        {
            try
            {
                Connection = new SqlConnection(connectionString);
                //connection.Open();
                //return connection;
            }
            catch (SqlException sqlE)
            {
                //Errorhantering
            }
            //return null;
        }


        public void CloseConnector(SqlConnection con)
        {
            con.Close();
        }




    }
}