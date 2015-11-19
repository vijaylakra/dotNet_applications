
Public Class MDI
    Inherits System.Windows.Forms.Form

    Private PhotoInstance As Form
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem

    Public Shared status As StatusBar
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
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuOpen As System.Windows.Forms.MenuItem
    Friend WithEvents MnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MnuOpen = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MnuExit = New System.Windows.Forms.MenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuOpen, Me.MenuItem4, Me.MenuItem2, Me.MnuExit})
        Me.MenuItem1.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.MenuItem1.Text = "File"
        '
        'MnuOpen
        '
        Me.MnuOpen.Index = 0
        Me.MnuOpen.Text = "Open"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "Back"
        '
        'MnuExit
        '
        Me.MnuExit.Index = 3
        Me.MnuExit.MergeOrder = 99
        Me.MnuExit.Text = "Exit"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = resources.GetString("OpenFileDialog1.Filter")
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 253)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3})
        Me.StatusBar1.Size = New System.Drawing.Size(292, 20)
        Me.StatusBar1.TabIndex = 1
        Me.StatusBar1.Text = "No Picture"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "No Image"
        Me.StatusBarPanel1.Width = 63
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "No Image"
        Me.StatusBarPanel2.Width = 63
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Width = 10
        '
        'MDI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.StatusBar1)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "MDI"
        Me.Text = "Edit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuExit.Click
        Me.Close()
        End
    End Sub
    Private Sub MnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuOpen.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PhotoInstance = New FrmPhoto()
            PhotoInstance.MdiParent = Me
            PhotoInstance.Tag = OpenFileDialog1.FileName
            PhotoInstance.Show()
        End If
    End Sub

    Private Sub MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        status = StatusBar1
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Home.Show()
        Me.Close()
    End Sub
End Class
