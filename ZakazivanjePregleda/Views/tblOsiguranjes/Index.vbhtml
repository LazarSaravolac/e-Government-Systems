@ModelType IEnumerable(Of ZakazivanjePregleda.ZakazivanjePregleda.tblOsiguranje)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Osiguranja</h2>

<p>
    @Html.ActionLink("Unesi novo", "Create")
</p>
<table class="table">
    <tr>
        <th>
            Vrsta Osiguranja
        </th>
        <th>
            Broj Polise
        </th>
        <th>
            Izdavac Osiguranja
        </th>
        <th>
            Datum Izdavanja Osiguranja
        </th>
        <th>
            Datum Isteka Osiguranja
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.VrstaOsiguranja)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.BrojPolise)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.IzdavacOsiguranja)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DatumIzdavanjaOsiguranja)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DatumIstekaOsiguranja)
            </td>
            <td>
                @Html.ActionLink("Izmena", "Edit", New With {.id = item.OsiguranjeID}) |
                @Html.ActionLink("Detalji", "Details", New With {.id = item.OsiguranjeID}) |
                @Html.ActionLink("Obrisi", "Delete", New With {.id = item.OsiguranjeID})
            </td>
        </tr>
    Next

</table>
@Html.ActionLink("Pocetna", "../Home/Index")