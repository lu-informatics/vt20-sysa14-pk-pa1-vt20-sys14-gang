using System;
using System.Collections.Generic;
using System.Data;
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

        //Show all column names method 2

        public DataTable ShowAllColumnNames()
        {
            DataTable dtNames = new DataTable();
            string query = "SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME in (select tablename from TablesOfInterest)";

            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        dtNames.Load(reader);
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
                    return dtNames;
                }

            }
        }


        //Show Number of rows method 2

        public DataTable ShowNumberOfRows()
        {
            DataTable dtRows = new DataTable();
            string query = "SELECT COUNT(*) AS NumberOfRows FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME in (select tablename from TablesOfInterest)";

            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        dtRows.Load(reader);
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
                        //connection.Close();
                        connect.CloseConnection(connection);
                    }
                    return dtRows;
                }

            }
        }
     
        }
        
    }



    