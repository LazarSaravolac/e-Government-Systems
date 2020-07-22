@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblPacijent
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
            @Html.DisplayNameFor(Function(model) model.Telefon)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Telefon)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DatumRodjenja)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatumRodjenja)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Adresa)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Adresa)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tblKarton.Napomena)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tblKarton.Napomena)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tblOsiguranje.VrstaOsiguranja)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tblOsiguranje.VrstaOsiguranja)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Izmena", "Edit", New With {.id = Model.PacijentID}) |
    @Html.ActionLink("Nazad", "Index")
</p>
