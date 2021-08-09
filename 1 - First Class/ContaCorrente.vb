Public Class ContaCorrente
    Public owner As String
    Public bank As Integer
    Public count As Integer
    Public money As Double
    Public extract As String = ""

    Public Function Sacar(moneyGet As Double) As Boolean
        If money < moneyGet Then
            Return False
        Else
            money -= moneyGet
            Return True
        End If
    End Function

    Public Sub Deposit(depositMoney As Double)
        money += depositMoney
    End Sub

    Public Function Transfer(valueTransfer As Double, ByRef contaDestiny As ContaCorrente) As Boolean
        If money < valueTransfer Then
            Return False
        Else
            money -= valueTransfer
            contaDestiny.Deposit(valueTransfer)
            Return True
        End If
    End Function
End Class
