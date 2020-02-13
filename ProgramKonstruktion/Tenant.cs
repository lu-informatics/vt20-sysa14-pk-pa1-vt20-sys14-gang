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
        private string phoneNumber;
        private string emailAddress;
        private DateTime rentingDate;

        public string Ssn {
            get => ssn;
            set => ssn = value;
        }
        public string Name {
            get => name;
            set => name = value;
        }
        public string PhoneNumber {
            get => phoneNumber;
            set => phoneNumber = value;
        }
        public string EmailAddress {
            get => emailAddress;
            set => emailAddress = value;
        }
        public DateTime RentingDate {
            get => rentingDate;
            set => rentingDate = value;
        }
    }
}
