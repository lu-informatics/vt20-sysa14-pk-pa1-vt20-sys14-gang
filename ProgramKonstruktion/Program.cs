﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramKonstruktion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());

            Connector c = new Connector();

            EmployeeDAL dal = new EmployeeDAL();

            Employee emp = new Employee("SA", "Sofia", "Ander", "Chef", "Gårdsgatan", "078888", "90303", "sofia@live.se");

            dal.CreateEmployee(emp);

         
;            

         
            



        }
    }
}
