@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Students"
End Code

<h2>Students</h2>

<p><a class="btn btn-success" href="@Url.Action("Create")">Create New</a></p>

<table class="table table-striped">
    <thead>
        <tr><th>First</th><th>Last</th><th>Age</th><th></th></tr>
    </thead>
    <tbody>
        @For Each item In Model
            @:<tr>
            @:<td>@item.FirstName</td>
            @:<td>@item.LastName</td>
            @:<td>@item.Age</td>
            @:<td>
                <a class="btn btn-sm btn-primary" href="@Url.Action("Edit", New With {.id = item.Id})">Edit</a>
                <a class="btn btn-sm btn-info" href="@Url.Action("Details", New With {.id = item.Id})">Details</a>
                <a class="btn btn-sm btn-danger" href="@Url.Action("Delete", New With {.id = item.Id})">Delete</a>
            @:</td>
            @:</tr>
        Next
    </tbody>
</table>
