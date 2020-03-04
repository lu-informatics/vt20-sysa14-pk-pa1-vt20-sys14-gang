using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using ProgramKonstruktion; 

namespace SqlWebApplication
{
    /// <summary>
    /// Summary description for SqlWebService
    /// </summary>
    [WebService(Namespace = "http://grupp2.ics.lu.se/")] //grupp2.ics.lu.se/
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SqlWebService : System.Web.Services.WebService


    {
        Connector c = new Connector();
        StorageDAL storageDAL = new StorageDAL();
        TenantDAL tenantDAL = new TenantDAL();



        [WebMethod]
        public List<Tenant> GetTenantBookings()
        {
            return tenantDAL.GetTenantBookings();
        }

        [WebMethod]
        public DataTable ShowAllBookings()
        {
            DataTable dt = new DataTable();
            dt = tenantDAL.ShowAllBookings();
            //dt.Columns.Add("");
            //dt.Rows.Add("");
            dt.TableName = "Table Name";
            return dt;

        }     

        [WebMethod]
        public List<Storage> GetListOfStorages()
        {
            return storageDAL.GetListOfStorages();
        }

        [WebMethod]
        public Storage FindStorage(string nbr)
        {
            return storageDAL.FindStorage(nbr);
        }

        [WebMethod]
        public DataTable ShowAllStorages()
        {
            DataTable dt = new DataTable();
            dt = storageDAL.ShowAllStorages();
            dt.TableName = "Table Name";
            return dt; 
        }

          



    }
}
