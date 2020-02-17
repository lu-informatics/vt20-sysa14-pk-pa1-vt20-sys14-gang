using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    class Tenant
    {

        private string ssn;
        private string name;
        private string phoneNbr;
        private string email;
      

        public string Ssn {
            get => ssn;
            set => ssn = value;
        }
        public string Name {
            get => name;
            set => name = value;
        }
        public string PhoneNumber {
            get => phoneNbr;
            set => phoneNbr = value;
        }
        public string EmailAddress {
            get => email;
            set => email = value;
        }
       
    }
}
