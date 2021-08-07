Public Class Frm_Main02
    Dim contaCorrente As New ContaCorrente
    Dim contaCorrente2 As New ContaCorrente
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "1 - First Class - second frm"
        Lbl_Main02.Text = "1 - First Class - second frm"

        'Start of count 1
        Lbl_Value1.Text = "To deposit or get"
        Lbl_Money1.Text = "Your Money"
        Lbl_Result1.Text = "Final Money"
        Lbl_ActualMoney1.Text = "Actual Money"
        Btn_GetMoney1.Text = "Get Money"
        Btn_Deposit1.Text = "Deposit"
        Grp_Conta1.Text = "1 Count"

        Txt_ActualMoney1.ReadOnly = True
        Txt_Extract1.ReadOnly = True
        Txt_Money1.ReadOnly = True
        Txt_Result1.ReadOnly = True

        'Start of count 2
        Lbl_Value2.Text = "To deposit or get"
        Lbl_Money2.Text = "Your Money"
        Lbl_Result2.Text = "Final Money"
        Lbl_ActualMoney2.Text = "Actual Money"
        Btn_GetMoney2.Text = "Get Money"
        Btn_Deposit2.Text = "Deposit"
        Grp_Conta2.Text = "2 Count"

        Txt_ActualMoney2.ReadOnly = True
        Txt_Extract2.ReadOnly = True
        Txt_Money2.ReadOnly = True
        Txt_Result2.ReadOnly = True

        'Dados da Classe ContaCorrente1
        contaCorrente.owner = "Daniel"
        contaCorrente.bank = 863
        contaCorrente.count = 863541
        contaCorrente.money = 1000
        Lbl_Welcome1.Text = "Welcome " + contaCorrente.owner + " Bank: " + contaCorrente.bank.ToString + " Count: " + contaCorrente.count.ToString
        Txt_ActualMoney1.Text = contaCorrente.money.ToString

        'Dados da Classe ContaCorrente2
        contaCorrente2.owner = "Bianca"
        contaCorrente2.bank = 863
        contaCorrente2.count = 863562
        contaCorrente2.money = 2500
        Lbl_Welcome2.Text = "Welcome " + contaCorrente2.owner + " Bank: " + contaCorrente2.bank.ToString + " Count: " + contaCorrente2.count.ToString
        Txt_ActualMoney2.Text = contaCorrente2.money.ToString

    End Sub

    Private Sub Btn_GetMoney_Click(sender As Object, e As EventArgs) Handles Btn_GetMoney1.Click
        Dim value As Double = Val(Txt_Value1.Text)
        Dim returnMoney As Boolean = contaCorrente.sacar(value)

        If returnMoney = False Then
            Txt_Money1.Text = ""
            Txt_Result1.Text = "Saque não efetuado"
        Else
            Txt_Money1.Text = contaCorrente.money.ToString
            Txt_Result1.Text = "Saque efetuado"
            Txt_ActualMoney1.Text = contaCorrente.money.ToString
            contaCorrente.extract += Now.ToString + " Saque of " + value.ToString + " Total money " + contaCorrente.money.ToString + vbCrLf
            Txt_Extract1.Text = contaCorrente.extract
        End If

    End Sub

    Private Sub Btn_Deposit_Click(sender As Object, e As EventArgs) Handles Btn_Deposit1.Click
        Dim valueDeposit As Double = Val(Txt_Value1.Text)

        Txt_Result1.Text = ""
        Txt_Money1.Text = ""

        contaCorrente.deposit(valueDeposit)
        Txt_Result1.Text = "Deposit Suscessfull"
        Txt_ActualMoney1.Text = contaCorrente.money.ToString
        contaCorrente.extract += Now.ToString + " Deposit of " + valueDeposit.ToString + " Total money " + contaCorrente.money.ToString + vbCrLf
        Txt_Extract1.Text = contaCorrente.extract
    End Sub

    Private Sub Btn_GetMoney2_Click(sender As Object, e As EventArgs) Handles Btn_GetMoney2.Click
        Dim value As Double = Val(Txt_value2.Text)
        Dim returnMoney As Boolean = contaCorrente2.sacar(value)

        If returnMoney = False Then
            Txt_Money2.Text = ""
            Txt_Result2.Text = "Saque não efetuado"
        Else
            Txt_Money2.Text = contaCorrente2.money.ToString
            Txt_Result2.Text = "Saque efetuado"
            Txt_ActualMoney2.Text = contaCorrente2.money.ToString
            contaCorrente2.extract += Now.ToString + " Saque of " + value.ToString + " Total money " + contaCorrente2.money.ToString + vbCrLf
            Txt_Extract2.Text = contaCorrente2.extract
        End If
    End Sub

    Private Sub Btn_Deposit2_Click(sender As Object, e As EventArgs) Handles Btn_Deposit2.Click
        Dim valueDeposit As Double = Val(Txt_value2.Text)

        Txt_Result2.Text = ""
        Txt_Money2.Text = ""

        contaCorrente2.deposit(valueDeposit)
        Txt_Result2.Text = "Deposit Suscessfull"
        Txt_ActualMoney2.Text = contaCorrente2.money.ToString
        contaCorrente2.extract += Now.ToString + " Deposit of " + valueDeposit.ToString + " Total money " + contaCorrente2.money.ToString + vbCrLf
        Txt_Extract2.Text = contaCorrente2.extract
    End Sub
End Class