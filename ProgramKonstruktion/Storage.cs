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
        private float price;
        private float size;
        private string address;
        private string tenantSsn; //eller om vi ska ha privat Tenant tenant
        private DateTime rentDate;

        public int StorageNumber
        {
            get => storageNbr;
            set => storageNbr = value;

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
