using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    class Storage
    {
        private string nbr;
        private double price;
        private double size;
        private string address;

        public string Nbr
        {
            get => Nbr;
            set => Nbr = value;

        }
        public double Price
        {
            get => price;
            set => price = value;
        }
        public double Size
        {
            get => size;
            set => size = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
       

    }
}
