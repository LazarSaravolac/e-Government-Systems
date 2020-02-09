@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblKarton
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Obrisi</h2>

<h3>Da li ste sigurni?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Obrisi" class="btn btn-default" /> |
            @Html.ActionLink("Nazad", "Index")
        </div>
    End Using
</div>
