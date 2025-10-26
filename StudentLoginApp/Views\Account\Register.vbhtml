@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Register"
End Code

<h2>Register</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    <div class="mb-3">
        @Html.LabelFor(Function(m) m.Username)
        @Html.TextBoxFor(Function(m) m.Username, New With {.class = "form-control"})
        @Html.ValidationMessageFor(Function(m) m.Username)
    </div>
    <div class="mb-3">
        @Html.LabelFor(Function(m) m.Email)
        @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
        @Html.ValidationMessageFor(Function(m) m.Email)
    </div>
    <div class="mb-3">
        @Html.LabelFor(Function(m) m.Password)
        @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
        @Html.ValidationMessageFor(Function(m) m.Password)
    </div>
    <button type="submit" class="btn btn-primary">Register</button>
End Using
