<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.combAudiences = New Sunny.UI.UIComboBox()
        Me.combSegment = New Sunny.UI.UIComboBox()
        Me.txtReplyFrom = New Sunny.UI.UITextBox()
        Me.txtCampaignTitle = New Sunny.UI.UITextBox()
        Me.combCampaignType = New Sunny.UI.UIComboBox()
        Me.btnApplySetting = New Sunny.UI.UIButton()
        Me.btnClose = New Sunny.UI.UIButton()
        Me.lblAudiences = New Sunny.UI.UILabel()
        Me.lblSegements = New Sunny.UI.UILabel()
        Me.lblFrom = New Sunny.UI.UILabel()
        Me.lblTitle = New Sunny.UI.UILabel()
        Me.lblType = New Sunny.UI.UILabel()
        Me.lineAudiences = New Sunny.UI.UILine()
        Me.lineReply = New Sunny.UI.UILine()
        Me.lineRecipient = New Sunny.UI.UILine()
        Me.lineCampaign = New Sunny.UI.UILine()
        Me.SuspendLayout()
        '
        'combAudiences
        '
        Me.combAudiences.DataSource = Nothing
        Me.combAudiences.Enabled = False
        Me.combAudiences.FillColor = System.Drawing.Color.White
        Me.combAudiences.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.combAudiences.Location = New System.Drawing.Point(12, 192)
        Me.combAudiences.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.combAudiences.MinimumSize = New System.Drawing.Size(63, 0)
        Me.combAudiences.Name = "combAudiences"
        Me.combAudiences.Padding = New System.Windows.Forms.Padding(0, 0, 30, 2)
        Me.combAudiences.Size = New System.Drawing.Size(360, 35)
        Me.combAudiences.TabIndex = 0
        Me.combAudiences.Text = "Select audience"
        Me.combAudiences.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.combAudiences.Watermark = ""
        Me.combAudiences.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'combSegment
        '
        Me.combSegment.DataSource = Nothing
        Me.combSegment.Enabled = False
        Me.combSegment.FillColor = System.Drawing.Color.White
        Me.combSegment.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.combSegment.Location = New System.Drawing.Point(12, 317)
        Me.combSegment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.combSegment.MinimumSize = New System.Drawing.Size(63, 0)
        Me.combSegment.Name = "combSegment"
        Me.combSegment.Padding = New System.Windows.Forms.Padding(0, 0, 30, 2)
        Me.combSegment.Size = New System.Drawing.Size(360, 35)
        Me.combSegment.TabIndex = 1
        Me.combSegment.Text = "Select segment"
        Me.combSegment.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.combSegment.Watermark = ""
        Me.combSegment.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'txtReplyFrom
        '
        Me.txtReplyFrom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReplyFrom.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.txtReplyFrom.Location = New System.Drawing.Point(12, 72)
        Me.txtReplyFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReplyFrom.MaxLength = 36
        Me.txtReplyFrom.MinimumSize = New System.Drawing.Size(1, 16)
        Me.txtReplyFrom.Name = "txtReplyFrom"
        Me.txtReplyFrom.ShowText = False
        Me.txtReplyFrom.Size = New System.Drawing.Size(360, 35)
        Me.txtReplyFrom.TabIndex = 4
        Me.txtReplyFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtReplyFrom.Watermark = "Reply from"
        Me.txtReplyFrom.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'txtCampaignTitle
        '
        Me.txtCampaignTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCampaignTitle.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.txtCampaignTitle.Location = New System.Drawing.Point(12, 437)
        Me.txtCampaignTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCampaignTitle.MaxLength = 36
        Me.txtCampaignTitle.MinimumSize = New System.Drawing.Size(1, 16)
        Me.txtCampaignTitle.Name = "txtCampaignTitle"
        Me.txtCampaignTitle.ShowText = False
        Me.txtCampaignTitle.Size = New System.Drawing.Size(360, 35)
        Me.txtCampaignTitle.TabIndex = 5
        Me.txtCampaignTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtCampaignTitle.Watermark = "Campaign title"
        Me.txtCampaignTitle.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'combCampaignType
        '
        Me.combCampaignType.DataSource = Nothing
        Me.combCampaignType.FillColor = System.Drawing.Color.White
        Me.combCampaignType.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.combCampaignType.Location = New System.Drawing.Point(12, 518)
        Me.combCampaignType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.combCampaignType.MinimumSize = New System.Drawing.Size(63, 0)
        Me.combCampaignType.Name = "combCampaignType"
        Me.combCampaignType.Padding = New System.Windows.Forms.Padding(0, 0, 30, 2)
        Me.combCampaignType.Size = New System.Drawing.Size(360, 35)
        Me.combCampaignType.TabIndex = 6
        Me.combCampaignType.Text = "Select campaign type"
        Me.combCampaignType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.combCampaignType.Watermark = ""
        Me.combCampaignType.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'btnApplySetting
        '
        Me.btnApplySetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApplySetting.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.btnApplySetting.Location = New System.Drawing.Point(14, 577)
        Me.btnApplySetting.MinimumSize = New System.Drawing.Size(1, 1)
        Me.btnApplySetting.Name = "btnApplySetting"
        Me.btnApplySetting.Size = New System.Drawing.Size(233, 35)
        Me.btnApplySetting.TabIndex = 7
        Me.btnApplySetting.Text = "Apply Settings"
        Me.btnApplySetting.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(268, 577)
        Me.btnClose.MinimumSize = New System.Drawing.Size(1, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Size = New System.Drawing.Size(104, 35)
        Me.btnClose.Style = Sunny.UI.UIStyle.Custom
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lblAudiences
        '
        Me.lblAudiences.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!)
        Me.lblAudiences.ForeColor = System.Drawing.Color.Black
        Me.lblAudiences.Location = New System.Drawing.Point(8, 164)
        Me.lblAudiences.Name = "lblAudiences"
        Me.lblAudiences.Size = New System.Drawing.Size(100, 23)
        Me.lblAudiences.Style = Sunny.UI.UIStyle.Custom
        Me.lblAudiences.TabIndex = 10
        Me.lblAudiences.Text = "Audiences"
        Me.lblAudiences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAudiences.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lblSegements
        '
        Me.lblSegements.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!)
        Me.lblSegements.ForeColor = System.Drawing.Color.Black
        Me.lblSegements.Location = New System.Drawing.Point(8, 289)
        Me.lblSegements.Name = "lblSegements"
        Me.lblSegements.Size = New System.Drawing.Size(100, 23)
        Me.lblSegements.Style = Sunny.UI.UIStyle.Custom
        Me.lblSegements.TabIndex = 11
        Me.lblSegements.Text = "Segments"
        Me.lblSegements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSegements.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lblFrom
        '
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!)
        Me.lblFrom.ForeColor = System.Drawing.Color.Black
        Me.lblFrom.Location = New System.Drawing.Point(8, 44)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(100, 23)
        Me.lblFrom.Style = Sunny.UI.UIStyle.Custom
        Me.lblFrom.TabIndex = 12
        Me.lblFrom.Text = "From"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFrom.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(12, 409)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(126, 23)
        Me.lblTitle.Style = Sunny.UI.UIStyle.Custom
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitle.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lblType
        '
        Me.lblType.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!)
        Me.lblType.ForeColor = System.Drawing.Color.Black
        Me.lblType.Location = New System.Drawing.Point(12, 490)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(100, 23)
        Me.lblType.Style = Sunny.UI.UIStyle.Custom
        Me.lblType.TabIndex = 14
        Me.lblType.Text = "Type"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblType.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lineAudiences
        '
        Me.lineAudiences.BackColor = System.Drawing.Color.Transparent
        Me.lineAudiences.FillColor = System.Drawing.Color.Transparent
        Me.lineAudiences.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.lineAudiences.Location = New System.Drawing.Point(12, 132)
        Me.lineAudiences.MinimumSize = New System.Drawing.Size(1, 1)
        Me.lineAudiences.Name = "lineAudiences"
        Me.lineAudiences.Size = New System.Drawing.Size(360, 29)
        Me.lineAudiences.Style = Sunny.UI.UIStyle.Custom
        Me.lineAudiences.TabIndex = 15
        Me.lineAudiences.Text = "Audiences/ Lists"
        Me.lineAudiences.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lineReply
        '
        Me.lineReply.BackColor = System.Drawing.Color.Transparent
        Me.lineReply.FillColor = System.Drawing.Color.Transparent
        Me.lineReply.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.lineReply.Location = New System.Drawing.Point(12, 12)
        Me.lineReply.MinimumSize = New System.Drawing.Size(1, 1)
        Me.lineReply.Name = "lineReply"
        Me.lineReply.Size = New System.Drawing.Size(360, 29)
        Me.lineReply.Style = Sunny.UI.UIStyle.Custom
        Me.lineReply.TabIndex = 16
        Me.lineReply.Text = "Reply From"
        Me.lineReply.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lineRecipient
        '
        Me.lineRecipient.BackColor = System.Drawing.Color.Transparent
        Me.lineRecipient.FillColor = System.Drawing.Color.Transparent
        Me.lineRecipient.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.lineRecipient.Location = New System.Drawing.Point(12, 254)
        Me.lineRecipient.MinimumSize = New System.Drawing.Size(1, 1)
        Me.lineRecipient.Name = "lineRecipient"
        Me.lineRecipient.Size = New System.Drawing.Size(360, 29)
        Me.lineRecipient.Style = Sunny.UI.UIStyle.Custom
        Me.lineRecipient.TabIndex = 17
        Me.lineRecipient.Text = "Recipient"
        Me.lineRecipient.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lineCampaign
        '
        Me.lineCampaign.BackColor = System.Drawing.Color.Transparent
        Me.lineCampaign.FillColor = System.Drawing.Color.Transparent
        Me.lineCampaign.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.lineCampaign.Location = New System.Drawing.Point(12, 377)
        Me.lineCampaign.MinimumSize = New System.Drawing.Size(1, 1)
        Me.lineCampaign.Name = "lineCampaign"
        Me.lineCampaign.Size = New System.Drawing.Size(360, 29)
        Me.lineCampaign.Style = Sunny.UI.UIStyle.Custom
        Me.lineCampaign.TabIndex = 18
        Me.lineCampaign.Text = "Campaign"
        Me.lineCampaign.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(386, 625)
        Me.Controls.Add(Me.lineCampaign)
        Me.Controls.Add(Me.lineRecipient)
        Me.Controls.Add(Me.lineReply)
        Me.Controls.Add(Me.lineAudiences)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblSegements)
        Me.Controls.Add(Me.lblAudiences)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnApplySetting)
        Me.Controls.Add(Me.combCampaignType)
        Me.Controls.Add(Me.txtCampaignTitle)
        Me.Controls.Add(Me.txtReplyFrom)
        Me.Controls.Add(Me.combSegment)
        Me.Controls.Add(Me.combAudiences)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents combAudiences As Sunny.UI.UIComboBox
    Friend WithEvents combSegment As Sunny.UI.UIComboBox
    Friend WithEvents txtReplyFrom As Sunny.UI.UITextBox
    Friend WithEvents txtCampaignTitle As Sunny.UI.UITextBox
    Friend WithEvents combCampaignType As Sunny.UI.UIComboBox
    Friend WithEvents btnApplySetting As Sunny.UI.UIButton
    Friend WithEvents btnClose As Sunny.UI.UIButton
    Friend WithEvents lblAudiences As Sunny.UI.UILabel
    Friend WithEvents lblSegements As Sunny.UI.UILabel
    Friend WithEvents lblFrom As Sunny.UI.UILabel
    Friend WithEvents lblTitle As Sunny.UI.UILabel
    Friend WithEvents lblType As Sunny.UI.UILabel
    Friend WithEvents lineAudiences As Sunny.UI.UILine
    Friend WithEvents lineReply As Sunny.UI.UILine
    Friend WithEvents lineRecipient As Sunny.UI.UILine
    Friend WithEvents lineCampaign As Sunny.UI.UILine
End Class
