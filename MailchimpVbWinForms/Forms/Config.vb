Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Config

    Dim appConfig As AppConfig = New AppConfig()

    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim apiKey As String = appConfig.getApiKey()
        If apiKey IsNot Nothing Then
            txtMcApiKey.Text = apiKey
        End If

    End Sub

    Private Sub txtMcApiKey_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMcApiKey.Validating

        Dim index As Integer = txtMcApiKey.Text.IndexOf("-")

        If Not index = 32 Then
            e.Cancel = True
            txtMcApiKey.Focus()
            errorProvider.SetError(txtMcApiKey, "Invalid api key")
        Else
            e.Cancel = False
            errorProvider.SetError(txtMcApiKey, "")
        End If

    End Sub

    Private Sub btnConfigure_Click(sender As Object, e As EventArgs) Handles btnConfigure.Click

        If ValidateChildren(ValidationConstraints.Enabled) Then

            AppConfig.setApiKey(txtMcApiKey.Text)

            Dim apiKey As String = appConfig.getApiKey()
            If apiKey IsNot Nothing Then
                Dim dashboard As Dashboard = New Dashboard()
                Me.Visible = False
                dashboard.Visible = True
            End If

        End If

    End Sub

End Class