Public Class ContaCorrente
    Public Property owner As ByteBank.Client
    Public Property bank As Integer
    Public Property count As Integer
    Public Property extract As String = ""

#Region "Constructor"
    Public Sub New(m_money As Integer, m_bank As Integer, m_count As Integer)
        bank = m_bank
        count = m_count
        money = m_money
    End Sub
#End Region

#Region "Property"
    Private m_money As Double = 1000
    Public Property money As Double
        Get
            Return m_money
        End Get
        Set(value As Double)
            If value < 0 Then
                m_money = 0
            Else
                m_money = value
            End If
        End Set
    End Property
#End Region

#Region "Métodos"
    Public Function Sacar(moneyGet As Double) As Boolean
        If m_money < moneyGet Then
            Return False
        Else
            m_money -= moneyGet
            Return True
        End If
    End Function

    Public Sub Deposit(depositMoney As Double)
        m_money += depositMoney
    End Sub

    Public Function Transfer(valueTransfer As Double, ByRef contaDestiny As ContaCorrente) As Boolean
        If m_money < valueTransfer Then
            Return False
        Else
            m_money -= valueTransfer
            contaDestiny.Deposit(valueTransfer)
            Return True
        End If
    End Function
#End Region
End Class
