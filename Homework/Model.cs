﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Этот исходный код был создан с помощью xsd, версия=4.0.30319.18020.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("article", Namespace="", IsNullable=false)]
public partial class Article {
    
    private string nameField;
    
    private int colorField;
    
    private bool colorFieldSpecified;
    
    private string componentsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int color {
        get {
            return this.colorField;
        }
        set {
            this.colorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool colorSpecified {
        get {
            return this.colorFieldSpecified;
        }
        set {
            this.colorFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string components {
        get {
            return this.componentsField;
        }
        set {
            this.componentsField = value;
        }
    }

    public override string ToString()
    {
        return name;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("service", Namespace="", IsNullable=false)]
public partial class Service {
    
    private long idField;
    
    private bool idFieldSpecified;
    
    private string nameField;
    
    private double priceField;
    
    private bool priceFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool idSpecified {
        get {
            return this.idFieldSpecified;
        }
        set {
            this.idFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public double price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool priceSpecified {
        get {
            return this.priceFieldSpecified;
        }
        set {
            this.priceFieldSpecified = value;
        }
    }

    public override string ToString()
    {
        return "[" + id + "] " + name;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("office", Namespace="", IsNullable=false)]
public partial class Office {
    
    private long idField;
    
    private bool idFieldSpecified;
    
    private string nameField;
    
    private string addressField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool idSpecified {
        get {
            return this.idFieldSpecified;
        }
        set {
            this.idFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }

    public override string ToString()
    {
        return "[" + id + "] " + name; 
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("employee", Namespace="", IsNullable=false)]
public partial class Employee {
    
    private long idField;
    
    private bool idFieldSpecified;
    
    private string firstNameField;
    
    private string lastNameField;
    
    private string patronymicNameField;
    
    private System.DateTime dateOfBirthField;
    
    private bool dateOfBirthFieldSpecified;
    
    private string phoneNumberField;
    
    private System.DateTime hireDateField;
    
    private bool hireDateFieldSpecified;
    
    private double salaryField;
    
    private bool salaryFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool idSpecified {
        get {
            return this.idFieldSpecified;
        }
        set {
            this.idFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string firstName {
        get {
            return this.firstNameField;
        }
        set {
            this.firstNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string lastName {
        get {
            return this.lastNameField;
        }
        set {
            this.lastNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string patronymicName {
        get {
            return this.patronymicNameField;
        }
        set {
            this.patronymicNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime dateOfBirth {
        get {
            return this.dateOfBirthField;
        }
        set {
            this.dateOfBirthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dateOfBirthSpecified {
        get {
            return this.dateOfBirthFieldSpecified;
        }
        set {
            this.dateOfBirthFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string phoneNumber {
        get {
            return this.phoneNumberField;
        }
        set {
            this.phoneNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime hireDate {
        get {
            return this.hireDateField;
        }
        set {
            this.hireDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool hireDateSpecified {
        get {
            return this.hireDateFieldSpecified;
        }
        set {
            this.hireDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public double salary {
        get {
            return this.salaryField;
        }
        set {
            this.salaryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool salarySpecified {
        get {
            return this.salaryFieldSpecified;
        }
        set {
            this.salaryFieldSpecified = value;
        }
    }

    public override string ToString()
    {
        return "[" + id + "] " + lastName + ", " + firstName; 
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("order", Namespace="", IsNullable=false)]
public partial class Order {
    
    private long idField;
    
    private bool idFieldSpecified;
    
    private string clientFirstNameField;
    
    private string clientLastNameField;
    
    private string clientPatronymicNameField;
    
    private string phoneNumberField;
    
    private System.DateTime orderDateField;
    
    private bool orderDateFieldSpecified;
    
    private bool executedField;
    
    private bool executedFieldSpecified;
    
    private Service serviceField;
    
    private Office officeField;
    
    private Employee employeeField;
    
    private Article[] articleListField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool idSpecified {
        get {
            return this.idFieldSpecified;
        }
        set {
            this.idFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string clientFirstName {
        get {
            return this.clientFirstNameField;
        }
        set {
            this.clientFirstNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string clientLastName {
        get {
            return this.clientLastNameField;
        }
        set {
            this.clientLastNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string clientPatronymicName {
        get {
            return this.clientPatronymicNameField;
        }
        set {
            this.clientPatronymicNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string phoneNumber {
        get {
            return this.phoneNumberField;
        }
        set {
            this.phoneNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.DateTime orderDate {
        get {
            return this.orderDateField;
        }
        set {
            this.orderDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool orderDateSpecified {
        get {
            return this.orderDateFieldSpecified;
        }
        set {
            this.orderDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public bool executed {
        get {
            return this.executedField;
        }
        set {
            this.executedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool executedSpecified {
        get {
            return this.executedFieldSpecified;
        }
        set {
            this.executedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public Service service {
        get {
            return this.serviceField;
        }
        set {
            this.serviceField = value;
        }
    }
    
    /// <remarks/>
    public Office office {
        get {
            return this.officeField;
        }
        set {
            this.officeField = value;
        }
    }
    
    /// <remarks/>
    public Employee employee {
        get {
            return this.employeeField;
        }
        set {
            this.employeeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("articleList", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public Article[] articleList {
        get {
            return this.articleListField;
        }
        set {
            this.articleListField = value;
        }
    }

    public override string ToString()
    {
        return "[" + id + "] " + clientLastName + ", " + clientFirstName + "/" + orderDate;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("exportedDatabase", Namespace="", IsNullable=false)]
public partial class ExportedDatabase {
    
    private Service[] servicesField;
    
    private Office[] officesField;
    
    private Employee[] employeesField;
    
    private Order[] ordersField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public Service[] services {
        get {
            return this.servicesField;
        }
        set {
            this.servicesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public Office[] offices {
        get {
            return this.officesField;
        }
        set {
            this.officesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public Employee[] employees {
        get {
            return this.employeesField;
        }
        set {
            this.employeesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public Order[] orders {
        get {
            return this.ordersField;
        }
        set {
            this.ordersField = value;
        }
    }
}
