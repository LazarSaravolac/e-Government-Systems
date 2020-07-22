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
    Public Class tblZakPregledasController
        Inherits System.Web.Mvc.Controller

        Private db As New ZakazivanjePregledaEntities8

        ' GET: tblZakPregledas
        Function Index() As ActionResult
            Dim tblZakPregledas = db.tblZakPregledas.Include(Function(t) t.tblLekar).Include(Function(t) t.tblPacijent)
            Return View(tblZakPregledas.ToList())
        End Function

        ' GET: tblZakPregledas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblZakPregleda As tblZakPregleda = db.tblZakPregledas.Find(id)
            If IsNothing(tblZakPregleda) Then
                Return HttpNotFound()
            End If
            Return View(tblZakPregleda)
        End Function

        ' GET: tblZakPregledas/Create
        Function Create() As ActionResult
            ViewBag.Lekar = New SelectList(db.tblLekars, "LekarID", "Prezime")
            ViewBag.Pacijent = New SelectList(db.tblPacijents, "PacijentID", "Prezime")
            Return View()
        End Function

        ' POST: tblZakPregledas/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ZakazivanjeID,Lekar,Pacijent,DatumPocetkaPregleda,DatumZavrsetkaPregleda")> ByVal tblZakPregleda As tblZakPregleda) As ActionResult
            If ModelState.IsValid Then
                db.tblZakPregledas.Add(tblZakPregleda)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Lekar = New SelectList(db.tblLekars, "LekarID", "Ime", tblZakPregleda.Lekar)
            ViewBag.Pacijent = New SelectList(db.tblPacijents, "PacijentID", "Ime", tblZakPregleda.Pacijent)
            Return View(tblZakPregleda)
        End Function

        ' GET: tblZakPregledas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblZakPregleda As tblZakPregleda = db.tblZakPregledas.Find(id)
            If IsNothing(tblZakPregleda) Then
                Return HttpNotFound()
            End If
            ViewBag.Lekar = New SelectList(db.tblLekars, "LekarID", "Prezime", tblZakPregleda.Lekar)
            ViewBag.Pacijent = New SelectList(db.tblPacijents, "PacijentID", "Prezime", tblZakPregleda.Pacijent)
            Return View(tblZakPregleda)
        End Function

        ' POST: tblZakPregledas/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ZakazivanjeID,Lekar,Pacijent,DatumPocetkaPregleda,DatumZavrsetkaPregleda")> ByVal tblZakPregleda As tblZakPregleda) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tblZakPregleda).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Lekar = New SelectList(db.tblLekars, "LekarID", "Ime", tblZakPregleda.Lekar)
            ViewBag.Pacijent = New SelectList(db.tblPacijents, "PacijentID", "Ime", tblZakPregleda.Pacijent)
            Return View(tblZakPregleda)
        End Function

        ' GET: tblZakPregledas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblZakPregleda As tblZakPregleda = db.tblZakPregledas.Find(id)
            If IsNothing(tblZakPregleda) Then
                Return HttpNotFound()
            End If
            Return View(tblZakPregleda)
        End Function

        ' POST: tblZakPregledas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tblZakPregleda As tblZakPregleda = db.tblZakPregledas.Find(id)
            db.tblZakPregledas.Remove(tblZakPregleda)
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
