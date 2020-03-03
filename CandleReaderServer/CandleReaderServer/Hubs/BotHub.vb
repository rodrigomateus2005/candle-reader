Imports System.Threading.Tasks
Imports CandleReaderServer.Ordem
Imports Microsoft.AspNet.SignalR

Public Class BotHub
    Inherits Hub

    Private candleReader As ICandleReader

    Public Sub New(candleReader As ICandleReader)
        Me.candleReader = candleReader
        Me.candleReader.OnPriceChanged = AddressOf OnPriceChanged
        Me.candleReader.OnOrderAdded = AddressOf OnOrderAdded
    End Sub

    Protected Overrides Sub Finalize()

    End Sub

    Public Function GetAtivos() As Ativo()
        Return Me.candleReader.GetAtivos()
    End Function

    Public Function GetOrdens() As Ordem()
        Return Me.candleReader.GetOrdens()
    End Function

    Public Function GetCandles(ativo As String, ByVal timeFrame As Integer) As Candle()
        Return Me.candleReader.GetCandles200(ativo, timeFrame)
    End Function

    Public Shared Sub OnPriceChanged(sender As Object, e As PriceChangedEventArgs)
        Dim context = GlobalHost.ConnectionManager.GetHubContext(Of BotHub)()
        context.Clients.All.onPriceChanged(e)
    End Sub

    Function AddOrdem(ativo As String, tipo As TipoOrdem, volume As Decimal) As Boolean
        Return Me.candleReader.AddOrdem(ativo, tipo, volume)
    End Function

    Public Shared Sub OnOrderAdded(sender As Object, e As EventArgs)
        Dim context = GlobalHost.ConnectionManager.GetHubContext(Of BotHub)()
        context.Clients.All.onOrderAdded(e)
    End Sub

End Class
