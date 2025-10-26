Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Student
        <Key>
        Public Property Id As Integer

        <Required>
        <StringLength(100)>
        Public Property FirstName As String

        <StringLength(100)>
        Public Property LastName As String

        Public Property Age As Integer?
    End Class
End Namespace
