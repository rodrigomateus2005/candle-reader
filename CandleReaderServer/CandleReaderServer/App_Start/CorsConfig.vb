Imports Owin

Public Module CorsConfig

    Public Sub Configure(app As IAppBuilder)
        app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll)
    End Sub

End Module
