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

    Partial Public Class tblOsiguranje
        Public Property OsiguranjeID As Integer
        Public Property VrstaOsiguranja As String
        Public Property BrojPolise As Integer
        Public Property IzdavacOsiguranja As String
        Public Property DatumIzdavanjaOsiguranja As Date
        Public Property DatumIstekaOsiguranja As Date
    
        Public Overridable Property tblPacijents As ICollection(Of tblPacijent) = New HashSet(Of tblPacijent)
    
    End Class

End Namespace
