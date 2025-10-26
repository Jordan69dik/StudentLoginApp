@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Home"
End Code

<div class="container">
    <h2>Welcome to StudentLoginApp</h2>
    @If Session("Username") IsNot Nothing Then
        @:<p>Hello, @Session("Username")!</p>
        @:<p><a href="@Url.Action("Logout", "Account")">Logout</a></p>
    Else
        @:<p><a href="@Url.Action("Login", "Account")">Login</a> or <a href="@Url.Action("Register", "Account")">Register</a></p>
    End If

    <p><a href="@Url.Action("Index", "Students")">Manage Students (CRUD)</a></p>
</div>
