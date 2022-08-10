Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Runtime.Serialization.Formatters.Binary

Public Class AppConfig

    Public apiKey As String

    Dim configuration As New Dictionary(Of String, Object)
    Dim formatter = New BinaryFormatter()
    Dim storage = IsolatedStorageFile.GetUserStoreForAssembly()

    Const key = "apiKey"
    Const configurationFileName = "configuration.cfg"

    Public Sub setApiKey(ByVal value As String)

        configuration.Clear()
        configuration.Add(key, value)
        Using stream = storage.OpenFile(configurationFileName, FileMode.OpenOrCreate, FileAccess.Write)
            formatter.Serialize(stream, configuration)
        End Using

    End Sub

    Public Function getApiKey() As String

        Dim value As String = ""

        Using stream = storage.OpenFile(configurationFileName, FileMode.OpenOrCreate, FileAccess.Read)
            configuration = formatter.Deserialize(stream)
        End Using
        If configuration.ContainsKey(key) Then
            value = configuration.Item(key)
        End If

        Return value

    End Function


End Class
