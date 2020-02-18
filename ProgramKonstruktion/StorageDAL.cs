using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProgramKonstruktion
{
    class StorageDAL
    {
        private Connector c = new Connector();
        private SqlConnection SqlConnection;

        public StorageDAL() //constructor
        {
            c = new Connector();
            SQLConnection = c.connection;
        }
        public Storage CreateStorage (Storage storage)
        { 
            
            string queryCreateStorage = "INSERT INTO (@storageNbr, @price, @size, @address)"; 
            SqlCommand command = new SqlCommand(queryCreateStorage, SqlConnection); 
            
            command.Parameters.Add("@storageNbr", SqLDbType.Int).Value = storage.StorageNbr; 
            command.Parameters.Add("@price", SqLDbType.Int).Value = storage.Price;
            command.Parameters.Add("@size", SqLDbType.Double).Value = storage.Size;
            command.Parameters.Add("@address", SqLDbType.NVarChar).Value = storage.address;

            try 
            {
                command.Connection.Open(); 
                command.ExecuteNonQuery(); //används för att vi inte returnerar någon data från SQL
            }
        }
        
    }
}
