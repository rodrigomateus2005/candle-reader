
Imports Microsoft.AspNet.SignalR
Imports Owin


Public Module SignalRConfig

    Public Sub Configure(app As IAppBuilder)

        Dim hubConfiguration = New HubConfiguration()
        hubConfiguration.EnableDetailedErrors = True
        hubConfiguration.EnableJavaScriptProxies = False

        'hubConfiguration.Resolver

        app.MapSignalR(hubConfiguration)

    End Sub

End Module
