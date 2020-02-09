@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblKarton
@Code
    ViewData("Title") = "Details"
End Code

<h2>Detalji</h2>

<div>
    
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Napomena)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Napomena)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Visina)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Visina)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tezina)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tezina)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Upozorenje)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Upozorenje)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tblHronicnaBolest.DijagnozaBolesti)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tblHronicnaBolest.DijagnozaBolesti)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tblLekar.Ime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tblLekar.Ime)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Izmena", "Izmena", New With {.id = Model.KartonID}) |
    @Html.ActionLink("Nazad", "Index")
</p>
