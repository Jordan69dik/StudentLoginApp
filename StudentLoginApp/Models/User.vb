Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class User
        <Key>
        Public Property Id As Integer

        <Required>
        <StringLength(100)>
        Public Property Username As String

        <Required>
        <StringLength(255)>
        Public Property Email As String

        <Required>
        <StringLength(255)>
        Public Property Password As String
    End Class
End Namespace
