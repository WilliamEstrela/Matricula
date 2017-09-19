Imports Microsoft.VisualBasic

Public Class Aluno

    Public _matricula As Integer
    Public _nome As String
    Public _matriculado As Boolean
    Public _cod_curso As Integer


    Public Sub New(matricula As Integer, nome As String, matriculado As Boolean, cod As Integer)
        Me._matricula = matricula
        Me._nome = nome
        Me._matriculado = matriculado
        Me._cod_curso = cod
    End Sub

    Public Property matricula() As Integer
        Get
            Return _matricula
        End Get
        Set(ByVal value As Integer)
            _matricula = value
        End Set
    End Property

    Public Property nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Public Property matriculado() As Boolean
        Get
            Return _matriculado
        End Get
        Set(ByVal value As Boolean)
            _matriculado = value
        End Set
    End Property

    Public Property codcurso() As Integer
        Get
            Return _cod_curso
        End Get
        Set(ByVal value As Integer)
            _matriculado = value
        End Set
    End Property
End Class
