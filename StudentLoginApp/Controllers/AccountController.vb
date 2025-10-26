Imports System.Web.Mvc
Imports StudentLoginApp.Models
Imports StudentLoginApp.Data
Imports System.Linq

Namespace Controllers
    Public Class AccountController
        Inherits Controller

        Private db As New StudentRegisterContext()

        Function Register() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Register(user As User) As ActionResult
            If ModelState.IsValid Then
                db.Users.Add(user)
                db.SaveChanges()
                Session("UserId") = user.Id
                Session("Username") = user.Username
                Return RedirectToAction("Index", "Home")
            End If
            Return View(user)
        End Function

        Function Login() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Login(username As String, password As String) As ActionResult
            Dim u = db.Users.FirstOrDefault(Function(x) x.Username = username AndAlso x.Password = password)
            If u IsNot Nothing Then
                Session("UserId") = u.Id
                Session("Username") = u.Username
                Return RedirectToAction("Index", "Home")
            End If
            ViewBag.Error = "Invalid credentials"
            Return View()
        End Function

        Function Logout() As ActionResult
            Session.Clear()
            Return RedirectToAction("Login")
        End Function
    End Class
End Namespace
