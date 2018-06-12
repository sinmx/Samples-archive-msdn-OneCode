﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Xml.Serialization

<Assembly: EdmSchemaAttribute("3d8f72ab-7af1-45f6-ab17-715dbbf17b12")>
#Region "EDM Relationship Metadata"
<Assembly: EdmRelationshipAttribute("EFCloneModel", "FK__BasicSale__EmpId__1FCDBCEB", "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, GetType(Employee), "BasicSalesInfo", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(BasicSalesInfo), True)>
<Assembly: EdmRelationshipAttribute("EFCloneModel", "FK__DetailSal__Basic__22AA2996", "BasicSalesInfo", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, GetType(BasicSalesInfo), "DetailSalesInfo", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(DetailSalesInfo), True)>
<Assembly: EdmRelationshipAttribute("EFCloneModel", "FK__EmpAddres__EmpId__173876EA", "Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, GetType(Employee), "EmpAddress", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(EmpAddress), True)>

#End Region

#Region "Contexts"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
Public Partial Class EFCloneEntities
    Inherits ObjectContext

    #Region "Constructors"

    ''' <summary>
    ''' Initializes a new EFCloneEntities object using the connection string found in the 'EFCloneEntities' section of the application configuration file.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=EFCloneEntities", "EFCloneEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new EFCloneEntities object.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "EFCloneEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new EFCloneEntities object.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "EFCloneEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Partial Methods"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

    #Region "ObjectSet Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property BasicSalesInfoes() As ObjectSet(Of BasicSalesInfo)
        Get
            If (_BasicSalesInfoes Is Nothing) Then
                _BasicSalesInfoes = MyBase.CreateObjectSet(Of BasicSalesInfo)("BasicSalesInfoes")
            End If
            Return _BasicSalesInfoes
        End Get
    End Property

    Private _BasicSalesInfoes As ObjectSet(Of BasicSalesInfo)

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property DetailSalesInfoes() As ObjectSet(Of DetailSalesInfo)
        Get
            If (_DetailSalesInfoes Is Nothing) Then
                _DetailSalesInfoes = MyBase.CreateObjectSet(Of DetailSalesInfo)("DetailSalesInfoes")
            End If
            Return _DetailSalesInfoes
        End Get
    End Property

    Private _DetailSalesInfoes As ObjectSet(Of DetailSalesInfo)

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property EmpAddresses() As ObjectSet(Of EmpAddress)
        Get
            If (_EmpAddresses Is Nothing) Then
                _EmpAddresses = MyBase.CreateObjectSet(Of EmpAddress)("EmpAddresses")
            End If
            Return _EmpAddresses
        End Get
    End Property

    Private _EmpAddresses As ObjectSet(Of EmpAddress)

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property Employees() As ObjectSet(Of Employee)
        Get
            If (_Employees Is Nothing) Then
                _Employees = MyBase.CreateObjectSet(Of Employee)("Employees")
            End If
            Return _Employees
        End Get
    End Property

    Private _Employees As ObjectSet(Of Employee)

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property sysdiagrams() As ObjectSet(Of sysdiagram)
        Get
            If (_sysdiagrams Is Nothing) Then
                _sysdiagrams = MyBase.CreateObjectSet(Of sysdiagram)("sysdiagrams")
            End If
            Return _sysdiagrams
        End Get
    End Property

    Private _sysdiagrams As ObjectSet(Of sysdiagram)

    #End Region

    #Region "AddTo Methods"

    ''' <summary>
    ''' Deprecated Method for adding a new object to the BasicSalesInfoes EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToBasicSalesInfoes(ByVal basicSalesInfo As BasicSalesInfo)
        MyBase.AddObject("BasicSalesInfoes", basicSalesInfo)
    End Sub

    ''' <summary>
    ''' Deprecated Method for adding a new object to the DetailSalesInfoes EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToDetailSalesInfoes(ByVal detailSalesInfo As DetailSalesInfo)
        MyBase.AddObject("DetailSalesInfoes", detailSalesInfo)
    End Sub

    ''' <summary>
    ''' Deprecated Method for adding a new object to the EmpAddresses EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToEmpAddresses(ByVal empAddress As EmpAddress)
        MyBase.AddObject("EmpAddresses", empAddress)
    End Sub

    ''' <summary>
    ''' Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToEmployees(ByVal employee As Employee)
        MyBase.AddObject("Employees", employee)
    End Sub

    ''' <summary>
    ''' Deprecated Method for adding a new object to the sysdiagrams EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddTosysdiagrams(ByVal sysdiagram As sysdiagram)
        MyBase.AddObject("sysdiagrams", sysdiagram)
    End Sub

    #End Region

End Class

#End Region

#Region "Entities"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="EFCloneModel", Name:="BasicSalesInfo")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class BasicSalesInfo
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new BasicSalesInfo object.
    ''' </summary>
    ''' <param name="salInfoId">Initial value of the SalInfoId property.</param>
    Public Shared Function CreateBasicSalesInfo(salInfoId As Global.System.Int32) As BasicSalesInfo
        Dim basicSalesInfo as BasicSalesInfo = New BasicSalesInfo
        basicSalesInfo.SalInfoId = salInfoId
        Return basicSalesInfo
    End Function

    #End Region

    #Region "Simple Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property SalInfoId() As Global.System.Int32
        Get
            Return _SalInfoId
        End Get
        Set
            If (_SalInfoId <> Value) Then
                OnSalInfoIdChanging(value)
                ReportPropertyChanging("SalInfoId")
                _SalInfoId = StructuralObject.SetValidValue(value, "SalInfoId")
                ReportPropertyChanged("SalInfoId")
                OnSalInfoIdChanged()
            End If
        End Set
    End Property

    Private _SalInfoId As Global.System.Int32
    Private Partial Sub OnSalInfoIdChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnSalInfoIdChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property EmpId() As Nullable(Of Global.System.Int32)
        Get
            Return _EmpId
        End Get
        Set
            OnEmpIdChanging(value)
            ReportPropertyChanging("EmpId")
            _EmpId = StructuralObject.SetValidValue(value, "EmpId")
            ReportPropertyChanged("EmpId")
            OnEmpIdChanged()
        End Set
    End Property

    Private _EmpId As Nullable(Of Global.System.Int32)
    Private Partial Sub OnEmpIdChanging(value As Nullable(Of Global.System.Int32))
    End Sub

    Private Partial Sub OnEmpIdChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Total() As Nullable(Of Global.System.Double)
        Get
            Return _Total
        End Get
        Set
            OnTotalChanging(value)
            ReportPropertyChanging("Total")
            _Total = StructuralObject.SetValidValue(value, "Total")
            ReportPropertyChanged("Total")
            OnTotalChanged()
        End Set
    End Property

    Private _Total As Nullable(Of Global.System.Double)
    Private Partial Sub OnTotalChanging(value As Nullable(Of Global.System.Double))
    End Sub

    Private Partial Sub OnTotalChanged()
    End Sub

    #End Region

    #Region "Navigation Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("EFCloneModel", "FK__BasicSale__EmpId__1FCDBCEB", "Employee")>
    Public Property Employee() As Employee
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employee)("EFCloneModel.FK__BasicSale__EmpId__1FCDBCEB", "Employee").Value
        End Get
        Set
            CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employee)("EFCloneModel.FK__BasicSale__EmpId__1FCDBCEB", "Employee").Value = value
        End Set
    End Property
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <BrowsableAttribute(False)>
    <DataMemberAttribute()>
    Public Property EmployeeReference() As EntityReference(Of Employee)
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employee)("EFCloneModel.FK__BasicSale__EmpId__1FCDBCEB", "Employee")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Employee)("EFCloneModel.FK__BasicSale__EmpId__1FCDBCEB", "Employee", value)
            End If
        End Set
    End Property

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("EFCloneModel", "FK__DetailSal__Basic__22AA2996", "DetailSalesInfo")>
     Public Property DetailSalesInfoes() As EntityCollection(Of DetailSalesInfo)
        Get
            Return CType(Me,IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of DetailSalesInfo)("EFCloneModel.FK__DetailSal__Basic__22AA2996", "DetailSalesInfo")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of DetailSalesInfo)("EFCloneModel.FK__DetailSal__Basic__22AA2996", "DetailSalesInfo", value)
            End If
        End Set
    End Property

    #End Region

End Class

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="EFCloneModel", Name:="DetailSalesInfo")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class DetailSalesInfo
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new DetailSalesInfo object.
    ''' </summary>
    ''' <param name="detailSalInfoId">Initial value of the DetailSalInfoId property.</param>
    Public Shared Function CreateDetailSalesInfo(detailSalInfoId As Global.System.Int32) As DetailSalesInfo
        Dim detailSalesInfo as DetailSalesInfo = New DetailSalesInfo
        detailSalesInfo.DetailSalInfoId = detailSalInfoId
        Return detailSalesInfo
    End Function

    #End Region

    #Region "Simple Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property DetailSalInfoId() As Global.System.Int32
        Get
            Return _DetailSalInfoId
        End Get
        Set
            If (_DetailSalInfoId <> Value) Then
                OnDetailSalInfoIdChanging(value)
                ReportPropertyChanging("DetailSalInfoId")
                _DetailSalInfoId = StructuralObject.SetValidValue(value, "DetailSalInfoId")
                ReportPropertyChanged("DetailSalInfoId")
                OnDetailSalInfoIdChanged()
            End If
        End Set
    End Property

    Private _DetailSalInfoId As Global.System.Int32
    Private Partial Sub OnDetailSalInfoIdChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnDetailSalInfoIdChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property BasicSalInfoId() As Nullable(Of Global.System.Int32)
        Get
            Return _BasicSalInfoId
        End Get
        Set
            OnBasicSalInfoIdChanging(value)
            ReportPropertyChanging("BasicSalInfoId")
            _BasicSalInfoId = StructuralObject.SetValidValue(value, "BasicSalInfoId")
            ReportPropertyChanged("BasicSalInfoId")
            OnBasicSalInfoIdChanged()
        End Set
    End Property

    Private _BasicSalInfoId As Nullable(Of Global.System.Int32)
    Private Partial Sub OnBasicSalInfoIdChanging(value As Nullable(Of Global.System.Int32))
    End Sub

    Private Partial Sub OnBasicSalInfoIdChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Sale() As Nullable(Of Global.System.Double)
        Get
            Return _Sale
        End Get
        Set
            OnSaleChanging(value)
            ReportPropertyChanging("Sale")
            _Sale = StructuralObject.SetValidValue(value, "Sale")
            ReportPropertyChanged("Sale")
            OnSaleChanged()
        End Set
    End Property

    Private _Sale As Nullable(Of Global.System.Double)
    Private Partial Sub OnSaleChanging(value As Nullable(Of Global.System.Double))
    End Sub

    Private Partial Sub OnSaleChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Year() As Nullable(Of Global.System.DateTime)
        Get
            Return _Year
        End Get
        Set
            OnYearChanging(value)
            ReportPropertyChanging("Year")
            _Year = StructuralObject.SetValidValue(value, "Year")
            ReportPropertyChanged("Year")
            OnYearChanged()
        End Set
    End Property

    Private _Year As Nullable(Of Global.System.DateTime)
    Private Partial Sub OnYearChanging(value As Nullable(Of Global.System.DateTime))
    End Sub

    Private Partial Sub OnYearChanged()
    End Sub

    #End Region

    #Region "Navigation Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("EFCloneModel", "FK__DetailSal__Basic__22AA2996", "BasicSalesInfo")>
    Public Property BasicSalesInfo() As BasicSalesInfo
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of BasicSalesInfo)("EFCloneModel.FK__DetailSal__Basic__22AA2996", "BasicSalesInfo").Value
        End Get
        Set
            CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of BasicSalesInfo)("EFCloneModel.FK__DetailSal__Basic__22AA2996", "BasicSalesInfo").Value = value
        End Set
    End Property
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <BrowsableAttribute(False)>
    <DataMemberAttribute()>
    Public Property BasicSalesInfoReference() As EntityReference(Of BasicSalesInfo)
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of BasicSalesInfo)("EFCloneModel.FK__DetailSal__Basic__22AA2996", "BasicSalesInfo")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of BasicSalesInfo)("EFCloneModel.FK__DetailSal__Basic__22AA2996", "BasicSalesInfo", value)
            End If
        End Set
    End Property

    #End Region

End Class

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="EFCloneModel", Name:="EmpAddress")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class EmpAddress
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new EmpAddress object.
    ''' </summary>
    ''' <param name="addressId">Initial value of the AddressId property.</param>
    Public Shared Function CreateEmpAddress(addressId As Global.System.Int32) As EmpAddress
        Dim empAddress as EmpAddress = New EmpAddress
        empAddress.AddressId = addressId
        Return empAddress
    End Function

    #End Region

    #Region "Simple Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property AddressId() As Global.System.Int32
        Get
            Return _AddressId
        End Get
        Set
            If (_AddressId <> Value) Then
                OnAddressIdChanging(value)
                ReportPropertyChanging("AddressId")
                _AddressId = StructuralObject.SetValidValue(value, "AddressId")
                ReportPropertyChanged("AddressId")
                OnAddressIdChanged()
            End If
        End Set
    End Property

    Private _AddressId As Global.System.Int32
    Private Partial Sub OnAddressIdChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnAddressIdChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property EmpId() As Nullable(Of Global.System.Int32)
        Get
            Return _EmpId
        End Get
        Set
            OnEmpIdChanging(value)
            ReportPropertyChanging("EmpId")
            _EmpId = StructuralObject.SetValidValue(value, "EmpId")
            ReportPropertyChanged("EmpId")
            OnEmpIdChanged()
        End Set
    End Property

    Private _EmpId As Nullable(Of Global.System.Int32)
    Private Partial Sub OnEmpIdChanging(value As Nullable(Of Global.System.Int32))
    End Sub

    Private Partial Sub OnEmpIdChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property AddressLine() As Global.System.String
        Get
            Return _AddressLine
        End Get
        Set
            OnAddressLineChanging(value)
            ReportPropertyChanging("AddressLine")
            _AddressLine = StructuralObject.SetValidValue(value, true, "AddressLine")
            ReportPropertyChanged("AddressLine")
            OnAddressLineChanged()
        End Set
    End Property

    Private _AddressLine As Global.System.String
    Private Partial Sub OnAddressLineChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnAddressLineChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property City() As Global.System.String
        Get
            Return _City
        End Get
        Set
            OnCityChanging(value)
            ReportPropertyChanging("City")
            _City = StructuralObject.SetValidValue(value, true, "City")
            ReportPropertyChanged("City")
            OnCityChanged()
        End Set
    End Property

    Private _City As Global.System.String
    Private Partial Sub OnCityChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnCityChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property State() As Global.System.String
        Get
            Return _State
        End Get
        Set
            OnStateChanging(value)
            ReportPropertyChanging("State")
            _State = StructuralObject.SetValidValue(value, true, "State")
            ReportPropertyChanged("State")
            OnStateChanged()
        End Set
    End Property

    Private _State As Global.System.String
    Private Partial Sub OnStateChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnStateChanged()
    End Sub

    #End Region

    #Region "Navigation Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("EFCloneModel", "FK__EmpAddres__EmpId__173876EA", "Employee")>
    Public Property Employee() As Employee
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employee)("EFCloneModel.FK__EmpAddres__EmpId__173876EA", "Employee").Value
        End Get
        Set
            CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employee)("EFCloneModel.FK__EmpAddres__EmpId__173876EA", "Employee").Value = value
        End Set
    End Property
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <BrowsableAttribute(False)>
    <DataMemberAttribute()>
    Public Property EmployeeReference() As EntityReference(Of Employee)
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employee)("EFCloneModel.FK__EmpAddres__EmpId__173876EA", "Employee")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Employee)("EFCloneModel.FK__EmpAddres__EmpId__173876EA", "Employee", value)
            End If
        End Set
    End Property

    #End Region

End Class

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="EFCloneModel", Name:="Employee")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class Employee
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new Employee object.
    ''' </summary>
    ''' <param name="empId">Initial value of the EmpId property.</param>
    Public Shared Function CreateEmployee(empId As Global.System.Int32) As Employee
        Dim employee as Employee = New Employee
        employee.EmpId = empId
        Return employee
    End Function

    #End Region

    #Region "Simple Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property EmpId() As Global.System.Int32
        Get
            Return _EmpId
        End Get
        Set
            If (_EmpId <> Value) Then
                OnEmpIdChanging(value)
                ReportPropertyChanging("EmpId")
                _EmpId = StructuralObject.SetValidValue(value, "EmpId")
                ReportPropertyChanged("EmpId")
                OnEmpIdChanged()
            End If
        End Set
    End Property

    Private _EmpId As Global.System.Int32
    Private Partial Sub OnEmpIdChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnEmpIdChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property FirstName() As Global.System.String
        Get
            Return _FirstName
        End Get
        Set
            OnFirstNameChanging(value)
            ReportPropertyChanging("FirstName")
            _FirstName = StructuralObject.SetValidValue(value, true, "FirstName")
            ReportPropertyChanged("FirstName")
            OnFirstNameChanged()
        End Set
    End Property

    Private _FirstName As Global.System.String
    Private Partial Sub OnFirstNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnFirstNameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property LastName() As Global.System.String
        Get
            Return _LastName
        End Get
        Set
            OnLastNameChanging(value)
            ReportPropertyChanging("LastName")
            _LastName = StructuralObject.SetValidValue(value, true, "LastName")
            ReportPropertyChanged("LastName")
            OnLastNameChanged()
        End Set
    End Property

    Private _LastName As Global.System.String
    Private Partial Sub OnLastNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnLastNameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Age() As Nullable(Of Global.System.Double)
        Get
            Return _Age
        End Get
        Set
            OnAgeChanging(value)
            ReportPropertyChanging("Age")
            _Age = StructuralObject.SetValidValue(value, "Age")
            ReportPropertyChanged("Age")
            OnAgeChanged()
        End Set
    End Property

    Private _Age As Nullable(Of Global.System.Double)
    Private Partial Sub OnAgeChanging(value As Nullable(Of Global.System.Double))
    End Sub

    Private Partial Sub OnAgeChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Sex() As Global.System.String
        Get
            Return _Sex
        End Get
        Set
            OnSexChanging(value)
            ReportPropertyChanging("Sex")
            _Sex = StructuralObject.SetValidValue(value, true, "Sex")
            ReportPropertyChanged("Sex")
            OnSexChanged()
        End Set
    End Property

    Private _Sex As Global.System.String
    Private Partial Sub OnSexChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnSexChanged()
    End Sub

    #End Region

    #Region "Navigation Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("EFCloneModel", "FK__BasicSale__EmpId__1FCDBCEB", "BasicSalesInfo")>
     Public Property BasicSalesInfoes() As EntityCollection(Of BasicSalesInfo)
        Get
            Return CType(Me,IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of BasicSalesInfo)("EFCloneModel.FK__BasicSale__EmpId__1FCDBCEB", "BasicSalesInfo")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of BasicSalesInfo)("EFCloneModel.FK__BasicSale__EmpId__1FCDBCEB", "BasicSalesInfo", value)
            End If
        End Set
    End Property

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("EFCloneModel", "FK__EmpAddres__EmpId__173876EA", "EmpAddress")>
     Public Property EmpAddresses() As EntityCollection(Of EmpAddress)
        Get
            Return CType(Me,IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of EmpAddress)("EFCloneModel.FK__EmpAddres__EmpId__173876EA", "EmpAddress")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of EmpAddress)("EFCloneModel.FK__EmpAddres__EmpId__173876EA", "EmpAddress", value)
            End If
        End Set
    End Property

    #End Region

End Class

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="EFCloneModel", Name:="sysdiagram")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class sysdiagram
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new sysdiagram object.
    ''' </summary>
    ''' <param name="name">Initial value of the name property.</param>
    ''' <param name="principal_id">Initial value of the principal_id property.</param>
    ''' <param name="diagram_id">Initial value of the diagram_id property.</param>
    Public Shared Function Createsysdiagram(name As Global.System.String, principal_id As Global.System.Int32, diagram_id As Global.System.Int32) As sysdiagram
        Dim sysdiagram as sysdiagram = New sysdiagram
        sysdiagram.name = name
        sysdiagram.principal_id = principal_id
        sysdiagram.diagram_id = diagram_id
        Return sysdiagram
    End Function

    #End Region

    #Region "Simple Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property name() As Global.System.String
        Get
            Return _name
        End Get
        Set
            OnnameChanging(value)
            ReportPropertyChanging("name")
            _name = StructuralObject.SetValidValue(value, false, "name")
            ReportPropertyChanged("name")
            OnnameChanged()
        End Set
    End Property

    Private _name As Global.System.String
    Private Partial Sub OnnameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnnameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property principal_id() As Global.System.Int32
        Get
            Return _principal_id
        End Get
        Set
            Onprincipal_idChanging(value)
            ReportPropertyChanging("principal_id")
            _principal_id = StructuralObject.SetValidValue(value, "principal_id")
            ReportPropertyChanged("principal_id")
            Onprincipal_idChanged()
        End Set
    End Property

    Private _principal_id As Global.System.Int32
    Private Partial Sub Onprincipal_idChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub Onprincipal_idChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property diagram_id() As Global.System.Int32
        Get
            Return _diagram_id
        End Get
        Set
            If (_diagram_id <> Value) Then
                Ondiagram_idChanging(value)
                ReportPropertyChanging("diagram_id")
                _diagram_id = StructuralObject.SetValidValue(value, "diagram_id")
                ReportPropertyChanged("diagram_id")
                Ondiagram_idChanged()
            End If
        End Set
    End Property

    Private _diagram_id As Global.System.Int32
    Private Partial Sub Ondiagram_idChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub Ondiagram_idChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property version() As Nullable(Of Global.System.Int32)
        Get
            Return _version
        End Get
        Set
            OnversionChanging(value)
            ReportPropertyChanging("version")
            _version = StructuralObject.SetValidValue(value, "version")
            ReportPropertyChanged("version")
            OnversionChanged()
        End Set
    End Property

    Private _version As Nullable(Of Global.System.Int32)
    Private Partial Sub OnversionChanging(value As Nullable(Of Global.System.Int32))
    End Sub

    Private Partial Sub OnversionChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property definition() As Global.System.Byte()
        Get
                Return StructuralObject.GetValidValue(_definition)
        End Get
        Set
            OndefinitionChanging(value)
            ReportPropertyChanging("definition")
            _definition = StructuralObject.SetValidValue(value, true, "definition")
            ReportPropertyChanged("definition")
            OndefinitionChanged()
        End Set
    End Property

    Private _definition As Global.System.Byte()
    Private Partial Sub OndefinitionChanging(value As Global.System.Byte())
    End Sub

    Private Partial Sub OndefinitionChanged()
    End Sub

    #End Region

End Class

#End Region

