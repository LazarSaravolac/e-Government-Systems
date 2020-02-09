@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblZakPregleda
@Code
    ViewData("Title") = "Details"
End Code

<h2>Detalji</h2>

<div>

    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.DatumPocetkaPregleda)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatumPocetkaPregleda)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DatumZavrsetkaPregleda)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatumZavrsetkaPregleda)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tblLekar.Ime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tblLekar.Ime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tblPacijent.Ime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tblPacijent.Ime)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Izmena", "Izmena", New With {.id = Model.ZakazivanjeID}) |
    @Html.ActionLink("Nazad", "Index")
</p>
