﻿using ProgramKonstruktion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace ERP1WebApplication
{
    /// <summary>
    /// Summary description for ERP1WebService
    /// </summary>
    [WebService(Namespace = "http://grupp2.ics.lu.se/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ERP1WebService : System.Web.Services.WebService
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

        [WebMethod]
        public DataTable ShowContentOfCronus()
        {
            DataTable content = employeeDal.ShowContentOfCronus();
            

            return content;


        }

        }

        }