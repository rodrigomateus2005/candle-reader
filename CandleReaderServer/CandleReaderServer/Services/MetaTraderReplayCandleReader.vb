Imports System.Threading
Imports MtApi5

Public Class MetaTraderReplayCandleReader
    Implements ICandleReader

    Private Structure Mercado
        Public Pregao As Thread
        Public Tempo As Date
        Public ProximosTicks As List(Of MqlTick)
        Public CandlesAnteriores As Dictionary(Of ENUM_TIMEFRAMES, Candle())
    End Structure

    Private Const PORT As Integer = 8228
    Private _mtApiClient As MtApi5Client

    Private Ativos As Ativo()

    Private Data As Date

    Private Candles As Dictionary(Of String, Mercado)

    Public Sub New(Data As Date)
        Me.Data = Data
        Me.Candles = New Dictionary(Of String, Mercado)
        Me._mtApiClient = New MtApi5Client()
        AddHandler Me._mtApiClient.ConnectionStateChanged, AddressOf Me.ConnectionStateChanged
    End Sub

    Public Sub Start()
        Me._mtApiClient.BeginConnect("localhost", MetaTraderReplayCandleReader.PORT)
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

    Private Property ICandleReader_OnPriceChanged As PriceChangedEventHandler Implements ICandleReader.OnPriceChanged

    Public Property OnOrderAdded As EventHandler Implements ICandleReader.OnOrderAdded
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As EventHandler)
            Throw New NotImplementedException()
        End Set
    End Property

    Protected Overridable Sub OnPriceChanged(ByVal e As PriceChangedEventArgs)
        If Me.ICandleReader_OnPriceChanged IsNot Nothing Then
            Me.ICandleReader_OnPriceChanged.Invoke(Me, e)
        End If
    End Sub

    Public Function GetAtivos() As Ativo() Implements ICandleReader.GetAtivos
        Return Me.Ativos
    End Function

    Public Function GetCandles200(ativo As String, timeFrame As Integer) As Candle() Implements ICandleReader.GetCandles200

        Return Me.GetCandles(ativo, timeFrame, 200)

    End Function

    Private Function GetCandles(ByVal symbol As String, ByVal timeFrame As ENUM_TIMEFRAMES, ByVal count As Integer) As Candle()
        If Me._mtApiClient.ConnectionState = Mt5ConnectionState.Disconnected Then Return Nothing

        Dim timeFrameEnum As ENUM_TIMEFRAMES

        If timeFrame = 1 Then
            timeFrameEnum = ENUM_TIMEFRAMES.PERIOD_M1
        Else
            timeFrameEnum = ENUM_TIMEFRAMES.PERIOD_M15
        End If

        If Not Me.Candles.ContainsKey(symbol) Then
            Me.Candles.Add(symbol, Me.AbrirMercado(symbol))
        End If

        If Not Me.Candles(symbol).CandlesAnteriores.ContainsKey(timeFrameEnum) Then
            Dim closes As Double() = {}
            Dim openings As Double() = {}
            Dim highs As Double() = {}
            Dim lows As Double() = {}
            Dim volumes As Long() = {}
            Dim dates As DateTime() = {}
            Dim iCount As Integer = count

            Dim data = Me.Data.AddDays(1)

            If timeFrame = ENUM_TIMEFRAMES.PERIOD_M1 Then
                iCount += (60 * 24)
            Else
                iCount += (4 * 24)
            End If

            Me._mtApiClient.CopyClose(symbol, timeFrame, data, iCount, closes)
            Me._mtApiClient.CopyOpen(symbol, timeFrame, data, iCount, openings)
            Me._mtApiClient.CopyHigh(symbol, timeFrame, data, iCount, highs)
            Me._mtApiClient.CopyLow(symbol, timeFrame, data, iCount, lows)
            Me._mtApiClient.CopyTickVolume(symbol, timeFrame, data, iCount, volumes)
            Me._mtApiClient.CopyTime(symbol, timeFrame, data, iCount, dates)

            Dim retorno As List(Of Candle) = New List(Of Candle)()

            For i As Integer = 0 To iCount - 1
                retorno.Add(New Candle() With {
                .Open = CDec(openings(i)),
                .Close = CDec(closes(i)),
                .High = CDec(highs(i)),
                .Low = CDec(lows(i)),
                .Volume = volumes(i),
                .Time = dates(i)
            })
            Next

            Me.Candles(symbol).CandlesAnteriores(timeFrame) = retorno.ToArray()
        End If

        Return Me.Candles(symbol).CandlesAnteriores(timeFrame) _
        .Where(Function(q) q.Time < Me.Candles(symbol).Tempo) _
        .Reverse() _
        .Take(200) _
        .Reverse() _
        .ToArray()
    End Function

    Private Function AbrirMercado(ByVal symbol As String) As Mercado
        Dim mercado As New Mercado

        Dim proximosTicks As New List(Of MqlTick)

        Dim data As Date = Me.Data

        While data < Me.Data.AddDays(1)
            Dim ticks As ULong = Math.Abs(New Date(1970, 1, 1).Subtract(data).TotalMilliseconds)
            proximosTicks.AddRange(Me._mtApiClient.CopyTicks(symbol, CopyTicksFlag.All, ticks, 1))

            data = proximosTicks.Last.time
        End While

        mercado.Tempo = Me.Data
        mercado.CandlesAnteriores = New Dictionary(Of ENUM_TIMEFRAMES, Candle())
        mercado.ProximosTicks = proximosTicks.Where(Function(q) q.time < Me.Data.AddDays(1)).ToList()

        mercado.Pregao = New Thread(Sub()
                                        While data < Me.Data.AddDays(1)

                                            Dim e As MqlTick = mercado.ProximosTicks.Last(Function(q) q.time < mercado.Tempo)

                                            Dim ev = New PriceChangedEventArgs With {
                                                    .Ativo = symbol,
                                                    .Time = e.time,
                                                    .PrecoVenda = e.bid,
                                                    .PrecoCompra = e.ask
                                              }

                                            ev.Fechamento = e.bid

                                            Me.OnPriceChanged(ev)

                                            mercado.Tempo = mercado.Tempo.AddMilliseconds(500)
                                            Thread.Sleep(500)
                                        End While
                                    End Sub)
        mercado.Pregao.Start()

        Return mercado
    End Function

    Public Function GetOrdens() As Ordem() Implements ICandleReader.GetOrdens
        Throw New NotImplementedException()
    End Function

    Public Function AddOrdem(ativo As String, tipo As Ordem.TipoOrdem, volume As Decimal) As Boolean Implements ICandleReader.AddOrdem
        Throw New NotImplementedException()
    End Function

    Public Function AddOrdem(ativo As String, tipo As Ordem.TipoOrdem, volume As Decimal, preco As Decimal) As Boolean Implements ICandleReader.AddOrdem
        Throw New NotImplementedException()
    End Function

    Public Function AddOrdem(ativo As String, tipo As Ordem.TipoOrdem, volume As Decimal, preco As Decimal, perdaMaxima As Decimal, lucroMaximo As Decimal) As Boolean Implements ICandleReader.AddOrdem
        Throw New NotImplementedException()
    End Function
End Class
