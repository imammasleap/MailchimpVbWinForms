Imports MailChimp.Net.Core
Imports MailChimp.Net.Models

Public Class Settings

    Dim appConfig As AppConfig = New AppConfig()
    Dim apiKey As String

    Public isSettingUpdated As Boolean
    Dim services As MailchimpService
    Dim signedInUser As ApiInfo

    Dim audiences As IEnumerable(Of List)
    Dim segments As IEnumerable(Of ListSegment)

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apiKey = appConfig.getApiKey()
    End Sub

    Private Sub Settings_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        If apiKey IsNot Nothing Then
            services = New MailchimpService(apiKey)
            signedInUser = services.GetApiInfo()
            loadReplyForm()
            loadAudiences()
            loadTitle()
            loadCampaignType()
        Else

        End If

    End Sub

    Private Sub loadReplyForm()
        txtReplyFrom.Text = If(appConfig.getReplyFrom() IsNot Nothing, appConfig.getReplyFrom(), signedInUser.Email)
    End Sub

    Private Sub loadAudiences()
        audiences = services.GetAudieances()
        If audiences IsNot Nothing Then
            combAudiences.Enabled = True
            For Each audience In audiences
                combAudiences.Items.Add(audience.Name)

                ' Select item
                If audience.Id = appConfig.getAudienceId() Then
                    combAudiences.SelectedItem = audience.Name
                End If
            Next
        End If
    End Sub


    Private Sub combAudiences_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combAudiences.SelectedIndexChanged

        Dim listId = audiences(combAudiences.SelectedIndex).Id
        loadSegments(listId)

    End Sub


    Private Sub loadSegments(listId As String)
        segments = services.GetSegments(listId)
        If segments IsNot Nothing Then
            combSegment.Enabled = True
            For Each segment In segments
                combSegment.Items.Add(segment.Name)
                ' Select item
                If segment.Id = appConfig.getSegmentsId() Then
                    combSegment.SelectedItem = segment.Name
                End If
            Next
        End If
    End Sub



    Private Sub loadTitle()
        txtCampaignTitle.Text = appConfig.getCampaignTitle()
    End Sub

    Private Sub loadCampaignType()

        combCampaignType.Items.Add("Regular")
        combCampaignType.Items.Add("Plaintext")
        combCampaignType.SelectedIndex = appConfig.getCampaignType() - 1

    End Sub


    Private Sub btnApplySetting_Click(sender As Object, e As EventArgs) Handles btnApplySetting.Click

        Dim email As String = txtReplyFrom.Text
        Dim title As String = txtCampaignTitle.Text

        If Extantion.IsEmail(email) = False Then
            MessageBox.Show("Invalid email address!")
        ElseIf title.Length = 0 Then
            MessageBox.Show("Campaign title is empty!")
        Else
            appConfig.configuration(AppConfig.replyFromKey) = email
            appConfig.configuration(AppConfig.audienceIdKey) = audiences(combAudiences.SelectedIndex).Id
            appConfig.configuration(AppConfig.segmentsIdKey) = segments(combSegment.SelectedIndex).Id
            appConfig.configuration(AppConfig.campaignTitleKey) = title
            appConfig.configuration(AppConfig.campaingnTypeKey) = combCampaignType.SelectedIndex + 1
            appConfig.setSettings()
            MessageBox.Show("Setting applied!")
            Me.Dispose()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class