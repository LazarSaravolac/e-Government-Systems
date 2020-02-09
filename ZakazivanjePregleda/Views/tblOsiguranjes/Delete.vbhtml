@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblOsiguranje
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Obrisi</h2>

<h3>Da li ste sigurni?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Obrisi" class="btn btn-default" /> |
            @Html.ActionLink("Nazad", "Index")
        </div>
    End Using
</div>
