using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    class StorageDAL
    {
        private Connector c = new Connector();
        private SqlConnection SQLConnection;

        public StorageDAL() //constructor
        {
            c = new Connector();
            SQLConnection = c.connection;
        }
        public Storage CreateStorage { 
            
            string queryCreateStorage = "INSERT INTO (@storageNbr, @price, @size, @address)"; 
            SQLcommand command = new SQLcommand(queryCreateStorage, SQLConnection); 
            
            command.parameters.Add("@storageNbr", SQLDbType.NInt32).Value=storage.storageNbr; 

        }
}
    }
}
