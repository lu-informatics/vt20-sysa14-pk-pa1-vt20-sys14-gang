using SqlWebApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWebService
{
    class Program
    {
        static void Main(string[] args)
        {

            RefService.WebServiceAssignmentSoapClient obj = new RefService.WebServiceAssignmentSoapClient();
            Console.WriteLine("Pls fill in a fileName:");
            string s = Console.ReadLine();
            Console.WriteLine(obj.ShowFile(s));
            Console.ReadLine(); 
            

           



        }
                
    }
}
//WebReference.WebAssignment();
// ConsoleAppWebService.RefService obj = ConsoleAppWebService.RefService(); 
//RefService.WebServiceAssignment  obj = new WebReference.WebAssignment();