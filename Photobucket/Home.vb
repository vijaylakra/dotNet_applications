Imports System.IO
Public Class Home
    Dim Dr As OleDb.OleDbDataReader
    Dim pic As PictureBox
    Dim x, y, diff, dify, i As Int32

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        x = 0
        y = 0
        Panel6.Controls.Clear()
        picPhoto.Visible = False
        btnAdd.Visible = False
        Label1.Text = "Your Uploaded Images"
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Me.user_name.Text & "'"
        Dr = Com2.ExecuteReader
        ' If Dr.Read = True Then
        While Dr.Read()
            Dim arrImage() As Byte
            Dim myMS As New System.IO.MemoryStream
            pic = New PictureBox()
            i += 1
            pic.Name = "Pic" & i
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            pic.BorderStyle = BorderStyle.Fixed3D
            arrImage = Dr(0)
            For Each ar As Byte In arrImage
                myMS.WriteByte(ar)
            Next
            pic.Image = Image.FromStream(myMS)
            pic.SetBounds(x, y, 150, 150)
            x += 150
            'check if there is enough space for in the x axis for adding an image
            If x >= Panel6.Width Or (x + 150) > Panel6.Width Then
                diff = Panel6.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel6.Height) Then
                dify = Panel6.Height - y
            End If
            Panel6.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()

        Cnn1.Close()
        LinkLabel8.Enabled = False
        LinkLabel1.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & user_name.Text & "'"
        Dr = Com2.ExecuteReader
        If Dr.Read = True Then
            Label4.Visible = False
        Else
            Label4.Text = "You have no Image Uploaded"
        End If
        Dr.Close()
        Cnn1.Close()
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Me.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Me.Hide()
        MDI.Show()
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Me.PicPhoto2.Visible = True
        Me.btnAdd.Visible = True
        Mainfrm.Username.Text = "Username"
        Mainfrm.password.Text = "Password"
        Mainfrm.Username.Focus()
        Mainfrm.Show()
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim index As Integer = -1
        Dim ind As Integer = -1
        index = ComboBox1.SelectedIndex
        ind = ComboBox2.SelectedIndex
        If index = -1 Then
            MsgBox("Chooose Category")
        ElseIf ind = -1 Then
            MsgBox("Choose Privacy")
        Else
            OpenConnect1()

            Dim arrImage() As Byte
            Dim strImage As String
            Dim myMs As New IO.MemoryStream
            '
            If Not IsNothing(Me.PicPhoto2.BackgroundImage) Then
                Me.PicPhoto2.BackgroundImage.Save(myMs, Me.PicPhoto2.BackgroundImage.RawFormat)
                arrImage = myMs.GetBuffer
                strImage = "?"
            Else
                arrImage = Nothing
                strImage = "NULL"
            End If
            Dim ID As Int32
            ID = Getid1("Pics", "ID")
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Cnn1
            cmd.CommandText = "Insert into Pics(ID,Username,Images,Category,Privacy) Values(" & ID & ",'" & _
                           Me.user_name.Text & "'," & strImage & ",'" & Me.ComboBox1.Text & "','" & Me.ComboBox2.Text & "')"
            

            If strImage = "?" Then
                cmd.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
            End If

            MsgBox("Data save successfully!")
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            cmd.ExecuteNonQuery()
            Cnn1.Close()
            picPhoto.Controls.Clear()
            LinkLabel8.Enabled = True
            PicPhoto2.BackgroundImage = Nothing
            x = 0
            y = 0
        End If
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim index As Integer = -1
        Dim ind As Integer = -1
        index = ComboBox1.SelectedIndex
        ind = ComboBox2.SelectedIndex
        If index = -1 Then
            MsgBox("Chooose Category")
            ComboBox1.Focus()
        ElseIf ind = -1 Then
            MsgBox("Choose Privacy")
            ComboBox2.Focus()
        Else

            OpenConnect1()

            Dim arrImage() As Byte
            Dim strImage As String
            Dim myMs As New IO.MemoryStream
            '
            If Not IsNothing(Me.picPhoto.BackgroundImage) Then
                Me.picPhoto.BackgroundImage.Save(myMs, Me.picPhoto.BackgroundImage.RawFormat)
                arrImage = myMs.GetBuffer
                strImage = "?"
            Else
                arrImage = Nothing
                strImage = "NULL"
            End If
            Dim ID As Int32
            ID = Getid1("Pics", "ID")
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = Cnn1
            cmd.CommandText = "Insert into Pics(ID,Username,Images,Category,Privacy) Values(" & ID & ",'" & _
                           Me.user_name.Text & "'," & strImage & ",'" & Me.ComboBox1.Text & "','" & Me.ComboBox2.Text & "')"

            If strImage = "?" Then
                cmd.Parameters.Add(strImage, OleDb.OleDbType.Binary).Value = arrImage
            End If
            Label4.Visible = False
            MsgBox("Data save successfully!")
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            cmd.ExecuteNonQuery()
            Cnn1.Close()
            x = 0
            y = 0
            picPhoto.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub llbBrowse_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbBrowse.LinkClicked
        If Me.ofd.ShowDialog = 1 Then
            Me.picPhoto.BackgroundImage = System.Drawing.Image.FromFile(Me.ofd.FileName)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Me.ofd.ShowDialog = 1 Then
            Me.PicPhoto2.BackgroundImage = System.Drawing.Image.FromFile(Me.ofd.FileName)
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Me.Hide()
        Library.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        x = 0
        y = 0
        Panel6.Controls.Clear()
        LinkLabel8.Enabled = True
        picPhoto.Visible = False
        btnAdd.Visible = False
        Label1.Text = "Public Uploaded Images"
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Privacy='Public'"
        Dr = Com2.ExecuteReader
        ' If Dr.Read = True Then
        While Dr.Read()
            Dim arrImage() As Byte
            Dim myMS As New System.IO.MemoryStream
            pic = New PictureBox()
            i += 1
            pic.Name = "Pic" & i
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            pic.BorderStyle = BorderStyle.Fixed3D
            arrImage = Dr(0)
            For Each ar As Byte In arrImage
                myMS.WriteByte(ar)
            Next
            pic.Image = Image.FromStream(myMS)
            pic.SetBounds(x, y, 150, 150)
            x += 150
            'check if there is enough space for in the x axis for adding an image
            If x >= Panel6.Width Or (x + 150) > Panel6.Width Then
                diff = Panel6.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel6.Height) Then
                dify = Panel6.Height - y
            End If
            Panel6.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()

    End Sub

    Private Sub help_link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles help_link.LinkClicked
        Me.Hide()
        AboutBox.Show()
    End Sub
End Class
