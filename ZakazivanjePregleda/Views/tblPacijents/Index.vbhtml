@ModelType IEnumerable(Of ZakazivanjePregleda.ZakazivanjePregleda.tblPacijent)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Pacijenti</h2>

<p>
    @Html.ActionLink("Unesi novog pacijenta", "Create")
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
            @Html.DisplayNameFor(Function(model) model.LBO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Telefon)
        </th>
        <th>
            Datum Rodjenja
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Adresa)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tblKarton.Napomena)
        </th>
        <th>
            Broj polise
        </th>
        <th>
            Vrsta Osiguranja
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
                @Html.DisplayFor(Function(modelItem) item.LBO)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Telefon)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DatumRodjenja)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Adresa)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tblKarton.Napomena)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tblOsiguranje.BrojPolise)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tblOsiguranje.VrstaOsiguranja)
            </td>
            <td>
                @Html.ActionLink("Izmena", "Edit", New With {.id = item.PacijentID}) |
                @Html.ActionLink("Detalji", "Details", New With {.id = item.PacijentID}) |
                @Html.ActionLink("Obrisi", "Delete", New With {.id = item.PacijentID})
            </td>
        </tr>
    Next

</table>
@Html.ActionLink("Pocetna", "../Home/Index")
