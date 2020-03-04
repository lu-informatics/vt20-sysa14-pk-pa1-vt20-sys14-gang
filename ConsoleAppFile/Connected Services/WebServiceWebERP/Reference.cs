﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppFile.WebServiceWebERP {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://grupp2.ics.lu.se/", ConfigurationName="WebServiceWebERP.WebServiceERP12Soap")]
    public interface WebServiceERP12Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/CreateEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleAppFile.WebServiceWebERP.Employee CreateEmployee(string no, string FirstName, string lastName, string jobTitle, string address, string phoneNumber, string email, string ssn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/CreateEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleAppFile.WebServiceWebERP.Employee> CreateEmployeeAsync(string no, string FirstName, string lastName, string jobTitle, string address, string phoneNumber, string email, string ssn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/FindEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleAppFile.WebServiceWebERP.Employee FindEmployee(string no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/FindEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleAppFile.WebServiceWebERP.Employee> FindEmployeeAsync(string no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/UpdateEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleAppFile.WebServiceWebERP.Employee UpdateEmployee(string no, string firstName, string lastName, string jobTitle, string address, string phoneNumber, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/UpdateEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleAppFile.WebServiceWebERP.Employee> UpdateEmployeeAsync(string no, string firstName, string lastName, string jobTitle, string address, string phoneNumber, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/DeleteEmployee", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool DeleteEmployee(string no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/DeleteEmployee", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteEmployeeAsync(string no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/ShowContentOfCronus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable ShowContentOfCronus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/ShowContentOfCronus", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> ShowContentOfCronusAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/EmployeeAndRelatives", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] EmployeeAndRelatives();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/EmployeeAndRelatives", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EmployeeAndRelativesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/ShowSickEmployees2004", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] ShowSickEmployees2004();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/ShowSickEmployees2004", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> ShowSickEmployees2004Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllKeys", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AllKeys();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllKeys", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AllKeysAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/ShowContentOfCronusDataTable", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] ShowContentOfCronusDataTable();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/ShowContentOfCronusDataTable", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> ShowContentOfCronusDataTableAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/MostAbsentEmployees", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] MostAbsentEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/MostAbsentEmployees", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> MostAbsentEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllIndexes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AllIndexes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllIndexes", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AllIndexesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllTableConstrains", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AllTableConstrains();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllTableConstrains", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AllTableConstrainsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllTablesInDatabaseSolOne", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AllTablesInDatabaseSolOne();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllTablesInDatabaseSolOne", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AllTablesInDatabaseSolOneAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllTablesInDatabaseSolTwo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AllTablesInDatabaseSolTwo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllTablesInDatabaseSolTwo", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AllTablesInDatabaseSolTwoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllColEmpTableSolOne", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AllColEmpTableSolOne();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllColEmpTableSolOne", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AllColEmpTableSolOneAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllColEmpTableSolTwo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AllColEmpTableSolTwo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/AllColEmpTableSolTwo", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AllColEmpTableSolTwoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/ShowFile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ShowFile(string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://grupp2.ics.lu.se/ShowFile", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ShowFileAsync(string fileName);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://grupp2.ics.lu.se/")]
    public partial class Employee : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string noField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string jobTitleField;
        
        private string addressField;
        
        private string phoneNumberField;
        
        private string ssnField;
        
        private string emailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
                this.RaisePropertyChanged("No");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
                this.RaisePropertyChanged("FirstName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
                this.RaisePropertyChanged("LastName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string JobTitle {
            get {
                return this.jobTitleField;
            }
            set {
                this.jobTitleField = value;
                this.RaisePropertyChanged("JobTitle");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string PhoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
                this.RaisePropertyChanged("PhoneNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Ssn {
            get {
                return this.ssnField;
            }
            set {
                this.ssnField = value;
                this.RaisePropertyChanged("Ssn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("Email");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceERP12SoapChannel : ConsoleAppFile.WebServiceWebERP.WebServiceERP12Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceERP12SoapClient : System.ServiceModel.ClientBase<ConsoleAppFile.WebServiceWebERP.WebServiceERP12Soap>, ConsoleAppFile.WebServiceWebERP.WebServiceERP12Soap {
        
        public WebServiceERP12SoapClient() {
        }
        
        public WebServiceERP12SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceERP12SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceERP12SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceERP12SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsoleAppFile.WebServiceWebERP.Employee CreateEmployee(string no, string FirstName, string lastName, string jobTitle, string address, string phoneNumber, string email, string ssn) {
            return base.Channel.CreateEmployee(no, FirstName, lastName, jobTitle, address, phoneNumber, email, ssn);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppFile.WebServiceWebERP.Employee> CreateEmployeeAsync(string no, string FirstName, string lastName, string jobTitle, string address, string phoneNumber, string email, string ssn) {
            return base.Channel.CreateEmployeeAsync(no, FirstName, lastName, jobTitle, address, phoneNumber, email, ssn);
        }
        
        public ConsoleAppFile.WebServiceWebERP.Employee FindEmployee(string no) {
            return base.Channel.FindEmployee(no);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppFile.WebServiceWebERP.Employee> FindEmployeeAsync(string no) {
            return base.Channel.FindEmployeeAsync(no);
        }
        
        public ConsoleAppFile.WebServiceWebERP.Employee UpdateEmployee(string no, string firstName, string lastName, string jobTitle, string address, string phoneNumber, string email) {
            return base.Channel.UpdateEmployee(no, firstName, lastName, jobTitle, address, phoneNumber, email);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppFile.WebServiceWebERP.Employee> UpdateEmployeeAsync(string no, string firstName, string lastName, string jobTitle, string address, string phoneNumber, string email) {
            return base.Channel.UpdateEmployeeAsync(no, firstName, lastName, jobTitle, address, phoneNumber, email);
        }
        
        public bool DeleteEmployee(string no) {
            return base.Channel.DeleteEmployee(no);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteEmployeeAsync(string no) {
            return base.Channel.DeleteEmployeeAsync(no);
        }
        
        public System.Data.DataTable ShowContentOfCronus() {
            return base.Channel.ShowContentOfCronus();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> ShowContentOfCronusAsync() {
            return base.Channel.ShowContentOfCronusAsync();
        }
        
        public string[] EmployeeAndRelatives() {
            return base.Channel.EmployeeAndRelatives();
        }
        
        public System.Threading.Tasks.Task<string[]> EmployeeAndRelativesAsync() {
            return base.Channel.EmployeeAndRelativesAsync();
        }
        
        public string[] ShowSickEmployees2004() {
            return base.Channel.ShowSickEmployees2004();
        }
        
        public System.Threading.Tasks.Task<string[]> ShowSickEmployees2004Async() {
            return base.Channel.ShowSickEmployees2004Async();
        }
        
        public string[] AllKeys() {
            return base.Channel.AllKeys();
        }
        
        public System.Threading.Tasks.Task<string[]> AllKeysAsync() {
            return base.Channel.AllKeysAsync();
        }
        
        public string[] ShowContentOfCronusDataTable() {
            return base.Channel.ShowContentOfCronusDataTable();
        }
        
        public System.Threading.Tasks.Task<string[]> ShowContentOfCronusDataTableAsync() {
            return base.Channel.ShowContentOfCronusDataTableAsync();
        }
        
        public string[] MostAbsentEmployees() {
            return base.Channel.MostAbsentEmployees();
        }
        
        public System.Threading.Tasks.Task<string[]> MostAbsentEmployeesAsync() {
            return base.Channel.MostAbsentEmployeesAsync();
        }
        
        public string[] AllIndexes() {
            return base.Channel.AllIndexes();
        }
        
        public System.Threading.Tasks.Task<string[]> AllIndexesAsync() {
            return base.Channel.AllIndexesAsync();
        }
        
        public string[] AllTableConstrains() {
            return base.Channel.AllTableConstrains();
        }
        
        public System.Threading.Tasks.Task<string[]> AllTableConstrainsAsync() {
            return base.Channel.AllTableConstrainsAsync();
        }
        
        public string[] AllTablesInDatabaseSolOne() {
            return base.Channel.AllTablesInDatabaseSolOne();
        }
        
        public System.Threading.Tasks.Task<string[]> AllTablesInDatabaseSolOneAsync() {
            return base.Channel.AllTablesInDatabaseSolOneAsync();
        }
        
        public string[] AllTablesInDatabaseSolTwo() {
            return base.Channel.AllTablesInDatabaseSolTwo();
        }
        
        public System.Threading.Tasks.Task<string[]> AllTablesInDatabaseSolTwoAsync() {
            return base.Channel.AllTablesInDatabaseSolTwoAsync();
        }
        
        public string[] AllColEmpTableSolOne() {
            return base.Channel.AllColEmpTableSolOne();
        }
        
        public System.Threading.Tasks.Task<string[]> AllColEmpTableSolOneAsync() {
            return base.Channel.AllColEmpTableSolOneAsync();
        }
        
        public string[] AllColEmpTableSolTwo() {
            return base.Channel.AllColEmpTableSolTwo();
        }
        
        public System.Threading.Tasks.Task<string[]> AllColEmpTableSolTwoAsync() {
            return base.Channel.AllColEmpTableSolTwoAsync();
        }
        
        public string ShowFile(string fileName) {
            return base.Channel.ShowFile(fileName);
        }
        
        public System.Threading.Tasks.Task<string> ShowFileAsync(string fileName) {
            return base.Channel.ShowFileAsync(fileName);
        }
    }
}
