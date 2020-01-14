Imports Microsoft.Extensions.DependencyInjection
Imports System.Web.Http.Dependencies

Public Class DefaultDependencyResolver
    Implements IDependencyResolver

    Protected serviceProvider As IServiceProvider

    Public Sub New(ByVal serviceProvider As IServiceProvider)
        Me.serviceProvider = serviceProvider
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Me.Dispose()
    End Sub

    Public Function GetService(ByVal serviceType As Type) As Object Implements IDependencyResolver.GetService
        Return Me.serviceProvider.GetService(serviceType)
    End Function

    Public Function GetServices(ByVal serviceType As Type) As IEnumerable(Of Object) Implements IDependencyResolver.GetServices
        Return Me.serviceProvider.GetServices(serviceType)
    End Function

    Public Function BeginScope() As IDependencyScope Implements IDependencyResolver.BeginScope
        Dim services = New ServiceCollection()
        Return New DefaultDependencyResolver(services.BuildServiceProvider())
    End Function
End Class
