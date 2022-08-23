<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCutPic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCutPic))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.chkLeftRight = New System.Windows.Forms.CheckBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.picSave = New System.Windows.Forms.PictureBox()
        Me.chkBW = New System.Windows.Forms.CheckBox()
        Me.txtThreshold = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboFormat = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCut = New System.Windows.Forms.ComboBox()
        Me.btnSaveCurrentPicture = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRows = New System.Windows.Forms.TextBox()
        Me.txtCols = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRedundance = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtT = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkColRow = New System.Windows.Forms.CheckBox()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Path:"
        '
        'txtFilePath
        '
        Me.txtFilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilePath.Location = New System.Drawing.Point(112, 7)
        Me.txtFilePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(757, 30)
        Me.txtFilePath.TabIndex = 1
        '
        'btnReload
        '
        Me.btnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReload.Location = New System.Drawing.Point(878, 7)
        Me.btnReload.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(86, 32)
        Me.btnReload.TabIndex = 2
        Me.btnReload.Text = "Load"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'chkLeftRight
        '
        Me.chkLeftRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkLeftRight.AutoSize = True
        Me.chkLeftRight.Checked = True
        Me.chkLeftRight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLeftRight.Location = New System.Drawing.Point(280, 404)
        Me.chkLeftRight.Margin = New System.Windows.Forms.Padding(4)
        Me.chkLeftRight.Name = "chkLeftRight"
        Me.chkLeftRight.Size = New System.Drawing.Size(125, 28)
        Me.chkLeftRight.TabIndex = 9
        Me.chkLeftRight.Text = "Right First"
        Me.chkLeftRight.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.Location = New System.Drawing.Point(879, 479)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(86, 32)
        Me.btnGo.TabIndex = 19
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lstFiles
        '
        Me.lstFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.ItemHeight = 24
        Me.lstFiles.Location = New System.Drawing.Point(112, 47)
        Me.lstFiles.Margin = New System.Windows.Forms.Padding(4)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(850, 124)
        Me.lstFiles.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(15, 497)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 24)
        Me.lblOutput.TabIndex = 7
        '
        'picSave
        '
        Me.picSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSave.Location = New System.Drawing.Point(908, 519)
        Me.picSave.Margin = New System.Windows.Forms.Padding(4)
        Me.picSave.Name = "picSave"
        Me.picSave.Size = New System.Drawing.Size(56, 52)
        Me.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picSave.TabIndex = 8
        Me.picSave.TabStop = False
        Me.picSave.Visible = False
        '
        'chkBW
        '
        Me.chkBW.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkBW.AutoSize = True
        Me.chkBW.Checked = True
        Me.chkBW.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBW.Location = New System.Drawing.Point(12, 367)
        Me.chkBW.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBW.Name = "chkBW"
        Me.chkBW.Size = New System.Drawing.Size(168, 28)
        Me.chkBW.TabIndex = 4
        Me.chkBW.Text = "Convert to B/W"
        Me.chkBW.UseVisualStyleBackColor = True
        '
        'txtThreshold
        '
        Me.txtThreshold.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtThreshold.Location = New System.Drawing.Point(188, 365)
        Me.txtThreshold.Margin = New System.Windows.Forms.Padding(4)
        Me.txtThreshold.Name = "txtThreshold"
        Me.txtThreshold.Size = New System.Drawing.Size(49, 30)
        Me.txtThreshold.TabIndex = 5
        Me.txtThreshold.Text = "40"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 368)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "%(Lower to black, else white)"
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.Location = New System.Drawing.Point(531, 364)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(86, 32)
        Me.btnPreview.TabIndex = 6
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.Location = New System.Drawing.Point(12, 545)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(890, 26)
        Me.lblMessage.TabIndex = 12
        Me.lblMessage.Text = "No Mission."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.picMain)
        Me.Panel1.Location = New System.Drawing.Point(16, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 179)
        Me.Panel1.TabIndex = 13
        '
        'picMain
        '
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(3, 3)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMain.TabIndex = 1
        Me.picMain.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 483)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Output"
        '
        'cboFormat
        '
        Me.cboFormat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormat.FormattingEnabled = True
        Me.cboFormat.Items.AddRange(New Object() {".JPG", ".PNG", ".GIF", ".TIF", ".BMP"})
        Me.cboFormat.Location = New System.Drawing.Point(94, 479)
        Me.cboFormat.Name = "cboFormat"
        Me.cboFormat.Size = New System.Drawing.Size(182, 32)
        Me.cboFormat.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Cut"
        '
        'cboCut
        '
        Me.cboCut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboCut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCut.FormattingEnabled = True
        Me.cboCut.Items.AddRange(New Object() {"No Cut", "Double", "Quad", "Customize"})
        Me.cboCut.Location = New System.Drawing.Point(91, 402)
        Me.cboCut.Name = "cboCut"
        Me.cboCut.Size = New System.Drawing.Size(182, 32)
        Me.cboCut.TabIndex = 8
        '
        'btnSaveCurrentPicture
        '
        Me.btnSaveCurrentPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveCurrentPicture.Location = New System.Drawing.Point(624, 365)
        Me.btnSaveCurrentPicture.Name = "btnSaveCurrentPicture"
        Me.btnSaveCurrentPicture.Size = New System.Drawing.Size(220, 31)
        Me.btnSaveCurrentPicture.TabIndex = 7
        Me.btnSaveCurrentPicture.Text = "Save current picture"
        Me.btnSaveCurrentPicture.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 444)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Rows"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(197, 443)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 24)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Cols"
        '
        'txtRows
        '
        Me.txtRows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRows.Location = New System.Drawing.Point(153, 441)
        Me.txtRows.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRows.Name = "txtRows"
        Me.txtRows.Size = New System.Drawing.Size(37, 30)
        Me.txtRows.TabIndex = 11
        Me.txtRows.Text = "1"
        '
        'txtCols
        '
        Me.txtCols.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCols.Location = New System.Drawing.Point(250, 441)
        Me.txtCols.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCols.Name = "txtCols"
        Me.txtCols.Size = New System.Drawing.Size(37, 30)
        Me.txtCols.TabIndex = 12
        Me.txtCols.Text = "5"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(760, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Redundance"
        Me.Label7.Visible = False
        '
        'txtRedundance
        '
        Me.txtRedundance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRedundance.Location = New System.Drawing.Point(885, 439)
        Me.txtRedundance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRedundance.Name = "txtRedundance"
        Me.txtRedundance.Size = New System.Drawing.Size(49, 30)
        Me.txtRedundance.TabIndex = 17
        Me.txtRedundance.Text = "0"
        Me.txtRedundance.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(942, 441)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "%"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(420, 443)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 24)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "L"
        Me.Label9.Visible = False
        '
        'txtL
        '
        Me.txtL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtL.Location = New System.Drawing.Point(446, 440)
        Me.txtL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(49, 30)
        Me.txtL.TabIndex = 13
        Me.txtL.Text = "0"
        Me.txtL.Visible = False
        '
        'txtR
        '
        Me.txtR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtR.Location = New System.Drawing.Point(531, 440)
        Me.txtR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(49, 30)
        Me.txtR.TabIndex = 14
        Me.txtR.Text = "0"
        Me.txtR.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(502, 443)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 24)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "R"
        Me.Label10.Visible = False
        '
        'txtT
        '
        Me.txtT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtT.Location = New System.Drawing.Point(614, 440)
        Me.txtT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(49, 30)
        Me.txtT.TabIndex = 15
        Me.txtT.Text = "0"
        Me.txtT.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(587, 443)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 24)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "T"
        Me.Label11.Visible = False
        '
        'txtB
        '
        Me.txtB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtB.Location = New System.Drawing.Point(698, 440)
        Me.txtB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(49, 30)
        Me.txtB.TabIndex = 16
        Me.txtB.Text = "0"
        Me.txtB.Visible = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(670, 442)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 24)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "B"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(351, 442)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 24)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Border:"
        Me.Label13.Visible = False
        '
        'chkColRow
        '
        Me.chkColRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkColRow.AutoSize = True
        Me.chkColRow.Checked = True
        Me.chkColRow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkColRow.Location = New System.Drawing.Point(413, 405)
        Me.chkColRow.Margin = New System.Windows.Forms.Padding(4)
        Me.chkColRow.Name = "chkColRow"
        Me.chkColRow.Size = New System.Drawing.Size(140, 28)
        Me.chkColRow.TabIndex = 10
        Me.chkColRow.Text = "Column row"
        Me.chkColRow.UseVisualStyleBackColor = True
        '
        'frmCutPic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 580)
        Me.Controls.Add(Me.chkColRow)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtT)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.txtL)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSaveCurrentPicture)
        Me.Controls.Add(Me.cboCut)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboFormat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtRedundance)
        Me.Controls.Add(Me.txtCols)
        Me.Controls.Add(Me.txtRows)
        Me.Controls.Add(Me.txtThreshold)
        Me.Controls.Add(Me.chkBW)
        Me.Controls.Add(Me.picSave)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lstFiles)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.chkLeftRight)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCutPic"
        Me.Text = "cut pic"
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnReload As Button
    Friend WithEvents chkLeftRight As CheckBox
    Friend WithEvents btnGo As Button
    Friend WithEvents lstFiles As ListBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents picSave As PictureBox
    Friend WithEvents chkBW As CheckBox
    Friend WithEvents txtThreshold As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPreview As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picMain As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboFormat As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label4 As Label
    Friend WithEvents cboCut As ComboBox
    Friend WithEvents btnSaveCurrentPicture As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRows As TextBox
    Friend WithEvents txtCols As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRedundance As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtL As TextBox
    Friend WithEvents txtR As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents chkColRow As CheckBox
End Class
