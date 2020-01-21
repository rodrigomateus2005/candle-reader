Imports System.Threading.Tasks
Imports Microsoft.AspNet.SignalR

Public Class BotHub
    Inherits Hub

    Private candleReader As ICandleReader

    Public Sub New(candleReader As ICandleReader)
        Me.candleReader = candleReader
        Me.candleReader.OnPriceChanged = AddressOf OnPriceChanged
    End Sub

    Public Function GetAtivos() As String()
        Return Me.candleReader.GetAtivos()
    End Function

    Public Function GetCandles(ativo As String) As Candle()
        Return Me.candleReader.GetCandles200(ativo)
    End Function

    Public Shared Sub OnPriceChanged(sender As Object, e As PriceChangedEventArgs)
        Dim context = GlobalHost.ConnectionManager.GetHubContext(Of BotHub)()
        context.Clients.All.onPriceChanged(e)
    End Sub

End Class
