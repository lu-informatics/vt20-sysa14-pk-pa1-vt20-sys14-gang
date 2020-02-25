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
            Console.WriteLine("Skriv in ett ssn: ");
            string s = Console.ReadLine();
            Tenant t = service.FindTenant(s);
            Console.WriteLine("Name:{0}n/ PhoneNumber:{1}n/ Ssn:{2}n/ StorageNbr:{3}n/", t.Name, t.PhoneNbr, t.Ssn, t.StorageAddress, t.StorageNbr); 
            Console.ReadLine(); 
            


        }
    }
}
