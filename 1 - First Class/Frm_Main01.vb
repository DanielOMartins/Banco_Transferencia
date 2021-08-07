Public Class Frm_Main01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "1 - First Class"
        Lbl_Main.Text = "1 - First Class"
        Lbl_Money.Text = "Money"
        Lbl_Add.Text = "Add"
        Btn_Action.Text = "Click here"
        Btn_Action2.Text = "Click here"
        Btn_ValRef.Text = "Click here"

    End Sub

    Private Sub Btn_Action_Click(sender As Object, e As EventArgs) Handles Btn_Action.Click
        Dim contaCorrente1 As New ContaCorrente
        Dim add As Double = Val(Txt_Add.Text)

        contaCorrente1.owner = "Daniel"
        contaCorrente1.bank = 863
        contaCorrente1.count = 863541
        contaCorrente1.money = Val(Txt_Money.Text)

        MsgBox("Your actual money " + contaCorrente1.owner + " on C/C " + contaCorrente1.bank.ToString + " - " + contaCorrente1.count.ToString + " is " + contaCorrente1.money.ToString)

        contaCorrente1.money += add
        MsgBox("Your actual money " + contaCorrente1.owner + " on C/C " + contaCorrente1.bank.ToString + " - " + contaCorrente1.count.ToString + " is " + contaCorrente1.money.ToString)


    End Sub

    Private Sub Btn_Action2_Click(sender As Object, e As EventArgs) Handles Btn_Action2.Click
        Dim contaCorrente2 As New ContaCorrente


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_ValRef.Click
        Dim age As Integer = 18
        Dim age2 As Integer

        age2 = age
        MsgBox("Age " + age2.ToString)

        Dim contaCorrente As New ContaCorrente
        Dim contaCorrente2 As New ContaCorrente

        contaCorrente.owner = "Daniel"
        contaCorrente.bank = 863
        contaCorrente.count = 863541
        contaCorrente.money = 1000

        contaCorrente2 = contaCorrente
        MsgBox("Money from contaCorrente is " + contaCorrente.money.ToString + " Money from contaCorrente2 " + contaCorrente2.money.ToString)

        contaCorrente.money = 300
        MsgBox("Money from contaCorrente is " + contaCorrente.money.ToString + " Money from contaCorrente2 " + contaCorrente2.money.ToString)
    End Sub
End Class
