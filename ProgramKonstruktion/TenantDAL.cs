using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProgramKonstruktion
{
    public class TenantDAL
    {
        private Connector connect = new Connector();
        private SqlConnection connection;
        private ErrorHandler errorHandler = new ErrorHandler();

        //constructor
        public TenantDAL()
        {
            connect = new Connector();
            connection = connect.Connection;
        }

        //Get all Bookings 
        public List<Tenant> GetTenantBookings()
        {
            List<Tenant> tenantBookings = new List<Tenant>();
            string query = "Select * FROM Tenant";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {

                    Tenant tenant = new Tenant();
                    {
                        tenant.Ssn = reader.GetString(0);
                        tenant.Name = reader.GetString(1);
                        tenant.PhoneNbr = reader.GetString(2);
                        tenant.Email = reader.GetString(3);
                        tenant.StorageNbr = reader.GetString(4);
                        tenant.RentDate = reader.GetDateTime(5);

                    }

                    tenantBookings.Add(tenant);
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
            return tenantBookings;


        }

        //Create new Booking for Tenant
        public Boolean CreateTenant(Tenant tenant)
        {
            Boolean added = false;
            string query = "INSERT INTO Tenant VALUES (@ssn, @name, @phoneNbr, @email, @storageNbr, @rentDate)";

            //Create command and add parameters
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = tenant.Ssn;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = tenant.Name;
            command.Parameters.Add("@phoneNbr", SqlDbType.NVarChar).Value = tenant.PhoneNbr;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = tenant.Email;
            command.Parameters.Add("@storageNbr", SqlDbType.NVarChar).Value = tenant.StorageNbr;
            command.Parameters.Add("@rentDate", SqlDbType.Date).Value = tenant.RentDate;

            try
            {
                connection.Open();
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 1)
                {
                    added = true;
                }
                else
                {
                    added = false;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(errorHandler.HandleErrorExceptionSql(e));
            }

            catch (Exception e)
            {
                Console.WriteLine(errorHandler.HandleExceptions(e));
            }
            finally
            {
                connect.CloseConnector(connection);
            }
            return added;
        }

        //Update Booking Information
        public Tenant UpdateTenant(string ssn, string name, string phoneNbr, string email)
        {

            string query = "UPDATE Tenant SET name = @name, phoneNbr = @phoneNbr, email = @email WHERE ssn = @ssn";

            Tenant tenant = new Tenant();
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phoneNbr", SqlDbType.NVarChar).Value = phoneNbr;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = ssn;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                tenant.Name = name;
                tenant.PhoneNbr = phoneNbr;
                tenant.Email = email;
                tenant.Ssn = ssn;
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
            return tenant;
        }

        //Delete Booking/Tenant for WebMethods
        public Boolean DeleteTenant(string ssn)
        {
            Boolean deletedTenant = false;

            string query = "DELETE FROM Tenant WHERE ssn = @ssn";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = ssn;

            try
            {
                connection.Open();
                int affectedRows = command.ExecuteNonQuery();


                if (affectedRows == 1)
                {
                    deletedTenant = true;

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
            return deletedTenant;

        }

        //Find Booking/Tenant for WebMethods
        public Tenant FindTenant(string ssn)
        {
            string query = "SELECT * FROM Tenant WHERE ssn = @ssn";

            SqlCommand command = new SqlCommand(query, connection);
            Tenant tenant = new Tenant();

            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = ssn;

            try
            { 
            
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tenant.Ssn = reader.GetString(0);
                    tenant.Name = reader.GetString(1);
                    tenant.PhoneNbr = reader.GetString(2);
                    tenant.Email = reader.GetString(3);
                    tenant.StorageNbr = reader.GetString(4);
                    tenant.RentDate = reader.GetDateTime(5);
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

            return tenant;

        }

        //Find Booking in dataGrid
        public DataTable FindTenants(string ssn)
        {
            DataTable dtTenant = new DataTable();
            Tenant tenant = new Tenant();

            string query = "SELECT* FROM Tenant WHERE ssn = @ssn";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = ssn;

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dtTenant.Load(reader);
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
            return dtTenant;
                }

        //ShowAllBokkings in dataGrid
        public DataTable ShowAllBookings()
        {
            DataTable dtBookings = new DataTable();
            string query = "SELECT * FROM TENANT";

            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        dtBookings.Load(reader);
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
                    return dtBookings;
                }

            }
        }

    }
        }