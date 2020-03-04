using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    public class Employee
    {
        private string no;
        private string firstName;
        private string lastName;
        private string jobTitle;
        private string address;
        private string phoneNumber;
        private string ssn;
        private string email;


        public Employee()
        {

        }

        public string No
        {
            get => no;
            set => no = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;

        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string JobTitle
        {
            get => jobTitle;
            set => jobTitle = value;
        }

        public string Address
        {
            get => address;
            set => address = value;

        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string Ssn
        {
            get => ssn;
            set => ssn = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }
    }
}