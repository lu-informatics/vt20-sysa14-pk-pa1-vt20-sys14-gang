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

        public StorageDAL()
        { //constructor

            connect = new Connector();
            connection = connect.getConnection();
        }

        //VARFÖR I HELVETE FUNGER AR INTE DENNA?!??!?!?!?!
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
                        storage.Nbr = reader.GetString(0);
                        storage.Price = reader.GetFloat(1);
                        storage.Size = reader.GetFloat(2);
                        storage.Address = reader.GetString(3);

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
                connect.CloseConnector();


            }
            return getListOfStorages;
        }

        public List<Storage> listOfAvailableStorages()
        {
            List<Storage> getListOfAvailableStorages = new List<Storage>();
            string query = "Select nbr, address FROM Storage WHERE NOT EXISTS( Select storageNbr, storageAddress FROM Tenant WHERE nbr = storageNbr AND address = storageAddress)";

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
                        storage.Address = reader.GetString(1);
                    }
                    getListOfAvailableStorages.Add(storage);
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
                connect.CloseConnector();

            }
            return getListOfAvailableStorages;
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

               
                // errorHandler.HandleExceptions(e);
            }
            finally
            {
                connect.CloseConnector();
                connection.Close();
            }
            return added;
        }

        public Storage UpdateStorage(string nbr, string address, float price, float size)
        {
           
            string query = "UPDATE Storage SET price = @price, size = @size WHERE nbr = @nbr AND address = @address";

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
                storage.Nbr = nbr;
                storage.Address = address;
                     

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                // errorHandler.HandleErrorExceptionSql(e);
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                // errorHandler.HandleExceptions(ex);
                return null;
            }
            finally
            {
                connect.CloseConnector();
            }
            return storage;
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

                connection.Open();
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    deletedStorage = true;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.CloseConnector();
                connection.Close();
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
                connection.Open();
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
                connection.Close();
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
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   storage.Address = reader.GetString(3);
                   storage.Nbr = reader.GetString(0);
                   storage.Price = (float) reader.GetDouble(1);
                   storage.Size = (float) reader.GetDouble(2);

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
                connection.Close();
            }
            return storage;
        }

    }

         }
     

   

