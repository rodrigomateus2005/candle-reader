﻿Imports Microsoft.AspNet.SignalR.Hubs
Imports MtApi5

Public Class MetaTraderCandleReader
    Implements ICandleReader

    Private Const PORT As Integer = 8228
    Private _mtApiClient As MtApi5Client

    Private Ativos As Ativo()

    Private Property ICandleReader_OnPriceChanged As PriceChangedEventHandler Implements ICandleReader.OnPriceChanged

    Public Sub New()
        Me._mtApiClient = New MtApi5Client()
        AddHandler Me._mtApiClient.ConnectionStateChanged, AddressOf Me.ConnectionStateChanged
        AddHandler Me._mtApiClient.QuoteUpdate, AddressOf Me.QuoteUpdated
    End Sub

    Protected Overrides Sub Finalize()
        RemoveHandler Me._mtApiClient.ConnectionStateChanged, AddressOf Me.ConnectionStateChanged
        RemoveHandler Me._mtApiClient.QuoteUpdate, AddressOf Me.QuoteUpdated
    End Sub

    Private Sub ConnectionStateChanged(ByVal sender As Object, ByVal e As Mt5ConnectionEventArgs)
        Console.WriteLine(e.ConnectionMessage)
        If e.Status = Mt5ConnectionState.Connected Then
            Me.OnConected()
        ElseIf e.Status = Mt5ConnectionState.Disconnected Then
            Me.OnDisconected()
        End If
    End Sub

    Private Sub OnConected()
        Dim quotes = Me._mtApiClient.GetQuotes().ToArray()

        Dim ativos As New List(Of Ativo)
        For Each quote In quotes
            Dim ativo As New Ativo

            ativo.Nome = quote.Instrument
            ativo.Digitos = Me._mtApiClient.SymbolInfoInteger(quote.Instrument, ENUM_SYMBOL_INFO_INTEGER.SYMBOL_DIGITS)

            ativos.Add(ativo)
        Next

        Me.Ativos = ativos.ToArray
    End Sub

    Private Sub OnDisconected()
        Me.Start()
    End Sub

    Private Sub QuoteUpdated(ByVal sender As Object, ByVal e As Mt5QuoteEventArgs)
        Dim closes As Double() = {}

        Dim ev = New PriceChangedEventArgs With {
                            .Ativo = e.Quote.Instrument,
                            .Time = e.Quote.Time,
                            .PrecoVenda = e.Quote.Bid,
                            .PrecoCompra = e.Quote.Ask
                      }

        Me._mtApiClient.CopyClose(e.Quote.Instrument, ENUM_TIMEFRAMES.PERIOD_M1, 0, 1, closes)

        ev.Fechamento = closes.FirstOrDefault()

        Me.OnPriceChanged(ev)
    End Sub

    Public Sub Start()
        Me._mtApiClient.BeginConnect("localhost", MetaTraderCandleReader.PORT)
    End Sub

    Private Function GetCandles(ByVal symbol As String, ByVal timeFrame As ENUM_TIMEFRAMES, ByVal count As Integer) As Candle()
        If Me._mtApiClient.ConnectionState = Mt5ConnectionState.Disconnected Then Return Nothing

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

    Public Function GetAtivos() As Ativo() Implements ICandleReader.GetAtivos
        Return Me.Ativos
    End Function

    Public Function GetCandles200(ByVal ativo As String, ByVal timeFrame As Integer) As Candle() Implements ICandleReader.GetCandles200
        Dim timeFrameEnum As ENUM_TIMEFRAMES
        If timeFrame = 1 Then
            timeFrameEnum = ENUM_TIMEFRAMES.PERIOD_M1
        Else
            timeFrameEnum = ENUM_TIMEFRAMES.PERIOD_M15
        End If
        Dim retorno = Me.GetCandles(ativo, timeFrameEnum, 200)
        Return retorno
    End Function

    Protected Overridable Sub OnPriceChanged(ByVal e As PriceChangedEventArgs)
        If Me.ICandleReader_OnPriceChanged IsNot Nothing Then
            Me.ICandleReader_OnPriceChanged.Invoke(Me, e)
        End If
    End Sub

End Class
