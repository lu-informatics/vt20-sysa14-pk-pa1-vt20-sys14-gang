using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ProgramKonstruktion;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebServiceERP1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceERP1 : System.Web.Services.WebService
    {
        EmployeeDAL employeeDal = new EmployeeDAL();

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
        public Employee FindEmployee (string no)
        {
            Employee e = employeeDal.FindEmployee(no);
            return e;
        }
    }
}
