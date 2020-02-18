using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ProgramKonstruktion
{
    class MetaDataPK2
    {
        private static readonly string host = "uwdb18.srv.lu.se";
        private static readonly string instanceName = "icssql001";
        private static readonly string dbName = "SYSA14_PK_ProgAssignment2";
        private static readonly string username = "sysa14reader";
        private static readonly string password = "INFreader1";

        ErrorHandler exceptionHandler = new ErrorHandler(); 

        public SqlConnection Connection { get; set; }

        public MetaDataPK2()
        {
            ConnectToDb();
        }

        private void ConnectToDb()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString());
            }
            catch (SqlException e)
            {
                exceptionHandler.HandleErrorExceptionSql(e);
            }
        }
        private string ConnectionString()
        {
            string connectionString = String.Format(
                "Data Source={0}\\{1}; Database name={2}; User id={3}; Password={4};",
                host, instanceName, dbName, username, password
            );

            return connectionString;
        }
        public void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }

    }
}
