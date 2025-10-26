@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Student Details"
End Code

<h2>Student Details</h2>

<div>
    <dl class="row">
        <dt class="col-sm-2">First Name</dt><dd class="col-sm-10">@Model.FirstName</dd>
        <dt class="col-sm-2">Last Name</dt><dd class="col-sm-10">@Model.LastName</dd>
        <dt class="col-sm-2">Age</dt><dd class="col-sm-10">@Model.Age</dd>
    </dl>
</div>
<p><a class="btn btn-secondary" href="@Url.Action("Index")">Back to list</a></p>
