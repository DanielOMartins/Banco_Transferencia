Public Class ContaCorrente
    Public owner As String
    Public bank As Integer
    Public count As Integer
    Public money As Double
    Public extract As String = ""

    Public Function sacar(moneyGet As Double) As Boolean
        If money < moneyGet Then
            Return False
        Else
            money -= moneyGet
            Return True
        End If
    End Function

    Public Sub deposit(depositMoney As Double)
        money += depositMoney
    End Sub

    Public Function transfer(valueTransfer As Double, contaDestiny As ContaCorrente) As Boolean

    End Function
End Class
