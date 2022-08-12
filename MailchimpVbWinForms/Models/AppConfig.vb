Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Runtime.Serialization.Formatters.Binary

Public Class AppConfig

    ' Formatter
    Dim formatter = New BinaryFormatter()
    ' IsolatedStorage
    Dim storage = IsolatedStorageFile.GetUserStoreForAssembly()
    ' File Name
    Const configurationFileName = "configuration.cfg"
    ' keys
    Public Const apiKey = "apiKey"
    Public Const replyFromKey = "replyFromKey"
    Public Const audienceIdKey = "audienceIdKey"
    Public Const segmentsIdKey = "segmentsIdKey"
    Public Const campaignTitleKey = "campaignTitleKey"
    Public Const campaingnTypeKey = "campaingnTypeKey"
    ' Dictionary
    Public configuration As New Dictionary(Of String, Object)

    ' Constructor
    Public Sub New()
        ' Load values on objects initialization
        configuration = getSettings()
    End Sub

    ' Settings
    Public Function getSettings() As Dictionary(Of String, Object)
        If storage.FileExists(configurationFileName) = True Then
            Using stream = storage.OpenFile(configurationFileName, FileMode.OpenOrCreate, FileAccess.Read)
                If stream.Length > 0 Then
                    Return formatter.Deserialize(stream)
                End If
            End Using
        End If
        Return Nothing
    End Function

    Public Sub setSettings()

        Using stream = storage.OpenFile(configurationFileName, FileMode.OpenOrCreate, FileAccess.Write)
            formatter.Serialize(stream, configuration)
        End Using

    End Sub


    ' Api Key
    Public Function getApiKey() As String
        If configuration.ContainsKey(apiKey) Then
            Return configuration.Item(apiKey)
        Else
            Return Nothing
        End If
    End Function

    Public Sub setApiKey(value As String)
        configuration(apiKey) = value
        setSettings()
    End Sub


    ' Reply From
    Public Function getReplyFrom() As String
        If configuration.ContainsKey(replyFromKey) Then
            Return configuration.Item(replyFromKey)
        Else
            Return Nothing
        End If
    End Function


    ' Audience Id
    Public Function getAudienceId() As String
        If configuration.ContainsKey(audienceIdKey) Then
            Return configuration.Item(audienceIdKey)
        Else
            Return Nothing
        End If
    End Function


    ' Segment Id
    Public Function getSegmentsId() As String
        If configuration.ContainsKey(segmentsIdKey) Then
            Return configuration.Item(segmentsIdKey)
        Else
            Return Nothing
        End If
    End Function


    ' Campaign Title
    Public Function getCampaignTitle() As String
        If configuration.ContainsKey(campaignTitleKey) Then
            Return configuration.Item(campaignTitleKey)
        Else
            Return Nothing
        End If
    End Function


    ' Campaign Type
    Public Function getCampaignType() As Integer
        If configuration.ContainsKey(campaingnTypeKey) Then
            Return configuration.Item(campaingnTypeKey)
        Else
            Return 0
        End If
    End Function


    ' Sign Out 
    Public Sub signOut()
        storage.DeleteFile(configurationFileName)
    End Sub

End Class
