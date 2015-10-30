Imports System.Net
Imports System.IO
Imports System.Configuration

Public Class ContactoController

    Private Shared contacto As Contacto

    Shared Function CrearContacto() As Boolean
        contacto = New Contacto()
        Return True
    End Function

    Shared Function getContacto() As Contacto
        Return contacto
    End Function



End Class
