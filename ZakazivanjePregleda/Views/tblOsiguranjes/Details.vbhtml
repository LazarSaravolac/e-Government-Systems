@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblOsiguranje
@Code
    ViewData("Title") = "Details"
End Code

<h2>Detalji</h2>

<div>
    
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.VrstaOsiguranja)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.VrstaOsiguranja)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.BrojPolise)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BrojPolise)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IzdavacOsiguranja)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IzdavacOsiguranja)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DatumIzdavanjaOsiguranja)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatumIzdavanjaOsiguranja)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DatumIstekaOsiguranja)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatumIstekaOsiguranja)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Izmena", "Edit", New With {.id = Model.OsiguranjeID}) |
    @Html.ActionLink("Nazad", "Index")
</p>
