Imports CandleReaderServer.Ordem

Public Interface ICandleReader

    Property OnPriceChanged As PriceChangedEventHandler
    Property OnOrderAdded As EventHandler

    Function GetAtivos() As Ativo()
    Function GetOrdens() As Ordem()
    Function GetCandles200(ByVal ativo As String, ByVal timeFrame As Integer) As Candle()

    Function AddOrdem(ativo As String, tipo As TipoOrdem, volume As Decimal) As Boolean
    Function AddOrdem(ativo As String, tipo As TipoOrdem, volume As Decimal, preco As Decimal) As Boolean
    Function AddOrdem(ativo As String, tipo As TipoOrdem, volume As Decimal, preco As Decimal, perdaMaxima As Decimal, lucroMaximo As Decimal) As Boolean

End Interface

Public Delegate Sub PriceChangedEventHandler(sender As Object, e As PriceChangedEventArgs)

Public Class PriceChangedEventArgs
    Inherits EventArgs
    Public Property Fechamento As Decimal
    Public Property PrecoCompra As Decimal
    Public Property PrecoVenda As Decimal
    Public Property Time As DateTime
    Public Property Ativo As String
End Class