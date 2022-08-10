<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.comAudience = New Sunny.UI.UIComboBox()
        Me.lbl = New Sunny.UI.UILabel()
        Me.btnSend = New Sunny.UI.UIButton()
        Me.lbl2 = New Sunny.UI.UILabel()
        Me.cmbCampaigns = New Sunny.UI.UIComboBox()
        Me.SuspendLayout()
        '
        'comAudience
        '
        Me.comAudience.DataSource = Nothing
        Me.comAudience.FillColor = System.Drawing.Color.White
        Me.comAudience.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.comAudience.Location = New System.Drawing.Point(12, 46)
        Me.comAudience.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comAudience.MinimumSize = New System.Drawing.Size(63, 0)
        Me.comAudience.Name = "comAudience"
        Me.comAudience.Padding = New System.Windows.Forms.Padding(0, 0, 30, 2)
        Me.comAudience.Size = New System.Drawing.Size(279, 35)
        Me.comAudience.TabIndex = 0
        Me.comAudience.Text = "audience"
        Me.comAudience.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.comAudience.Watermark = ""
        Me.comAudience.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lbl
        '
        Me.lbl.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.lbl.Location = New System.Drawing.Point(8, 9)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(284, 23)
        Me.lbl.TabIndex = 4
        Me.lbl.Text = "Select an audience."
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'btnSend
        '
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.btnSend.Location = New System.Drawing.Point(12, 221)
        Me.btnSend.MinimumSize = New System.Drawing.Size(1, 1)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(102, 35)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send"
        Me.btnSend.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.lbl2.Location = New System.Drawing.Point(8, 109)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(284, 23)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "Select an audience."
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl2.Visible = False
        Me.lbl2.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'cmbCampaigns
        '
        Me.cmbCampaigns.DataSource = Nothing
        Me.cmbCampaigns.FillColor = System.Drawing.Color.White
        Me.cmbCampaigns.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.cmbCampaigns.Location = New System.Drawing.Point(12, 150)
        Me.cmbCampaigns.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCampaigns.MinimumSize = New System.Drawing.Size(63, 0)
        Me.cmbCampaigns.Name = "cmbCampaigns"
        Me.cmbCampaigns.Padding = New System.Windows.Forms.Padding(0, 0, 30, 2)
        Me.cmbCampaigns.Size = New System.Drawing.Size(279, 35)
        Me.cmbCampaigns.TabIndex = 6
        Me.cmbCampaigns.Text = "campaign"
        Me.cmbCampaigns.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmbCampaigns.Visible = False
        Me.cmbCampaigns.Watermark = ""
        Me.cmbCampaigns.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 272)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.cmbCampaigns)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.comAudience)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents comAudience As Sunny.UI.UIComboBox
    Friend WithEvents lbl As Sunny.UI.UILabel
    Friend WithEvents btnSend As Sunny.UI.UIButton
    Friend WithEvents lbl2 As Sunny.UI.UILabel
    Friend WithEvents cmbCampaigns As Sunny.UI.UIComboBox
End Class
