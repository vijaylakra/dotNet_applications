

Public Class FrmPhoto
    Inherits System.Windows.Forms.Form

    'Two object variables to be used in the class
    Private extension As String
    Private undoImage As Image

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        InitializeComponent()

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents MyPicture As System.Windows.Forms.PictureBox
    Friend WithEvents MnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSaveAs As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSave As System.Windows.Forms.MenuItem
    Private WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuCopy As System.Windows.Forms.MenuItem
    Friend WithEvents MnuCut As System.Windows.Forms.MenuItem
    Friend WithEvents MnuPaste As System.Windows.Forms.MenuItem
    Friend WithEvents MnuClose As System.Windows.Forms.MenuItem
    Friend WithEvents MnuZoom As System.Windows.Forms.MenuItem
    Friend WithEvents MnuZoomAuto As System.Windows.Forms.MenuItem
    Friend WithEvents MnuZoom200 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuZoom100 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuZoom75 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuZoom50 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuZoom25 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuRotateLeft As System.Windows.Forms.MenuItem
    Friend WithEvents MnuRotateRight As System.Windows.Forms.MenuItem
    Friend WithEvents MnuFlipHorizontally As System.Windows.Forms.MenuItem
    Friend WithEvents MnuFlipVertically As System.Windows.Forms.MenuItem
    Friend WithEvents MnuEmboss As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSharpen As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSmooth As System.Windows.Forms.MenuItem
    Friend WithEvents MnuDiffuse As System.Windows.Forms.MenuItem
    Friend WithEvents MnuUndo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPhoto))
        Me.MyPicture = New System.Windows.Forms.PictureBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MnuFile = New System.Windows.Forms.MenuItem
        Me.MnuSave = New System.Windows.Forms.MenuItem
        Me.MnuSaveAs = New System.Windows.Forms.MenuItem
        Me.MnuClose = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MnuUndo = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MnuCopy = New System.Windows.Forms.MenuItem
        Me.MnuCut = New System.Windows.Forms.MenuItem
        Me.MnuPaste = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MnuZoom = New System.Windows.Forms.MenuItem
        Me.MnuZoomAuto = New System.Windows.Forms.MenuItem
        Me.MnuZoom200 = New System.Windows.Forms.MenuItem
        Me.MnuZoom100 = New System.Windows.Forms.MenuItem
        Me.MnuZoom75 = New System.Windows.Forms.MenuItem
        Me.MnuZoom50 = New System.Windows.Forms.MenuItem
        Me.MnuZoom25 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MnuRotateLeft = New System.Windows.Forms.MenuItem
        Me.MnuRotateRight = New System.Windows.Forms.MenuItem
        Me.MnuFlipHorizontally = New System.Windows.Forms.MenuItem
        Me.MnuFlipVertically = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MnuEmboss = New System.Windows.Forms.MenuItem
        Me.MnuSharpen = New System.Windows.Forms.MenuItem
        Me.MnuSmooth = New System.Windows.Forms.MenuItem
        Me.MnuDiffuse = New System.Windows.Forms.MenuItem
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.MyPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyPicture
        '
        Me.MyPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPicture.Location = New System.Drawing.Point(4, 4)
        Me.MyPicture.Name = "MyPicture"
        Me.MyPicture.Size = New System.Drawing.Size(283, 43)
        Me.MyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.MyPicture.TabIndex = 0
        Me.MyPicture.TabStop = False
        Me.MyPicture.Visible = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuFile, Me.MenuItem2, Me.MenuItem6})
        '
        'MnuFile
        '
        Me.MnuFile.Index = 0
        Me.MnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuSave, Me.MnuSaveAs, Me.MnuClose, Me.MenuItem1})
        Me.MnuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.MnuFile.Text = "File"
        '
        'MnuSave
        '
        Me.MnuSave.Enabled = False
        Me.MnuSave.Index = 0
        Me.MnuSave.Text = "Save"
        '
        'MnuSaveAs
        '
        Me.MnuSaveAs.Index = 1
        Me.MnuSaveAs.Text = "Save as..."
        '
        'MnuClose
        '
        Me.MnuClose.Index = 2
        Me.MnuClose.Text = "Close Image"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuUndo, Me.MenuItem4, Me.MnuCopy, Me.MnuCut, Me.MnuPaste})
        Me.MenuItem2.Text = "Edit"
        '
        'MnuUndo
        '
        Me.MnuUndo.Enabled = False
        Me.MnuUndo.Index = 0
        Me.MnuUndo.Text = "Undo"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
        '
        'MnuCopy
        '
        Me.MnuCopy.Index = 2
        Me.MnuCopy.Text = "Copy"
        '
        'MnuCut
        '
        Me.MnuCut.Index = 3
        Me.MnuCut.Text = "Cut"
        '
        'MnuPaste
        '
        Me.MnuPaste.Enabled = False
        Me.MnuPaste.Index = 4
        Me.MnuPaste.Text = "Paste"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuZoom, Me.MenuItem8, Me.MenuItem9})
        Me.MenuItem6.Text = "Image Options"
        '
        'MnuZoom
        '
        Me.MnuZoom.Index = 0
        Me.MnuZoom.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuZoomAuto, Me.MnuZoom200, Me.MnuZoom100, Me.MnuZoom75, Me.MnuZoom50, Me.MnuZoom25})
        Me.MnuZoom.Text = "Zoom"
        '
        'MnuZoomAuto
        '
        Me.MnuZoomAuto.Checked = True
        Me.MnuZoomAuto.Index = 0
        Me.MnuZoomAuto.Text = "Auto"
        '
        'MnuZoom200
        '
        Me.MnuZoom200.Index = 1
        Me.MnuZoom200.Text = "200%"
        '
        'MnuZoom100
        '
        Me.MnuZoom100.Index = 2
        Me.MnuZoom100.Text = "100%"
        '
        'MnuZoom75
        '
        Me.MnuZoom75.Index = 3
        Me.MnuZoom75.Text = "75%"
        '
        'MnuZoom50
        '
        Me.MnuZoom50.Index = 4
        Me.MnuZoom50.Text = "50%"
        '
        'MnuZoom25
        '
        Me.MnuZoom25.Index = 5
        Me.MnuZoom25.Text = "25%"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuRotateLeft, Me.MnuRotateRight, Me.MnuFlipHorizontally, Me.MnuFlipVertically})
        Me.MenuItem8.Text = "Rotate"
        '
        'MnuRotateLeft
        '
        Me.MnuRotateLeft.Index = 0
        Me.MnuRotateLeft.Text = "Rotate Left"
        '
        'MnuRotateRight
        '
        Me.MnuRotateRight.Index = 1
        Me.MnuRotateRight.Text = "Rotate Right"
        '
        'MnuFlipHorizontally
        '
        Me.MnuFlipHorizontally.Index = 2
        Me.MnuFlipHorizontally.Text = "Flip Horizontally"
        '
        'MnuFlipVertically
        '
        Me.MnuFlipVertically.Index = 3
        Me.MnuFlipVertically.Text = "Flip Vertically"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuEmboss, Me.MnuSharpen, Me.MnuSmooth, Me.MnuDiffuse})
        Me.MenuItem9.Text = "Effects"
        '
        'MnuEmboss
        '
        Me.MnuEmboss.Index = 0
        Me.MnuEmboss.Text = "Emboss"
        '
        'MnuSharpen
        '
        Me.MnuSharpen.Index = 1
        Me.MnuSharpen.Text = "Sharpen"
        '
        'MnuSmooth
        '
        Me.MnuSmooth.Index = 2
        Me.MnuSmooth.Text = "Smooth"
        '
        'MnuDiffuse
        '
        Me.MnuDiffuse.Index = 3
        Me.MnuDiffuse.Text = "Diffuse"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "image"
        Me.SaveFileDialog1.Filter = resources.GetString("SaveFileDialog1.Filter")
        '
        'FrmPhoto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(332, 169)
        Me.Controls.Add(Me.MyPicture)
        Me.Menu = Me.MainMenu1
        Me.Name = "FrmPhoto"
        Me.Text = "FrmPhoto"
        CType(Me.MyPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    'When the form is loaded
    Private Sub FrmPhoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Establishes form title
        Me.Text = Me.Tag
        'Stores picture extension
        extension = Me.Text.Substring(Me.Text.IndexOf(".") + 1)
        'Loads the image and sets ratio, size, position...
        MyPicture.Image = Image.FromFile(Me.Tag)
        ResizePicture()
        SetFormSize()
        SetForm()
        'Makes picture visible(optimizing efficiency)
        MyPicture.Visible = True
        'Checks clipboard
        If Clipboard.GetDataObject.GetDataPresent(DataFormats.Bitmap) Then
            MnuPaste.Enabled = True
        End If
        'Sets status information
        MDI.status.ShowPanels = True
    End Sub

    'When the form gets the focus, Information is displayed
    'in the Status Bar
    Private Sub FrmPhoto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        Try
            MDI.status.Panels(0).Text = "Size: " & MyPicture.Image.Width & "*" & MyPicture.Image.Height
            MDI.status.Panels(1).Text = "Color Depth: " & System.Drawing.Image.GetPixelFormatSize(MyPicture.Image.PixelFormat) & " bpp"
            MDI.status.Panels(2).Text = "Image Resolution: " & CInt(MyPicture.Image.HorizontalResolution) & "*" & CInt(MyPicture.Image.VerticalResolution)
        Catch ignore As NullReferenceException
        End Try
    End Sub

    'When you close the picture
    Private Sub MnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuClose.Click
        Me.MyPicture.Image = Nothing
        Me.Close()
    End Sub

    'When picture is closing 
    'If this is the last child
    'changes Status bar
    Private Sub FrmPhoto_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Me.ParentForm.MdiChildren.Length = 1 Then
            MDI.status.ShowPanels = False
        End If
        Me.MyPicture.Image = Nothing
    End Sub


    'Ehrr, this resizes images mantaining aspect ratio
    '(probably this subroutines could be more efficient)
    'Hope not to hurt your senses (I'm not a proffesional)
    Private Sub ResizePicture()
        'I think it explains itself, isn't it?
        If MyPicture.Image.Width < MyPicture.Width And _
        MyPicture.Image.Height < MyPicture.Height Then
            MyPicture.SizeMode = PictureBoxSizeMode.CenterImage
        Else
            Dim ratio As Single
            If MyPicture.Image.Width > MyPicture.Image.Height Then
                ratio = MyPicture.Image.Width / MyPicture.Image.Height
                MyPicture.Height = MyPicture.Width / ratio
            Else
                ratio = MyPicture.Image.Height / MyPicture.Image.Width
                MyPicture.Height = MyPicture.Width / ratio
            End If
        End If
    End Sub

    'Second one, which try to avoid the form to be too large
    Private Sub SetFormSize()
        If MyPicture.Width < (Screen.PrimaryScreen.Bounds.Width * 0.8) Then
            Me.Width = MyPicture.Width + 20
        Else
            Me.Width = Screen.PrimaryScreen.Bounds.Width * 0.8
        End If
        If MyPicture.Height < (Screen.PrimaryScreen.Bounds.Height * 0.75) Then
            Me.Height = MyPicture.Height + 40
        Else
            Me.Height = Screen.PrimaryScreen.Bounds.Height * 0.75
        End If
    End Sub

    'This sets the form in the middle of parent form
    Private Sub SetForm()
        Me.Top = (Me.MdiParent.Height - Me.Height) / 2
        Me.Left = (Me.MdiParent.Width - Me.Width) / 2
    End Sub


    'When you save directly it saves and deletes the mark
    Private Sub MnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSave.Click
        UnsetModified()
        Try
            MsgBox(Me.Text)
            MyPicture.Image.Save(Me.Text)
        Catch err As Exception
            MsgBox(err.Message & ControlChars.CrLf & "Try with Save as...", MsgBoxStyle.Information, "ERROR")
        End Try
    End Sub


    'It saves depending of the extension
    Private Sub MnuSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSaveAs.Click
        Select Case extension
            Case "bmp"
                SaveFileDialog1.FilterIndex = 2
            Case "emf"
                SaveFileDialog1.FilterIndex = 3
            Case "exif"
                SaveFileDialog1.FilterIndex = 4
            Case "gif"
                SaveFileDialog1.FilterIndex = 5
            Case "ico"
                SaveFileDialog1.FilterIndex = 6
            Case "jpg"
                SaveFileDialog1.FilterIndex = 7
            Case "jepg"
                SaveFileDialog1.FilterIndex = 7
            Case "png"
                SaveFileDialog1.FilterIndex = 8
            Case "tif"
                SaveFileDialog1.FilterIndex = 9
            Case "wmf"
                SaveFileDialog1.FilterIndex = 10
            Case Else
                SaveFileDialog1.FilterIndex = 1
        End Select
        If Me.Text.EndsWith("*") Then
            Me.Text = Me.Text.Substring( _
                0, Me.Text.IndexOf("*"))
        End If
        SaveFileDialog1.FileName = Me.Text.Substring(Me.Text.LastIndexOf("\") + 1)
        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Me.MyPicture.Image.Save(SaveFileDialog1.FileName)
        End If
    End Sub


    'When picture is modified (an effect is applied)
    'It adds a mark in the title and enables Save Option
    Private Sub SetModified()
        If Me.Tag <> "Modified" Then
            Me.Text = Me.Text + "*"
            Me.MainMenu1.MenuItems(0).MenuItems(0).Enabled = True
            Me.Tag = "Modified"
        End If
    End Sub


    'Deletes Mark from title
    Private Sub UnsetModified()
        If Me.Tag = "Modified" Then
            Me.Text = Me.Text.Substring( _
                0, Me.Text.IndexOf("*"))
            Me.MainMenu1.MenuItems(0).MenuItems(0).Enabled = False
            Me.Tag = Me.Text
        End If
    End Sub

    'Sets undo image as image and refresh picture. Easy!
    Private Sub MnuUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuUndo.Click
        MnuUndo.Enabled = False
        MyPicture.Image = undoImage
        MyPicture.Refresh()
    End Sub


    '**************************************************************
    'COPY/CUT/PASTE

    'This are copy paste and cut options
    'Using Clipboard class it's an easy task
    Private Sub MnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCopy.Click
        Clipboard.SetDataObject(MyPicture.Image)
        MnuPaste.Enabled = True
    End Sub

    Private Sub MnuPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuPaste.Click
        If Clipboard.GetDataObject.GetDataPresent(DataFormats.Bitmap) Then
            MyPicture.Image = Clipboard.GetDataObject.GetData(DataFormats.Bitmap)
            MnuPaste.Enabled = False
        End If
    End Sub

    Private Sub MnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCut.Click
        Clipboard.SetDataObject(MyPicture.Image)
        MyPicture.CreateGraphics.Clear(Color.White)
        MnuPaste.Enabled = True
    End Sub



    '************************************************************
    'ZOOM OPTIONS


    'Zoom to auto, sets original size
    Private Sub MnuZoomAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuZoomAuto.Click
        MyPicture.SizeMode = PictureBoxSizeMode.AutoSize
        ResizePicture()
    End Sub

    'When you zoom image, picture box resizes in strech mode
    Private Sub MnuZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuZoom100.Click, _
    MnuZoom200.Click, MnuZoom25.Click, MnuZoom50.Click, MnuZoom75.Click
        'Checks selected zoom mode
        UncheckZoomMenu()
        MyPicture.SizeMode = PictureBoxSizeMode.StretchImage
        MyPicture.Width = (MyPicture.Image.Width * _
        Val(CType(sender, MenuItem).Text)) / 100
        MyPicture.Height = (MyPicture.Image.Height * Val(CType(sender, MenuItem).Text)) / 100
        SetFormSize()
        SetForm()
        CType(sender, MenuItem).Checked = True
    End Sub

    'Subrutine to uncheck zoom options
    Private Sub UncheckZoomMenu()
        Dim mnuitem As MenuItem
        For Each mnuitem In MainMenu1.MenuItems(2).MenuItems(0).MenuItems
            mnuitem.Checked = False
        Next
    End Sub



    '************************************************************
    'ROTATE IMAGE


    'This are the subroutines to rotate image
    'I'm going to comment only the first one
    'Next are the same
    Private Sub MnuRotateRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuRotateRight.Click
        'Calls RotateFlip method of class Image
        MyPicture.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        'Forces to repaint image
        MyPicture.Invalidate()
        'Swaps width * Height
        Dim tmp As Integer
        tmp = MyPicture.Width
        MyPicture.Width = MyPicture.Height
        MyPicture.Height = tmp
    End Sub


    Private Sub MnuRotateLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuRotateLeft.Click
        MyPicture.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        MyPicture.Invalidate()
        Dim tmp As Integer
        tmp = MyPicture.Width
        MyPicture.Width = MyPicture.Height
        MyPicture.Height = tmp
    End Sub

    'These two don´t need to change dimensions
    Private Sub MnuFlipHorizontally_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFlipHorizontally.Click
        MyPicture.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        MyPicture.Invalidate()
    End Sub

    Private Sub MnuFlipVertically_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFlipVertically.Click
        MyPicture.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
        MyPicture.Invalidate()
    End Sub




    '************************************************************
    'EFFECTS

    'This are the image effects. I'm going to comment only
    'the first one, because others are similar
    Private Sub MnuEmboss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuEmboss.Click
        'Sets undo image and enables menu option
        undoImage = MyPicture.Image
        MnuUndo.Enabled = True
        'A pointer to the image
        Dim bmap As New Bitmap(MyPicture.Image)
        MyPicture.Image = bmap
        'Needed variables
        Dim tempbmp As New Bitmap(MyPicture.Image)
        Dim i, j As Integer
        Dim DispX As Integer = 1, DispY As Integer = 1
        Dim red, green, blue As Integer
        'So, we go across the image matrix, pixel by pixel
        With tempbmp
            For i = 0 To .Height - 2  'rows
                For j = 0 To .Width - 2  'cols
                    Dim pixel1, pixel2 As System.Drawing.Color
                    'gets pixel and next one
                    pixel1 = .GetPixel(j, i)
                    pixel2 = .GetPixel(j + DispX, i + DispY)
                    'We change colors
                    red = Math.Min(Math.Abs(CInt(pixel1.R) - _
                    CInt(pixel2.R)) + 128, 255)
                    green = Math.Min(Math.Abs(CInt(pixel1.G) - _
                    CInt(pixel2.G)) + 128, 255)
                    blue = Math.Min(Math.Abs(CInt(pixel1.B) - _
                    CInt(pixel2.B)) + 128, 255)
                    bmap.SetPixel(j, i, Color.FromArgb(red, green, blue))
                Next
                'Every 10 rows shows current result
                If i Mod 10 = 0 Then
                    MyPicture.Invalidate()
                    MyPicture.Refresh()
                    MyPicture.CreateGraphics.DrawString _
                    ("Now Processing... " & Int(100 * i / (MyPicture.Image.Height - 2)).ToString _
                    & "%", New Font("Verdana", 12, FontStyle.Bold), Brushes.White, 10, 25)
                End If
            Next
        End With
        'Refresh the image and sets the mark in the title
        MyPicture.Refresh()
        SetModified()
    End Sub


    Private Sub MnuSharpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSharpen.Click
        undoImage = MyPicture.Image
        MnuUndo.Enabled = True
        Dim bmap As New Bitmap(MyPicture.Image)
        MyPicture.Image = bmap
        Dim tempbmp As New Bitmap(MyPicture.Image)
        Dim i, j As Integer
        Dim DX As Integer = 1, DY As Integer = 1
        Dim red, green, blue As Integer
        With tempbmp
            For i = DX To .Height - DX - 1
                For j = DY To .Width - DY - 1
                    red = CInt(.GetPixel(j, i).R) + 0.5 * CInt((.GetPixel(j, i).R) - CInt(.GetPixel(j - DX, i - DY).R))
                    green = CInt(.GetPixel(j, i).G) + 0.7 * CInt((.GetPixel(j, i).G) - CInt(.GetPixel(j - DX, i - DY).G))
                    blue = CInt(.GetPixel(j, i).B) + 0.5 * CInt((.GetPixel(j, i).B - CInt(.GetPixel(j - DX, i - DY).B)))
                    red = Math.Min(Math.Max(red, 0), 255)
                    green = Math.Min(Math.Max(green, 0), 255)
                    blue = Math.Min(Math.Max(blue, 0), 255)
                    bmap.SetPixel(j, i, Color.FromArgb(red, green, blue))
                Next
                If i Mod 10 = 0 Then
                    MyPicture.Invalidate()
                    MyPicture.Refresh()
                    MyPicture.CreateGraphics.DrawString _
                    ("Now Processing... " & Int(100 * i / (MyPicture.Image.Height - 2)).ToString _
                    & "%", New Font("Verdana", 12, FontStyle.Bold), Brushes.White, 10, 25)
                End If
            Next
        End With
        MyPicture.Refresh()
        SetModified()
    End Sub

    Private Sub MnuSmooth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSmooth.Click
        undoImage = MyPicture.Image
        MnuUndo.Enabled = True
        Dim bmap As New Bitmap(MyPicture.Image)
        MyPicture.Image = bmap
        Dim tempbmp As New Bitmap(MyPicture.Image)
        Dim DX As Integer = 1
        Dim DY As Integer = 1
        Dim red, green, blue As Integer

        Dim i, j As Integer
        With tempbmp
            For i = DX To .Height - DX - 1
                For j = DY To .Width - DY - 1
                    red = CInt((CInt(.GetPixel(j - 1, i - 1).R) + _
                            CInt(.GetPixel(j - 1, i).R) + _
                            CInt(.GetPixel(j - 1, i + 1).R) + _
                            CInt(.GetPixel(j, i - 1).R) + _
                            CInt(.GetPixel(j, i).R) + _
                            CInt(.GetPixel(j, i + 1).R) + _
                            CInt(.GetPixel(j + 1, i - 1).R) + _
                            CInt(.GetPixel(j + 1, i).R) + _
                            CInt(.GetPixel(j + 1, i + 1).R)) / 9)

                    green = CInt((CInt(.GetPixel(j - 1, i - 1).G) + _
                            CInt(.GetPixel(j - 1, i).G) + _
                            CInt(.GetPixel(j - 1, i + 1).G) + _
                            CInt(.GetPixel(j, i - 1).G) + _
                            CInt(.GetPixel(j, i).G) + _
                            CInt(.GetPixel(j, i + 1).G) + _
                            CInt(.GetPixel(j + 1, i - 1).G) + _
                            CInt(.GetPixel(j + 1, i).G) + _
                            CInt(.GetPixel(j + 1, i + 1).G)) / 9)

                    blue = CInt((CInt(.GetPixel(j - 1, i - 1).B) + _
                            CInt(.GetPixel(j - 1, i).B) + _
                            CInt(.GetPixel(j - 1, i + 1).B) + _
                            CInt(.GetPixel(j, i - 1).B) + _
                            CInt(.GetPixel(j, i).B) + _
                            CInt(.GetPixel(j, i + 1).B) + _
                            CInt(.GetPixel(j + 1, i - 1).B) + _
                            CInt(.GetPixel(j + 1, i).B) + _
                            CInt(.GetPixel(j + 1, i + 1).B)) / 9)
                    red = Math.Min(Math.Max(red, 0), 255)
                    green = Math.Min(Math.Max(green, 0), 255)
                    blue = Math.Min(Math.Max(blue, 0), 255)
                    bmap.SetPixel(j, i, Color.FromArgb(red, green, blue))
                Next
                If i Mod 10 = 0 Then
                    MyPicture.Invalidate()
                    MyPicture.Refresh()
                    MyPicture.CreateGraphics.DrawString _
                    ("Now Processing... " & Int(100 * i / (MyPicture.Image.Height - 2)).ToString _
                    & "%", New Font("Verdana", 12, FontStyle.Bold), Brushes.White, 10, 25)
                End If
            Next
        End With
        MyPicture.Refresh()
        SetModified()
    End Sub

    Private Sub MnuDiffuse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuDiffuse.Click
        undoImage = MyPicture.Image
        MnuUndo.Enabled = True
        Dim bmap As New Bitmap(MyPicture.Image)
        MyPicture.Image = bmap
        Dim tempbmp As New Bitmap(MyPicture.Image)
        Dim i As Integer, j As Integer
        Dim DX As Integer
        Dim DY As Integer
        Dim red As Integer, green As Integer, blue As Integer
        With tempbmp
            For i = 3 To .Height - 3
                For j = 3 To .Width - 3
                    DX = Rnd() * 4 - 2
                    DY = Rnd() * 4 - 2
                    red = .GetPixel(j + DX, i + DY).R
                    green = .GetPixel(j + DX, i + DY).G
                    blue = .GetPixel(j + DX, i + DY).B
                    bmap.SetPixel(j, i, Color.FromArgb(red, green, blue))
                Next
                If i Mod 10 = 0 Then
                    MyPicture.Invalidate()
                    MyPicture.Refresh()
                    MyPicture.CreateGraphics.DrawString _
                    ("Now Processing... " & Int(100 * i / (MyPicture.Image.Height - 2)).ToString _
                    & "%", New Font("Verdana", 12, FontStyle.Bold), SystemBrushes.Control, 10, 20)
                End If
            Next
        End With
        MyPicture.Refresh()
        SetModified()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub
End Class
