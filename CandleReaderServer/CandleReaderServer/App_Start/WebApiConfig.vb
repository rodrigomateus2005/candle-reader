Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Imports Microsoft.Extensions.DependencyInjection

Public Module WebApiConfig

    Public Sub Register(ByVal config As HttpConfiguration)
        ' Web API configuration and services

        ' Web API routes
        config.MapHttpAttributeRoutes()

        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )

        'Dim services = New ServiceCollection()

        'CandleReaderConfig.RegisterReader(services)

        'Dim Resolver = New DefaultDependencyResolver(services.BuildServiceProvider())
        'config.DependencyResolver = Resolver
    End Sub
End Module
