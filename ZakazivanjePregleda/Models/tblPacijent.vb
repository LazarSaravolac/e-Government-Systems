'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace ZakazivanjePregleda

    Partial Public Class tblPacijent
        Public Property PacijentID As Integer
        Public Property Ime As String
        Public Property Prezime As String
        Public Property LBO As Nullable(Of Integer)
        Public Property Telefon As Nullable(Of Integer)
        Public Property DatumRodjenja As Date
        Public Property Adresa As String
        Public Property Osiguranje As Nullable(Of Integer)
    
        Public Overridable Property tblKarton As tblKarton
        Public Overridable Property tblOsiguranje As tblOsiguranje
        Public Overridable Property tblZakPregledas As ICollection(Of tblZakPregleda) = New HashSet(Of tblZakPregleda)
    
    End Class

End Namespace
