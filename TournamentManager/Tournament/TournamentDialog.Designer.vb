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
        Me.StageLabel = New System.Windows.Forms.Label()
        Me.NextStageButton = New System.Windows.Forms.Button()
        Me.MatchList = New System.Windows.Forms.FlowLayoutPanel()
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
        'StageLabel
        '
        Me.StageLabel.AutoSize = True
        Me.StageLabel.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StageLabel.Location = New System.Drawing.Point(12, 9)
        Me.StageLabel.Name = "StageLabel"
        Me.StageLabel.Size = New System.Drawing.Size(258, 31)
        Me.StageLabel.TabIndex = 1
        Me.StageLabel.Text = "Stage # - Select winners"
        '
        'NextStageButton
        '
        Me.NextStageButton.Location = New System.Drawing.Point(12, 427)
        Me.NextStageButton.Name = "NextStageButton"
        Me.NextStageButton.Size = New System.Drawing.Size(91, 37)
        Me.NextStageButton.TabIndex = 6
        Me.NextStageButton.Text = "Next stage"
        Me.NextStageButton.UseVisualStyleBackColor = True
        '
        'MatchList
        '
        Me.MatchList.AutoScroll = True
        Me.MatchList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MatchList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MatchList.Location = New System.Drawing.Point(12, 43)
        Me.MatchList.Name = "MatchList"
        Me.MatchList.Size = New System.Drawing.Size(552, 371)
        Me.MatchList.TabIndex = 7
        Me.MatchList.WrapContents = False
        '
        'TournamentDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(580, 485)
        Me.Controls.Add(Me.MatchList)
        Me.Controls.Add(Me.NextStageButton)
        Me.Controls.Add(Me.StageLabel)
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
    Friend WithEvents StageLabel As Label
    Friend WithEvents NextStageButton As Button
    Friend WithEvents MatchList As FlowLayoutPanel
End Class
