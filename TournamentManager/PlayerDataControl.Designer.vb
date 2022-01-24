<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlayerDataControl
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StatsLabel = New System.Windows.Forms.Label()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BorderPanel = New System.Windows.Forms.Panel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameLabel.Location = New System.Drawing.Point(3, 6)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(222, 28)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "GamerTag (PlayerName)"
        '
        'StatsLabel
        '
        Me.StatsLabel.AutoSize = True
        Me.StatsLabel.Location = New System.Drawing.Point(3, 43)
        Me.StatsLabel.Name = "StatsLabel"
        Me.StatsLabel.Size = New System.Drawing.Size(108, 20)
        Me.StatsLabel.TabIndex = 9
        Me.StatsLabel.Text = "n wins, n losses"
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(3, 9)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(94, 29)
        Me.EditButton.TabIndex = 10
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.NameLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditButton)
        Me.SplitContainer1.Size = New System.Drawing.Size(465, 40)
        Me.SplitContainer1.SplitterDistance = 356
        Me.SplitContainer1.TabIndex = 11
        '
        'BorderPanel
        '
        Me.BorderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BorderPanel.Location = New System.Drawing.Point(457, -63)
        Me.BorderPanel.Name = "BorderPanel"
        Me.BorderPanel.Size = New System.Drawing.Size(27, 154)
        Me.BorderPanel.TabIndex = 12
        '
        'PlayerDataControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.BorderPanel)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatsLabel)
        Me.Name = "PlayerDataControl"
        Me.Size = New System.Drawing.Size(465, 66)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents StatsLabel As Label
    Friend WithEvents EditButton As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BorderPanel As Panel
End Class
