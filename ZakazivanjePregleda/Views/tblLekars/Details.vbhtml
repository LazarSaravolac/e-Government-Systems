@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblLekar
@Code
    ViewData("Title") = "Details"
End Code

<h2>Detalji</h2>

<div>
    
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Ime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Ime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Prezime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Prezime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Specijalista)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Specijalista)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tblUstanova.Adresa)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tblUstanova.Adresa)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Izmena", "Edit", New With {.id = Model.LekarID}) |
    @Html.ActionLink("Nazad", "Index")
</p>
