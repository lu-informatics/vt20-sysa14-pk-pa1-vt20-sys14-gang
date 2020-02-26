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
    public class EmployeeDAL
    {
        private ConnectorForCronus connect = new ConnectorForCronus();
        private SqlConnection connection;

        public EmployeeDAL()
        { //constructor

            connect = new ConnectorForCronus();
            connection = connect.Connection;
        }

        public List<Employee> GetEmployees()
        {

            List<Employee> getListOfEmployees = new List<Employee>();

            string query = "SELECT * FROM [CRONUS Sverige AB$Employee]";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee();

                    {
                        employee.No = reader.GetString(1);
                        employee.FirstName = reader.GetString(2);
                        employee.LastName = reader.GetString(4);
                        employee.JobTitle = reader.GetString(6);
                        employee.Address = reader.GetString(8);
                        employee.PhoneNumber = reader.GetString(13);
                        employee.Email = reader.GetString(16);
                        employee.Ssn = reader.GetString(22);

                    }
                    getListOfEmployees.Add(employee);

                }
                reader.Close();

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            catch (Exception e)
            {

            }

            finally
            {
                connect.CloseConnector(connection);
            }

            return getListOfEmployees;

        }

        public Employee CreateEmployee(Employee employee)
        {

            string query = "INSERT INTO [CRONUS Sverige AB$Employee] ([No_], [First Name], [Last Name], [Job Title], [Address], [Phone No_], [E-Mail], [Social Security No_]) VALUES (@No, @FirstName, @LastName, @JobTitle, @Address, @PhoneNumber, @Email, @Ssn)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@No", SqlDbType.NVarChar).Value = employee.No;
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employee.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employee.LastName;
            command.Parameters.Add("@JobTitle", SqlDbType.NVarChar).Value = employee.JobTitle;
            command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = employee.Address;
            command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = employee.PhoneNumber;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = employee.Email;
            command.Parameters.Add("@Ssn", SqlDbType.NVarChar).Value = employee.Ssn;

            try
            {
                connection.Open();
                int affectedRows = command.ExecuteNonQuery();
                employee.No = "HEJ";


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                //  MessageBox.Show(e.Message);
                //errorhandling?

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //  MessageBox.Show(e.Message);
            }
            finally
            {
                connect.CloseConnector(connection);
            }
            return employee;
        }

        public Employee FindEmployee(string no)
        {

            string query = "SELECT [Last Name], [Job Title], [E-Mail] FROM [CRONUS Sverige AB$Employee] WHERE[No_] = @No";

            SqlCommand command = new SqlCommand(query, connection);
            Employee employee = new Employee();

            command.Parameters.Add("@No", SqlDbType.NVarChar).Value = no;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employee.LastName = reader.GetString(0);
                    employee.JobTitle = reader.GetString(1);
                    employee.Email = reader.GetString(2);

                }
            }
            catch (SqlException e)
            {
                // MessageBox.Show(e.Message);

            }
            catch (Exception e)
            {

            }
            finally
            {
                connect.CloseConnector(connection);
            }
            return employee;
        }

        public Employee UpdateEmployee(string no, string firstName, string lastName, string jobTitle, string address, string phoneNumber, string email)
        {

            string query = "UPDATE [CRONUS Sverige AB$Employee] SET [First Name] = @FirstName, [Last Name] = @LastName, [Job Title] = @JobTitle, [Address] = @Address, [Phone No_] = @PhoneNumber, [E-Mail] = @Email WHERE [No_] = @No";

            Employee employee = new Employee();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstName;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName;
            command.Parameters.Add("@JobTitle", SqlDbType.NVarChar).Value = jobTitle;
            command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = phoneNumber;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@No", SqlDbType.NVarChar).Value = no;


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.JobTitle = jobTitle;
                employee.Address = address;
                employee.PhoneNumber = phoneNumber;
                employee.Email = email;
                employee.No = no;


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
                connect.CloseConnector(connection);
            }
            return employee;
        }

        public Boolean DeleteEmployee(string no)
        {
            Boolean deleted = false;
            string query = "DELETE FROM [CRONUS Sverige AB$Employee] WHERE [No_] = @No";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@No", SqlDbType.NVarChar).Value = no;

            try
            {
                connection.Open();

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 1)
                {
                    deleted = true;
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
                connect.CloseConnector(connection);
            }
            return deleted;
        }


        public List<Tenant> listOfTenantSsn()
        {
            List<Tenant> getListOfTenantSsn = new List<Tenant>();
            string query = "Select ssn FROM Tenant";

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
                    }
                    getListOfTenantSsn.Add(tenant);
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
                connect.CloseConnector(connection);

            }
            return getListOfTenantSsn;
        }

    }
}
