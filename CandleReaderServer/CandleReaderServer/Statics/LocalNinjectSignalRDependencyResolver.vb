Imports Ninject
Imports Microsoft.AspNet.SignalR
Public Class LocalNinjectSignalRDependencyResolver
    Inherits DefaultDependencyResolver

    Protected _kernel As IKernel

    Public Sub New(ByVal kernel As IKernel)
        Me._kernel = kernel
    End Sub

    Public Overrides Function GetService(serviceType As Type) As Object
        Return If(Me._kernel.TryGet(serviceType), MyBase.GetService(serviceType))
    End Function

    Public Overrides Function GetServices(serviceType As Type) As IEnumerable(Of Object)
        Return Me._kernel.GetAll(serviceType).Concat(MyBase.GetServices(serviceType))
    End Function

End Class
