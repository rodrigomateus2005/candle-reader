
Imports Microsoft.AspNet.SignalR
Imports Microsoft.Owin
Imports Owin
Imports System.Web.Http
Imports System.Web.Http.Cors

<Assembly: OwinStartup(GetType(SignalRConfig))>
Public Class SignalRConfig

    Public Sub Configuration(app As IAppBuilder)

        app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll)

        Dim hubConfiguration = New HubConfiguration()
        hubConfiguration.EnableDetailedErrors = True
        hubConfiguration.EnableJavaScriptProxies = False

        app.MapSignalR(hubConfiguration)

    End Sub

End Class
