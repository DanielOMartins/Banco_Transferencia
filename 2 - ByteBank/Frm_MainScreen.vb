Imports _2___ByteBank.ByteBank

Public Class Frm_MainScreen
    Dim contaCorrente As New ContaCorrente(1000, 863, 863541)
    Dim contaCorrente2 As New ContaCorrente(2000, 863, 863562)
    Dim daniel As New Client("Daniel")
    Dim bianca As New Client("Bianca")
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Byte Bank"
        Lbl_Main02.Text = "Byte Bank"

        'Start of count 1
        Lbl_Value1.Text = "To deposit or get"
        Lbl_Money1.Text = "Your Money"
        Lbl_Result1.Text = "Final Money"
        Lbl_ActualMoney1.Text = "Actual Money"
        Lbl_Name1.Text = "Name"
        Lbl_ClientCount.Text = "Client quantity: " + Client.countClient.ToString
        Btn_GetMoney1.Text = "Get Money"
        Btn_Deposit1.Text = "Deposit"
        Btn_Transfer1.Text = "Transfer"
        Btn_Name1.Text = "..."
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
        Lbl_Name2.Text = "Name"
        Btn_GetMoney2.Text = "Get Money"
        Btn_Deposit2.Text = "Deposit"
        Btn_Transfer2.Text = "Transfer"
        Btn_Name2.Text = "..."
        Grp_Conta2.Text = "2 Count"

        Txt_ActualMoney2.ReadOnly = True
        Txt_Extract2.ReadOnly = True
        Txt_Money2.ReadOnly = True
        Txt_Result2.ReadOnly = True

        'Dados da Classe ContaCorrente1
        daniel.CPF = "47391079880"
        daniel.prof = "Dev"
        daniel.city = "São Paulo"

        contaCorrente.owner = daniel
        Lbl_Welcome1.Text = "Welcome " + contaCorrente.owner.name + " Bank: " + contaCorrente.bank.ToString + " Count: " + contaCorrente.count.ToString
        Txt_ActualMoney1.Text = contaCorrente.money.ToString

        'Dados da Classe ContaCorrente2
        bianca.CPF = "54379891040"
        bianca.prof = "Farmaceutica"
        bianca.city = "São Paulo"

        contaCorrente2.owner = bianca
        Lbl_Welcome2.Text = "Welcome " + contaCorrente2.owner.name + " Bank: " + contaCorrente2.bank.ToString + " Count: " + contaCorrente2.count.ToString
        Txt_ActualMoney2.Text = contaCorrente2.money.ToString
    End Sub

#Region "Grp 1"
    Private Sub Btn_GetMoney1_Click(sender As Object, e As EventArgs) Handles Btn_GetMoney1.Click
        Dim value As Double = Val(Txt_Value1.Text)
        Dim returnMoney As Boolean = contaCorrente.Sacar(value)

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

    Private Sub Btn_Deposit1_Click(sender As Object, e As EventArgs) Handles Btn_Deposit1.Click
        Dim valueDeposit As Double = Val(Txt_Value1.Text)

        Txt_Result1.Text = ""
        Txt_Money1.Text = ""

        contaCorrente.Deposit(valueDeposit)
        Txt_Result1.Text = "Deposit Suscessfull"
        Txt_ActualMoney1.Text = contaCorrente.money.ToString
        contaCorrente.extract += Now.ToString + " Deposit of " + valueDeposit.ToString + " Total money " + contaCorrente.money.ToString + vbCrLf
        Txt_Extract1.Text = contaCorrente.extract
    End Sub

    Private Sub Btn_Transfer1_Click(sender As Object, e As EventArgs) Handles Btn_Transfer1.Click
        Txt_Result1.Text = ""
        Txt_Money1.Text = ""

        Dim valueTransfer As Double = Val(Txt_Value1.Text)
        Dim returnTransfer As Boolean = contaCorrente.Transfer(valueTransfer, contaCorrente2)

        If returnTransfer = False Then
            Txt_Money1.Text = ""
            Txt_Result1.Text = "Transfer failed"
        Else
            Txt_Money1.Text = contaCorrente.money.ToString
            Txt_Money2.Text = contaCorrente2.money.ToString

            Txt_Result1.Text = "Transfer suscessfull"
            Txt_ActualMoney1.Text = contaCorrente.money.ToString
            Txt_ActualMoney2.Text = contaCorrente2.money.ToString

            contaCorrente.extract += Now.ToString + " Transfer of " + valueTransfer.ToString + " Total money " + contaCorrente.money.ToString + vbCrLf
            contaCorrente2.extract += Now.ToString + " Transfer of " + valueTransfer.ToString + " Total money " + contaCorrente2.money.ToString + vbCrLf
            Txt_Extract1.Text = contaCorrente.extract
            Txt_Extract2.Text = contaCorrente2.extract
        End If
    End Sub
#End Region

#Region "Grp 2"
    Private Sub Btn_GetMoney2_Click(sender As Object, e As EventArgs) Handles Btn_GetMoney2.Click
        Dim value As Double = Val(Txt_value2.Text)
        Dim returnMoney As Boolean = contaCorrente2.Sacar(value)

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

        contaCorrente2.Deposit(valueDeposit)
        Txt_Result2.Text = "Deposit Suscessfull"
        Txt_ActualMoney2.Text = contaCorrente2.money.ToString
        contaCorrente2.extract += Now.ToString + " Deposit of " + valueDeposit.ToString + " Total money " + contaCorrente2.money.ToString + vbCrLf
        Txt_Extract2.Text = contaCorrente2.extract
    End Sub

    Private Sub Btn_Transfer2_Click(sender As Object, e As EventArgs) Handles Btn_Transfer2.Click
        Txt_Result2.Text = ""
        Txt_Money2.Text = ""

        Dim valueTransfer As Double = Val(Txt_value2.Text)
        Dim returnTransfer As Boolean = contaCorrente2.Transfer(valueTransfer, contaCorrente)

        If returnTransfer = False Then
            Txt_Money2.Text = ""
            Txt_Result2.Text = "Transfer failed"
        Else
            Txt_Money1.Text = contaCorrente.money.ToString
            Txt_Money2.Text = contaCorrente2.money.ToString

            Txt_Result2.Text = "Transfer suscessfull"
            Txt_ActualMoney1.Text = contaCorrente.money.ToString
            Txt_ActualMoney2.Text = contaCorrente2.money.ToString

            contaCorrente.extract += Now.ToString + " Transfer of " + valueTransfer.ToString + " Total money " + contaCorrente.money.ToString + vbCrLf
            contaCorrente2.extract += Now.ToString + " Transfer of " + valueTransfer.ToString + " Total money " + contaCorrente2.money.ToString + vbCrLf
            Txt_Extract1.Text = contaCorrente.extract
            Txt_Extract2.Text = contaCorrente2.extract
        End If
    End Sub
#End Region

    Private Sub Btn_Name1_Click(sender As Object, e As EventArgs) Handles Btn_Name1.Click
        Dim vName As String = Txt_Name1.Text
        daniel.name = vName

        Lbl_Welcome1.Text = "Welcome " + contaCorrente.owner.name + " Bank: " + contaCorrente.bank.ToString + " Count: " + contaCorrente.count.ToString
    End Sub

    Private Sub Btn_Name2_Click(sender As Object, e As EventArgs)
        Dim vName As String = Txt_Name2.Text
        bianca.name = vName

        Lbl_Welcome2.Text = "Welcome " + contaCorrente2.owner.name + " Bank: " + contaCorrente2.bank.ToString + " Count: " + contaCorrente2.count.ToString
    End Sub
End Class
