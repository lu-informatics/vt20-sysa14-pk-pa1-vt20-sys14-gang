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
        private string storageNbr;
        private DateTime rentDate;
        private string storageAddress;

        public string Ssn {
            get => ssn;
            set => ssn = value;
        }
        public string Name {
            get => name;
            set => name = value;
        }
        public string PhoneNbr {
            get => phoneNbr;
            set => phoneNbr = value;
        }
        public string Email {
            get => email;
            set => email = value;
        }
        public string StorageNbr {
            get => storageNbr;
            set => storageNbr = value;
        }
        public string RentDate {
            get => rentDate;
            set => rentDate = value;
        }
        public string StorageAddress {
            get => storageAddress;
            set => storageAddress = value;
        }
    }
}
