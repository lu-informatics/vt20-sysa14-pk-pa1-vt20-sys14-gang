using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    class Storage
    {
        private int storageNbr;
        private double price;
        private double size;
        private string address;
       
        public int StorageNumber
        {
            get => storageNbr;
            set => storageNbr = value;

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
