using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    class EmployeeDAL
    {

        private Connector connect = new Connector();
        private SqlConnection connection;
        

        public EmployeeDAL()
        { //constructor

            connect = new Connector();
            connection = connect.Connection;
        }

        public List<Employee> GetEmployees()
        {
            return null;
        }


    }
}
