﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
   public class ErrorHandler

    {

        public String HandleExceptions(Exception e)
        {

            return "Error, try again!";

        }
        public String HandleErrorExceptionSql(SqlException e)
        {
            switch (e.Number)
            {
                case 2627: //two entrys with same primary key
                    return "This object is already in the database";
                    break;

                case 515: //nullerror
                    return "Null exception";
                    break;

                case 0:
                    return "Error connecting to the server";
                    break;

                case 4060:
                    return "Error connecting to database";
                    break;

                default:
                    return "Unknown error";
            }

        }
    }
}