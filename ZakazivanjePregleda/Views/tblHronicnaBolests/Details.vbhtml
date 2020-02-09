@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblHronicnaBolest
@Code
    ViewData("Title") = "Details"
End Code

<h2>Detalji</h2>

<div>
    
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.DijagnozaBolesti)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DijagnozaBolesti)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DatumPostavljanja)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatumPostavljanja)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Terapija)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Terapija)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DatumPoslednjeKontrole)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatumPoslednjeKontrole)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Izmena", "Izmena", New With {.id = Model.HronicnaBolestID}) |
    @Html.ActionLink("Nazad", "Index")
</p>
