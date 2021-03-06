﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramKonstruktion
{
    public class StorageDAL
    {
        private Connector connect = new Connector();
        private SqlConnection connection;
        private ErrorHandler errorHandler = new ErrorHandler();

        //constructor
        public StorageDAL()
        {

            connect = new Connector();
            connection = connect.Connection;
        }

        //Get allStorages 
        public List<Storage> GetListOfStorages()
        {
            List<Storage> getListOfStorages = new List<Storage>();
            string query = "SELECT * FROM Storage";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {
                    Storage storage = new Storage();
                    {
                        storage.Nbr = reader.GetString(0);
                        storage.Price = (float)reader.GetSqlDouble(1);
                        storage.Size = (float)reader.GetSqlDouble(2);
                        storage.Address = reader.GetString(3);

                    }
                    getListOfStorages.Add(storage);
                }
                reader.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(errorHandler.HandleErrorExceptionSql(e));
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorHandler.HandleExceptions(ex));

            }
            finally
            {
                connect.CloseConnector(connection);


            }
            return getListOfStorages;
        }

        //All available storages
        public List<Storage> listOfAvailableStorages()
        {
            List<Storage> getListOfAvailableStorages = new List<Storage>();
            string query = "Select nbr FROM Storage WHERE NOT EXISTS(Select storageNbr FROM Tenant WHERE nbr = storageNbr)";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    Storage storage = new Storage();
                    {
                        storage.Nbr = reader.GetString(0);
                    }
                    getListOfAvailableStorages.Add(storage);
                }
                reader.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(errorHandler.HandleErrorExceptionSql(e));
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorHandler.HandleExceptions(ex));

            }
            finally
            {
                connect.CloseConnector(connection);

            }
            return getListOfAvailableStorages;
        }


        //Create Storage
        public Boolean CreateStorage(Storage storage)
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
                connection.Open();
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
            catch (Exception ex)
            {

               
                errorHandler.HandleExceptions(ex);


            }
            finally
            {
                connect.CloseConnector(connection);
            }
            return added;
        }

        //Update Storage
        public Storage UpdateStorage(string nbr, string address, float price, float size)
        {

            string query = "UPDATE Storage SET price = @price, size = @size, address = @address WHERE nbr = @nbr"; //AND address = @address";

            Storage storage = new Storage();
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@price", SqlDbType.Float).Value = price;
            command.Parameters.Add("@size", SqlDbType.Float).Value = size;
            command.Parameters.Add("@nbr", SqlDbType.NVarChar).Value = nbr;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                storage.Price = price;
                storage.Size = size;
                storage.Address = address;

            }
            catch (SqlException e)
            {
                Console.WriteLine(errorHandler.HandleErrorExceptionSql(e));
                return null;
            }
            catch (Exception ex)
            {

                Console.WriteLine(errorHandler.HandleExceptions(ex));
                return null;
            }
            finally
            {
                connect.CloseConnector(connection);
            }
            return storage;
        }

        //Delete Storage
        public Boolean DeleteStorage(string nbr)
        {
            Boolean deletedStorage = false;
            string query = "DELETE FROM Storage WHERE nbr = @nbr";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@nbr", SqlDbType.NVarChar).Value = nbr;

            try
            {

                connection.Open();
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    deletedStorage = true;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(errorHandler.HandleErrorExceptionSql(e));
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorHandler.HandleExceptions(ex));
            }
            finally
            {
                connect.CloseConnector(connection);
            }
            return deletedStorage;
        }

        //Find Storage for WebMethod
        public Storage FindStorage(string nbr)
        {
            string query = "SELECT * FROM Storage WHERE nbr = @nbr";

            SqlCommand command = new SqlCommand(query, connection);
            Storage storage = new Storage();

            command.Parameters.Add("@nbr", SqlDbType.NVarChar).Value = nbr;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    storage.Nbr = reader.GetString(0);
                    storage.Price = (float)reader.GetDouble(1);
                    storage.Size = (float)reader.GetDouble(2);
                    storage.Address = reader.GetString(3);

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(errorHandler.HandleErrorExceptionSql(e));
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorHandler.HandleExceptions(ex));
            }
            finally
            {
                connect.CloseConnector(connection);
            }
            return storage;
        }

        //Find Storage in dataGrid
        public DataTable FindStorages(string nbr)
        {
            DataTable dtStorage = new DataTable();
            Tenant tenant = new Tenant();

            string query = "SELECT* FROM Storage WHERE nbr = @nbr";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@nbr", SqlDbType.NVarChar).Value = nbr;

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dtStorage.Load(reader);
            }
            catch (SqlException e)
            {
                Console.WriteLine(errorHandler.HandleErrorExceptionSql(e));
            }
            catch (Exception ex)
            {
                Console.WriteLine(errorHandler.HandleExceptions(ex));
            }

            finally
            {

                connect.CloseConnector(connection);
            }
            return dtStorage;
        }

        //Show all storages in dataGrid
        public DataTable ShowAllStorages()
        {
            DataTable dtStorages = new DataTable();
            string query = "SELECT * FROM STORAGE";

            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        dtStorages.Load(reader);
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(errorHandler.HandleErrorExceptionSql(e));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(errorHandler.HandleExceptions(ex));
                    }

                    finally
                    {

                        connect.CloseConnector(connection);
                    }
                    return dtStorages;
                }

            }

        }
    }
}

   

