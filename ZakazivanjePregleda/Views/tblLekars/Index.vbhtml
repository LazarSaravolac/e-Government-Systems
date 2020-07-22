@ModelType IEnumerable(Of ZakazivanjePregleda.ZakazivanjePregleda.tblLekar)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Lekari</h2>

<p>
    @Html.ActionLink("Unesi novog lekara", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Ime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Prezime)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Specijalista)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tblUstanova.Adresa)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Ime)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Prezime)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Specijalista)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tblUstanova.Adresa)
            </td>
            <td>
                @Html.ActionLink("Izmena", "Edit", New With {.id = item.LekarID}) |
                @Html.ActionLink("Detalji", "Details", New With {.id = item.LekarID}) |
                @Html.ActionLink("Obrisi", "Delete", New With {.id = item.LekarID})
            </td>
        </tr>
    Next

</table>
@Html.ActionLink("Pocetna", "../Home/Index")