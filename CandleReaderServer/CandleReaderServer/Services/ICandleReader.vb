Public Interface ICandleReader

    Property OnPriceChanged As PriceChangedEventHandler

    Function GetAtivos() As Ativo()
    Function GetCandles200(ByVal ativo As String, ByVal timeFrame As Integer) As Candle()
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