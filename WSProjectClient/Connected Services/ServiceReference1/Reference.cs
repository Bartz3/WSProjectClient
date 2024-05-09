﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://interfaces/", ConfigurationName="ServiceReference1.UserService")]
    public interface UserService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserService/AddUserRequest", ReplyAction="http://interfaces/UserService/AddUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<int> AddUserAsync(ServiceReference1.addUserRequest arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserService/GetUsersRequest", ReplyAction="http://interfaces/UserService/GetUsersResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.GetUsersResponse> GetUsersAsync(ServiceReference1.GetUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserService/SignInUserRequest", ReplyAction="http://interfaces/UserService/SignInUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceReference1.user> SignInUserAsync(ServiceReference1.userCredentialsRequest arg0);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class addUserRequest : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private int userIdField;
        
        private string emailField;
        
        private string usernameField;
        
        private string passwordField;
        
        private string passwordConfirmField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
                this.RaisePropertyChanged("userId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
                this.RaisePropertyChanged("email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
                this.RaisePropertyChanged("username");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string passwordConfirm
        {
            get
            {
                return this.passwordConfirmField;
            }
            set
            {
                this.passwordConfirmField = value;
                this.RaisePropertyChanged("passwordConfirm");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class userCredentialsRequest : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string emailField;
        
        private string passwordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
                this.RaisePropertyChanged("email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class user : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private int idField;
        
        private string usernameField;
        
        private string emailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
                this.RaisePropertyChanged("Email");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUsers", WrapperNamespace="http://interfaces/", IsWrapped=true)]
    public partial class GetUsersRequest
    {
        
        public GetUsersRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetUsersResponse", WrapperNamespace="http://interfaces/", IsWrapped=true)]
    public partial class GetUsersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("users", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ServiceReference1.user[] @return;
        
        public GetUsersResponse()
        {
        }
        
        public GetUsersResponse(ServiceReference1.user[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface UserServiceChannel : ServiceReference1.UserService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<ServiceReference1.UserService>, ServiceReference1.UserService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserServiceClient() : 
                base(UserServiceClient.GetDefaultBinding(), UserServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.UserServiceImplPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), UserServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<int> AddUserAsync(ServiceReference1.addUserRequest arg0)
        {
            return base.Channel.AddUserAsync(arg0);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetUsersResponse> ServiceReference1.UserService.GetUsersAsync(ServiceReference1.GetUsersRequest request)
        {
            return base.Channel.GetUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetUsersResponse> GetUsersAsync()
        {
            ServiceReference1.GetUsersRequest inValue = new ServiceReference1.GetUsersRequest();
            return ((ServiceReference1.UserService)(this)).GetUsersAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.user> SignInUserAsync(ServiceReference1.userCredentialsRequest arg0)
        {
            return base.Channel.SignInUserAsync(arg0);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.UserServiceImplPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.UserServiceImplPort))
            {
                return new System.ServiceModel.EndpointAddress("http://desktop-ve5gok9:8080/ProjectServer-1.0-SNAPSHOT/UserServiceImplService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UserServiceClient.GetBindingForEndpoint(EndpointConfiguration.UserServiceImplPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UserServiceClient.GetEndpointAddress(EndpointConfiguration.UserServiceImplPort);
        }
        
        public enum EndpointConfiguration
        {
            
            UserServiceImplPort,
        }
    }
}
