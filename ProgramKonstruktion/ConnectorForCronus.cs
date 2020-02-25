using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    class ConnectorForCronus
    {

        private string connectionString = "Data Source=SYST4DEV01;Initial Catalog = Demo Database NAV (5-0); Integrated Security = True";

        public SqlConnection Connection
        {
            get;
            private set;
        }

        public ConnectorForCronus()
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

            }
        }
        
        public void CloseConnector(SqlConnection con)
        {
            con.Close();
        }
    }
}
