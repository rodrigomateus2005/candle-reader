Imports System.Web.Http
Imports System.Web.Http.Controllers
Imports Microsoft.Extensions.DependencyInjection

Public Module CandleReaderConfig
    Public Sub RegisterReader(ByVal services As ServiceCollection)

        Dim candleReader = New MetaTraderCandleReader()
        candleReader.Start()

        services.AddSingleton(GetType(ICandleReader), candleReader)
    End Sub
End Module
