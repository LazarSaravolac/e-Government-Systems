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


    Public Class tblLekarsController
        Inherits System.Web.Mvc.Controller

        Private db As New ZakazivanjePregledaEntities8

        ' GET: tblLekars
        Function Index() As ActionResult
            Dim tblLekars = db.tblLekars.Include(Function(t) t.tblUstanova)
            Return View(tblLekars.ToList())
        End Function

        ' GET: tblLekars/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblLekar As tblLekar = db.tblLekars.Find(id)
            If IsNothing(tblLekar) Then
                Return HttpNotFound()
            End If
            Return View(tblLekar)
        End Function

        ' GET: tblLekars/Create
        Function Create() As ActionResult
            ViewBag.Ustanova = New SelectList(db.tblUstanovas, "UstanovaID", "Adresa")
            Return View()
        End Function

        ' POST: tblLekars/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="LekarID,Ime,Prezime,Specijalista,Ustanova")> ByVal tblLekar As tblLekar) As ActionResult
            If ModelState.IsValid Then
                db.tblLekars.Add(tblLekar)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Ustanova = New SelectList(db.tblUstanovas, "UstanovaID", "Adresa", tblLekar.Ustanova)
            Return View(tblLekar)
        End Function

        ' GET: tblLekars/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblLekar As tblLekar = db.tblLekars.Find(id)
            If IsNothing(tblLekar) Then
                Return HttpNotFound()
            End If
            ViewBag.Ustanova = New SelectList(db.tblUstanovas, "UstanovaID", "Adresa", tblLekar.Ustanova)
            Return View(tblLekar)
        End Function

        ' POST: tblLekars/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="LekarID,Ime,Prezime,Specijalista,Ustanova")> ByVal tblLekar As tblLekar) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tblLekar).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Ustanova = New SelectList(db.tblUstanovas, "UstanovaID", "Adresa", tblLekar.Ustanova)
            Return View(tblLekar)
        End Function

        ' GET: tblLekars/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblLekar As tblLekar = db.tblLekars.Find(id)
            If IsNothing(tblLekar) Then
                Return HttpNotFound()
            End If
            Return View(tblLekar)
        End Function

        ' POST: tblLekars/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tblLekar As tblLekar = db.tblLekars.Find(id)
            db.tblLekars.Remove(tblLekar)
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
