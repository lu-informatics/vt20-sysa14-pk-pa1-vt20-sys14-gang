using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramKonstruktion
{
    class PK2DAL
    {

        private PK2Connector connect = new PK2Connector();
        private SqlConnection connection;
        private ErrorHandler errorHandler = new ErrorHandler();

        public PK2DAL() //constructor
        {
            connect = new PK2Connector();
            connection = connect.Connection;
        }


        // Show number of rows
        public List<String> NumberOfRows()
        {
            List<String> rowNumber = new List<String>();
            string query = "SELECT COUNT(*) AS NumberOfRows FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME in (select tablename from TablesOfInterest)";

           

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string numberOfRows = reader.GetString(0);
                    rowNumber.Add(numberOfRows);
                }

                reader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                // errorHandler.HandleErrorExceptionSql(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connect.CloseConnection(connection);
            }

            return rowNumber;

        }

        //Show all Column Names
        public List<String> AllColumnNames()
        {
            List<String> columnNames = new List<String>();

            
            string query = "SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME in (select tablename from TablesOfInterest)";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                // Loop through resultset
                while (reader.Read())
                {
                    string columnNamesFromSQL = reader.GetString(0).ToString();
                    columnNames.Add(columnNamesFromSQL);

                }

                reader.Close();
            }

            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                // errorHandler.HandleErrorExceptionSql(e);
            }
            catch (Exception ex)
            {
                errorHandler.HandleExceptions(ex);
            }
            finally
            {
                connect.CloseConnection(connection);
            }

                return columnNames;

            }
        
            
        }
        
    }



    