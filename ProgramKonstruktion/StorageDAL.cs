using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    class StorageDAL
    {
        private Connector connect = new Connector();
        private SqlConnection connection;
        private ErrorHandler errorHandler = new ErrorHandler();

        public StorageDAL()
        { //constructor

            connect = new Connector();
            connection = connect.getConnection();
        }
        public Boolean CreateStorage(Storage storage)
        {
            Boolean added = false;
            string query = "INSERT INTO Storage (storageNbr, price, size, address) VALUES (@storageNbr, @price, @size, @address)";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.Add("@storageNbr", SqlDbType.Int).Value = storage.StorageNumber;
            command.Parameters.Add("@price", SqlDbType.Float).Value = storage.Price;
            command.Parameters.Add("@size", SqlDbType.Float).Value = storage.Size;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = storage.Address;

            try
            {
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 1)
                {
                    added = true;
                }
            }
            catch (SqlException e)
            {
                errorHandler.HandleErrorExceptionSql(e);
            }
            catch (Exception e)
            {
                errorHandler.HandleExceptions(e);
            }
            finally
            {
                connect.CloseConnector();
            }
            return added;
        }

        public Storage UpdateStorage (string nbr, string price, string size, string address)
        {
            string query = "UPDATE Storage" +
                "SET price = @price, size = @size, WHERE nbr = @nbr AND address = @address";

            Storage storage = new Storage();
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@nbr", SqlDbType.NVarChar).Value = nbr;
            command.Parameters.Add("@price", SqlDbType.NVarChar).Value = price;
            command.Parameters.Add("@size", SqlDbType.NVarChar).Value = size;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;


        try
            {

                command.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                errorHandler.HandleErrorExceptionSql(e);
            }
            catch (Exception ex)
            {
                errorHandler.HandleExceptions(ex);
            }
            finally
            {
                connect.CloseConnector();
            }
            return storage;
        }

    }
}
