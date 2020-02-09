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
    Public Class tblOsiguranjesController
        Inherits System.Web.Mvc.Controller

        Private db As New ZakazivanjePregledaEntities8

        ' GET: tblOsiguranjes
        Function Index() As ActionResult
            Return View(db.tblOsiguranjes.ToList())
        End Function

        ' GET: tblOsiguranjes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblOsiguranje As tblOsiguranje = db.tblOsiguranjes.Find(id)
            If IsNothing(tblOsiguranje) Then
                Return HttpNotFound()
            End If
            Return View(tblOsiguranje)
        End Function

        ' GET: tblOsiguranjes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: tblOsiguranjes/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="OsiguranjeID,VrstaOsiguranja,BrojPolise,IzdavacOsiguranja,DatumIzdavanjaOsiguranja,DatumIstekaOsiguranja")> ByVal tblOsiguranje As tblOsiguranje) As ActionResult
            If ModelState.IsValid Then
                db.tblOsiguranjes.Add(tblOsiguranje)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tblOsiguranje)
        End Function

        ' GET: tblOsiguranjes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblOsiguranje As tblOsiguranje = db.tblOsiguranjes.Find(id)
            If IsNothing(tblOsiguranje) Then
                Return HttpNotFound()
            End If
            Return View(tblOsiguranje)
        End Function

        ' POST: tblOsiguranjes/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="OsiguranjeID,VrstaOsiguranja,BrojPolise,IzdavacOsiguranja,DatumIzdavanjaOsiguranja,DatumIstekaOsiguranja")> ByVal tblOsiguranje As tblOsiguranje) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tblOsiguranje).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tblOsiguranje)
        End Function

        ' GET: tblOsiguranjes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblOsiguranje As tblOsiguranje = db.tblOsiguranjes.Find(id)
            If IsNothing(tblOsiguranje) Then
                Return HttpNotFound()
            End If
            Return View(tblOsiguranje)
        End Function

        ' POST: tblOsiguranjes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tblOsiguranje As tblOsiguranje = db.tblOsiguranjes.Find(id)
            db.tblOsiguranjes.Remove(tblOsiguranje)
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
