using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using ProgramKonstruktion;

namespace WebAppERP
{
    /// <summary>
    /// Summary description for WebServiceERP12
    /// </summary>
    [WebService(Namespace = "http://grupp2.ics.lu.se/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceERP12 : System.Web.Services.WebService
    {


        EmployeeDAL employeeDal = new EmployeeDAL();
        DataTable dt = new DataTable(); 


        [WebMethod]
        public Employee CreateEmployee(string no, string FirstName, string lastName, string jobTitle, string address, string phoneNumber, string email, string ssn)
        {
            Employee employee = new Employee();
            employee.No = no;
            employee.FirstName = FirstName;
            employee.LastName = lastName;
            employee.JobTitle = jobTitle;
            employee.Address = address;
            employee.PhoneNumber = phoneNumber;
            employee.Email = email;
            employee.Ssn = ssn;

            return employeeDal.CreateEmployee(employee);
        }

        [WebMethod]
        public Employee FindEmployee(string no)
        {
            Employee e = employeeDal.FindEmployee(no);
            return e;
        }

        [WebMethod]
        public Employee UpdateEmployee(string no, string firstName, string lastName, string jobTitle, string address, string phoneNumber, string email)
        {
            Employee employee = new Employee();

            employee.No = no;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.JobTitle = jobTitle;
            employee.Address = address;
            employee.PhoneNumber = phoneNumber;
            employee.Email = email;

            return employeeDal.UpdateEmployee(no, firstName, lastName, jobTitle, address, phoneNumber, email);

        }

        [WebMethod]
        public Boolean DeleteEmployee(string no)
        {
            Boolean deleted = employeeDal.DeleteEmployee(no);

            return deleted;
        }


        //Methods for collecting metadata from CRONUS database

        [WebMethod]
        public DataTable ShowContentOfCronus()
        {
            DataTable content = employeeDal.ShowContentOfCronus();

            return content;

        }


        //New webmethods from Tove  
        [WebMethod]
        public List<String> EmployeeAndRelatives()
        {
            dt = employeeDal.EmployeeAndRelatives();
            List<String> tableList = new List<string>(); 
            foreach(DataRow r in dt.Rows)
            {
                string value = ""; 
                foreach(DataColumn c in dt.Columns)
                {
                    value += r[c].ToString() + " | "; 
                }
                tableList.Add(value); 
            }
            return tableList; 
        }

        [WebMethod]
        public List<String> ShowSickEmployees2004()
        {
            dt = employeeDal.EmployeeAndRelatives();
            List<String> tableList = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string value = "" + ""+ ""+ ""+ "";
                foreach (DataColumn c in dt.Columns)
                {
                    value += r[c].ToString() + " | ";
                }
                tableList.Add(value);
            }
            return tableList;
        }

        [WebMethod]
        public List<String> AllKeys()
        {
            dt = employeeDal.EmployeeAndRelatives();
            List<String> tableList = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string value = "" + "" + "";
                foreach (DataColumn c in dt.Columns)
                {
                    value += r[c].ToString() + " | ";
                }
                tableList.Add(value);
            }
            return tableList;
        }

        [WebMethod]
        public List<String> ShowContentOfCronusDataTable()
        {
            dt = employeeDal.EmployeeAndRelatives();
            List<String> tableList = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string value = "" + "" + "";
                foreach (DataColumn c in dt.Columns)
                {
                    value += r[c].ToString() + " | ";
                }
                tableList.Add(value);
            }
            return tableList;
        }

        [WebMethod]
        public List<String> MostAbsentEmployees()
        {
            dt = employeeDal.EmployeeAndRelatives();
            List<String> tableList = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string value = "" + "" + "";
                foreach (DataColumn c in dt.Columns)
                {
                    value += r[c].ToString() + " | ";
                }
                tableList.Add(value);
            }
            return tableList;
        }

        [WebMethod]
        public List<String> AllIndexes()
        {
            dt = employeeDal.EmployeeAndRelatives();
            List<String> tableList = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string value = "" + "" + ""+"";
                foreach (DataColumn c in dt.Columns)
                {
                    value += r[c].ToString() + " | ";
                }
                tableList.Add(value);
            }
            return tableList;
        }

        [WebMethod]
        public List<String> AllTableConstrains()
        {
            dt = employeeDal.EmployeeAndRelatives();
            List<String> tableList = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string value = ""+""+""+ ""+""+ ""+""+""+"";
                foreach (DataColumn c in dt.Columns)
                {
                    value += r[c].ToString() + " | ";
                }
                tableList.Add(value);
            }
            return tableList;
        }

        [WebMethod]
        public List<String> AllTablesInDatabaseSolOne()
        {
            dt = employeeDal.EmployeeAndRelatives();
            List<String> tableList = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string value = "" + "" + "" + "";
                foreach (DataColumn c in dt.Columns)
                {
                    value += r[c].ToString() + " | ";
                }
                tableList.Add(value);
            }
            return tableList;
        }

        [WebMethod]
        public DataTable AllTablesInDatabaseSolTwo()
        {
            dt = employeeDal.EmployeeAndRelatives();
            List<String> tableList = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string value = "" + "" + "" + "";
                foreach (DataColumn c in dt.Columns)
                {
                    value += r[c].ToString() + " | ";
                }
                tableList.Add(value);
            }
            return tableList;
        }

        [WebMethod]
        public DataTable AllColEmpTableSolOne()
        {
            dt = employeeDal.EmployeeAndRelatives();
            List<String> tableList = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string value = "" ;
                foreach (DataColumn c in dt.Columns)
                {
                    value += r[c].ToString() + " | ";
                }
                tableList.Add(value);
            }
            return tableList;
        }

        [WebMethod]
        public DataTable AllColEmpTableSolTwo()
        {
            dt = employeeDal.EmployeeAndRelatives();
            List<String> tableList = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string value = ""+"";
                foreach (DataColumn c in dt.Columns)
                {
                    value += r[c].ToString() + " | ";
                }
                tableList.Add(value);
            }
            return tableList;
        }


        /*
        [WebMethod]
        public DataTable ShowSickEmployees2004()
        {
            DataTable sickEmp = employeeDal.ShowSickEmployees2004();
            return sickEmp; 
        }

        [WebMethod]
        public DataTable MostAbsentEmployees()
        {
            DataTable mostAbsentEmp = employeeDal.MostAbsentEmployees();
            return mostAbsentEmp; 
        }
        */

/*
        [WebMethod]
        public DataTable AllKeys()
        {
            DataTable keys = employeeDal.AllKeys();
            return keys; 
        }

        [WebMethod]
        public DataTable AllIndexes()
        {
            DataTable index = employeeDal.AllIndexes();
            return index; 
        }

        [WebMethod]
        public DataTable AllTableConstrains()
        {
            DataTable tableConstraints = employeeDal.AllTableConstrains(); 
            return tableConstraints;
        }

        [WebMethod]
        public DataTable AllTablesInDatabaseSolOne()
        {
            DataTable allTables = employeeDal.AllTablesInDatabaseSolOne();
            return allTables; 
        }

        [WebMethod]
        public DataTable AllTablesInDatabaseSolTwo()
        {
            DataTable allTables = employeeDal.AllTablesInDatabaseSolTwo(); 
            return allTables;
        }

        [WebMethod]
        public DataTable AllColEmpTableSolOne()
        {
            DataTable allEmpTables = employeeDal.AllColEmpTableSolOne(); 
            return allEmpTables;
        }

        [WebMethod]
        public DataTable AllColEmpTableSolTwo()
        {
            DataTable allEmpTables = employeeDal.AllColEmpTableSolTwo(); 
            return allEmpTables;
        }


    */




        //Webbmethod for showing what a file holds.
        [WebMethod]
        public string ShowFile(string fileName)
        {
            string location = @"C:\Users\WebServiceFile\" + fileName;
            string text = File.ReadAllText(location);
            return text;

        }




    }

}

            
    


 




   
