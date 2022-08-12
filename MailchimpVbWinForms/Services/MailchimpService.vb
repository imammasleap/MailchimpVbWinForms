Imports MailChimp.Net
Imports MailChimp.Net.Core
Imports MailChimp.Net.Interfaces
Imports MailChimp.Net.Models


Public Class MailchimpService

    Public manager As IMailChimpManager

    Public Sub New(ByVal apiKey As String)
        manager = New MailChimpManager(apiKey)
    End Sub


    Public Function GetApiInfo() As ApiInfo

        Try
            Dim result = manager.Api.GetInfoAsync()
            Return result.Result
        Catch ex As MailChimpException
            Return Nothing
        End Try

    End Function


    Public Function GetAudieances() As IEnumerable(Of List)

        Try
            Dim result = manager.Lists.GetAllAsync()
            Return result.Result
        Catch ex As MailChimpException
            Return Nothing
        End Try

    End Function


    Public Function GetSegments(ByVal listId As String) As IEnumerable(Of ListSegment)

        Try
            Dim result = manager.ListSegments.GetAllAsync(listId)
            Return result.Result
        Catch ex As MailChimpException
            Return Nothing
        End Try

    End Function




    Public Async Function SendEmail(subject As String, body As String, fromName As String, config As AppConfig) As Task

        Try
            Dim listId = config.getAudienceId()
            Dim segmentId = config.getSegmentsId()
            Dim replyFrom = config.getReplyFrom()
            Dim campaignTitle = config.getCampaignTitle()
            Dim campaignType = config.getCampaignType()


            Dim campaignSettings As Setting = New Setting With {
                .FromName = fromName,
                .ReplyTo = replyFrom,
                .Title = campaignTitle,
                .SubjectLine = subject
            }

            Dim segment As ListSegment = Await manager.ListSegments.GetAsync(listId, segmentId).ConfigureAwait(False)

            Dim campaign = Await manager.Campaigns.AddAsync(
                New Campaign With {
                    .Settings = campaignSettings,
                    .Recipients = New Recipient With {
                        .ListId = listId,
                        .SegmentText = segment.Name,
                        .SegmentOptions = segment.Options
                    },
                    .Type = campaignType
                }).ConfigureAwait(False)

            Await manager.Content.AddOrUpdateAsync(campaign.Id, New ContentRequest With {.Html = body})

            ' Finally send the campaign to the recipient
            Await manager.Campaigns.SendAsync(campaign.Id)

            MessageBox.Show("Mail sent successfully!")
        Catch ex As Exception
            MessageBox.Show("Exception: " & ex.Message)
        End Try

    End Function



End Class

