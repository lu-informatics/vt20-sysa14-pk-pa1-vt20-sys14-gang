using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProgramKonstruktion
{
    class Connector

    {

        private string connectionString = "Data Source = SYST4DEV01; Initial Catalog = StoreIT2; User Id = tgang; Password = tgang1;";

        private SqlConnection connection;
        public SqlConnection getConnection()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException sqlE)
            {
                //Errorhantering
            }
            return null;
        }


        public void CloseConnector()
        {
            connection.Close();
        }




    }
}