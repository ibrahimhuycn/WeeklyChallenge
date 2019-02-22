Public Class CustomRulesUI
    Private Sub ButtonCheckRules_Click(sender As Object, e As EventArgs) Handles ButtonCheckRules.Click
        Dim person As New PersonModel
        person.ApplyRules(Me, New PersonModel With {.FirstName = TextBoxFirstName.Text,
                          .LastName = TextBoxLastName.Text,
                          .PostalCode = TextBoxPostalCode.Text})
    End Sub
End Class
