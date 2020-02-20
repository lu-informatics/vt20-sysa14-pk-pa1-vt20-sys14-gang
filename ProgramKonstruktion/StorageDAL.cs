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

        public List<Storage> GetListOfStorages()
        {
            List<Storage> getListOfStorages = new List<Storage>();
            string query = "SELECT * FROM Storage";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Storage storage = new Storage();
                    {
                        storage.Nbr = reader.GetString(1);
                        storage.Price = reader.GetFloat(2);
                        storage.Size = reader.GetFloat(3);
                        storage.Address = reader.GetString(4);

                    }
                    getListOfStorages.Add(storage);
                }
                reader.Close();

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
               // errorHandler.HandleErrorExceptionSql(e);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
               // errorHandler.HandleExceptions(e);

            }
            finally
            {
                connection.Close();
            }
            return getListOfStorages;
        }

        public Boolean  CreateStorage(Storage storage)
        {
            Boolean added = false;
            string query = "INSERT INTO Storage VALUES (@storageNbr, @price, @size, @address)";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.Add("@storageNbr", SqlDbType.Int).Value = storage.Nbr;
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
                MessageBox.Show(e.Message);

               
                // errorHandler.HandleExceptions(e);
            }
            finally
            {
                connect.CloseConnector();
            }
            return added;
        }

        public Boolean UpdateStorage(string nbr, string address, float price, float size)
        {
            Boolean updated = false;
            string query = "UPDATE Storage SET price = @price, size = @size WHERE nbr = @nbr AND address = @address";

            
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@price", SqlDbType.Float).Value = price;
            command.Parameters.Add("@size", SqlDbType.Float).Value = size;
            command.Parameters.Add("@nbr", SqlDbType.NVarChar).Value = nbr;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;


            try
            {
                
               int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    updated = true;
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                // errorHandler.HandleErrorExceptionSql(e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                // errorHandler.HandleExceptions(ex);
            }
            finally
            {
                connect.CloseConnector();
            }
            return updated;
        }

        public Boolean DeleteStorage(string nbr, string address)
        {
            Boolean deletedStorage = false;
            string query = "DELETE FROM Storage WHERE nbr = @nbr AND address = @address";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@nbr", SqlDbType.NVarChar).Value = nbr;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;

            try
            {
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    deletedStorage = true;
                }
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
            return deletedStorage;
        }

        public Boolean DeleteTenantFromStorage (string nbr, string address)
        {
            Boolean deleteTenantFromStorage = false;
            string query = "DELETE Tenant FROM Storage WHERE storageNbr = @storageNbr and storageAddress = @storageAddress";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@storageNbr", SqlDbType.NVarChar).Value = nbr;
            command.Parameters.Add("@storageAddress", SqlDbType.NVarChar).Value = address;

            try
            {
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    deleteTenantFromStorage = true;
                }
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
            return deleteTenantFromStorage;
        }

        public Storage FindStorage(string nbr, string address)
        {
            string query = "SELECT * FROM Storage WHERE nbr = @nbr AND address = @address";

            SqlCommand command = new SqlCommand(query, connection);
            Storage storage = new Storage();

            command.Parameters.Add("@nbr", SqlDbType.NVarChar).Value = nbr;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    storage.Nbr = reader.GetString(1);
                    storage.Price = reader.GetFloat(2);
                    storage.Size = reader.GetFloat(3);
                    storage.Address = reader.GetString(4);
                   
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                //errorHandler.HandleErrorExceptionSql(e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //errorHandler.HandleExceptions(ex);
            }
            finally
            {
                connect.CloseConnector();
            }
            return storage;
        }

    }

         }
     

   

