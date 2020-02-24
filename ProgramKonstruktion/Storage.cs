using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    public class Storage
    {
        private string nbr;
        private float price;
        private float size;
        private string address;

       public Storage (string nbr, float price, float size, string address)
        {
            this.nbr = nbr;
            this.price = price;
            this.size = size;
            this.address = address;

        }
        
        public Storage()
        {

        }
        public string Nbr
        {
            get => nbr;
            set => nbr = value;

        }
        public float Price
        {
            get => price;
            set => price = value;
        }
        public float Size
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
