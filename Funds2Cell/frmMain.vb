'https://apiuat.beyondpayments.com/BulkIssuingRestAPI/help

Imports System.Net.Http
Imports System.Web
Imports System.Text
Imports System.Net
Imports Newtonsoft.Json

Public Class frmMain

    'Global STD Vars
    Private STDChannelName As String
    Private STDChannelToken As String
    Private STDBeyondPaymentsAPIUrl As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSTDVars()
    End Sub

    Private Sub LoadSTDVars()
        ' APIUrl = "https://api.payaccsys.com/"

        'Standard Bank - BeyondPayments:InstantMoney
        STDChannelName = "Payaccsys"
        STDChannelToken = "123456"
        STDBeyondPaymentsAPIUrl = "https://apiuat.beyondpayments.com/"

    End Sub

    Private Async Function CallCreateChannelSession() As Task(Of HttpResponseMessage)

        Dim response As New HttpResponseMessage

        Try

            'Dim credentials As New NetworkCredential("test", "test")
            'Dim handler As New HttpClientHandler
            'handler.Credentials = credentials

            Using client As New HttpClient()

                client.BaseAddress = New Uri(STDBeyondPaymentsAPIUrl)
                client.DefaultRequestHeaders.Authorization = _
                   New Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(String.Format("{0}:{1}", "test", "test"))))

                'client.DefaultRequestHeaders.Accept.Clear()
                client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))
                '  Dim requestUrl As String = String.Format("api/v1mock/transactions/1?customerCode=TEST1APIFN")
                Dim requestUrl As String = String.Format("BulkIssuingRestAPI/Api/v1/CreateChannelSession")
                Dim strChannelName = HttpUtility.UrlEncode(STDChannelName)
                Dim strChannelToken = HttpUtility.UrlEncode(STDChannelToken)
                'Dim queryString As New StringContent("", Encoding.UTF8, "application/json")
                Dim queryString As New StringContent("ChannelName=" & strChannelName, Encoding.UTF8, "application/json")
                response = Await client.PostAsync(requestUrl, queryString)

            End Using

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

        Return response

    End Function

    Private Function CallVerifyUser() As Boolean

        Return False

    End Function

    Private Async Sub StandardBankProcess()

        Dim objSTDChannelSession As New STDBeyondPayments.CreateChannelSession
        Dim CreateChannelSessionResponse As HttpResponseMessage

        CreateChannelSessionResponse = Await Task.Run(Function() CallCreateChannelSession())

        If CreateChannelSessionResponse IsNot Nothing Then

            Me.txtHttpClient.Text = CreateChannelSessionResponse.StatusCode.ToString() & vbCrLf

            If CreateChannelSessionResponse.IsSuccessStatusCode Then
                MsgBox("SUCCESS")
            Else
                MsgBox("FAILED")
            End If

            Dim strBodyContent As String = Await CreateChannelSessionResponse.Content.ReadAsStringAsync
            Me.txtHttpClient.Text += strBodyContent

            objSTDChannelSession = JsonConvert.DeserializeObject(Of STDBeyondPayments.CreateChannelSession)(strBodyContent)

            MsgBox(objSTDChannelSession.ResultText)

        End If

    End Sub

    Private Sub btnSubmitBatch_Click(sender As Object, e As EventArgs) Handles btnSubmitBatch.Click
        '2do case stdbank cell batch selected
        StandardBankProcess()
    End Sub


End Class
