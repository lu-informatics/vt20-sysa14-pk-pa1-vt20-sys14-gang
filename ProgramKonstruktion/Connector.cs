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

        private string connectionString = "Data Source = SYST4DEV01; Initial Catalog = SIT; User Id = tgang; Password = tgang1;";
        

        public SqlConnection connection
        {
            get;
            set;
        }


        public Connector() //constructor to database
        {
            OpenConnection();
        }

        public void OpenConnection()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

               // if (connection != null)
               // {
               //     Console.WriteLine("Det funkade!!! :)");
               // }

            } catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CloseConnector() 
        {
            connection.Close();
        }
  



    }
}
