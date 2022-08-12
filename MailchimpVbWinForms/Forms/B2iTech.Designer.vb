<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class B2iTech
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(B2iTech))
        Me.txtSubject = New Sunny.UI.UITextBox()
        Me.HtmlEditControlMessage = New Zoople.HTMLEditControl()
        Me.lblMessage = New Sunny.UI.UILabel()
        Me.btnSend = New Sunny.UI.UIButton()
        Me.UiPanel1 = New Sunny.UI.UIPanel()
        Me.picBoxUserAvater = New System.Windows.Forms.PictureBox()
        Me.lblUserName = New Sunny.UI.UILedLabel()
        Me.btnHelp = New Sunny.UI.UIImageButton()
        Me.btnNotification = New Sunny.UI.UIImageButton()
        Me.btnSignIn = New Sunny.UI.UIButton()
        Me.btnSettings = New Sunny.UI.UIImageButton()
        Me.lblSubject = New Sunny.UI.UILabel()
        Me.UiPanel1.SuspendLayout()
        CType(Me.picBoxUserAvater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNotification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSubject
        '
        Me.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.txtSubject.Location = New System.Drawing.Point(16, 99)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubject.MaxLength = 36
        Me.txtSubject.MinimumSize = New System.Drawing.Size(1, 16)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Radius = 0
        Me.txtSubject.RectColor = System.Drawing.Color.Gray
        Me.txtSubject.ShowText = False
        Me.txtSubject.Size = New System.Drawing.Size(855, 35)
        Me.txtSubject.Style = Sunny.UI.UIStyle.Custom
        Me.txtSubject.TabIndex = 2
        Me.txtSubject.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtSubject.Watermark = "Subject"
        Me.txtSubject.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'HtmlEditControlMessage
        '
        Me.HtmlEditControlMessage.AcceptsReturn = True
        Me.HtmlEditControlMessage.AvailableInlineStyles = CType(resources.GetObject("HtmlEditControlMessage.AvailableInlineStyles"), System.Collections.Generic.List(Of String))
        Me.HtmlEditControlMessage.BackColor = System.Drawing.SystemColors.Control
        Me.HtmlEditControlMessage.BaseURL = Nothing
        Me.HtmlEditControlMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.HtmlEditControlMessage.CleanMSWordHTMLOnPaste = True
        Me.HtmlEditControlMessage.CodeEditor.Enabled = True
        Me.HtmlEditControlMessage.CodeEditor.Locked = False
        Me.HtmlEditControlMessage.CodeEditor.TabWidth = 720
        Me.HtmlEditControlMessage.CodeEditor.WordWrap = False
        Me.HtmlEditControlMessage.CSSText = Nothing
        Me.HtmlEditControlMessage.CustomColorPalette = Nothing
        Me.HtmlEditControlMessage.DocumentHTML = Nothing
        Me.HtmlEditControlMessage.DuplicateBasicTextFormattingAfterEnterKey = False
        Me.HtmlEditControlMessage.EnableInlineSpelling = False
        Me.HtmlEditControlMessage.FontSizesList = Nothing
        Me.HtmlEditControlMessage.FontsList = Nothing
        Me.HtmlEditControlMessage.HiddenButtons = Nothing
        Me.HtmlEditControlMessage.ImageStorageLocation = Nothing
        Me.HtmlEditControlMessage.InCodeView = False
        Me.HtmlEditControlMessage.LanguageFile = Nothing
        Me.HtmlEditControlMessage.LicenceActivationKey = Nothing
        Me.HtmlEditControlMessage.LicenceKey = Nothing
        Me.HtmlEditControlMessage.LicenceKeyInlineSpelling = Nothing
        Me.HtmlEditControlMessage.Location = New System.Drawing.Point(16, 190)
        Me.HtmlEditControlMessage.Name = "HtmlEditControlMessage"
        Me.HtmlEditControlMessage.Size = New System.Drawing.Size(855, 365)
        Me.HtmlEditControlMessage.SpellingAutoCorrectionList = CType(resources.GetObject("HtmlEditControlMessage.SpellingAutoCorrectionList"), System.Collections.Hashtable)
        Me.HtmlEditControlMessage.TabIndex = 3
        Me.HtmlEditControlMessage.ToolstripImageScalingSize = New System.Drawing.Size(16, 16)
        Me.HtmlEditControlMessage.UseParagraphAsDefault = True
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.lblMessage.Location = New System.Drawing.Point(12, 164)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(284, 23)
        Me.lblMessage.TabIndex = 8
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMessage.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'btnSend
        '
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.btnSend.Location = New System.Drawing.Point(16, 576)
        Me.btnSend.MinimumSize = New System.Drawing.Size(1, 1)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(122, 35)
        Me.btnSend.TabIndex = 9
        Me.btnSend.Text = "Send"
        Me.btnSend.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'UiPanel1
        '
        Me.UiPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.UiPanel1.Controls.Add(Me.picBoxUserAvater)
        Me.UiPanel1.Controls.Add(Me.lblUserName)
        Me.UiPanel1.Controls.Add(Me.btnHelp)
        Me.UiPanel1.Controls.Add(Me.btnNotification)
        Me.UiPanel1.Controls.Add(Me.btnSignIn)
        Me.UiPanel1.Controls.Add(Me.btnSettings)
        Me.UiPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.UiPanel1.FillColor2 = System.Drawing.Color.Transparent
        Me.UiPanel1.FillDisableColor = System.Drawing.Color.Transparent
        Me.UiPanel1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.UiPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UiPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UiPanel1.MinimumSize = New System.Drawing.Size(1, 1)
        Me.UiPanel1.Name = "UiPanel1"
        Me.UiPanel1.Size = New System.Drawing.Size(884, 58)
        Me.UiPanel1.Style = Sunny.UI.UIStyle.Custom
        Me.UiPanel1.TabIndex = 12
        Me.UiPanel1.Text = Nothing
        Me.UiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.UiPanel1.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'picBoxUserAvater
        '
        Me.picBoxUserAvater.BackgroundImage = CType(resources.GetObject("picBoxUserAvater.BackgroundImage"), System.Drawing.Image)
        Me.picBoxUserAvater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBoxUserAvater.Location = New System.Drawing.Point(12, 9)
        Me.picBoxUserAvater.Name = "picBoxUserAvater"
        Me.picBoxUserAvater.Size = New System.Drawing.Size(40, 40)
        Me.picBoxUserAvater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxUserAvater.TabIndex = 19
        Me.picBoxUserAvater.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.lblUserName.Location = New System.Drawing.Point(67, 12)
        Me.lblUserName.MinimumSize = New System.Drawing.Size(1, 1)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(354, 35)
        Me.lblUserName.Style = Sunny.UI.UIStyle.Custom
        Me.lblUserName.TabIndex = 18
        Me.lblUserName.Text = "Guest user"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUserName.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'btnHelp
        '
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.Location = New System.Drawing.Point(642, 18)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(24, 24)
        Me.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHelp.Style = Sunny.UI.UIStyle.Custom
        Me.btnHelp.TabIndex = 16
        Me.btnHelp.TabStop = False
        Me.btnHelp.Text = Nothing
        Me.btnHelp.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'btnNotification
        '
        Me.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotification.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.btnNotification.Image = CType(resources.GetObject("btnNotification.Image"), System.Drawing.Image)
        Me.btnNotification.Location = New System.Drawing.Point(681, 18)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.Size = New System.Drawing.Size(24, 24)
        Me.btnNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNotification.Style = Sunny.UI.UIStyle.Custom
        Me.btnNotification.TabIndex = 15
        Me.btnNotification.TabStop = False
        Me.btnNotification.Text = Nothing
        Me.btnNotification.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'btnSignIn
        '
        Me.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignIn.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.btnSignIn.Location = New System.Drawing.Point(760, 12)
        Me.btnSignIn.MinimumSize = New System.Drawing.Size(1, 1)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(111, 35)
        Me.btnSignIn.Style = Sunny.UI.UIStyle.Custom
        Me.btnSignIn.TabIndex = 14
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'btnSettings
        '
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.Location = New System.Drawing.Point(720, 18)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(24, 24)
        Me.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSettings.Style = Sunny.UI.UIStyle.Custom
        Me.btnSettings.TabIndex = 13
        Me.btnSettings.TabStop = False
        Me.btnSettings.Text = Nothing
        Me.btnSettings.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'lblSubject
        '
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!)
        Me.lblSubject.Location = New System.Drawing.Point(12, 71)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(284, 23)
        Me.lblSubject.TabIndex = 13
        Me.lblSubject.Text = "Subject"
        Me.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSubject.ZoomScaleRect = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'B2iTech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 625)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.HtmlEditControlMessage)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.UiPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "B2iTech"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "B2iTech"
        Me.UiPanel1.ResumeLayout(False)
        CType(Me.picBoxUserAvater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNotification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSubject As Sunny.UI.UITextBox
    Friend WithEvents HtmlEditControlMessage As Zoople.HTMLEditControl
    Friend WithEvents lblMessage As Sunny.UI.UILabel
    Friend WithEvents btnSend As Sunny.UI.UIButton
    Friend WithEvents UiPanel1 As Sunny.UI.UIPanel
    Friend WithEvents btnSettings As Sunny.UI.UIImageButton
    Friend WithEvents btnSignIn As Sunny.UI.UIButton
    Friend WithEvents btnNotification As Sunny.UI.UIImageButton
    Friend WithEvents btnHelp As Sunny.UI.UIImageButton
    Friend WithEvents lblUserName As Sunny.UI.UILedLabel
    Friend WithEvents lblSubject As Sunny.UI.UILabel
    Friend WithEvents picBoxUserAvater As PictureBox
End Class
