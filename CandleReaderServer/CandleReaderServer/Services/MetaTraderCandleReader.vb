Imports Microsoft.AspNet.SignalR.Hubs
Imports MtApi5

Public Class MetaTraderCandleReader
    Implements ICandleReader

    Private Const PORT As Integer = 8228
    Private _mtApiClient As MtApi5Client

    Private Ativos As Ativo()

    Private Property ICandleReader_OnPriceChanged As PriceChangedEventHandler Implements ICandleReader.OnPriceChanged

    Public Property ICandleReader_OnOrderAdded As EventHandler Implements ICandleReader.OnOrderAdded

    Public Sub New()
        Me._mtApiClient = New MtApi5Client()
        AddHandler Me._mtApiClient.ConnectionStateChanged, AddressOf Me.ConnectionStateChanged
        AddHandler Me._mtApiClient.QuoteUpdate, AddressOf Me.OnQuoteUpdated
        AddHandler Me._mtApiClient.OnTradeTransaction, AddressOf Me.OnTradeTransaction
    End Sub

    Protected Overrides Sub Finalize()
        RemoveHandler Me._mtApiClient.ConnectionStateChanged, AddressOf Me.ConnectionStateChanged
        RemoveHandler Me._mtApiClient.QuoteUpdate, AddressOf Me.OnQuoteUpdated
        RemoveHandler Me._mtApiClient.OnTradeTransaction, AddressOf Me.OnTradeTransaction
    End Sub

    Private Sub ConnectionStateChanged(ByVal sender As Object, ByVal e As Mt5ConnectionEventArgs)
        Console.WriteLine(e.ConnectionMessage)
        If e.Status = Mt5ConnectionState.Connected Then
            Me.OnConected()
        ElseIf e.Status = Mt5ConnectionState.Disconnected Then
            Me.OnDisconected()
        ElseIf e.Status = Mt5ConnectionState.Failed Then
            Me.OnFailed()
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

    Private Sub OnFailed()
        Dim t = New Threading.Thread(Sub()
                                         Threading.Thread.Sleep(5000)
                                         If Me._mtApiClient.ConnectionState <> Mt5ConnectionState.Connected Then
                                             Me._mtApiClient.BeginConnect(PORT)
                                         End If
                                     End Sub)
        t.Start()
    End Sub

    Private Sub OnTradeTransaction(ByVal sender As Object, ByVal e As Mt5TradeTransactionEventArgs)

    End Sub

    Private Sub OnQuoteUpdated(ByVal sender As Object, ByVal e As Mt5QuoteEventArgs)

        Dim ev = New PriceChangedEventArgs With {
                            .Ativo = e.Quote.Instrument,
                            .Time = e.Quote.Time,
                            .PrecoVenda = e.Quote.Bid,
                            .PrecoCompra = e.Quote.Ask
                      }

        ev.Fechamento = e.Quote.Bid

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

    Public Function GetOrdens() As Ordem() Implements ICandleReader.GetOrdens
        Dim retorno As New List(Of Ordem)

        Dim count As Integer = Me._mtApiClient.OrdersTotal()

        For index = 0 To count - 1
            Dim ticket As ULong = Me._mtApiClient.OrderGetTicket(index)

            Me._mtApiClient.OrderSelect(ticket)

            Dim ordem As New Ordem

            ordem.Preco = Me._mtApiClient.OrderGetDouble(ENUM_ORDER_PROPERTY_DOUBLE.ORDER_PRICE_CURRENT)
            ordem.LucroMaximo = Me._mtApiClient.OrderGetDouble(ENUM_ORDER_PROPERTY_DOUBLE.ORDER_TP)
            ordem.PerdaMaxima = Me._mtApiClient.OrderGetDouble(ENUM_ORDER_PROPERTY_DOUBLE.ORDER_SL)
            ordem.Executado = False
            If (Me._mtApiClient.OrderGetInteger(ENUM_ORDER_PROPERTY_INTEGER.ORDER_TYPE) = ENUM_ORDER_TYPE.ORDER_TYPE_BUY_LIMIT) Then
                ordem.Tipo = Ordem.TipoOrdem.Compra
            Else
                ordem.Tipo = Ordem.TipoOrdem.Venda
            End If

            retorno.Add(ordem)
        Next

        count = Me._mtApiClient.PositionsTotal()

        For index = 0 To count - 1
            Dim ticket As ULong = Me._mtApiClient.PositionGetTicket(index)

            Me._mtApiClient.PositionSelectByTicket(ticket)

            Dim ordem As New Ordem

            ordem.Preco = Me._mtApiClient.PositionGetDouble(ENUM_POSITION_PROPERTY_DOUBLE.POSITION_PRICE_CURRENT)
            ordem.LucroMaximo = Me._mtApiClient.PositionGetDouble(ENUM_POSITION_PROPERTY_DOUBLE.POSITION_TP)
            ordem.PerdaMaxima = Me._mtApiClient.PositionGetDouble(ENUM_POSITION_PROPERTY_DOUBLE.POSITION_SL)
            ordem.Executado = True
            If (Me._mtApiClient.PositionGetInteger(ENUM_POSITION_PROPERTY_INTEGER.POSITION_TYPE) = ENUM_ORDER_TYPE.ORDER_TYPE_BUY_LIMIT) Then
                ordem.Tipo = Ordem.TipoOrdem.Compra
            Else
                ordem.Tipo = Ordem.TipoOrdem.Venda
            End If

            retorno.Add(ordem)
        Next

        Return retorno.ToArray()
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

    Public Function AddOrdem(ativo As String, tipo As Ordem.TipoOrdem, volume As Decimal) As Boolean Implements ICandleReader.AddOrdem
        Return Me.AddOrdem(ativo, tipo, volume, 0, 0, 0)
    End Function

    Public Function AddOrdem(ativo As String, tipo As Ordem.TipoOrdem, volume As Decimal, preco As Decimal) As Boolean Implements ICandleReader.AddOrdem
        Return Me.AddOrdem(ativo, tipo, volume, preco, 0, 0)
    End Function

    Public Function AddOrdem(ativo As String, tipo As Ordem.TipoOrdem, volume As Decimal, preco As Decimal, perdaMaxima As Decimal, lucroMaximo As Decimal) As Boolean Implements ICandleReader.AddOrdem
        Dim request As New MqlTradeRequest
        Dim result As MqlTradeResult = Nothing

        If preco <= 0 Then
            request.Action = ENUM_TRADE_REQUEST_ACTIONS.TRADE_ACTION_DEAL
            If tipo = Ordem.TipoOrdem.Compra Then
                request.Type = ENUM_ORDER_TYPE.ORDER_TYPE_BUY
            Else
                request.Type = ENUM_ORDER_TYPE.ORDER_TYPE_SELL
            End If
        Else
            request.Action = ENUM_TRADE_REQUEST_ACTIONS.TRADE_ACTION_PENDING
            request.Price = preco
            If tipo = Ordem.TipoOrdem.Compra Then
                request.Type = ENUM_ORDER_TYPE.ORDER_TYPE_BUY_LIMIT
            Else
                request.Type = ENUM_ORDER_TYPE.ORDER_TYPE_SELL_LIMIT
            End If
        End If

        request.Type_filling = ENUM_ORDER_TYPE_FILLING.ORDER_FILLING_RETURN
        request.Volume = volume

        request.Sl = perdaMaxima
        request.Tp = lucroMaximo

        Return Me._mtApiClient.OrderSend(request, result)
    End Function

End Class
