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

    Partial Public Class tblZakPregleda
        Public Property ZakazivanjeID As Integer
        Public Property Lekar As Nullable(Of Integer)
        Public Property Pacijent As Nullable(Of Integer)
        Public Property DatumPocetkaPregleda As Nullable(Of Date)
        Public Property DatumZavrsetkaPregleda As Nullable(Of Date)
    
        Public Overridable Property tblLekar As tblLekar
        Public Overridable Property tblPacijent As tblPacijent
    
    End Class

End Namespace
