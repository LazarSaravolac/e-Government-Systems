@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblPacijent
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Brisanje</h2>

<h3>Da li ste sigurni?</h3>
<div>
    <h4>tblPacijent</h4>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Brisanje" class="btn btn-default" /> |
            @Html.ActionLink("Nazad", "Index")
        </div>
    End Using
</div>
