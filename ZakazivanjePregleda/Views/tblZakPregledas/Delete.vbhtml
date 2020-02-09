@ModelType ZakazivanjePregleda.ZakazivanjePregleda.tblZakPregleda
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Brisanje</h2>

<h3>Da li ste sigurni?</h3>
<div>
    <h4>tblZakPregleda</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.DatumPocetkaPregleda)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatumPocetkaPregleda)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DatumZavrsetkaPregleda)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DatumZavrsetkaPregleda)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tblLekar.Ime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tblLekar.Ime)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tblPacijent.Ime)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tblPacijent.Ime)
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
