using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProgramKonstruktion
{
    class TenantDAL
    {
        private Connector connect = new Connector();
        private SqlConnection connection;
        private ErrorHandler errorHandler = new ErrorHandler();

        public TenantDAL() //constructor
        {
            connect = new Connector();
            connection = connect.getConnection();
        }

        //Create tenant
        public Boolean CreateTenant(Tenant tenant)
        {
            Boolean added = false;
            string query = "INSERT INTO Tenant VALUES (@ssn, @name, @phoneNbr, @email)";

            //Create command and add parameters
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = tenant.Ssn;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = tenant.Name;
            command.Parameters.Add("@phoneNbr", SqlDbType.NVarChar).Value = tenant.PhoneNbr;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = tenant.Email;

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

        public Tenant UpdateTenant(string ssn, string name, string email, string phoneNbr)
        {

            string query = "UPDATE Tenant" +
                "SET name = @name, phoneNbr = @phoneNbr, email = @email WHERE ssn = @ssn";

            Tenant tenant = new Tenant();
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = ssn;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phoneNbr", SqlDbType.NVarChar).Value = phoneNbr;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            try
            {

                command.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                errorHandler.HandleErrorExceptionSql(e);
            }
            finally
            {
                connect.CloseConnector();
            }
            return tenant;
        }


        public Boolean DeleteTenantFromStorage(string ssn)

        {
            Boolean deletedTenantFromStorage = false;

            string query = "DELETE Tenant FROM Storage WHERE tenantSsn =@ssn";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = ssn;


            try
            {

                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 1)
                {
                    deletedTenantFromStorage = true;
                }
            }
            catch (SqlException e)
            {
                errorHandler.HandleErrorExceptionSql(e);
            }
            finally
            {
                connect.CloseConnector();
            }
            return deletedTenantFromStorage;
        }

        public Boolean DeleteTenant(string ssn)
        {
            Boolean deletedTenant = false;

            string query = "DELETE Tenant WHERE ssn = @ssn";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = ssn;


            try
            {
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    deletedTenant = true;
                }
            }
            catch (SqlException e)
            {
                errorHandler.HandleErrorExceptionSql(e);
            }
            finally
            {
                connect.CloseConnector();
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
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tenant.Name = reader.GetString(1);
                    tenant.PhoneNbr = reader.GetString(2);
                    tenant.Email = reader.GetString(3);
                }
            }
            catch (SqlException e)
            {
                errorHandler.HandleErrorExceptionSql(e);
            }
            finally
            {
                connect.CloseConnector();
            }
            return tenant;
        }
    }




}