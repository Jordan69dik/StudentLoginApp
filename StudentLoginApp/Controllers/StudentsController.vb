Imports System.Web.Mvc
Imports StudentLoginApp.Data
Imports StudentLoginApp.Models
Imports System.Net

Namespace Controllers
    Public Class StudentsController
        Inherits Controller

        Private db As New StudentRegisterContext()

        Function Index() As ActionResult
            Return View(db.Students.ToList())
        End Function

        Function Details(id As Integer?) As ActionResult
            If id Is Nothing Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim student = db.Students.Find(id)
            If student Is Nothing Then
                Return HttpNotFound()
            End If
            Return View(student)
        End Function

        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Create(<Bind(Include:="FirstName,LastName,Age")> student As Student) As ActionResult
            If ModelState.IsValid Then
                db.Students.Add(student)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(student)
        End Function

        Function Edit(id As Integer?) As ActionResult
            If id Is Nothing Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim student = db.Students.Find(id)
            If student Is Nothing Then
                Return HttpNotFound()
            End If
            Return View(student)
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Edit(<Bind(Include:="Id,FirstName,LastName,Age")> student As Student) As ActionResult
            If ModelState.IsValid Then
                db.Entry(student).State = System.Data.Entity.EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(student)
        End Function

        Function Delete(id As Integer?) As ActionResult
            If id Is Nothing Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim student = db.Students.Find(id)
            If student Is Nothing Then
                Return HttpNotFound()
            End If
            Return View(student)
        End Function

        <HttpPost, ActionName("Delete")>
        <ValidateAntiForgeryToken>
        Function DeleteConfirmed(id As Integer) As ActionResult
            Dim student = db.Students.Find(id)
            db.Students.Remove(student)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace
