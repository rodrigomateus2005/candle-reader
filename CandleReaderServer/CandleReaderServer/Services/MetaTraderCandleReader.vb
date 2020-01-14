Imports Microsoft.AspNet.SignalR.Hubs
Imports MtApi5

Public Class MetaTraderCandleReader
    Implements ICandleReader

    'Private Const SYMBOLS_NAME As String = "WIN$"
    Private Const SYMBOLS_NAME As String = "EURUSD"
    Private Const PORT As Integer = 8228
    Private _mtApiClient As MtApi5Client

    Public Event PriceChanged As PriceChangedEventHandler Implements ICandleReader.PriceChanged
    Private Property Clients As IHubCallerConnectionContext(Of Object) Implements ICandleReader.Clients

    Public Sub New()
        Me._mtApiClient = New MtApi5Client()
        AddHandler Me._mtApiClient.ConnectionStateChanged, AddressOf Me.ConnectionStateChanged
    End Sub

    Protected Overrides Sub Finalize()
        RemoveHandler Me._mtApiClient.ConnectionStateChanged, AddressOf Me.ConnectionStateChanged
    End Sub

    Private Sub ConnectionStateChanged(ByVal sender As Object, ByVal e As Mt5ConnectionEventArgs)
        Console.WriteLine(e.ConnectionMessage)
    End Sub

    Public Sub Start()
        Me._mtApiClient.BeginConnect("localhost", MetaTraderCandleReader.PORT)
    End Sub

    Private Function GetCandles(ByVal symbol As String, ByVal timeFrame As ENUM_TIMEFRAMES, ByVal count As Integer) As Candle()
        Dim closes As Double() = {}
        Dim openings As Double() = {}
        Dim highs As Double() = {}
        Dim lows As Double() = {}
        Dim volumes As Long() = {}
        Dim dates As DateTime() = {}

        Me._mtApiClient.CopyClose(symbol, timeFrame, 0, count, closes)
        Me._mtApiClient.CopyOpen(symbol, timeFrame, 0, count, openings)
        Me._mtApiClient.CopyHigh(symbol, timeFrame, 0, count, highs)
        Me._mtApiClient.CopyLow(symbol, timeFrame, 0, count, lows)
        Me._mtApiClient.CopyTickVolume(symbol, timeFrame, 0, count, volumes)
        Me._mtApiClient.CopyTime(symbol, timeFrame, 0, count, dates)

        Dim retorno As List(Of Candle) = New List(Of Candle)()

        For i As Integer = 0 To count - 1
            retorno.Add(New Candle() With {
            .Open = CDec(openings(i)),
            .Close = CDec(closes(i)),
            .High = CDec(highs(i)),
            .Low = CDec(lows(i)),
            .Volume = volumes(i),
            .Time = dates(i)
        })
        Next

        Return retorno.ToArray()
    End Function

    Public Function GetCandles200() As Candle() Implements ICandleReader.GetCandles200
        Dim retorno = Me.GetCandles(MetaTraderCandleReader.SYMBOLS_NAME, ENUM_TIMEFRAMES.PERIOD_M15, 200)
        Return retorno
    End Function

    Protected Overridable Sub OnPriceChanged(ByVal e As PriceChangedEventArgs)
        RaiseEvent PriceChanged(Me, e)
        Me.Clients?.Caller.SendCoreAsync("OnPriceChange", New Object() {e})
    End Sub

End Class
