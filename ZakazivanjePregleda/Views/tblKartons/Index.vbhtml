@ModelType IEnumerable(Of ZakazivanjePregleda.ZakazivanjePregleda.tblKarton)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Kartoni</h2>

<p>
    @Html.ActionLink("Unesi nov", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Napomena)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Visina)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tezina)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Upozorenje)
        </th>
        <th>
            Dijagnoza Bolesti
        </th>
        <th>
            Lekar
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Napomena)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Visina)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Tezina)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Upozorenje)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tblHronicnaBolest.DijagnozaBolesti)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tblLekar.Ime)
                @Html.DisplayFor(Function(modelItem) item.tblLekar.Prezime)
            </td>
            <td>
                @Html.ActionLink("Izmena", "Edit", New With {.id = item.KartonID}) |
                @Html.ActionLink("Detalji", "Details", New With {.id = item.KartonID}) |
                @Html.ActionLink("Obrisi", "Delete", New With {.id = item.KartonID})
            </td>
        </tr>
    Next

</table>
@Html.ActionLink("Pocetna", "../Home/Index")