
Namespace ByteBank
    Public Class Client

#Region "Constructor"
        Public Sub New(initialName As String)
            name = initialName
            countClient += 1
        End Sub
#End Region

#Region "Property"

        Public Property name As String
        Public Property CPF As String
        Public Property prof As String
        Public Property city As String

        Private Shared m_countClient As Integer
        Public Shared ReadOnly Property countClient As Integer
            Get
                Return m_countClient
            End Get
        End Property
    End Class
#End Region
End Namespace


