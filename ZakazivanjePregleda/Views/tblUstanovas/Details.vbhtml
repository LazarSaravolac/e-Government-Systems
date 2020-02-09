@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblUstanova
@Code
    ViewData("Title") = "Details"
End Code

<h2>Detalji</h2>

<div>
   
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Adresa)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Adresa)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.VrstaUstanove)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.VrstaUstanove)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Direktor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Direktor)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Izmena", "Izmena", New With {.id = Model.UstanovaID}) |
    @Html.ActionLink("Nazad", "Index")
</p>
