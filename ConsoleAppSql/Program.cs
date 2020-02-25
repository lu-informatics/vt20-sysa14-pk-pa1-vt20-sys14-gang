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
            SqlServiceReference.SqlWebServiceSoapClient obj = new SqlServiceReference.SqlWebServiceSoapClient();
            Console.WriteLine("Pls fill in a fileName:"); 
            string s = Console.ReadLine();
            Console.WriteLine(obj.Showfile(s));
            Console.Read
        }
    }
}
