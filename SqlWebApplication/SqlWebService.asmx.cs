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
        public Tenant UpdateTenant(string ssn, string name, string phoneNbr, string email)
        {
            return tenantDAL.UpdateTenant(ssn, name, phoneNbr, email); 

        }
       
        [WebMethod]
        public bool CreateTenant(string ssn, string name, string phoneNbr, string email, string storageNbr, DateTime rentDate)
        {
            Tenant t = new Tenant();
            t.Name = name;
            t.Ssn = ssn;
            t.PhoneNbr = phoneNbr;
            t.Email = email;
            t.StorageNbr = storageNbr;
            t.RentDate = rentDate;
            return tenantDAL.CreateTenant(t);

        }

        [WebMethod]
        public Boolean DeleteTenant(string ssn)
        {
            return tenantDAL.DeleteTenant(ssn); 
        }

        [WebMethod]
        public Tenant FindTenant(string ssn)
        {
            return tenantDAL.FindTenant(ssn);
        }

        
       

        // Starting with Storage methods

        [WebMethod]
        public Boolean CreateStorage(string nbr, float price, float size, string address)
        {
            Storage s = new Storage();
            s.Nbr = nbr;
            s.Price = price;
            s.Size = size; 
            s.Address = address;
            return storageDAL.CreateStorage(s);

        }

        [WebMethod]
        public Storage UpdateStorage(string nbr, string address, float price, float size)
        {
            return storageDAL.UpdateStorage(nbr, address, price, size);
        }

        [WebMethod]
        public Boolean DeleteStorage(string nbr)
        {
            return storageDAL.DeleteStorage(nbr);
        }

        [WebMethod]
        public Boolean DeleteTenantFromStorage(string nbr)
        {
            return storageDAL.DeleteTenantFromStorage(nbr);
        }

        [WebMethod]
        public Storage FindStorage(string nbr)
        {
            return storageDAL.FindStorage(nbr);
        }

    }
}
