Imports System.IO
Imports System.Net
Imports System.Text.Json.Serialization
Imports Newtonsoft.Json

Public Class ServiceAPI

    Sub send(dataType As String, dataProperties As String)
        'Buat objek data
        Dim jsonData As New Dictionary(Of String, String)
        jsonData.Add("dataType", dataType)
        jsonData.Add("dataProperties", dataProperties)

        'ubah ke format json
        Dim jsonString As String = JsonConvert.SerializeObject(jsonData)

        'API endpoint
        Dim url As String = "http://103.82.242.90:10006/api/data/store" 'Bisa diubah dengan URL API asli

        'create request
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "POST" 'Method CRUD ada GET, POST, PUT, DELETE, dan REQUEST
        request.ContentType = "application/json"

        'Tulis json ke body request
        Using StreamWriter As New StreamWriter(request.GetRequestStream())
            StreamWriter.Write(jsonString)
        End Using

        'Get response
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Using StreamReader As New StreamReader(response.GetResponseStream())
            Dim result As String = StreamReader.ReadToEnd()
            Console.WriteLine("API Response : " & result)
        End Using

        Console.ReadLine()
    End Sub

End Class
