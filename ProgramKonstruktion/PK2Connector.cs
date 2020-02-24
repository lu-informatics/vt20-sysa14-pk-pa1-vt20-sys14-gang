﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ProgramKonstruktion
{
    class PK2Connector
    {


        /*private string connectionString = "Data Source = uwdb18.srv.lu.se; Initial Catalog = SYSA14_PK_ProgAssignment2; User Id = sysa14reader; Password = INFreader1;";

        public SqlConnection Connection { get; private set; }

        public PK2Connector()
        {
            getConnection();
        }

        public void getConnection() {

            try
            {
                Connection = new SqlConnection(connectionString);
                Console.WriteLine("fungerar");
            }

            catch (SqlException sqlE)
            {

                Console.WriteLine(":(");
            }
        }

            public void CloseConnector(SqlConnection con)
            {
                con.Close();
            }*/



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
                Connection.Open();
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

   