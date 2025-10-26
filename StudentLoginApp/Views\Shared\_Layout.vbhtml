<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>@ViewBag.Title - StudentLoginApp</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" />
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <div class="container">
            <a class="navbar-brand" href="@Url.Action("Index", "Home")">StudentLoginApp</a>
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav ms-auto">
                    <li class="nav-item"><a class="nav-link" href="@Url.Action("Index","Students")">Students</a></li>
                    @If Session("Username") IsNot Nothing Then
                        @:<li class="nav-item"><a class="nav-link" href="@Url.Action("Logout","Account")">Logout</a></li>
                    Else
                        @:<li class="nav-item"><a class="nav-link" href="@Url.Action("Login","Account")">Login</a></li>
                    End If
                </ul>
            </div>
        </div>
    </nav>

    <div class="container mt-4">
        @RenderBody()
    </div>
</body>
</html>
