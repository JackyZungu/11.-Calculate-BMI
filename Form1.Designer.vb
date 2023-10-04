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
        txtHeight = New TextBox()
        txtWeight = New TextBox()
        txtBMI = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtComment = New TextBox()
        btnCal = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(329, 86)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(125, 27)
        txtHeight.TabIndex = 0
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(329, 144)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(125, 27)
        txtWeight.TabIndex = 1
        ' 
        ' txtBMI
        ' 
        txtBMI.BackColor = SystemColors.Info
        txtBMI.Location = New Point(329, 198)
        txtBMI.Name = "txtBMI"
        txtBMI.Size = New Size(191, 27)
        txtBMI.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(149, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 20)
        Label1.TabIndex = 3
        Label1.Text = "Enter your height in (m)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(149, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 20)
        Label2.TabIndex = 4
        Label2.Text = "Enter your weight(in kg)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(149, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 20)
        Label3.TabIndex = 5
        Label3.Text = "Your BIM is"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(149, 250)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 20)
        Label4.TabIndex = 6
        Label4.Text = "Comment"
        ' 
        ' txtComment
        ' 
        txtComment.BackColor = SystemColors.Info
        txtComment.Location = New Point(329, 250)
        txtComment.Name = "txtComment"
        txtComment.Size = New Size(191, 27)
        txtComment.TabIndex = 7
        ' 
        ' btnCal
        ' 
        btnCal.Location = New Point(320, 322)
        btnCal.Name = "btnCal"
        btnCal.Size = New Size(120, 68)
        btnCal.TabIndex = 8
        btnCal.Text = "Calculate"
        btnCal.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Stencil", 15.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(258, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(249, 31)
        Label5.TabIndex = 9
        Label5.Text = "BMI CALCULATION"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(btnCal)
        Controls.Add(txtComment)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtBMI)
        Controls.Add(txtWeight)
        Controls.Add(txtHeight)
        Name = "Form1"
        Text = "BMI Calculation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents btnCal As Button
    Friend WithEvents Label5 As Label
End Class
