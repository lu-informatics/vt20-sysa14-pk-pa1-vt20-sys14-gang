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

        public Employee(string no, string firstName, string lastName, string jobTitle, string address, string phoneNumber, string ssn, string email)
        {
            this.no = no;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobTitle = jobTitle;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.ssn = ssn;
            this.email = email;
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