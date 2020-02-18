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
        private SqlConnection SQLConnection;
        private ErrorHandler errorHandler = new ErrorHandler();

        public TenantDAL() //constructor
        {
            connect = new Connector();
            SQLConnection = connect.connection;

        }

        //Create tenant
        public Tenant CreateTenant (Tenant tenant) 
        {
            string query = "INSERT INTO Tenant VALUES (@ssn, @name, @phoneNbr, @email)";

            //Create command and add parameters
            SqlCommand command = new SqlCommand(query, SQLConnection);
            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = tenant.Ssn;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = tenant.Name;
            command.Parameters.Add("@phoneNbr", SqlDbType.NVarChar).Value = tenant.PhoneNbr;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = tenant.Email;

            try
            {
                command.Connection.Open();
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
          
        public Tenant UpdateTenant (Tenant tenant)
        {
            string query = "UPDATE Tenant" +
                "SET ssn = @ssn, name = @name, phoneNbr = @phoneNbr, email = @email WHERE ssn = @ssn";

            SqlCommand command = new SqlCommand(query, SQLConnection);

            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = tenant.Ssn;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = tenant.Name;
            command.Parameters.Add("@phoneNbr", SqlDbType.NVarChar).Value = tenant.PhoneNbr;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = tenant.Email;

            try
            {
                command.Connection.Open();
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
    

    public Tenant DeleteTenantFromStorage(Tenant tenant)
    {
        string query = "DELETE Tenant FROM Storage WHERE tenantSsn = @ssn"; //tenant.ssn?

        SqlCommand command = new SqlCommand(query, SQLConnection);

        command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = tenant.Ssn;
        

        try
        {
            command.Connection.Open();
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

        public Tenant DeleteTenant(Tenant tenant)
        {
            string query = "DELETE Tenant WHERE ssn = @ssn"; //tenant.ssn?

            SqlCommand command = new SqlCommand(query, SQLConnection);

            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = tenant.Ssn;


            try
            {
                command.Connection.Open();
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

        public Tenant FindTenant (Tenant tenant)
        {
            string query = "SELECT * FROM Tenant WHERE ssn = @ssn"; //tenant.ssn?

            SqlCommand command = new SqlCommand(query, SQLConnection);

            command.Parameters.Add("@ssn", SqlDbType.NVarChar).Value = tenant.Ssn;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = tenant.Name;
            command.Parameters.Add("@phoneNbr", SqlDbType.NVarChar).Value = tenant.PhoneNbr;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = tenant.Email;

            try
            {
                command.Connection.Open();
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
    }

        


    }

