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

            Console.ReadLine(); 
            


        }
    }
}
