Imports System.Threading.Tasks
Imports Microsoft.Owin
Imports Owin

<Assembly: OwinStartup(GetType(Startup))>
Public Class Startup

    Public Shared IsLoaded As Boolean

    Public Sub Configuration(app As IAppBuilder)

        CorsConfig.Configure(app)
        SignalRConfig.Configure(app)
        WebApiConfig.Configure(app)

        'app.MapWhen(Function(c)
        '                If c.Request.Path.StartsWithSegments(PathString.FromUriComponent("/Config.aspx")) Then
        '                    Return False
        '                Else
        '                    Return Not Startup.IsLoaded
        '                End If
        '            End Function,
        '            Sub(a)
        '                a.Run(Function(c)
        '                          c.Response.Redirect("/Config.aspx")
        '                          Return Task.CompletedTask
        '                      End Function)
        '            End Sub)

        'app.MapWhen(Function(c)
        '                Return Startup.IsLoaded
        '            End Function,
        '            Sub(a)

        '                CorsConfig.Configure(a)
        '                SignalRConfig.Configure(a)
        '                WebApiConfig.Configure(a)

        '            End Sub)
    End Sub

End Class
