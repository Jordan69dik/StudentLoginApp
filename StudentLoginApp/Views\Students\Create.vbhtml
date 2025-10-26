@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Create Student"
End Code

<h2>Create Student</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    <div class="mb-3">
        @Html.LabelFor(Function(m) m.FirstName)
        @Html.TextBoxFor(Function(m) m.FirstName, New With {.class = "form-control"})
        @Html.ValidationMessageFor(Function(m) m.FirstName)
    </div>
    <div class="mb-3">
        @Html.LabelFor(Function(m) m.LastName)
        @Html.TextBoxFor(Function(m) m.LastName, New With {.class = "form-control"})
    </div>
    <div class="mb-3">
        @Html.LabelFor(Function(m) m.Age)
        @Html.TextBoxFor(Function(m) m.Age, New With {.class = "form-control", .type = "number"})
    </div>
    <button type="submit" class="btn btn-primary">Save</button>
End Using
