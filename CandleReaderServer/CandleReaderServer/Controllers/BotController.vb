Imports System.Net
Imports System.Web.Http

Namespace Controllers
    <RoutePrefix("api/Bot")>
    Public Class BotController
        Inherits ApiController

        Private candleReader As ICandleReader

        Public Sub New(candleReader As ICandleReader)
            Me.candleReader = candleReader
        End Sub

        <HttpGet()>
        <ActionName("GetCandles")>
        Public Function GetCandles() As Candle()
            Return Me.candleReader.GetCandles200()
        End Function

    End Class
End Namespace