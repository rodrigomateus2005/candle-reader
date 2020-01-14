Imports System.Threading.Tasks
Imports Microsoft.AspNet.SignalR

Public Class BotHub
    Inherits Hub

    Private candleReader As ICandleReader

    Public Sub New(candleReader As ICandleReader)
        Me.candleReader = candleReader
    End Sub

    Public Overrides Function OnConnected() As Task
        Me.candleReader.Clients = Me.Clients
        Return MyBase.OnConnected()
    End Function

    Public Function GetCandles() As Candle()
        Return Me.candleReader.GetCandles200()
    End Function

End Class
