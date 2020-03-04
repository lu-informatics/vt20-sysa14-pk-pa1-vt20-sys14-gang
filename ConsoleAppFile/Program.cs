using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFile
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hej");
            WebServiceWebERP.WebServiceERP12SoapClient o = new WebServiceWebERP.WebServiceERP12SoapClient();
            //  RefService.WebServiceAssignmentSoapClient obj = new RefService.WebServiceAssignmentSoapClient();
            Console.WriteLine("Pls fill in a fileName:");
            string s = Console.ReadLine();
            Console.WriteLine(o.ShowFile(s));
            Console.ReadLine();


        }
    }
}
