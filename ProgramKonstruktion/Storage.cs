﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    class Storage
    {
        private int storageNumber;
        private double price;
        private double size;
        private string address;

        public int StorageNumber {
            get => storageNumber;
            set => storageNumber = value;

        }
        public double Price {
            get => price;
            set => price = value;
        }
        public double Size {
            get => size;
            set => size = value;
        }
        public string Address {
            get => address;
            set => address = value;
        }
    }
}
