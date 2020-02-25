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
            Application.Run(new GUI());

            /* tenant.Email = "hej@";
             tenant.Name = "hej";
             tenant.PhoneNbr = "00";
             tenant.Ssn = "99";
             tenant.StorageAddress = "Andgatan 101";
            tenant.StorageNbr = "2";
             tenant.RentDate = new DateTime(2009,06,01);
            dal2.CreateTenant(tenant);
            Console.WriteLine(tenant); /* //createTenant saknas!!
                                           /*Tenant t = dal2.FindTenant("999");
                                           Console.WriteLine(t.Name);*/





            StorageDAL dal2 = new StorageDAL();
           List<Storage> listOfAS = dal2.listOfAvailableStorages();

            foreach(Storage s in listOfAS)
            {
                Console.WriteLine(s.Nbr);
            }
           /* Storage storage = new Storage();
            storage.Address = "Fågelvägen 1";
            storage.Nbr = "15";
            storage.Price = 9000;
            storage.Size = 56;

            dal.CreateStorage(storage);
            Console.WriteLine(storage.Address);*/



            /* TenantDAL dal = new TenantDAL();
             Tenant tenant = new Tenant();
             tenant.Ssn = "23";
             tenant.Email = "hej@gmail.com";
             tenant.PhoneNbr = "112";
             tenant.StorageNbr = "4";
             tenant.StorageAddress = storage.Address;
              DateTime value = new DateTime(2018, 1, 10);
              tenant.RentDate = value;
             dal.CreateTenant(tenant);*/


            // Tenant finded = dal.FindTenant("23");
            // Console.WriteLine(finded.Ssn);


        }
    }
}
