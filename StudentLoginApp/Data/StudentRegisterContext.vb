Imports System.Data.Entity
Imports StudentLoginApp.Models

Namespace Data
    Public Class StudentRegisterContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("name=StudentRegisterConnection")
        End Sub

        Public Property Users As DbSet(Of StudentLoginApp.Models.User)
        Public Property Students As DbSet(Of StudentLoginApp.Models.Student)
    End Class
End Namespace
