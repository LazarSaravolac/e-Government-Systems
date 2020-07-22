@ModelType IEnumerable(Of ZakazivanjePregleda.ZakazivanjePregleda.tblUstanova)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Ustanove</h2>

<p>
    @Html.ActionLink("Unesi novu ustanovu", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Adresa)
        </th>
        <th>
            Vrsta Ustanove
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Direktor)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Adresa)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.VrstaUstanove)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Direktor)
            </td>
            <td>
                @Html.ActionLink("Izmena", "Edit", New With {.id = item.UstanovaID}) |
                @Html.ActionLink("Detalji", "Details", New With {.id = item.UstanovaID}) |
                @Html.ActionLink("Obrisi", "Delete", New With {.id = item.UstanovaID})
            </td>
        </tr>
    Next

</table>
@Html.ActionLink("Pocetna", "../Home/Index")