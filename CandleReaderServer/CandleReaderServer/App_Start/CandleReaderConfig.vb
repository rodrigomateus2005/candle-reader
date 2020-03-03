Imports System.Web.Http
Imports System.Web.Http.Controllers
Imports Microsoft.Extensions.DependencyInjection
Imports Ninject

Public Module CandleReaderConfig
    Public Sub RegisterReader(ByVal kernel As IKernel)

        'Dim candleReader = New MetaTraderReplayCandleReader(New Date(2020, 2, 7))
        Dim candleReader = New MetaTraderCandleReader()
        candleReader.Start()

        kernel.Bind(Of ICandleReader)().ToConstant(candleReader).InSingletonScope()

    End Sub
End Module
