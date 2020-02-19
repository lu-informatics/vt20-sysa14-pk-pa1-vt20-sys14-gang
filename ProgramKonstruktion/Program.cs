using System;
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
            Application.Run(new Form1());

            Connector c = new Connector();


            TenantDAL dal = new TenantDAL();
            Tenant tenant = new Tenant();
            tenant.Ssn = "23";
            tenant.Email = "hej@gmail.com";
            tenant.PhoneNbr = "112";
            tenant.StorageNbr = "5";
            tenant.StorageAddress = "Flodavägen 1";
            DateTime value = new DateTime(2018, 1, 10);
           tenant.RentDate = value;
            dal.CreateTenant(tenant);
           // Tenant finded = dal.FindTenant("23");
           // Console.WriteLine(finded.Ssn);

           
        }
    }
}
