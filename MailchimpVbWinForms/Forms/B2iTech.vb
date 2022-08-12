Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports MailChimp.Net.Models

Public Class B2iTech

    Dim appConfig As AppConfig = New AppConfig()
    Dim apiKey As String

    Dim service As MailchimpService
    Dim signedInUser As ApiInfo



    Private Sub B2iTech_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadMethod()

    End Sub


    Private Sub B2iTech_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        shownMethod()

    End Sub


    Private Sub loadMethod()

        apiKey = appConfig.getApiKey()

        If apiKey IsNot Nothing Then
            service = New MailchimpService(apiKey)

            signedInUser = service.GetApiInfo()

            picBoxUserAvater.LoadAsync(signedInUser.AvatarUrl)
            lblUserName.Text = signedInUser.AccountName
            btnSignIn.Text = "Sign Out"
        Else
            picBoxUserAvater.Image = Nothing
            lblUserName.Text = "Guest user"
            btnSignIn.Text = "Sign In"
        End If

    End Sub

    Private Sub shownMethod()

        apiKey = appConfig.getApiKey()

        If apiKey Is Nothing Then
            Using signIn = New SignIn()
                signIn.ShowDialog()

                If signIn.isSignedIn = True Then
                    loadMethod()
                End If

            End Using
        End If

    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        If btnSignIn.Text = "Sign In" Then
            shownMethod()
        ElseIf btnSignIn.Text = "Sign Out" Then
            appConfig.signOut()
            loadMethod()
            shownMethod()
        End If

    End Sub


    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        apiKey = appConfig.getApiKey()

        If apiKey Is Nothing Then
            Using signIn = New SignIn()
                signIn.ShowDialog()
                If signIn.isSignedIn = True Then
                    loadMethod()
                End If
            End Using
        Else
            Using settings = New Settings()
                settings.ShowDialog()
                If settings.isSettingUpdated = True Then
                    loadMethod()
                End If
            End Using
        End If

    End Sub


    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Dim subject As String = txtSubject.Text
        Dim body As String = HtmlEditControlMessage.DocumentHTML


        If subject Is Nothing Then
            MessageBox.Show("Subject is empty!")
        ElseIf body Is Nothing Then
            MessageBox.Show("Email body is empty!")
        Else

            Dim task = service.SendEmail(subject, body, signedInUser.AccountName, appConfig)

        End If

    End Sub

End Class