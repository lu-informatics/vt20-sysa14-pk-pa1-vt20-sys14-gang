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
        private Connector c = new Connector();
        private SqlConnection SQLConnection;
        private ErrorHandler eh = new ErrorHandler();

        public TenantDAL() //constructor
        {
            c = new Connector();
            SQLConnection = c.connection;

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
                eh.HandleErrorExceptionSql(e);
            }
            finally
            {
                c.CloseConnector();
            }
            return tenant;
            }
          
        public Tenant UpdateTenant (Tenant tenant)
        {
            string query = "UPDATE Tenant" +
                "SET ssn = @ssn, name = @name, phoneNbr = @phoneNbr, email = @email WHERE ssn = " + tenant.Ssn;

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
                eh.HandleErrorExceptionSql(e);
            }
            finally
            {
                c.CloseConnector();
            }
            return tenant;
        }
    }
        



    }
}
