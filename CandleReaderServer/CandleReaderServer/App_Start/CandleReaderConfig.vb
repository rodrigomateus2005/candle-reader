Imports System.Web.Http
Imports System.Web.Http.Controllers
Imports Microsoft.Extensions.DependencyInjection
Imports Ninject

Public Module CandleReaderConfig
    Public Sub RegisterReader(ByVal kernel As IKernel)

        Dim candleReader = New MetaTraderCandleReader()
        candleReader.Start()

        kernel.Bind(Of ICandleReader)().ToConstant(candleReader).InSingletonScope()

    End Sub
End Module
