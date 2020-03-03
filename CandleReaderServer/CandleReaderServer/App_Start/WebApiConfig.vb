Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports Microsoft.Extensions.DependencyInjection
Imports Owin

Public Module WebApiConfig

    Public Sub Configure(ByVal appBuilder As IAppBuilder)
        Dim Config = New HttpConfiguration()

        Config.MapHttpAttributeRoutes()

        Config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )

        SwaggerConfig.Configure(Config)
        NinjectConfig.Configure(Config)

        appBuilder.UseWebApi(Config)

    End Sub
End Module
