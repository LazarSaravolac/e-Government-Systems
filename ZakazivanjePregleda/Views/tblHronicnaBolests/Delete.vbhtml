@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblHronicnaBolest
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Obrisi</h2>

<h3>Da li ste sigurni?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Obrisi" class="btn btn-default" /> |
            @Html.ActionLink("Nazad", "Index")
        </div>
    End Using
</div>
