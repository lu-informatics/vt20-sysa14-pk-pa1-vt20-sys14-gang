using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ProgramKonstruktion; 

namespace SqlWebApplication
{
    /// <summary>
    /// Summary description for SqlWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
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
        public Tenant UpdateTenant(string ssn, string name, string phoneNbr, string email)
        {
            return tenantDAL.UpdateTenant(ssn, name, phoneNbr, email); 


        }
       


        [WebMethod]
        public bool CreateTenant(string ssn, string name, string phoneNbr, string email, string storageNbr, DateTime rentDate, string storageAddrress)
        {
            Tenant t = new Tenant();
            t.Name = name;
            t.Ssn = ssn;
            t.PhoneNbr = phoneNbr;
            t.Email = email;
            t.StorageNbr = storageNbr;
            t.RentDate = rentDate;
            t.StorageAddress = storageAddrress; 
            return tenantDAL.CreateTenant(t);

            


        }
       

    }
}
