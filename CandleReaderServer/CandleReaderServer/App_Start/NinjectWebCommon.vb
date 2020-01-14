Imports System
Imports System.Web
Imports System.Web.Http
Imports Microsoft.Web.Infrastructure.DynamicModuleHelper

Imports Ninject
Imports Ninject.Web.Common

<Assembly: WebActivator.PreApplicationStartMethod(GetType(NinjectWebCommon), "Start")>
<Assembly: WebActivator.ApplicationShutdownMethodAttribute(GetType(NinjectWebCommon), "StopNinject")>
Public Module NinjectWebCommon
    Private ReadOnly bootstrapper As Bootstrapper = New Bootstrapper()

    Public Sub Start()
        DynamicModuleUtility.RegisterModule(GetType(OnePerRequestHttpModule))
        DynamicModuleUtility.RegisterModule(GetType(NinjectHttpModule))
        bootstrapper.Initialize(AddressOf CreateKernel)
    End Sub

    Public Sub StopNinject()
        bootstrapper.ShutDown()
    End Sub

    Private Function CreateKernel() As IKernel
        Dim kernel = New StandardKernel()
        kernel.Bind(Of Func(Of IKernel))().ToMethod(Function(ctx) Function() New Bootstrapper().Kernel)
        kernel.Bind(Of IHttpModule)().To(Of HttpApplicationInitializationHttpModule)()

        RegisterServices(kernel)

        GlobalConfiguration.Configuration.DependencyResolver = New LocalNinjectDependencyResolver(kernel)

        Return kernel
    End Function

    Private Sub RegisterServices(kernel As IKernel)
        Dim candleReader = New MetaTraderCandleReader()
        candleReader.Start()

        kernel.Bind(Of ICandleReader)().ToConstant(candleReader).InSingletonScope()

    End Sub
End Module
