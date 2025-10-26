@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Edit Student"
End Code

<h2>Edit Student</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.HiddenFor(Function(m) m.Id)
    <div class="mb-3">
        @Html.LabelFor(Function(m) m.FirstName)
        @Html.TextBoxFor(Function(m) m.FirstName, New With {.class = "form-control"})
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
