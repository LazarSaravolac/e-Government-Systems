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
    Public Class tblUstanovasController
        Inherits System.Web.Mvc.Controller

        Private db As New ZakazivanjePregledaEntities8

        ' GET: tblUstanovas
        Function Index() As ActionResult
            Return View(db.tblUstanovas.ToList())
        End Function

        ' GET: tblUstanovas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblUstanova As tblUstanova = db.tblUstanovas.Find(id)
            If IsNothing(tblUstanova) Then
                Return HttpNotFound()
            End If
            Return View(tblUstanova)
        End Function

        ' GET: tblUstanovas/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: tblUstanovas/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="UstanovaID,Adresa,VrstaUstanove,Direktor")> ByVal tblUstanova As tblUstanova) As ActionResult
            If ModelState.IsValid Then
                db.tblUstanovas.Add(tblUstanova)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tblUstanova)
        End Function

        ' GET: tblUstanovas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblUstanova As tblUstanova = db.tblUstanovas.Find(id)
            If IsNothing(tblUstanova) Then
                Return HttpNotFound()
            End If
            Return View(tblUstanova)
        End Function

        ' POST: tblUstanovas/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="UstanovaID,Adresa,VrstaUstanove,Direktor")> ByVal tblUstanova As tblUstanova) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tblUstanova).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tblUstanova)
        End Function

        ' GET: tblUstanovas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblUstanova As tblUstanova = db.tblUstanovas.Find(id)
            If IsNothing(tblUstanova) Then
                Return HttpNotFound()
            End If
            Return View(tblUstanova)
        End Function

        ' POST: tblUstanovas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tblUstanova As tblUstanova = db.tblUstanovas.Find(id)
            db.tblUstanovas.Remove(tblUstanova)
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
