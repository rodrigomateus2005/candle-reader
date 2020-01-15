Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports Microsoft.Extensions.DependencyInjection

Public Module WebApiConfig

    Public Sub Register(ByVal config As HttpConfiguration)
        ' Web API configuration and services

        Dim cors As EnableCorsAttribute = New EnableCorsAttribute("*", "*", "*")

        config.EnableCors(cors)

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
