Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ZakazivanjePregleda.ZakazivanjePregleda

Namespace Controllers
    Public Class tblPacijentsController
        Inherits System.Web.Mvc.Controller

        Private db As New ZakazivanjePregledaEntities8

        ' GET: tblPacijents
        Function Index() As ActionResult
            Dim tblPacijents = db.tblPacijents.Include(Function(t) t.tblKarton).Include(Function(t) t.tblOsiguranje)
            Return View(tblPacijents.ToList())
        End Function

        ' GET: tblPacijents/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblPacijent As tblPacijent = db.tblPacijents.Find(id)
            If IsNothing(tblPacijent) Then
                Return HttpNotFound()
            End If
            Return View(tblPacijent)
        End Function

        ' GET: tblPacijents/Create
        Function Create() As ActionResult
            ViewBag.LBO = New SelectList(db.tblKartons, "KartonID", "KartonID")
            ViewBag.Osiguranje = New SelectList(db.tblOsiguranjes, "OsiguranjeID", "BrojPolise")
            Return View()
        End Function

        ' POST: tblPacijents/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="PacijentID,Ime,Prezime,LBO,Telefon,DatumRodjenja,Adresa,Osiguranje")> ByVal tblPacijent As tblPacijent) As ActionResult
            If ModelState.IsValid Then
                db.tblPacijents.Add(tblPacijent)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.LBO = New SelectList(db.tblKartons, "KartonID", "Napomena", tblPacijent.LBO)
            ViewBag.Osiguranje = New SelectList(db.tblOsiguranjes, "OsiguranjeID", "VrstaOsiguranja", tblPacijent.Osiguranje)
            Return View(tblPacijent)
        End Function

        ' GET: tblPacijents/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblPacijent As tblPacijent = db.tblPacijents.Find(id)
            If IsNothing(tblPacijent) Then
                Return HttpNotFound()
            End If
            ViewBag.LBO = New SelectList(db.tblKartons, "KartonID", "KartonID", tblPacijent.LBO)
            ViewBag.Osiguranje = New SelectList(db.tblOsiguranjes, "OsiguranjeID", "BrojPolise", tblPacijent.Osiguranje)
            Return View(tblPacijent)
        End Function

        ' POST: tblPacijents/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="PacijentID,Ime,Prezime,LBO,Telefon,DatumRodjenja,Adresa,Osiguranje")> ByVal tblPacijent As tblPacijent) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tblPacijent).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.LBO = New SelectList(db.tblKartons, "KartonID", "Napomena", tblPacijent.LBO)
            ViewBag.Osiguranje = New SelectList(db.tblOsiguranjes, "OsiguranjeID", "VrstaOsiguranja", tblPacijent.Osiguranje)
            Return View(tblPacijent)
        End Function

        ' GET: tblPacijents/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblPacijent As tblPacijent = db.tblPacijents.Find(id)
            If IsNothing(tblPacijent) Then
                Return HttpNotFound()
            End If
            Return View(tblPacijent)
        End Function

        ' POST: tblPacijents/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tblPacijent As tblPacijent = db.tblPacijents.Find(id)
            db.tblPacijents.Remove(tblPacijent)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
