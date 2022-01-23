<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TournamentDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.BracketLabel = New System.Windows.Forms.Label()
        Me.MatchLabel = New System.Windows.Forms.Label()
        Me.WinnerComboBox = New System.Windows.Forms.ComboBox()
        Me.WinnerLabel = New System.Windows.Forms.Label()
        Me.SetWinnerButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(369, 422)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'BracketLabel
        '
        Me.BracketLabel.AutoSize = True
        Me.BracketLabel.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BracketLabel.Location = New System.Drawing.Point(12, 9)
        Me.BracketLabel.Name = "BracketLabel"
        Me.BracketLabel.Size = New System.Drawing.Size(141, 31)
        Me.BracketLabel.TabIndex = 1
        Me.BracketLabel.Text = "Bracket num"
        '
        'MatchLabel
        '
        Me.MatchLabel.AutoSize = True
        Me.MatchLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MatchLabel.Location = New System.Drawing.Point(13, 44)
        Me.MatchLabel.Name = "MatchLabel"
        Me.MatchLabel.Size = New System.Drawing.Size(253, 20)
        Me.MatchLabel.TabIndex = 3
        Me.MatchLabel.Text = "Player0 vs Player1 - Select the winner"
        '
        'WinnerComboBox
        '
        Me.WinnerComboBox.FormattingEnabled = True
        Me.WinnerComboBox.Location = New System.Drawing.Point(74, 72)
        Me.WinnerComboBox.Name = "WinnerComboBox"
        Me.WinnerComboBox.Size = New System.Drawing.Size(151, 28)
        Me.WinnerComboBox.TabIndex = 4
        '
        'WinnerLabel
        '
        Me.WinnerLabel.AutoSize = True
        Me.WinnerLabel.Location = New System.Drawing.Point(12, 75)
        Me.WinnerLabel.Name = "WinnerLabel"
        Me.WinnerLabel.Size = New System.Drawing.Size(56, 20)
        Me.WinnerLabel.TabIndex = 5
        Me.WinnerLabel.Text = "Winner"
        '
        'SetWinnerButton
        '
        Me.SetWinnerButton.Location = New System.Drawing.Point(231, 72)
        Me.SetWinnerButton.Name = "SetWinnerButton"
        Me.SetWinnerButton.Size = New System.Drawing.Size(94, 29)
        Me.SetWinnerButton.TabIndex = 6
        Me.SetWinnerButton.Text = "Next match"
        Me.SetWinnerButton.UseVisualStyleBackColor = True
        '
        'TournamentDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(580, 485)
        Me.Controls.Add(Me.SetWinnerButton)
        Me.Controls.Add(Me.WinnerLabel)
        Me.Controls.Add(Me.WinnerComboBox)
        Me.Controls.Add(Me.MatchLabel)
        Me.Controls.Add(Me.BracketLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TournamentDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TournamentDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents BracketLabel As Label
    Friend WithEvents MatchLabel As Label
    Friend WithEvents WinnerComboBox As ComboBox
    Friend WithEvents WinnerLabel As Label
    Friend WithEvents SetWinnerButton As Button
End Class
