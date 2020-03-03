Imports System.Web.Http

Public Module NinjectConfig

    Public Sub Configure(Config As HttpConfiguration)

        Config.DependencyResolver = New LocalNinjectDependencyResolver(NinjectWebCommon.GetLoadedKernel())

    End Sub

End Module
