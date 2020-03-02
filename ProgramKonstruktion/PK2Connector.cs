using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    class PK2Connector
    {

        private static readonly string host = "uwdb18.srv.lu.se";
        private static readonly string instanceName = "icssql001";
        private static readonly string dbName = "SYSA14_PK_ProgAssignment2";
        private static readonly string username = "sysa14reader";
        private static readonly string password = "INFreader1";

        ErrorHandler exceptionHandler = new ErrorHandler();

        public SqlConnection Connection { get; set; }

        public void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }

        private string ConnectionString()
        {
            string connectionString = String.Format(
                "Data Source={0}\\{1}; Initial Catalog={2}; User id={3}; Password={4};",
                host, instanceName, dbName, username, password
            );

            return connectionString;
        }

        public PK2Connector()
        {
            ConnectToDb();
        }

        private void ConnectToDb()
        {
            try
            {
                Connection = new SqlConnection(this.ConnectionString());
                if (Connection == null)
                {
                    Console.WriteLine("error");
                }
            }
            catch (SqlException e)
            {
                exceptionHandler.HandleErrorExceptionSql(e);
            }
        }
    }
}

