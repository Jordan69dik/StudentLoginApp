@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Delete Student"
End Code

<h2>Delete Student</h2>

<div>
    <h4>Are you sure you want to delete this?</h4>
    <dl class="row">
        <dt class="col-sm-2">First</dt><dd class="col-sm-10">@Model.FirstName</dd>
        <dt class="col-sm-2">Last</dt><dd class="col-sm-10">@Model.LastName</dd>
    </dl>
    @Using Html.BeginForm("Delete", "Students", New With {.id = Model.Id}, FormMethod.Post)
        @Html.AntiForgeryToken()
        <button type="submit" class="btn btn-danger">Delete</button>
        <a class="btn btn-secondary" href="@Url.Action("Index")">Cancel</a>
    End Using
</div>
