Public Interface ICandleReader

    Property OnPriceChanged As PriceChangedEventHandler

    Function GetAtivos() As String()
    Function GetCandles200(ByVal ativo As String) As Candle()
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

Public Class Candle
    Public Property Time As DateTime
    Public Property Open As Decimal
    Public Property Close As Decimal
    Public Property High As Decimal
    Public Property Low As Decimal
    Public Property Volume As Decimal
End Class