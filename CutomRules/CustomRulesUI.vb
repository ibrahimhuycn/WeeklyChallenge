Public Class CustomRulesUI
    Dim WithEvents _person As PersonModel
    Private Sub ButtonCheckRules_Click(sender As Object, e As EventArgs) Handles ButtonCheckRules.Click
        TextBoxDisplayMessage.Text = ""
        _person = New PersonModel
        _person.ApplyRules(Me, New PersonModel With {.FirstName = TextBoxFirstName.Text,
                          .LastName = TextBoxLastName.Text,
                          .PostalCode = TextBoxPostalCode.Text,
                          .CompanyName = TextBoxCompanyName.Text,
                          .CompanyPostalCode = TextBoxCompanyPostalCode.Text})
    End Sub

    Private Sub DisplayMessage(ByVal sender As Object, ByVal message As String) Handles _person.ReturnMessage

        If Not TextBoxDisplayMessage.Text = Nothing Then
            TextBoxDisplayMessage.Text = String.Format("{0}{1}{2}", TextBoxDisplayMessage.Text, message, vbCrLf)
        Else

            TextBoxDisplayMessage.Text = message & vbCrLf
        End If
    End Sub
End Class
