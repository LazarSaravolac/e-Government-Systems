@ModelType IEnumerable(Of ZakazivanjePregleda.ZakazivanjePregleda.tblZakPregleda)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Zakazivanje pregleda</h2>

<p>
    @Html.ActionLink("Unesi novo zakazivanje", "Create")
</p>
<table class="table">
    <tr>
        <th>
            Vreme Pocetka Pregleda
        </th>
        <th>
            Vreme Zavrsetka Pregleda
        </th>
        <th>
            Lekar
        </th>
        <th>
            Pacijent
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DatumPocetkaPregleda)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DatumZavrsetkaPregleda)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tblLekar.Ime)  @Html.DisplayFor(Function(modelItem) item.tblLekar.Prezime)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.tblPacijent.Ime) @Html.DisplayFor(Function(modelItem) item.tblPacijent.Prezime)
            </td>
            <td>
                @Html.ActionLink("Izmena", "Edit", New With {.id = item.ZakazivanjeID}) |
                @Html.ActionLink("Detalji", "Details", New With {.id = item.ZakazivanjeID}) |
                @Html.ActionLink("Obrisi", "Delete", New With {.id = item.ZakazivanjeID})
            </td>
        </tr>
    Next

</table>
@Html.ActionLink("Pocetna", "../Home/Index")