﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>

            </div>
            <!--
        <div class="navbar-collapse collapse">
            <ul class="nav navbar-nav">
                <li><a href="https://localhost:44312">Pocetna</a></li>
                <li><a href="https://localhost:44312/tblLekars/index">Lekar</a></li>
                <li><a href="https://localhost:44312/tblPacijents/index">Pacijent</a></li>
                <li><a href="https://localhost:44312/tblUstanovas/index">Ustanova</a></li>
                <li><a href="https://localhost:44312/tblKartons/index">Karton</a></li>
                <li><a href="https://localhost:44312/tblOsiguranjes/index">Osiguranje</a></li>
                <li><a href="https://localhost:44312/tblHronicnaBolests/index">Hronicna Bolest</a></li>

                <!--<li>@Html.ActionLink("Pacijent", "tblPacijents")</li>
            </ul>
        </div>
        -->
    </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - MVC Zakazivanje pregleda Lazar Saravolac I7 16/2019</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
