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
    Public Class tblKartonsController
        Inherits System.Web.Mvc.Controller

        Private db As New ZakazivanjePregledaEntities8

        ' GET: tblKartons
        Function Index() As ActionResult
            Dim tblKartons = db.tblKartons.Include(Function(t) t.tblHronicnaBolest).Include(Function(t) t.tblLekar)
            Return View(tblKartons.ToList())
        End Function

        ' GET: tblKartons/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblKarton As tblKarton = db.tblKartons.Find(id)
            If IsNothing(tblKarton) Then
                Return HttpNotFound()
            End If
            Return View(tblKarton)
        End Function

        ' GET: tblKartons/Create
        Function Create() As ActionResult
            ViewBag.HronicnaBolest = New SelectList(db.tblHronicnaBolests, "HronicnaBolestID", "DijagnozaBolesti")
            ViewBag.IzabraniLekar = New SelectList(db.tblLekars, "LekarID", "Prezime")
            Return View()
        End Function

        ' POST: tblKartons/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="KartonID,Napomena,HronicnaBolest,Visina,Tezina,Upozorenje,IzabraniLekar")> ByVal tblKarton As tblKarton) As ActionResult
            If ModelState.IsValid Then
                db.tblKartons.Add(tblKarton)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.HronicnaBolest = New SelectList(db.tblHronicnaBolests, "HronicnaBolestID", "DijagnozaBolesti", tblKarton.HronicnaBolest)
            ViewBag.IzabraniLekar = New SelectList(db.tblLekars, "LekarID", "Prezime", tblKarton.IzabraniLekar)
            Return View(tblKarton)
        End Function

        ' GET: tblKartons/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblKarton As tblKarton = db.tblKartons.Find(id)
            If IsNothing(tblKarton) Then
                Return HttpNotFound()
            End If
            ViewBag.HronicnaBolest = New SelectList(db.tblHronicnaBolests, "HronicnaBolestID", "DijagnozaBolesti", tblKarton.HronicnaBolest)
            ViewBag.IzabraniLekar = New SelectList(db.tblLekars, "LekarID", "Prezime", tblKarton.IzabraniLekar)
            Return View(tblKarton)
        End Function

        ' POST: tblKartons/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="KartonID,Napomena,HronicnaBolest,Visina,Tezina,Upozorenje,IzabraniLekar")> ByVal tblKarton As tblKarton) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tblKarton).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.HronicnaBolest = New SelectList(db.tblHronicnaBolests, "HronicnaBolestID", "DijagnozaBolesti", tblKarton.HronicnaBolest)
            ViewBag.IzabraniLekar = New SelectList(db.tblLekars, "LekarID", "Ime", tblKarton.IzabraniLekar)
            Return View(tblKarton)
        End Function

        ' GET: tblKartons/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblKarton As tblKarton = db.tblKartons.Find(id)
            If IsNothing(tblKarton) Then
                Return HttpNotFound()
            End If
            Return View(tblKarton)
        End Function

        ' POST: tblKartons/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tblKarton As tblKarton = db.tblKartons.Find(id)
            db.tblKartons.Remove(tblKarton)
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
