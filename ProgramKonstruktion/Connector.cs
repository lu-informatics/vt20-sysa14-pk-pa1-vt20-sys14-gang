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

        private string connectionString = "Data Source = SYST4DEV01; Initial Catalog = StoreIT_Database; User Id = tgang; Password = tgang1;";
        

        public SqlConnection Connection
        {
            get;
            set;
        }


        public Connector() //constructor to database
        {

        }

        public void OpenConnection()
        {
            try
            {
                Connection = new SqlConnection(connectionString);
                Connection.Open();

            } catch (SqlException ex)
            {
                //exhandler

            } catch (Exception e)
            {
                //exhandler
            }
        }

        public void CloseConnector() 
        {
            Connection.Close();
        }
  



    }
}
