Imports System.Web.Mvc
Imports System.Web.Routing

Public Class GlobalApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        RouteConfig.RegisterRoutes(RouteTable.Routes)
    End Sub
End Class
