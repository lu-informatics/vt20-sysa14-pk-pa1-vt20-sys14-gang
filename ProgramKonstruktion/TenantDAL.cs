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

        public TenantDAL() //constructor
        {
            connect = new Connector();
            connection = connect.Connection;
        }

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
                MessageBox.Show(e.Message);
                // errorHandler.HandleErrorExceptionSql(e);
            }
            catch (Exception ex)
            {
                errorHandler.HandleExceptions(ex);
            }
            finally
            {
                connect.CloseConnector(connection);
            }
            return tenantBookings;


        }



        //Create tenant
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
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                //   errorHandler.HandleErrorExceptionSql(e);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connect.CloseConnector(connection);
            }
            return added;
        }

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
                MessageBox.Show(e.Message);
                // errorHandler.HandleErrorExceptionSql(e);
                return null;
            }
            catch (Exception ex)
            {
                errorHandler.HandleExceptions(ex);
                return null;
            }
            finally
            {
                connect.CloseConnector(connection);
            }
            return tenant;
        }

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
                MessageBox.Show(e.Message);
                //errorHandler.HandleErrorExceptionSql(e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                // errorHandler.HandleExceptions(ex);
            }
            finally
            {
                connect.CloseConnector(connection);
            }
            return deletedTenant;

        }

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
                    // tenant.StorageAddress = reader.GetString(6);
                }
            }
            catch (SqlException e)
            {
                // errorHandler.HandleErrorExceptionSql(e);
                MessageBox.Show(e.Message);
            }
            catch (Exception ex)
            {
                //errorHandler.HandleExceptions(ex);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.CloseConnector(connection);

            }

            return tenant;

        }


        public DataTable findTenants(string ssn)
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
                MessageBox.Show(e.Message);
                // errorHandler.HandleErrorExceptionSql(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {

                connect.CloseConnector(connection);
            }
            return dtTenant;
                }

            }
        }