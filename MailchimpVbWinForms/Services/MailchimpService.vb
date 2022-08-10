Imports MailChimp.Net
Imports MailChimp.Net.Core
Imports MailChimp.Net.Interfaces
Imports MailChimp.Net.Models


Public Class MailchimpService

    Public manager As IMailChimpManager

    Public Sub New(ByVal apiKey As String)
        manager = New MailChimpManager(apiKey)
    End Sub


    Public Function GetAudieances() As IEnumerable(Of List)

        Try
            Dim result = manager.Lists.GetAllAsync()
            Return result.Result
        Catch ex As MailChimpException
            Return {}
        End Try

    End Function


    Public Function GetCampaigns() As IEnumerable(Of Campaign)

        Try
            Dim result = manager.Campaigns.GetAllAsync()
            Return result.Result
        Catch ex As MailChimpException
            Return {}
        End Try

    End Function


    Public Async Function SendEmail(campaignId As String) As Task

        Try
            Await manager.Campaigns.SendAsync(campaignId)
            MessageBox.Show("Email sent successfully!")
        Catch ex As MailChimpException
            MessageBox.Show("Email sent failed!, Reason: " & ex.Message)
        End Try

    End Function



End Class

