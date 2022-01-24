<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TournamentMatchControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.WinnerLabel = New System.Windows.Forms.Label()
        Me.WinnerComboBox = New System.Windows.Forms.ComboBox()
        Me.MatchLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WinnerLabel
        '
        Me.WinnerLabel.AutoSize = True
        Me.WinnerLabel.Location = New System.Drawing.Point(3, 35)
        Me.WinnerLabel.Name = "WinnerLabel"
        Me.WinnerLabel.Size = New System.Drawing.Size(56, 20)
        Me.WinnerLabel.TabIndex = 8
        Me.WinnerLabel.Text = "Winner"
        '
        'WinnerComboBox
        '
        Me.WinnerComboBox.FormattingEnabled = True
        Me.WinnerComboBox.Location = New System.Drawing.Point(65, 31)
        Me.WinnerComboBox.Name = "WinnerComboBox"
        Me.WinnerComboBox.Size = New System.Drawing.Size(151, 28)
        Me.WinnerComboBox.TabIndex = 7
        '
        'MatchLabel
        '
        Me.MatchLabel.AutoSize = True
        Me.MatchLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MatchLabel.Location = New System.Drawing.Point(3, 4)
        Me.MatchLabel.Name = "MatchLabel"
        Me.MatchLabel.Size = New System.Drawing.Size(158, 25)
        Me.MatchLabel.TabIndex = 6
        Me.MatchLabel.Text = "Player0 vs Player1"
        '
        'TournamentMatchControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WinnerLabel)
        Me.Controls.Add(Me.WinnerComboBox)
        Me.Controls.Add(Me.MatchLabel)
        Me.Name = "TournamentMatchControl"
        Me.Size = New System.Drawing.Size(327, 64)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WinnerLabel As Label
    Friend WithEvents WinnerComboBox As ComboBox
    Friend WithEvents MatchLabel As Label
End Class
