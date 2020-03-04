using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKonstruktion
{
    class Controller
    {

        private TenantDAL tenantDal = new TenantDAL();
        private StorageDAL storageDal = new StorageDAL();
        private EmployeeDAL employeeDal = new EmployeeDAL();


        public Boolean CreateTenant(Tenant tenant)
        {
            return tenantDal.CreateTenant(tenant); 
        }

        public Tenant UpdateTenant(string ssn, string name, string phoneNbr, string email)
        {
            return tenantDal.UpdateTenant(ssn, name, phoneNbr, email); 
        }

        public Boolean DeleteTenant(string ssn)
        {
            return tenantDal.DeleteTenant(ssn); 
        }

        public Tenant FindTenant(string ssn)
        {
            return tenantDal.FindTenant(ssn); 
        }

        public DataTable FindTenants(string ssn)
        {
            return tenantDal.FindTenants(ssn); 
        }

        public DataTable ShowAllBookings()
        {
            return tenantDal.ShowAllBookings(); 
        }

        public List<Storage> GetListOfStorages()
        {
            return storageDal.GetListOfStorages(); 
        }

        public List<Storage> listOfAvailableStorages()
        {
            return storageDal.listOfAvailableStorages(); 
        }

        public Boolean CreateStorage(Storage storage)
        {
            return storageDal.CreateStorage(storage); 
        }

        public Storage UpdateStorage(string nbr, string address, float price, float size)
        {
            return storageDal.UpdateStorage(nbr, address, price, size); 
        }

        public Boolean DeleteStorage(string nbr)
        {
            return storageDal.DeleteStorage(nbr); 
        }

        public Storage FindStorage(string nbr)
        {
            return storageDal.FindStorage(nbr); 
        }

        public DataTable FindStorages(string nbr)
        {
            return storageDal.FindStorages(nbr); 
        }

        public DataTable ShowAllStorages()
        {
            return storageDal.ShowAllStorages(); 
        }

        public List<Employee> GetEmployees()
        {
            return employeeDal.GetEmployees(); 
        }

        public Employee CreateEmployee(Employee employee)
        {
            return employeeDal.CreateEmployee(employee); 
        }

        public Employee FindEmployee(string no)
        {
            return employeeDal.FindEmployee(no); 
        }

        public Employee UpdateEmployee(string no, string firstName, string lastName, string jobTitle, string address, string phoneNumber, string email)
        {
            return employeeDal.UpdateEmployee(no, firstName, lastName, jobTitle, address, phoneNumber, email); 
        }

        public Boolean DeleteEmployee(string no)
        {
            return employeeDal.DeleteEmployee(no); 
        }

        public List<Tenant> listOfTenantSsn()
        {
            return employeeDal.listOfTenantSsn(); 
        }

        public DataTable EmployeeAndRelatives()
        {
            return employeeDal.EmployeeAndRelatives(); 
        }

        public DataTable AllKeys()
        {
            return employeeDal.AllKeys(); 
        }

        public DataTable ShowContentOfCronusDataTable()
        {
            return employeeDal.ShowContentOfCronusDataTable(); 
        }

        public DataTable ShowSickEmployees2004()
        {
            return employeeDal.ShowSickEmployees2004(); 
        }

        public DataTable MostAbsentEmployees()
        {
            return employeeDal.MostAbsentEmployees(); 
        }

        public DataTable AllIndexes()
        {
            return employeeDal.AllIndexes(); 
        }

        public DataTable AllTableConstrains()
        {
            return employeeDal.AllTableConstrains(); 
        }

        public DataTable AllTablesInDatabaseSolOne()
        {
            return employeeDal.AllTablesInDatabaseSolOne(); 
        }

        public DataTable AllTablesInDatabaseSolTwo()
        {
            return employeeDal.AllTablesInDatabaseSolTwo(); 
        }

        public DataTable AllColEmpTableSolOne()
        {
            return employeeDal.AllColEmpTableSolOne(); 
        }

        public DataTable AllColEmpTableSolTwo()
        {
            return employeeDal.AllColEmpTableSolTwo(); 
        }


    }
}
