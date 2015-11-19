<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.picPhoto = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.llbBrowse = New System.Windows.Forms.LinkLabel
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.help_link = New System.Windows.Forms.LinkLabel
        Me.user_name = New System.Windows.Forms.LinkLabel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PicPhoto2 = New System.Windows.Forms.Panel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.Panel6.SuspendLayout()
        Me.picPhoto.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PicPhoto2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel8.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel8.Location = New System.Drawing.Point(32, 238)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(126, 24)
        Me.LinkLabel8.TabIndex = 31
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Your Upload"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.AutoScroll = True
        Me.Panel6.Controls.Add(Me.picPhoto)
        Me.Panel6.Controls.Add(Me.btnAdd)
        Me.Panel6.Location = New System.Drawing.Point(23, 272)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(709, 410)
        Me.Panel6.TabIndex = 30
        '
        'picPhoto
        '
        Me.picPhoto.BackgroundImage = CType(resources.GetObject("picPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPhoto.Controls.Add(Me.Label4)
        Me.picPhoto.Controls.Add(Me.llbBrowse)
        Me.picPhoto.Location = New System.Drawing.Point(104, 6)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(425, 364)
        Me.picPhoto.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(60, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Label4"
        '
        'llbBrowse
        '
        Me.llbBrowse.AutoSize = True
        Me.llbBrowse.BackColor = System.Drawing.Color.Black
        Me.llbBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbBrowse.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llbBrowse.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llbBrowse.Location = New System.Drawing.Point(181, 331)
        Me.llbBrowse.Name = "llbBrowse"
        Me.llbBrowse.Size = New System.Drawing.Size(59, 16)
        Me.llbBrowse.TabIndex = 34
        Me.llbBrowse.TabStop = True
        Me.llbBrowse.Text = "Browse"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkBlue
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(278, 376)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Upload"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.LinkLabel7)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.help_link)
        Me.Panel2.Controls.Add(Me.user_name)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-8, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1372, 146)
        Me.Panel2.TabIndex = 32
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel7.LinkColor = System.Drawing.Color.White
        Me.LinkLabel7.Location = New System.Drawing.Point(1290, 14)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(65, 20)
        Me.LinkLabel7.TabIndex = 16
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Logout"
        Me.LinkLabel7.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gray
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.Photobucket.My.Resources.Resources.username
        Me.PictureBox3.Location = New System.Drawing.Point(1129, 114)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'help_link
        '
        Me.help_link.AutoSize = True
        Me.help_link.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help_link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.help_link.LinkColor = System.Drawing.Color.White
        Me.help_link.Location = New System.Drawing.Point(1315, 116)
        Me.help_link.Name = "help_link"
        Me.help_link.Size = New System.Drawing.Size(42, 18)
        Me.help_link.TabIndex = 14
        Me.help_link.TabStop = True
        Me.help_link.Text = "Help"
        '
        'user_name
        '
        Me.user_name.AutoSize = True
        Me.user_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_name.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.user_name.LinkColor = System.Drawing.Color.White
        Me.user_name.Location = New System.Drawing.Point(1172, 116)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(44, 18)
        Me.user_name.TabIndex = 13
        Me.user_name.TabStop = True
        Me.user_name.Text = "User"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.LinkLabel4)
        Me.Panel4.Controls.Add(Me.LinkLabel5)
        Me.Panel4.Controls.Add(Me.LinkLabel6)
        Me.Panel4.Location = New System.Drawing.Point(17, 65)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(631, 38)
        Me.Panel4.TabIndex = 18
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel4.LinkColor = System.Drawing.Color.White
        Me.LinkLabel4.Location = New System.Drawing.Point(180, 13)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(37, 18)
        Me.LinkLabel4.TabIndex = 14
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Edit"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel5.LinkColor = System.Drawing.Color.White
        Me.LinkLabel5.Location = New System.Drawing.Point(109, 13)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(59, 18)
        Me.LinkLabel5.TabIndex = 16
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Library"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel6.LinkColor = System.Drawing.Color.White
        Me.LinkLabel6.Location = New System.Drawing.Point(36, 12)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(53, 18)
        Me.LinkLabel6.TabIndex = 14
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Home"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Photobucket.My.Resources.Resources.photocamera
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 38)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(79, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(14, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 24)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Hello"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(68, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 34)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Welcome to Photobucket!"
        '
        'PicPhoto2
        '
        Me.PicPhoto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicPhoto2.Controls.Add(Me.LinkLabel1)
        Me.PicPhoto2.Location = New System.Drawing.Point(940, 284)
        Me.PicPhoto2.Name = "PicPhoto2"
        Me.PicPhoto2.Size = New System.Drawing.Size(396, 360)
        Me.PicPhoto2.TabIndex = 38
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Black
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(169, 325)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 16)
        Me.LinkLabel1.TabIndex = 37
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Browse"
        Me.LinkLabel1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1100, 659)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(739, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Category:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(741, 504)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Privacy"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"backgrounds", "winter_landscapes", "city_lights", "holiday_photos", "memes", "snowboarding", "night_life", "winter_cities", "coffee_art", "wallpapers", "giraffe_Picture", "superbowl"})
        Me.ComboBox1.Location = New System.Drawing.Point(808, 458)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(122, 24)
        Me.ComboBox1.TabIndex = 44
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Public", "Private"})
        Me.ComboBox2.Location = New System.Drawing.Point(808, 504)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(122, 24)
        Me.ComboBox2.TabIndex = 45
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(201, 241)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(119, 20)
        Me.LinkLabel2.TabIndex = 46
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Public Upload"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PicPhoto2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LinkLabel8)
        Me.Controls.Add(Me.Panel6)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.Panel6.ResumeLayout(False)
        Me.picPhoto.ResumeLayout(False)
        Me.picPhoto.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PicPhoto2.ResumeLayout(False)
        Me.PicPhoto2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents picPhoto As System.Windows.Forms.Panel
    Friend WithEvents llbBrowse As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents help_link As System.Windows.Forms.LinkLabel
    Friend WithEvents user_name As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PicPhoto2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
End Class
