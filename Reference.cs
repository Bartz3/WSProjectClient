﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://interfaces/", ConfigurationName="UserReservationService")]
public interface UserReservationService
{
    
    // CODEGEN: Parametr „return” wymaga dodatkowych informacji o schemacie, których nie można uzyskać w trybie parametru. Określony atrybut to „System.Xml.Serialization.XmlArrayAttribute”.
    [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserReservationService/GetUserReservationsRequest", ReplyAction="http://interfaces/UserReservationService/GetUserReservationsResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
    GetUserReservationsResponse GetUserReservations(GetUserReservationsRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserReservationService/GetUserReservationsRequest", ReplyAction="http://interfaces/UserReservationService/GetUserReservationsResponse")]
    System.Threading.Tasks.Task<GetUserReservationsResponse> GetUserReservationsAsync(GetUserReservationsRequest request);
    
    // CODEGEN: Parametr „return” wymaga dodatkowych informacji o schemacie, których nie można uzyskać w trybie parametru. Określony atrybut to „System.Xml.Serialization.XmlArrayAttribute”.
    [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserReservationService/GetUserReservationsByUserIdRequest", ReplyAction="http://interfaces/UserReservationService/GetUserReservationsByUserIdResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
    GetUserReservationsByUserIdResponse GetUserReservationsByUserId(GetUserReservationsByUserIdRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserReservationService/GetUserReservationsByUserIdRequest", ReplyAction="http://interfaces/UserReservationService/GetUserReservationsByUserIdResponse")]
    System.Threading.Tasks.Task<GetUserReservationsByUserIdResponse> GetUserReservationsByUserIdAsync(GetUserReservationsByUserIdRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserReservationService/AddUserReservationRequest", ReplyAction="http://interfaces/UserReservationService/AddUserReservationResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
    [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
    int AddUserReservation(addUserReservationRequest arg0);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserReservationService/AddUserReservationRequest", ReplyAction="http://interfaces/UserReservationService/AddUserReservationResponse")]
    [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
    System.Threading.Tasks.Task<int> AddUserReservationAsync(addUserReservationRequest arg0);
    
    // CODEGEN: Parametr „return” wymaga dodatkowych informacji o schemacie, których nie można uzyskać w trybie parametru. Określony atrybut to „System.Xml.Serialization.XmlElementAttribute”.
    [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserReservationService/GetReservationConfirmationRequest", ReplyAction="http://interfaces/UserReservationService/GetReservationConfirmationResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
    GetReservationConfirmationResponse GetReservationConfirmation(GetReservationConfirmationRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserReservationService/GetReservationConfirmationRequest", ReplyAction="http://interfaces/UserReservationService/GetReservationConfirmationResponse")]
    System.Threading.Tasks.Task<GetReservationConfirmationResponse> GetReservationConfirmationAsync(GetReservationConfirmationRequest request);
    
    // CODEGEN: Parametr „return” wymaga dodatkowych informacji o schemacie, których nie można uzyskać w trybie parametru. Określony atrybut to „System.Xml.Serialization.XmlArrayAttribute”.
    [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserReservationService/GetUserReservationsByFlightIdRequest", ReplyAction="http://interfaces/UserReservationService/GetUserReservationsByFlightIdResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
    GetUserReservationsByFlightIdResponse GetUserReservationsByFlightId(GetUserReservationsByFlightIdRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://interfaces/UserReservationService/GetUserReservationsByFlightIdRequest", ReplyAction="http://interfaces/UserReservationService/GetUserReservationsByFlightIdResponse")]
    System.Threading.Tasks.Task<GetUserReservationsByFlightIdResponse> GetUserReservationsByFlightIdAsync(GetUserReservationsByFlightIdRequest request);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://interfaces/")]
public partial class addUserReservationRequest
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
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

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetUserReservations", WrapperNamespace="http://interfaces/", IsWrapped=true)]
public partial class GetUserReservationsRequest
{
    
    public GetUserReservationsRequest()
    {
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetUserReservationsResponse", WrapperNamespace="http://interfaces/", IsWrapped=true)]
public partial class GetUserReservationsResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
    [System.Xml.Serialization.XmlArrayAttribute()]
    [System.Xml.Serialization.XmlArrayItemAttribute("reservations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public userReservations[] @return;
    
    public GetUserReservationsResponse()
    {
    }
    
    public GetUserReservationsResponse(userReservations[] @return)
    {
        this.@return = @return;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetUserReservationsByUserId", WrapperNamespace="http://interfaces/", IsWrapped=true)]
public partial class GetUserReservationsByUserIdRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
    public getUserReservationRequest arg0;
    
    public GetUserReservationsByUserIdRequest()
    {
    }
    
    public GetUserReservationsByUserIdRequest(getUserReservationRequest arg0)
    {
        this.arg0 = arg0;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetUserReservationsByUserIdResponse", WrapperNamespace="http://interfaces/", IsWrapped=true)]
public partial class GetUserReservationsByUserIdResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
    [System.Xml.Serialization.XmlArrayAttribute()]
    [System.Xml.Serialization.XmlArrayItemAttribute("reservations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public userReservations[] @return;
    
    public GetUserReservationsByUserIdResponse()
    {
    }
    
    public GetUserReservationsByUserIdResponse(userReservations[] @return)
    {
        this.@return = @return;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetReservationConfirmation", WrapperNamespace="http://interfaces/", IsWrapped=true)]
public partial class GetReservationConfirmationRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
    public int arg0;
    
    public GetReservationConfirmationRequest()
    {
    }
    
    public GetReservationConfirmationRequest(int arg0)
    {
        this.arg0 = arg0;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetReservationConfirmationResponse", WrapperNamespace="http://interfaces/", IsWrapped=true)]
public partial class GetReservationConfirmationResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] @return;
    
    public GetReservationConfirmationResponse()
    {
    }
    
    public GetReservationConfirmationResponse(byte[] @return)
    {
        this.@return = @return;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetUserReservationsByFlightId", WrapperNamespace="http://interfaces/", IsWrapped=true)]
public partial class GetUserReservationsByFlightIdRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
    public getUserReservationRequest arg0;
    
    public GetUserReservationsByFlightIdRequest()
    {
    }
    
    public GetUserReservationsByFlightIdRequest(getUserReservationRequest arg0)
    {
        this.arg0 = arg0;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetUserReservationsByFlightIdResponse", WrapperNamespace="http://interfaces/", IsWrapped=true)]
public partial class GetUserReservationsByFlightIdResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
    [System.Xml.Serialization.XmlArrayAttribute()]
    [System.Xml.Serialization.XmlArrayItemAttribute("reservations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public userReservations[] @return;
    
    public GetUserReservationsByFlightIdResponse()
    {
    }
    
    public GetUserReservationsByFlightIdResponse(userReservations[] @return)
    {
        this.@return = @return;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface UserReservationServiceChannel : UserReservationService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class UserReservationServiceClient : System.ServiceModel.ClientBase<UserReservationService>, UserReservationService
{
    
    public UserReservationServiceClient()
    {
    }
    
    public UserReservationServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public UserReservationServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public UserReservationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public UserReservationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetUserReservationsResponse UserReservationService.GetUserReservations(GetUserReservationsRequest request)
    {
        return base.Channel.GetUserReservations(request);
    }
    
    public userReservations[] GetUserReservations()
    {
        GetUserReservationsRequest inValue = new GetUserReservationsRequest();
        GetUserReservationsResponse retVal = ((UserReservationService)(this)).GetUserReservations(inValue);
        return retVal.@return;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<GetUserReservationsResponse> UserReservationService.GetUserReservationsAsync(GetUserReservationsRequest request)
    {
        return base.Channel.GetUserReservationsAsync(request);
    }
    
    public System.Threading.Tasks.Task<GetUserReservationsResponse> GetUserReservationsAsync()
    {
        GetUserReservationsRequest inValue = new GetUserReservationsRequest();
        return ((UserReservationService)(this)).GetUserReservationsAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetUserReservationsByUserIdResponse UserReservationService.GetUserReservationsByUserId(GetUserReservationsByUserIdRequest request)
    {
        return base.Channel.GetUserReservationsByUserId(request);
    }
    
    public userReservations[] GetUserReservationsByUserId(getUserReservationRequest arg0)
    {
        GetUserReservationsByUserIdRequest inValue = new GetUserReservationsByUserIdRequest();
        inValue.arg0 = arg0;
        GetUserReservationsByUserIdResponse retVal = ((UserReservationService)(this)).GetUserReservationsByUserId(inValue);
        return retVal.@return;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<GetUserReservationsByUserIdResponse> UserReservationService.GetUserReservationsByUserIdAsync(GetUserReservationsByUserIdRequest request)
    {
        return base.Channel.GetUserReservationsByUserIdAsync(request);
    }
    
    public System.Threading.Tasks.Task<GetUserReservationsByUserIdResponse> GetUserReservationsByUserIdAsync(getUserReservationRequest arg0)
    {
        GetUserReservationsByUserIdRequest inValue = new GetUserReservationsByUserIdRequest();
        inValue.arg0 = arg0;
        return ((UserReservationService)(this)).GetUserReservationsByUserIdAsync(inValue);
    }
    
    public int AddUserReservation(addUserReservationRequest arg0)
    {
        return base.Channel.AddUserReservation(arg0);
    }
    
    public System.Threading.Tasks.Task<int> AddUserReservationAsync(addUserReservationRequest arg0)
    {
        return base.Channel.AddUserReservationAsync(arg0);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetReservationConfirmationResponse UserReservationService.GetReservationConfirmation(GetReservationConfirmationRequest request)
    {
        return base.Channel.GetReservationConfirmation(request);
    }
    
    public byte[] GetReservationConfirmation(int arg0)
    {
        GetReservationConfirmationRequest inValue = new GetReservationConfirmationRequest();
        inValue.arg0 = arg0;
        GetReservationConfirmationResponse retVal = ((UserReservationService)(this)).GetReservationConfirmation(inValue);
        return retVal.@return;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<GetReservationConfirmationResponse> UserReservationService.GetReservationConfirmationAsync(GetReservationConfirmationRequest request)
    {
        return base.Channel.GetReservationConfirmationAsync(request);
    }
    
    public System.Threading.Tasks.Task<GetReservationConfirmationResponse> GetReservationConfirmationAsync(int arg0)
    {
        GetReservationConfirmationRequest inValue = new GetReservationConfirmationRequest();
        inValue.arg0 = arg0;
        return ((UserReservationService)(this)).GetReservationConfirmationAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetUserReservationsByFlightIdResponse UserReservationService.GetUserReservationsByFlightId(GetUserReservationsByFlightIdRequest request)
    {
        return base.Channel.GetUserReservationsByFlightId(request);
    }
    
    public userReservations[] GetUserReservationsByFlightId(getUserReservationRequest arg0)
    {
        GetUserReservationsByFlightIdRequest inValue = new GetUserReservationsByFlightIdRequest();
        inValue.arg0 = arg0;
        GetUserReservationsByFlightIdResponse retVal = ((UserReservationService)(this)).GetUserReservationsByFlightId(inValue);
        return retVal.@return;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<GetUserReservationsByFlightIdResponse> UserReservationService.GetUserReservationsByFlightIdAsync(GetUserReservationsByFlightIdRequest request)
    {
        return base.Channel.GetUserReservationsByFlightIdAsync(request);
    }
    
    public System.Threading.Tasks.Task<GetUserReservationsByFlightIdResponse> GetUserReservationsByFlightIdAsync(getUserReservationRequest arg0)
    {
        GetUserReservationsByFlightIdRequest inValue = new GetUserReservationsByFlightIdRequest();
        inValue.arg0 = arg0;
        return ((UserReservationService)(this)).GetUserReservationsByFlightIdAsync(inValue);
    }
}
