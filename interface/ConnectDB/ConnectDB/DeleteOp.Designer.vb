﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteOp
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.delete_button = New System.Windows.Forms.Button()
        Me.deleteid = New System.Windows.Forms.TextBox()
        Me.delete_lable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'delete_button
        '
        Me.delete_button.Location = New System.Drawing.Point(116, 87)
        Me.delete_button.Name = "delete_button"
        Me.delete_button.Size = New System.Drawing.Size(75, 23)
        Me.delete_button.TabIndex = 8
        Me.delete_button.Text = "Delete!"
        Me.delete_button.UseVisualStyleBackColor = True
        '
        'deleteid
        '
        Me.deleteid.Location = New System.Drawing.Point(106, 57)
        Me.deleteid.Name = "deleteid"
        Me.deleteid.Size = New System.Drawing.Size(100, 20)
        Me.deleteid.TabIndex = 7
        '
        'delete_lable
        '
        Me.delete_lable.AutoSize = True
        Me.delete_lable.Location = New System.Drawing.Point(29, 60)
        Me.delete_lable.Name = "delete_lable"
        Me.delete_lable.Size = New System.Drawing.Size(71, 13)
        Me.delete_lable.TabIndex = 6
        Me.delete_lable.Text = "Oponnent ID:"
        '
        'DeleteOp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 159)
        Me.Controls.Add(Me.delete_button)
        Me.Controls.Add(Me.deleteid)
        Me.Controls.Add(Me.delete_lable)
        Me.Name = "DeleteOp"
        Me.Text = "DeleteOp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents delete_button As Button
    Friend WithEvents deleteid As TextBox
    Friend WithEvents delete_lable As Label
End Class
