﻿Imports AppProyectoKPI

Public Class Permiso

    Private _idPermiso As Integer
    Private _descripcion As String
    Private _accion As String

    Private Sub New()

    End Sub

    Public Property IdPermiso As Integer
        Get
            Return _idPermiso
        End Get
        Set(value As Integer)
            _idPermiso = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Accion As String
        Get
            Return _accion
        End Get
        Set(value As String)
            _accion = value
        End Set
    End Property
End Class
