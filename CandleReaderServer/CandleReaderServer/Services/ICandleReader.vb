Imports Microsoft.AspNet.SignalR.Hubs

Public Interface ICandleReader
    Event PriceChanged As PriceChangedEventHandler

    Property Clients As IHubCallerConnectionContext(Of Object)

    Function GetCandles200() As Candle()
End Interface

Public Delegate Sub PriceChangedEventHandler(sender As Object, e As PriceChangedEventArgs)

Public Class PriceChangedEventArgs
    Inherits EventArgs
    Public Property PrecoCompra As Decimal
    Public Property PrecoVenda As Decimal
    Public Property Time As DateTime
End Class

Public Class Candle
    Public Property Time As DateTime
    Public Property Open As Decimal
    Public Property Close As Decimal
    Public Property High As Decimal
    Public Property Low As Decimal
    Public Property Volume As Decimal
End Class