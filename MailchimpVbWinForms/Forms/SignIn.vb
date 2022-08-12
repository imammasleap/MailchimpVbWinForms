Public Class SignIn

    Dim appConfig As AppConfig = New AppConfig()
    Public isSignedIn As Boolean


    Private Sub txtMcApiKey_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMcApiKey.Validating
        Dim index As Integer = txtMcApiKey.Text.IndexOf("-")

        If Not index = 32 Then
            e.Cancel = True
            txtMcApiKey.Focus()
            ErrorProvider.SetError(txtMcApiKey, "Invalid api key")
        Else
            e.Cancel = False
            ErrorProvider.SetError(txtMcApiKey, "")
        End If
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then

            appConfig.setApiKey(txtMcApiKey.Text)

            Dim apiKey As String = appConfig.getApiKey()
            If apiKey IsNot Nothing Then
                isSignedIn = True
                Me.Close()
            End If

        End If
    End Sub

End Class