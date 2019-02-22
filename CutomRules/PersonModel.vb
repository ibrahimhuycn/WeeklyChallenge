Public Class PersonModel
    Inherits CompanyModel
    Public Event ApplyRule(ByVal sender As Object, ByVal person As PersonModel, ByVal staticPerson As PersonModel)
    Public Event ReturnMessage(ByVal sender As Object, ByVal message As String)
    Private _firstName As String
    Private _lastName As String

    Public Overridable Property FirstName As String
        Get
            Return _firstName
        End Get
        Set
            _firstName = Value.Trim()
        End Set
    End Property

    Public Overridable Property LastName As String
        Get
            Return _lastName
        End Get
        Set
            _lastName = Value.Trim()
        End Set
    End Property

    Dim _postalCode As String
    ''' <summary>
    ''' Postal codes can be alphanumeric hence the string representation
    ''' </summary>
    ''' <returns></returns>
    Overridable Property PostalCode As String
        Get
            Return _postalCode
        End Get
        Set
            _postalCode = Value.Trim()
        End Set
    End Property

    Public Enum PersonFields
        FirstName
        LastName
        PostalCode
    End Enum
    Public Sub ApplyRules(ByVal sender As Object, ByVal person As PersonModel)

        Dim ReadStaticPerson() As String = My.Settings.StaticPerson.Split(My.Settings.PersonFieldDelimiter)

        Dim StaticPerson As New PersonModel With {
            .FirstName = ReadStaticPerson(PersonFields.FirstName),
            .LastName = ReadStaticPerson(PersonFields.LastName),
            .PostalCode = ReadStaticPerson(PersonFields.PostalCode)
        }
        RaiseEvent ApplyRule(Me, person, StaticPerson)
    End Sub

    Private Sub MatchFirstName(ByVal sender As Object, ByVal person As PersonModel, ByVal staticPerson As PersonModel) Handles Me.ApplyRule
        If person.LastName = staticPerson.LastName Then RaiseEvent ReturnMessage(Me, String.Format("Possibly related to {0} {1}.", staticPerson.FirstName, staticPerson.LastName))
    End Sub
    Private Sub InitialsMatch(ByVal sender As Object, ByVal person As PersonModel, ByVal staticPerson As PersonModel) Handles Me.ApplyRule
        If (person.FirstName.Substring(0, 1) = staticPerson.FirstName.Substring(0, 1) And
            person.LastName.Substring(0, 1) = staticPerson.LastName.Substring(0, 1)) Then

            RaiseEvent ReturnMessage(Me, String.Format("Same initials as {0} {1}.", staticPerson.FirstName, staticPerson.LastName))
        End If
    End Sub
    Private Sub PartialPostalCodeMatch(ByVal sender As Object, ByVal person As PersonModel, ByVal staticPerson As PersonModel) Handles Me.ApplyRule
        If person.PostalCode.Substring(0, 2) = staticPerson.PostalCode.Substring(0, 2) Then RaiseEvent ReturnMessage(Me, String.Format("In the same general area as {0}.", staticPerson.FirstName))
    End Sub
    Private Sub CompareCompanyName(ByVal sender As Object, ByVal person As PersonModel, ByVal staticPerson As PersonModel) Handles Me.ApplyRule
        Select Case True
            Case person.CompanyName.Contains(staticPerson.LastName)
                If person.CompanyName.Contains(String.Format("IAm{0}{1}", staticPerson.FirstName, staticPerson.LastName)) Then
                    RaiseEvent ReturnMessage(Me, String.Format("{0}'s Company", staticPerson.FirstName))
                Else
                    RaiseEvent ReturnMessage(Me, String.Format("A company owned by a {0}", staticPerson.LastName))
                End If


        End Select

        If person.CompanyPostalCode.StartsWith("08") Then RaiseEvent ReturnMessage(Me, "A Company in New Jersey")
    End Sub

End Class
