@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblUstanova
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Obrisi</h2>

<h3>Da li ste sigurni?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Obrisi" class="btn btn-default" /> |
            @Html.ActionLink("Nazad", "Index")
        </div>
    End Using
</div>
