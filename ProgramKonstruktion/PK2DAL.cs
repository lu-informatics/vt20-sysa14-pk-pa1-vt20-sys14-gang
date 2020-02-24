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

        private PK2Connector connect;
        private SqlConnection connection;
        private ErrorHandler errorHandler = new ErrorHandler();

        public PK2DAL() //constructor
        {
            connect = new PK2Connector();
        }

        /*public List<DataHolder> metadata()
        {
            ResultSet rs = null;

            List<DataHolder> constraints;


            try
            {
                connection.Open();
                rs = conn.createStatement().executeQuery(
                        "SELECT TABLE_CATALOG, TABLE_SCHEMA, COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE\r\n" +
                        "FROM INFORMATION_SCHEMA.COLUMNS\r\n" +
                        "WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'");
                while (rs.next())
                {
                    constraints.add(new DataHolder(rs.getString(1), rs.getString(2), rs.getString(3), rs.getString(4), rs.getString(5)));

                }
            }
            catch (Exception e)
            {
                e.printStackTrace();
            }

            return constraints;

        }
        */


        public List<String> AllColumnNames()
        {
            List<string> columnNames = new List<string>();
            string query = "SELECT * FROM TablesOfInterest";

            connection = connect.Connection;

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                SqlDataReader reader = command.ExecuteReader();


                // Loop through resultset
                while (reader.Read())
                {
                    string tableNames = reader.GetString(0).ToString();
                    columnNames.Add(reader.GetString(0).ToString());
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