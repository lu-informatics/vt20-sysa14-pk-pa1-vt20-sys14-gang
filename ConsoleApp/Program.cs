using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)

        {
            
            WebReference.WebAssignment1 obj = new WebReference.WebAssignment1();
            string s = Console.ReadLine(); 
            Console.WriteLine(obj.ShowFile(s));
            Console.ReadLine(); 

        }  
    }
}