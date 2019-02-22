Public MustInherit Class CompanyModel
    Dim _companyName As String
    Overridable Property CompanyName As String
        Get
            Return _companyName
        End Get
        Set
            _companyName = Value.Trim()
        End Set
    End Property

    Private _companyPostalCode As String
    Overridable Property CompanyPostalCode As String
        Get
            Return _companyPostalCode
        End Get
        Set
            _companyPostalCode = Value.Trim()
        End Set
    End Property
End Class
