using ProgramKonstruktion;
using SqlWebApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSql
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new SqlWebService();

            //Console.WriteLine("Skriv in ett ssn: ");
            //string s = Console.ReadLine();
            // Tenant t = service.FindTenant(s);


            List<Storage> listOfStorage = service.GetListOfStorages();
            Console.WriteLine("----- STORAGE -----");
            foreach (Storage s in listOfStorage)
            {
                Console.WriteLine("Number: {0}, Price: {1}, Size: {2}, Address: {3}", s.Nbr, Convert.ToString(s.Price), Convert.ToString(s.Size), s.Address);
            }

            List<Tenant> listOfTenants = service.GetTenantBookings();
            Console.WriteLine("----- TENANTS -----");
            foreach (Tenant t in listOfTenants)
            {
                Console.WriteLine("Ssn: {0}, Name: {1}, PhoneNbr: {2}, Email: {3}, StorageNbr: {4}, RentDate: {5}", t.Ssn, t.Name, t.PhoneNbr, t.Email, t.StorageAddress, t.RentDate);
            }

            Console.ReadLine();


        }
    }
}
