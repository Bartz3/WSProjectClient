﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserTicketServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://interfaces/", ConfigurationName="UserTicketServiceReference.UserTicketService")]
    public interface UserTicketService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserTicketService/GetTicketByReservationIdRequest", ReplyAction="http://interfaces/UserTicketService/GetTicketByReservationIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<UserTicketServiceReference.GetTicketByReservationIdResponse> GetTicketByReservationIdAsync(UserTicketServiceReference.GetTicketByReservationIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserTicketService/GetTicketsByFlightIdRequest", ReplyAction="http://interfaces/UserTicketService/GetTicketsByFlightIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<UserTicketServiceReference.GetTicketsByFlightIdResponse> GetTicketsByFlightIdAsync(UserTicketServiceReference.GetTicketsByFlightIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserTicketService/GetTicketsRequest", ReplyAction="http://interfaces/UserTicketService/GetTicketsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<UserTicketServiceReference.GetTicketsResponse> GetTicketsAsync(UserTicketServiceReference.GetTicketsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserTicketService/AddTicketRequest", ReplyAction="http://interfaces/UserTicketService/AddTicketResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<int> AddTicketAsync(UserTicketServiceReference.addUserTicketRequest arg0);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class getUserTicketRequest
    {
        
        private int reservationIdField;
        
        private int flightIdField;
        
        private int airportIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int reservationId
        {
            get
            {
                return this.reservationIdField;
            }
            set
            {
                this.reservationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int flightId
        {
            get
            {
                return this.flightIdField;
            }
            set
            {
                this.flightIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int airportId
        {
            get
            {
                return this.airportIdField;
            }
            set
            {
                this.airportIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class addUserTicketRequest
    {
        
        private int reservationIdField;
        
        private int flightIdField;
        
        private int airportIdField;
        
        private double priceField;
        
        private int seatNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int reservationId
        {
            get
            {
                return this.reservationIdField;
            }
            set
            {
                this.reservationIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int flightId
        {
            get
            {
                return this.flightIdField;
            }
            set
            {
                this.flightIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int airportId
        {
            get
            {
                return this.airportIdField;
            }
            set
            {
                this.airportIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int seatNumber
        {
            get
            {
                return this.seatNumberField;
            }
            set
            {
                this.seatNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class getUserReservationRequest
    {
        
        private int userIdField;
        
        private int flightIdField;
        
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
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int flightId
        {
            get
            {
                return this.flightIdField;
            }
            set
            {
                this.flightIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class plane
    {
        
        private int idField;
        
        private string typeField;
        
        private int seatsField;
        
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
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int Seats
        {
            get
            {
                return this.seatsField;
            }
            set
            {
                this.seatsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class airport
    {
        
        private int idField;
        
        private string nameField;
        
        private string cityField;
        
        private string countryField;
        
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
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class flight
    {
        
        private int idField;
        
        private airport arrivalField;
        
        private airport destinationField;
        
        private plane planeField;
        
        private System.DateTime flightDateField;
        
        private bool flightDateFieldSpecified;
        
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
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public airport Arrival
        {
            get
            {
                return this.arrivalField;
            }
            set
            {
                this.arrivalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public airport Destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public plane Plane
        {
            get
            {
                return this.planeField;
            }
            set
            {
                this.planeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime FlightDate
        {
            get
            {
                return this.flightDateField;
            }
            set
            {
                this.flightDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlightDateSpecified
        {
            get
            {
                return this.flightDateFieldSpecified;
            }
            set
            {
                this.flightDateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class user
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
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class userReservations
    {
        
        private int idField;
        
        private user userField;
        
        private flight flightField;
        
        private userTickets[] ticketsField;
        
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
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public user User
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public flight Flight
        {
            get
            {
                return this.flightField;
            }
            set
            {
                this.flightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Tickets", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public userTickets[] Tickets
        {
            get
            {
                return this.ticketsField;
            }
            set
            {
                this.ticketsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
    public partial class userTickets
    {
        
        private int idField;
        
        private double priceField;
        
        private int seatNumberField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private userReservations userReservationsField;
        
        private flight flightField;
        
        private airport airportField;
        
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
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int SeatNumber
        {
            get
            {
                return this.seatNumberField;
            }
            set
            {
                this.seatNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public userReservations UserReservations
        {
            get
            {
                return this.userReservationsField;
            }
            set
            {
                this.userReservationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public flight Flight
        {
            get
            {
                return this.flightField;
            }
            set
            {
                this.flightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public airport Airport
        {
            get
            {
                return this.airportField;
            }
            set
            {
                this.airportField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTicketByReservationId", WrapperNamespace="http://interfaces/", IsWrapped=true)]
    public partial class GetTicketByReservationIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public UserTicketServiceReference.getUserTicketRequest arg0;
        
        public GetTicketByReservationIdRequest()
        {
        }
        
        public GetTicketByReservationIdRequest(UserTicketServiceReference.getUserTicketRequest arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTicketByReservationIdResponse", WrapperNamespace="http://interfaces/", IsWrapped=true)]
    public partial class GetTicketByReservationIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("tickets", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public UserTicketServiceReference.userTickets[] @return;
        
        public GetTicketByReservationIdResponse()
        {
        }
        
        public GetTicketByReservationIdResponse(UserTicketServiceReference.userTickets[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTicketsByFlightId", WrapperNamespace="http://interfaces/", IsWrapped=true)]
    public partial class GetTicketsByFlightIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public UserTicketServiceReference.getUserReservationRequest arg0;
        
        public GetTicketsByFlightIdRequest()
        {
        }
        
        public GetTicketsByFlightIdRequest(UserTicketServiceReference.getUserReservationRequest arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTicketsByFlightIdResponse", WrapperNamespace="http://interfaces/", IsWrapped=true)]
    public partial class GetTicketsByFlightIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("tickets", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public UserTicketServiceReference.userTickets[] @return;
        
        public GetTicketsByFlightIdResponse()
        {
        }
        
        public GetTicketsByFlightIdResponse(UserTicketServiceReference.userTickets[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTickets", WrapperNamespace="http://interfaces/", IsWrapped=true)]
    public partial class GetTicketsRequest
    {
        
        public GetTicketsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTicketsResponse", WrapperNamespace="http://interfaces/", IsWrapped=true)]
    public partial class GetTicketsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("tickets", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public UserTicketServiceReference.userTickets[] @return;
        
        public GetTicketsResponse()
        {
        }
        
        public GetTicketsResponse(UserTicketServiceReference.userTickets[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface UserTicketServiceChannel : UserTicketServiceReference.UserTicketService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class UserTicketServiceClient : System.ServiceModel.ClientBase<UserTicketServiceReference.UserTicketService>, UserTicketServiceReference.UserTicketService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserTicketServiceClient() : 
                base(UserTicketServiceClient.GetDefaultBinding(), UserTicketServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.UserTicketServiceImplPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserTicketServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(UserTicketServiceClient.GetBindingForEndpoint(endpointConfiguration), UserTicketServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserTicketServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserTicketServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserTicketServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserTicketServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserTicketServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UserTicketServiceReference.GetTicketByReservationIdResponse> UserTicketServiceReference.UserTicketService.GetTicketByReservationIdAsync(UserTicketServiceReference.GetTicketByReservationIdRequest request)
        {
            return base.Channel.GetTicketByReservationIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<UserTicketServiceReference.GetTicketByReservationIdResponse> GetTicketByReservationIdAsync(UserTicketServiceReference.getUserTicketRequest arg0)
        {
            UserTicketServiceReference.GetTicketByReservationIdRequest inValue = new UserTicketServiceReference.GetTicketByReservationIdRequest();
            inValue.arg0 = arg0;
            return ((UserTicketServiceReference.UserTicketService)(this)).GetTicketByReservationIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UserTicketServiceReference.GetTicketsByFlightIdResponse> UserTicketServiceReference.UserTicketService.GetTicketsByFlightIdAsync(UserTicketServiceReference.GetTicketsByFlightIdRequest request)
        {
            return base.Channel.GetTicketsByFlightIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<UserTicketServiceReference.GetTicketsByFlightIdResponse> GetTicketsByFlightIdAsync(UserTicketServiceReference.getUserReservationRequest arg0)
        {
            UserTicketServiceReference.GetTicketsByFlightIdRequest inValue = new UserTicketServiceReference.GetTicketsByFlightIdRequest();
            inValue.arg0 = arg0;
            return ((UserTicketServiceReference.UserTicketService)(this)).GetTicketsByFlightIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UserTicketServiceReference.GetTicketsResponse> UserTicketServiceReference.UserTicketService.GetTicketsAsync(UserTicketServiceReference.GetTicketsRequest request)
        {
            return base.Channel.GetTicketsAsync(request);
        }
        
        public System.Threading.Tasks.Task<UserTicketServiceReference.GetTicketsResponse> GetTicketsAsync()
        {
            UserTicketServiceReference.GetTicketsRequest inValue = new UserTicketServiceReference.GetTicketsRequest();
            return ((UserTicketServiceReference.UserTicketService)(this)).GetTicketsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<int> AddTicketAsync(UserTicketServiceReference.addUserTicketRequest arg0)
        {
            return base.Channel.AddTicketAsync(arg0);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.UserTicketServiceImplPort))
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
            if ((endpointConfiguration == EndpointConfiguration.UserTicketServiceImplPort))
            {
                return new System.ServiceModel.EndpointAddress("http://desktop-ve5gok9:8080/ProjectServer-1.0-SNAPSHOT/UserTicketServiceImplServi" +
                        "ce");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UserTicketServiceClient.GetBindingForEndpoint(EndpointConfiguration.UserTicketServiceImplPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UserTicketServiceClient.GetEndpointAddress(EndpointConfiguration.UserTicketServiceImplPort);
        }
        
        public enum EndpointConfiguration
        {
            
            UserTicketServiceImplPort,
        }
    }
}