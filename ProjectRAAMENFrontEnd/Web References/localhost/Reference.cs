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

namespace ProjectRAAMENFrontEnd.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class WebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsertCustomerOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertStaffOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUserByUsernameAndPasswordOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUserByIdOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService() {
            this.Url = global::ProjectRAAMENFrontEnd.Properties.Settings.Default.ProjectRAAMENFrontEnd_localhost_WebService;
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
        public event InsertCustomerCompletedEventHandler InsertCustomerCompleted;
        
        /// <remarks/>
        public event InsertStaffCompletedEventHandler InsertStaffCompleted;
        
        /// <remarks/>
        public event GetUserByUsernameAndPasswordCompletedEventHandler GetUserByUsernameAndPasswordCompleted;
        
        /// <remarks/>
        public event GetUserByIdCompletedEventHandler GetUserByIdCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertCustomer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertCustomer(string Username, string Password, string Gender, string Email) {
            object[] results = this.Invoke("InsertCustomer", new object[] {
                        Username,
                        Password,
                        Gender,
                        Email});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertCustomerAsync(string Username, string Password, string Gender, string Email) {
            this.InsertCustomerAsync(Username, Password, Gender, Email, null);
        }
        
        /// <remarks/>
        public void InsertCustomerAsync(string Username, string Password, string Gender, string Email, object userState) {
            if ((this.InsertCustomerOperationCompleted == null)) {
                this.InsertCustomerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertCustomerOperationCompleted);
            }
            this.InvokeAsync("InsertCustomer", new object[] {
                        Username,
                        Password,
                        Gender,
                        Email}, this.InsertCustomerOperationCompleted, userState);
        }
        
        private void OnInsertCustomerOperationCompleted(object arg) {
            if ((this.InsertCustomerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertCustomerCompleted(this, new InsertCustomerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertStaff", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertStaff(string Username, string Password, string Gender, string Email) {
            object[] results = this.Invoke("InsertStaff", new object[] {
                        Username,
                        Password,
                        Gender,
                        Email});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertStaffAsync(string Username, string Password, string Gender, string Email) {
            this.InsertStaffAsync(Username, Password, Gender, Email, null);
        }
        
        /// <remarks/>
        public void InsertStaffAsync(string Username, string Password, string Gender, string Email, object userState) {
            if ((this.InsertStaffOperationCompleted == null)) {
                this.InsertStaffOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertStaffOperationCompleted);
            }
            this.InvokeAsync("InsertStaff", new object[] {
                        Username,
                        Password,
                        Gender,
                        Email}, this.InsertStaffOperationCompleted, userState);
        }
        
        private void OnInsertStaffOperationCompleted(object arg) {
            if ((this.InsertStaffCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertStaffCompleted(this, new InsertStaffCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUserByUsernameAndPassword", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetUserByUsernameAndPassword(string Username, string Password) {
            object[] results = this.Invoke("GetUserByUsernameAndPassword", new object[] {
                        Username,
                        Password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetUserByUsernameAndPasswordAsync(string Username, string Password) {
            this.GetUserByUsernameAndPasswordAsync(Username, Password, null);
        }
        
        /// <remarks/>
        public void GetUserByUsernameAndPasswordAsync(string Username, string Password, object userState) {
            if ((this.GetUserByUsernameAndPasswordOperationCompleted == null)) {
                this.GetUserByUsernameAndPasswordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUserByUsernameAndPasswordOperationCompleted);
            }
            this.InvokeAsync("GetUserByUsernameAndPassword", new object[] {
                        Username,
                        Password}, this.GetUserByUsernameAndPasswordOperationCompleted, userState);
        }
        
        private void OnGetUserByUsernameAndPasswordOperationCompleted(object arg) {
            if ((this.GetUserByUsernameAndPasswordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUserByUsernameAndPasswordCompleted(this, new GetUserByUsernameAndPasswordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUserById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetUserById(int Id) {
            object[] results = this.Invoke("GetUserById", new object[] {
                        Id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetUserByIdAsync(int Id) {
            this.GetUserByIdAsync(Id, null);
        }
        
        /// <remarks/>
        public void GetUserByIdAsync(int Id, object userState) {
            if ((this.GetUserByIdOperationCompleted == null)) {
                this.GetUserByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUserByIdOperationCompleted);
            }
            this.InvokeAsync("GetUserById", new object[] {
                        Id}, this.GetUserByIdOperationCompleted, userState);
        }
        
        private void OnGetUserByIdOperationCompleted(object arg) {
            if ((this.GetUserByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUserByIdCompleted(this, new GetUserByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void InsertCustomerCompletedEventHandler(object sender, InsertCustomerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void InsertStaffCompletedEventHandler(object sender, InsertStaffCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertStaffCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertStaffCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void GetUserByUsernameAndPasswordCompletedEventHandler(object sender, GetUserByUsernameAndPasswordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUserByUsernameAndPasswordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUserByUsernameAndPasswordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void GetUserByIdCompletedEventHandler(object sender, GetUserByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUserByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUserByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591