using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    class PK2TableObjects
    {
        public string TableName { get; set; }
        public int NumberOfRows { get; set; }
        public List<string> ColumnNames { get; set; }

        public PK2TableObjects(string tableNames, int numberOfRows, List<string> columnNames)
        {
            TableName = tableNames;
            NumberOfRows = numberOfRows;
            ColumnNames = columnNames;
        }

        public PK2TableObjects()
        {

        }


    }
}
