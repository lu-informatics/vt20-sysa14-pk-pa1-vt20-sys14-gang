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
        private string tenantSsn; //eller om vi ska ha privat Tenant tenant
        private DateTime rentDate;

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
        public string TenantSsn
        {
            get => tenantSsn;
            set => tenantSsn = value;
        }
        public DateTime RentDate
        {
            get => rentDate;
            set => rentDate = value;
        }


    }
}
