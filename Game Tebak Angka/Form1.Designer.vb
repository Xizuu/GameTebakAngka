<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtAngkaSatu = New TextBox()
        txtAngkaDua = New TextBox()
        txtOperator = New TextBox()
        btnMulai = New Button()
        btnJawab = New Button()
        txtJawaban = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(51, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 30)
        Label1.TabIndex = 0
        Label1.Text = "Game Tebak Angka"
        ' 
        ' txtAngkaSatu
        ' 
        txtAngkaSatu.Location = New Point(98, 95)
        txtAngkaSatu.Name = "txtAngkaSatu"
        txtAngkaSatu.Size = New Size(100, 23)
        txtAngkaSatu.TabIndex = 1
        txtAngkaSatu.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtAngkaDua
        ' 
        txtAngkaDua.Location = New Point(98, 153)
        txtAngkaDua.Name = "txtAngkaDua"
        txtAngkaDua.Size = New Size(100, 23)
        txtAngkaDua.TabIndex = 2
        txtAngkaDua.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtOperator
        ' 
        txtOperator.Location = New Point(132, 124)
        txtOperator.Name = "txtOperator"
        txtOperator.Size = New Size(28, 23)
        txtOperator.TabIndex = 3
        txtOperator.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnMulai
        ' 
        btnMulai.Location = New Point(51, 253)
        btnMulai.Name = "btnMulai"
        btnMulai.Size = New Size(75, 23)
        btnMulai.TabIndex = 4
        btnMulai.Text = "Mulai"
        btnMulai.UseVisualStyleBackColor = True
        ' 
        ' btnJawab
        ' 
        btnJawab.Location = New Point(178, 253)
        btnJawab.Name = "btnJawab"
        btnJawab.Size = New Size(75, 23)
        btnJawab.TabIndex = 5
        btnJawab.Text = "Jawab"
        btnJawab.UseVisualStyleBackColor = True
        ' 
        ' txtJawaban
        ' 
        txtJawaban.Location = New Point(98, 224)
        txtJawaban.Name = "txtJawaban"
        txtJawaban.Size = New Size(100, 23)
        txtJawaban.TabIndex = 6
        txtJawaban.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(139, 188)
        Label2.Name = "Label2"
        Label2.Size = New Size(21, 21)
        Label2.TabIndex = 7
        Label2.Text = "="
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(320, 450)
        Controls.Add(Label2)
        Controls.Add(txtJawaban)
        Controls.Add(btnJawab)
        Controls.Add(btnMulai)
        Controls.Add(txtOperator)
        Controls.Add(txtAngkaDua)
        Controls.Add(txtAngkaSatu)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAngkaSatu As TextBox
    Friend WithEvents txtAngkaDua As TextBox
    Friend WithEvents txtOperator As TextBox
    Friend WithEvents btnMulai As Button
    Friend WithEvents btnJawab As Button
    Friend WithEvents txtJawaban As TextBox
    Friend WithEvents Label2 As Label

End Class
