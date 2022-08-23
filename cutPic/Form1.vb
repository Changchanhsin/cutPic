Public Class frmCutPic
    Dim cutRows As Integer
    Dim cutCols As Integer
    Dim f As System.Drawing.Imaging.ImageFormat

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        lstFiles.Items.Clear()
        If txtFilePath.Text = "" Then
            Exit Sub
        End If
        For Each ws In FileIO.FileSystem.GetFiles(txtFilePath.Text)
            Dim kzm As String = ws.Substring(InStrRev(ws, "."), ws.Length - InStrRev(ws, ".")).ToLower() '定义扩展名变量
            If kzm = "jpe" Or kzm = "tiff" Or kzm = "tif" Or kzm = "gif" Or kzm = "jpeg" Or kzm = "jpg" Or kzm = "bmp" Or kzm = "png" Then
                lstFiles.Items.Add(ws)
            End If
        Next
        If lstFiles.Items.Count > 0 Then
            lblMessage.Text = "Ready."
        Else
            lblMessage.Text = "No Mission."
        End If
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        txtFilePath.Text = Application.StartupPath
    End Sub

    Private Sub lstFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFiles.SelectedIndexChanged
        Try
            picMain.Load(lstFiles.SelectedItem)
        Catch

        End Try
    End Sub

    Private Sub setFileExt()
        Select Case cboFormat.Text
            Case ".JPG"
                f = Imaging.ImageFormat.Jpeg
            Case ".GIF"
                f = Imaging.ImageFormat.Gif
            Case ".PNG"
                f = Imaging.ImageFormat.Png
            Case ".TIF"
                f = Imaging.ImageFormat.Tiff
            Case Else
                f = Imaging.ImageFormat.Bmp
        End Select

    End Sub
    Private Sub savePicture(fn As String)
        Dim bmp As Bitmap
        Dim w As Integer
        Dim h As Integer
        Dim rect As Rectangle
        Dim stepRow As Integer
        Dim stepCol As Integer
        Dim lboundRow As Integer
        Dim uboundRow As Integer
        Dim lboundCol As Integer
        Dim uboundCol As Integer
        Dim nameABC As String
        Dim name123 As String

        updateCheck()
        If chkLeftRight.Checked Then
            stepCol = -1
            lboundCol = cutCols - 1
            uboundCol = 0
        Else
            stepCol = 1
            uboundCol = cutCols - 1
            lboundCol = 0
        End If
        If chkColRow.Checked Then
            stepRow = 1
            uboundRow = cutRows - 1
            lboundRow = 0
        Else
            stepRow = -1
            lboundRow = cutRows - 1
            uboundRow = 0
        End If
        rect.Width = picMain.Image.Width
        rect.Height = picMain.Image.Height

        If cutCols = 1 Then
            nameABC = ""
        Else
            nameABC = "A"
        End If
        If cutRows = 1 Then
            name123 = ""
        Else
            name123 = "1"
        End If

        w = picMain.Image.Width / cutCols
        h = picMain.Image.Height / cutRows
        bmp = New Bitmap(w, h)
        Dim grpSave As Graphics = Graphics.FromImage(bmp)

        For i = lboundRow To uboundRow Step stepRow
            For j = lboundCol To uboundCol Step stepCol
                Application.DoEvents()
                grpSave.DrawImage(picMain.Image, -j * w, -i * h, picMain.Image.Width, picMain.Image.Height)
                picSave.Image = bmp
                picSave.Refresh()
                picSave.Image.Save(fn + "_" + name123 + nameABC + cboFormat.Text, f)
                If nameABC <> "" Then
                    nameABC = Chr(Asc(nameABC) + 1)
                End If
            Next
            If nameABC <> "" Then
                nameABC = "A"
            End If
            If name123 <> "" Then
                name123 = Chr(Asc(name123) + 1)
            End If
        Next

        grpSave.Dispose()
        'bmp.Dispose()
        GC.Collect()

        Application.DoEvents()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'picMain.Visible = False
        btnGo.Enabled = False
        btnReload.Enabled = False
        btnPreview.Enabled = False
        Try
            setFileExt()

            Dim j As Integer
            j = 1
            For Each i In lstFiles.Items
                picMain.Load(i)

                lblMessage.Text = j & "/" & lstFiles.Items.Count & " " & i.ToString
                j += 1

                If chkBW.Checked = True Then
                    convertToBW()
                End If

                savePicture(i.ToString)
                Application.DoEvents()
            Next
            lblMessage.Text = "Completed."
            'picMain.Image.Dispose()

        Catch
        End Try
        btnGo.Enabled = True
        btnReload.Enabled = True
        btnPreview.Enabled = True
        'picMain.Visible = True
    End Sub

    Private Sub convertToBW()
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim bmpNew As New Bitmap(picMain.Image.Width, picMain.Image.Height)
        Dim c As Color
        Dim d As Color
        Dim b As Single
        Dim g As Integer
        't = Val(txtThreshold.Text) * 2.55
        'b = Val(txtThreshold.Text) / 100
        b = Val(txtThreshold.Text)
        For j = 0 To picMain.Image.Height - 1

            Application.DoEvents()
            For i = 0 To picMain.Image.Width - 1
                c = bmp.GetPixel(i, j)
                g = c.GetBrightness
                g = (c.R * 4 + c.G * 10 + c.B * 2) / 41
                If g < b Then
                    d = Color.Black
                Else
                    d = Color.White
                End If
                bmpNew.SetPixel(i, j, d)
            Next
        Next
        picMain.Image.Dispose()
        picMain.Image = bmpNew
        picMain.Refresh()
    End Sub
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        btnPreview.Enabled = False
        btnGo.Enabled = False
        btnReload.Enabled = False
        lstFiles.Enabled = False
        convertToBW()
        lstFiles.Enabled = True
        btnReload.Enabled = True
        btnGo.Enabled = True
        btnPreview.Enabled = True
    End Sub

    Private Sub frmCutPic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFormat.SelectedIndex = 0
        cboCut.SelectedIndex = 1
    End Sub

    Private Sub frmCutPic_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        MessageBox.Show("Cut pictures in folder to double or quad." & vbCrLf & "by Chang Chanhsin, 2022 @ Beijing.", "Cut Pictures", MessageBoxButtons.OK)
    End Sub

    Private Sub btnSaveCurrentPicture_Click(sender As Object, e As EventArgs) Handles btnSaveCurrentPicture.Click
        Try
            If lstFiles.Items.Count > 0 Then
                savePicture(lstFiles.SelectedItem.ToString)
            End If
        Catch

        End Try
    End Sub

    Private Function Between(x As Integer, l As Integer, u As Integer) As Integer
        Between = x
        If x > u Then
            Between = u
        End If
        If x < l Then
            Between = l
        End If
    End Function

    Private Sub txtRows_TextChanged(sender As Object, e As EventArgs) Handles txtRows.TextChanged
        Try
            txtRows.Text = Between(Int(txtRows.Text), 1, 9)
            updateCheck()
        Catch

        End Try
    End Sub

    Private Sub txtCols_TextChanged(sender As Object, e As EventArgs) Handles txtCols.TextChanged
        Try
            txtCols.Text = Between(Int(txtCols.Text), 1, 26)
            updateCheck()
        Catch

        End Try
    End Sub

    Private Sub updateCheck()
        Select Case cboCut.Text
            Case "Double"
                cutRows = 1
                cutCols = 2
            Case "Quad"
                cutRows = 2
                cutCols = 2
            Case "Customize"
                cutRows = Int(txtRows.Text)
                cutCols = Int(txtCols.Text)
            Case Else
                cutRows = 1
                cutCols = 1
        End Select
        If cutRows = 1 Then
            chkColRow.Enabled = False
        Else
            chkColRow.Enabled = True
        End If
        If cutCols = 1 Then
            chkLeftRight.Enabled = False
        Else
            chkLeftRight.Enabled = True
        End If
    End Sub

    Private Sub cboCut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCut.SelectedIndexChanged
        updateCheck()
        If cboCut.Text = "Customize" Then
            txtRows.Enabled = True
            txtCols.Enabled = True
        Else
            txtRows.Enabled = False
            txtCols.Enabled = False
        End If
    End Sub

    Private Sub chkBW_CheckedChanged(sender As Object, e As EventArgs) Handles chkBW.CheckedChanged
        If chkBW.Checked = True Then
            txtThreshold.Enabled = True
            btnPreview.Enabled = True
            btnSaveCurrentPicture.Enabled = True
        Else
            txtThreshold.Enabled = False
            btnPreview.Enabled = False
            btnSaveCurrentPicture.Enabled = False
        End If
    End Sub

End Class
