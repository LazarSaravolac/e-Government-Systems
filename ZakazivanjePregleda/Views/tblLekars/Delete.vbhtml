@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblLekar
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Obrisi</h2>

<h3>Da li ste sigurni?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Obrisi" class="btn btn-default" /> |
            @Html.ActionLink("Nazad", "Index")
        </div>
    End Using
</div>
