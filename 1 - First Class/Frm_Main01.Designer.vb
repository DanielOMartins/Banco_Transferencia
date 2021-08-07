<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main01
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Action = New System.Windows.Forms.Button()
        Me.Lbl_Main = New System.Windows.Forms.Label()
        Me.Lbl_Money = New System.Windows.Forms.Label()
        Me.Lbl_Add = New System.Windows.Forms.Label()
        Me.Txt_Money = New System.Windows.Forms.TextBox()
        Me.Txt_Add = New System.Windows.Forms.TextBox()
        Me.Btn_Action2 = New System.Windows.Forms.Button()
        Me.Btn_ValRef = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Action
        '
        Me.Btn_Action.Location = New System.Drawing.Point(13, 43)
        Me.Btn_Action.Name = "Btn_Action"
        Me.Btn_Action.Size = New System.Drawing.Size(113, 29)
        Me.Btn_Action.TabIndex = 1
        Me.Btn_Action.Text = "Button1"
        Me.Btn_Action.UseVisualStyleBackColor = True
        '
        'Lbl_Main
        '
        Me.Lbl_Main.AutoSize = True
        Me.Lbl_Main.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Main.Name = "Lbl_Main"
        Me.Lbl_Main.Size = New System.Drawing.Size(41, 15)
        Me.Lbl_Main.TabIndex = 0
        Me.Lbl_Main.Text = "Label1"
        '
        'Lbl_Money
        '
        Me.Lbl_Money.AutoSize = True
        Me.Lbl_Money.Location = New System.Drawing.Point(12, 97)
        Me.Lbl_Money.Name = "Lbl_Money"
        Me.Lbl_Money.Size = New System.Drawing.Size(41, 15)
        Me.Lbl_Money.TabIndex = 2
        Me.Lbl_Money.Text = "Label1"
        '
        'Lbl_Add
        '
        Me.Lbl_Add.AutoSize = True
        Me.Lbl_Add.Location = New System.Drawing.Point(141, 97)
        Me.Lbl_Add.Name = "Lbl_Add"
        Me.Lbl_Add.Size = New System.Drawing.Size(41, 15)
        Me.Lbl_Add.TabIndex = 3
        Me.Lbl_Add.Text = "Label2"
        '
        'Txt_Money
        '
        Me.Txt_Money.Location = New System.Drawing.Point(13, 116)
        Me.Txt_Money.Name = "Txt_Money"
        Me.Txt_Money.Size = New System.Drawing.Size(91, 23)
        Me.Txt_Money.TabIndex = 4
        '
        'Txt_Add
        '
        Me.Txt_Add.Location = New System.Drawing.Point(141, 116)
        Me.Txt_Add.Name = "Txt_Add"
        Me.Txt_Add.Size = New System.Drawing.Size(91, 23)
        Me.Txt_Add.TabIndex = 5
        '
        'Btn_Action2
        '
        Me.Btn_Action2.Location = New System.Drawing.Point(156, 43)
        Me.Btn_Action2.Name = "Btn_Action2"
        Me.Btn_Action2.Size = New System.Drawing.Size(113, 29)
        Me.Btn_Action2.TabIndex = 6
        Me.Btn_Action2.Text = "Button1"
        Me.Btn_Action2.UseVisualStyleBackColor = True
        '
        'Btn_ValRef
        '
        Me.Btn_ValRef.Location = New System.Drawing.Point(69, 159)
        Me.Btn_ValRef.Name = "Btn_ValRef"
        Me.Btn_ValRef.Size = New System.Drawing.Size(113, 29)
        Me.Btn_ValRef.TabIndex = 7
        Me.Btn_ValRef.Text = "Button1"
        Me.Btn_ValRef.UseVisualStyleBackColor = True
        '
        'Frm_Main01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 212)
        Me.Controls.Add(Me.Btn_ValRef)
        Me.Controls.Add(Me.Btn_Action2)
        Me.Controls.Add(Me.Txt_Add)
        Me.Controls.Add(Me.Txt_Money)
        Me.Controls.Add(Me.Lbl_Add)
        Me.Controls.Add(Me.Lbl_Money)
        Me.Controls.Add(Me.Btn_Action)
        Me.Controls.Add(Me.Lbl_Main)
        Me.Name = "Frm_Main01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Action As Button
    Friend WithEvents Lbl_Main As Label
    Friend WithEvents Lbl_Money As Label
    Friend WithEvents Lbl_Add As Label
    Friend WithEvents Txt_Money As TextBox
    Friend WithEvents Txt_Add As TextBox
    Friend WithEvents Btn_Action2 As Button
    Friend WithEvents Btn_ValRef As Button
End Class
