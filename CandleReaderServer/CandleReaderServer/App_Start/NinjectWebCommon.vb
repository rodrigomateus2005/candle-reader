Imports System
Imports System.Web
Imports System.Web.Http
Imports Microsoft.AspNet.SignalR
Imports Microsoft.Web.Infrastructure.DynamicModuleHelper

Imports Ninject
Imports Ninject.Web.Common

<Assembly: WebActivator.PreApplicationStartMethod(GetType(NinjectWebCommon), "Start")>
<Assembly: WebActivator.ApplicationShutdownMethodAttribute(GetType(NinjectWebCommon), "StopNinject")>
Public Module NinjectWebCommon
    Private ReadOnly bootstrapper As Bootstrapper = New Bootstrapper()
    Private kernel As IKernel

    Public Sub Start()
        bootstrapper.Initialize(AddressOf CreateKernel)
    End Sub

    Public Sub StopNinject()
        bootstrapper.ShutDown()
    End Sub

    Public Function GetLoadedKernel() As IKernel
        Return kernel
    End Function

    Private Function CreateKernel() As IKernel
        Dim kernel = New StandardKernel()
        kernel.Bind(Of Func(Of IKernel))().ToMethod(Function(ctx) Function() New Bootstrapper().Kernel)

        NinjectWebCommon.kernel = kernel

        RegisterServices(kernel)

        NinjectConfig.Configure(GlobalConfiguration.Configuration)
        GlobalHost.DependencyResolver = New LocalNinjectSignalRDependencyResolver(kernel)

        Return kernel
    End Function

    Private Sub RegisterServices(kernel As IKernel)

        CandleReaderConfig.RegisterReader(kernel)

    End Sub
End Module
