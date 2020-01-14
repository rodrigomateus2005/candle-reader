Imports Microsoft.Extensions.DependencyInjection
Imports Ninject
Imports System.Web.Http.Dependencies

Public Class LocalNinjectDependencyResolver
    Implements IDependencyResolver

    Protected _kernel As IKernel

    Public Sub New(ByVal kernel As IKernel)
        Me._kernel = kernel
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub

    Public Function GetService(ByVal serviceType As Type) As Object Implements IDependencyResolver.GetService
        Return Me._kernel.TryGet(serviceType)
    End Function

    Public Function GetServices(ByVal serviceType As Type) As IEnumerable(Of Object) Implements IDependencyResolver.GetServices
        Return Me._kernel.GetAll(serviceType)
    End Function

    Public Function BeginScope() As IDependencyScope Implements IDependencyResolver.BeginScope
        Return Me
    End Function
End Class
