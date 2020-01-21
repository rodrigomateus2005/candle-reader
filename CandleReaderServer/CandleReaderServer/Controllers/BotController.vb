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
        <ActionName("GetAtivos")>
        <Route("GetAtivos")>
        Public Function GetAtivos() As String()
            Return Me.candleReader.GetAtivos()
        End Function

        <HttpGet()>
        <ActionName("GetCandles")>
        <Route("GetCandles")>
        Public Function GetCandles(ativo As String) As Candle()
            Return Me.candleReader.GetCandles200(ativo)
        End Function

    End Class
End Namespace