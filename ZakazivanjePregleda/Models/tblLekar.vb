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

    Partial Public Class tblLekar
        Public Property LekarID As Integer
        Public Property Ime As String
        Public Property Prezime As String
        Public Property Specijalista As String
        Public Property Ustanova As Nullable(Of Integer)
    
        Public Overridable Property tblKartons As ICollection(Of tblKarton) = New HashSet(Of tblKarton)
        Public Overridable Property tblUstanova As tblUstanova
        Public Overridable Property tblZakPregledas As ICollection(Of tblZakPregleda) = New HashSet(Of tblZakPregleda)
    
    End Class

End Namespace