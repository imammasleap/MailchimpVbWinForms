
Imports MailChimp.Net.Models

Public Class Dashboard

    Dim appConfig As AppConfig = New AppConfig()
    Dim audiences As IEnumerable(Of List)
    Dim campaigns As IEnumerable(Of Campaign)
    Dim manager


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim apiKey As String = appConfig.getApiKey()
        manager = New MailchimpService(apiKey)

        audiences = manager.GetAudieances()

        For Each audience In audiences
            comAudience.Items.Add(audience.Name)
        Next

    End Sub


    Private Sub comAudience_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comAudience.SelectedIndexChanged

        campaigns = manager.GetCampaigns()

        For Each campaign In campaigns
            cmbCampaigns.Items.Add(campaign.Settings.Title)
        Next

        lbl2.Visible = True
        cmbCampaigns.Visible = True

    End Sub


    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim selectedAudience As List = New List()

        For Each audience In audiences
            If audience.Name = comAudience.Text Then
                selectedAudience = audience
                Exit For
            End If
        Next

        Dim selectedCampaign As Campaign = New Campaign()

        For Each campaign In campaigns
            If campaign.Settings.Title = cmbCampaigns.Text Then
                selectedCampaign = campaign
                Exit For
            End If
        Next


        ' Send Email
        If selectedCampaign.Id IsNot Nothing Then
            manager.SendEmail(selectedCampaign.Id)
        Else
            MessageBox.Show("Please select a campaign")
        End If

    End Sub

End Class