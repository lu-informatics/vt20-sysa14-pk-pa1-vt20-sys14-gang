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
        private Connector conn = new Connector();
        private SqlConnection SqlConnection;
        private Errorhandler errorHandler = new ErrorHandler(); 
        
       
        //find tenant through storage 
        public StorageDAL() //constructor
        {
            conn = new Connector();
            SQLConnection = conn.connection;
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
            catch (SqlException e) {    
                
            }
            {

            }
        }
        
    }
}
