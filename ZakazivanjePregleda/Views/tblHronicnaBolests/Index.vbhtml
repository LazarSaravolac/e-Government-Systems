@ModelType IEnumerable(Of ZakazivanjePregleda.ZakazivanjePregleda.tblHronicnaBolest)
@Code
ViewData("Title") = "Index"
End Code

<h2>Hronicne bolesti</h2>

<p>
    @Html.ActionLink("Unesi novu", "Create")
</p>
<table class="table">
    <tr>
        <th>
            Dijagnoza Bolesti
        </th>
        <th>
            Datum Postavljanja
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Terapija)
        </th>
        <th>
            Datum Poslednje Kontrole
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DijagnozaBolesti)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DatumPostavljanja)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Terapija)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DatumPoslednjeKontrole)
        </td>
        <td>
            @Html.ActionLink("Izmena", "Edit", New With {.id = item.HronicnaBolestID}) |
            @Html.ActionLink("Detalji", "Details", New With {.id = item.HronicnaBolestID}) |
            @Html.ActionLink("Obrisi", "Delete", New With {.id = item.HronicnaBolestID})
        </td>
    </tr>
Next

</table>
