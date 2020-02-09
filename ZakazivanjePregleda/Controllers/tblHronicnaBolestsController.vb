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
    Public Class tblHronicnaBolestsController
        Inherits System.Web.Mvc.Controller

        Private db As New ZakazivanjePregledaEntities8

        ' GET: tblHronicnaBolests
        Function Index() As ActionResult
            Return View(db.tblHronicnaBolests.ToList())
        End Function

        ' GET: tblHronicnaBolests/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblHronicnaBolest As tblHronicnaBolest = db.tblHronicnaBolests.Find(id)
            If IsNothing(tblHronicnaBolest) Then
                Return HttpNotFound()
            End If
            Return View(tblHronicnaBolest)
        End Function

        ' GET: tblHronicnaBolests/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: tblHronicnaBolests/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="HronicnaBolestID,DijagnozaBolesti,DatumPostavljanja,Terapija,DatumPoslednjeKontrole")> ByVal tblHronicnaBolest As tblHronicnaBolest) As ActionResult
            If ModelState.IsValid Then
                db.tblHronicnaBolests.Add(tblHronicnaBolest)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tblHronicnaBolest)
        End Function

        ' GET: tblHronicnaBolests/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblHronicnaBolest As tblHronicnaBolest = db.tblHronicnaBolests.Find(id)
            If IsNothing(tblHronicnaBolest) Then
                Return HttpNotFound()
            End If
            Return View(tblHronicnaBolest)
        End Function

        ' POST: tblHronicnaBolests/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="HronicnaBolestID,DijagnozaBolesti,DatumPostavljanja,Terapija,DatumPoslednjeKontrole")> ByVal tblHronicnaBolest As tblHronicnaBolest) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tblHronicnaBolest).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tblHronicnaBolest)
        End Function

        ' GET: tblHronicnaBolests/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblHronicnaBolest As tblHronicnaBolest = db.tblHronicnaBolests.Find(id)
            If IsNothing(tblHronicnaBolest) Then
                Return HttpNotFound()
            End If
            Return View(tblHronicnaBolest)
        End Function

        ' POST: tblHronicnaBolests/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tblHronicnaBolest As tblHronicnaBolest = db.tblHronicnaBolests.Find(id)
            db.tblHronicnaBolests.Remove(tblHronicnaBolest)
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
