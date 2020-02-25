﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ProgramKonstruktion.SqlWebReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SqlWebServiceSoap", Namespace="http://grupp2.ics.lu.se/")]
    public partial class SqlWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback UpdateTenantOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateTenantOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteTenantOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindTenantOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateStorageOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateStorageOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteStorageOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteTenantFromStorageOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindStorageOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SqlWebService() {
            this.Url = global::ProgramKonstruktion.Properties.Settings.Default.ProgramKonstruktion_SqlWebReference_SqlWebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event UpdateTenantCompletedEventHandler UpdateTenantCompleted;
        
        /// <remarks/>
        public event CreateTenantCompletedEventHandler CreateTenantCompleted;
        
        /// <remarks/>
        public event DeleteTenantCompletedEventHandler DeleteTenantCompleted;
        
        /// <remarks/>
        public event FindTenantCompletedEventHandler FindTenantCompleted;
        
        /// <remarks/>
        public event CreateStorageCompletedEventHandler CreateStorageCompleted;
        
        /// <remarks/>
        public event UpdateStorageCompletedEventHandler UpdateStorageCompleted;
        
        /// <remarks/>
        public event DeleteStorageCompletedEventHandler DeleteStorageCompleted;
        
        /// <remarks/>
        public event DeleteTenantFromStorageCompletedEventHandler DeleteTenantFromStorageCompleted;
        
        /// <remarks/>
        public event FindStorageCompletedEventHandler FindStorageCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp2.ics.lu.se/UpdateTenant", RequestNamespace="http://grupp2.ics.lu.se/", ResponseNamespace="http://grupp2.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tenant UpdateTenant(string ssn, string name, string phoneNbr, string email) {
            object[] results = this.Invoke("UpdateTenant", new object[] {
                        ssn,
                        name,
                        phoneNbr,
                        email});
            return ((Tenant)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateTenantAsync(string ssn, string name, string phoneNbr, string email) {
            this.UpdateTenantAsync(ssn, name, phoneNbr, email, null);
        }
        
        /// <remarks/>
        public void UpdateTenantAsync(string ssn, string name, string phoneNbr, string email, object userState) {
            if ((this.UpdateTenantOperationCompleted == null)) {
                this.UpdateTenantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateTenantOperationCompleted);
            }
            this.InvokeAsync("UpdateTenant", new object[] {
                        ssn,
                        name,
                        phoneNbr,
                        email}, this.UpdateTenantOperationCompleted, userState);
        }
        
        private void OnUpdateTenantOperationCompleted(object arg) {
            if ((this.UpdateTenantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateTenantCompleted(this, new UpdateTenantCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp2.ics.lu.se/CreateTenant", RequestNamespace="http://grupp2.ics.lu.se/", ResponseNamespace="http://grupp2.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CreateTenant(string ssn, string name, string phoneNbr, string email, string storageNbr, System.DateTime rentDate) {
            object[] results = this.Invoke("CreateTenant", new object[] {
                        ssn,
                        name,
                        phoneNbr,
                        email,
                        storageNbr,
                        rentDate});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CreateTenantAsync(string ssn, string name, string phoneNbr, string email, string storageNbr, System.DateTime rentDate) {
            this.CreateTenantAsync(ssn, name, phoneNbr, email, storageNbr, rentDate, null);
        }
        
        /// <remarks/>
        public void CreateTenantAsync(string ssn, string name, string phoneNbr, string email, string storageNbr, System.DateTime rentDate, object userState) {
            if ((this.CreateTenantOperationCompleted == null)) {
                this.CreateTenantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateTenantOperationCompleted);
            }
            this.InvokeAsync("CreateTenant", new object[] {
                        ssn,
                        name,
                        phoneNbr,
                        email,
                        storageNbr,
                        rentDate}, this.CreateTenantOperationCompleted, userState);
        }
        
        private void OnCreateTenantOperationCompleted(object arg) {
            if ((this.CreateTenantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateTenantCompleted(this, new CreateTenantCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp2.ics.lu.se/DeleteTenant", RequestNamespace="http://grupp2.ics.lu.se/", ResponseNamespace="http://grupp2.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool DeleteTenant(string ssn) {
            object[] results = this.Invoke("DeleteTenant", new object[] {
                        ssn});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteTenantAsync(string ssn) {
            this.DeleteTenantAsync(ssn, null);
        }
        
        /// <remarks/>
        public void DeleteTenantAsync(string ssn, object userState) {
            if ((this.DeleteTenantOperationCompleted == null)) {
                this.DeleteTenantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteTenantOperationCompleted);
            }
            this.InvokeAsync("DeleteTenant", new object[] {
                        ssn}, this.DeleteTenantOperationCompleted, userState);
        }
        
        private void OnDeleteTenantOperationCompleted(object arg) {
            if ((this.DeleteTenantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteTenantCompleted(this, new DeleteTenantCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp2.ics.lu.se/FindTenant", RequestNamespace="http://grupp2.ics.lu.se/", ResponseNamespace="http://grupp2.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tenant FindTenant(string ssn) {
            object[] results = this.Invoke("FindTenant", new object[] {
                        ssn});
            return ((Tenant)(results[0]));
        }
        
        /// <remarks/>
        public void FindTenantAsync(string ssn) {
            this.FindTenantAsync(ssn, null);
        }
        
        /// <remarks/>
        public void FindTenantAsync(string ssn, object userState) {
            if ((this.FindTenantOperationCompleted == null)) {
                this.FindTenantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindTenantOperationCompleted);
            }
            this.InvokeAsync("FindTenant", new object[] {
                        ssn}, this.FindTenantOperationCompleted, userState);
        }
        
        private void OnFindTenantOperationCompleted(object arg) {
            if ((this.FindTenantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindTenantCompleted(this, new FindTenantCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp2.ics.lu.se/CreateStorage", RequestNamespace="http://grupp2.ics.lu.se/", ResponseNamespace="http://grupp2.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CreateStorage(string nbr, float price, float size, string address) {
            object[] results = this.Invoke("CreateStorage", new object[] {
                        nbr,
                        price,
                        size,
                        address});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CreateStorageAsync(string nbr, float price, float size, string address) {
            this.CreateStorageAsync(nbr, price, size, address, null);
        }
        
        /// <remarks/>
        public void CreateStorageAsync(string nbr, float price, float size, string address, object userState) {
            if ((this.CreateStorageOperationCompleted == null)) {
                this.CreateStorageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateStorageOperationCompleted);
            }
            this.InvokeAsync("CreateStorage", new object[] {
                        nbr,
                        price,
                        size,
                        address}, this.CreateStorageOperationCompleted, userState);
        }
        
        private void OnCreateStorageOperationCompleted(object arg) {
            if ((this.CreateStorageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateStorageCompleted(this, new CreateStorageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp2.ics.lu.se/UpdateStorage", RequestNamespace="http://grupp2.ics.lu.se/", ResponseNamespace="http://grupp2.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Storage UpdateStorage(string nbr, string address, float price, float size) {
            object[] results = this.Invoke("UpdateStorage", new object[] {
                        nbr,
                        address,
                        price,
                        size});
            return ((Storage)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateStorageAsync(string nbr, string address, float price, float size) {
            this.UpdateStorageAsync(nbr, address, price, size, null);
        }
        
        /// <remarks/>
        public void UpdateStorageAsync(string nbr, string address, float price, float size, object userState) {
            if ((this.UpdateStorageOperationCompleted == null)) {
                this.UpdateStorageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateStorageOperationCompleted);
            }
            this.InvokeAsync("UpdateStorage", new object[] {
                        nbr,
                        address,
                        price,
                        size}, this.UpdateStorageOperationCompleted, userState);
        }
        
        private void OnUpdateStorageOperationCompleted(object arg) {
            if ((this.UpdateStorageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateStorageCompleted(this, new UpdateStorageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp2.ics.lu.se/DeleteStorage", RequestNamespace="http://grupp2.ics.lu.se/", ResponseNamespace="http://grupp2.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool DeleteStorage(string nbr) {
            object[] results = this.Invoke("DeleteStorage", new object[] {
                        nbr});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteStorageAsync(string nbr) {
            this.DeleteStorageAsync(nbr, null);
        }
        
        /// <remarks/>
        public void DeleteStorageAsync(string nbr, object userState) {
            if ((this.DeleteStorageOperationCompleted == null)) {
                this.DeleteStorageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteStorageOperationCompleted);
            }
            this.InvokeAsync("DeleteStorage", new object[] {
                        nbr}, this.DeleteStorageOperationCompleted, userState);
        }
        
        private void OnDeleteStorageOperationCompleted(object arg) {
            if ((this.DeleteStorageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteStorageCompleted(this, new DeleteStorageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp2.ics.lu.se/DeleteTenantFromStorage", RequestNamespace="http://grupp2.ics.lu.se/", ResponseNamespace="http://grupp2.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool DeleteTenantFromStorage(string nbr) {
            object[] results = this.Invoke("DeleteTenantFromStorage", new object[] {
                        nbr});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteTenantFromStorageAsync(string nbr) {
            this.DeleteTenantFromStorageAsync(nbr, null);
        }
        
        /// <remarks/>
        public void DeleteTenantFromStorageAsync(string nbr, object userState) {
            if ((this.DeleteTenantFromStorageOperationCompleted == null)) {
                this.DeleteTenantFromStorageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteTenantFromStorageOperationCompleted);
            }
            this.InvokeAsync("DeleteTenantFromStorage", new object[] {
                        nbr}, this.DeleteTenantFromStorageOperationCompleted, userState);
        }
        
        private void OnDeleteTenantFromStorageOperationCompleted(object arg) {
            if ((this.DeleteTenantFromStorageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteTenantFromStorageCompleted(this, new DeleteTenantFromStorageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp2.ics.lu.se/FindStorage", RequestNamespace="http://grupp2.ics.lu.se/", ResponseNamespace="http://grupp2.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Storage FindStorage(string nbr) {
            object[] results = this.Invoke("FindStorage", new object[] {
                        nbr});
            return ((Storage)(results[0]));
        }
        
        /// <remarks/>
        public void FindStorageAsync(string nbr) {
            this.FindStorageAsync(nbr, null);
        }
        
        /// <remarks/>
        public void FindStorageAsync(string nbr, object userState) {
            if ((this.FindStorageOperationCompleted == null)) {
                this.FindStorageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindStorageOperationCompleted);
            }
            this.InvokeAsync("FindStorage", new object[] {
                        nbr}, this.FindStorageOperationCompleted, userState);
        }
        
        private void OnFindStorageOperationCompleted(object arg) {
            if ((this.FindStorageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindStorageCompleted(this, new FindStorageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://grupp2.ics.lu.se/")]
    public partial class Tenant {
        
        private string ssnField;
        
        private string nameField;
        
        private string phoneNbrField;
        
        private string emailField;
        
        private string storageNbrField;
        
        private System.DateTime rentDateField;
        
        private string storageAddressField;
        
        /// <remarks/>
        public string Ssn {
            get {
                return this.ssnField;
            }
            set {
                this.ssnField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string PhoneNbr {
            get {
                return this.phoneNbrField;
            }
            set {
                this.phoneNbrField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string StorageNbr {
            get {
                return this.storageNbrField;
            }
            set {
                this.storageNbrField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime RentDate {
            get {
                return this.rentDateField;
            }
            set {
                this.rentDateField = value;
            }
        }
        
        /// <remarks/>
        public string StorageAddress {
            get {
                return this.storageAddressField;
            }
            set {
                this.storageAddressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://grupp2.ics.lu.se/")]
    public partial class Storage {
        
        private string nbrField;
        
        private float priceField;
        
        private float sizeField;
        
        private string addressField;
        
        /// <remarks/>
        public string Nbr {
            get {
                return this.nbrField;
            }
            set {
                this.nbrField = value;
            }
        }
        
        /// <remarks/>
        public float Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public float Size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
        
        /// <remarks/>
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void UpdateTenantCompletedEventHandler(object sender, UpdateTenantCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateTenantCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateTenantCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tenant Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tenant)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void CreateTenantCompletedEventHandler(object sender, CreateTenantCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateTenantCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateTenantCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void DeleteTenantCompletedEventHandler(object sender, DeleteTenantCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteTenantCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteTenantCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void FindTenantCompletedEventHandler(object sender, FindTenantCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindTenantCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindTenantCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tenant Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tenant)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void CreateStorageCompletedEventHandler(object sender, CreateStorageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateStorageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateStorageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void UpdateStorageCompletedEventHandler(object sender, UpdateStorageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateStorageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateStorageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Storage Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Storage)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void DeleteStorageCompletedEventHandler(object sender, DeleteStorageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteStorageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteStorageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void DeleteTenantFromStorageCompletedEventHandler(object sender, DeleteTenantFromStorageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteTenantFromStorageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteTenantFromStorageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void FindStorageCompletedEventHandler(object sender, FindStorageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FindStorageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FindStorageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Storage Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Storage)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591