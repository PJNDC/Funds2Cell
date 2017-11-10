Namespace STDBeyondPayments

    Public Class CreateChannelSession
        Public Property SessionKey As String
        Public Property SessionChannelKey As String
        Public Property ResultText As String
        Public Property ResultCode As Integer
    End Class

    Public Class Credentials
        Public Property ChannelName As String
        Public Property ChannelToken As String
        Public Property ClientDateTime As DateTime
        Public Property ChannelKey As String
        Public Property ChannelLastSequence As String
    End Class

    Public Class VerifyUser
        Public Property UserName As String
        Public Property Password As String
        Public Property Credentials As Credentials
    End Class

End Namespace

