@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Login"
End Code

<h2>Login</h2>

@if ViewBag.Error IsNot Nothing Then
    <div class="alert alert-danger">@ViewBag.Error</div>
End If

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    <div class="mb-3">
        <label>Username</label>
        <input type="text" name="username" class="form-control" />
    </div>
    <div class="mb-3">
        <label>Password</label>
        <input type="password" name="password" class="form-control" />
    </div>
    <button type="submit" class="btn btn-primary">Login</button>
End Using
