Public Class Mainfrm
    Dim x1 As Integer
    Dim Dr As OleDb.OleDbDataReader
    Dim pic As PictureBox
    Dim x, y, diff, dify, i As Int32
    Private Sub signup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signup.Click
        If Username.Text = "" Then
            warning.Visible = True
            Username.Focus()
        ElseIf password.Text = "" Then
            passwarning.Visible = True
            password.Focus()
        Else
            Com.CommandText = "Select Username,Pass from tblUser where Username='" & Username.Text & "'and Pass='" & password.Text & "'"
            Dr = Com.ExecuteReader
            If Dr.Read = True Then
                Me.Hide()
                Home.Label3.Text = Dr(0)
                Home.LinkLabel7.Visible = True
                Home.user_name.Text = Dr(0)
                Home.Show()
                Dr.Close()
            Else
                invalid.Visible = True
                warning.Visible = False
                invaildpass.Visible = True
                Username.Focus()
                password.Focus()
            End If
            Dr.Close()
        End If
    End Sub

    Private Sub email_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Username.Click
        Username.Text = ""
    End Sub

    Private Sub password_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles password.Click
        password.Text = ""
    End Sub

    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Cnn.Close()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenConnect()
        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 1000
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Reg.Show()
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        x1 += 1
        If x1 = 2 Then
            PictureBox5.Left = PictureBox5.Left - 320
            PictureBox15.Left = PictureBox15.Left + 320
        End If
        If x1 = 3 Then
            PictureBox9.Left = PictureBox9.Left + 540
            PictureBox18.Left = PictureBox18.Left - 540
        End If
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='backgrounds' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='winter_landscapes' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='city_lights' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='holiday_photos' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='memes' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='snowboarding' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='night_life' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='winter_cities' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='coffee_art' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='wallpapers' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel12_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='giraffe_pictures' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel13_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        Me.Hide()
        PublicLib.Show()
        PublicLib.Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Category='superbowl' and Privacy='Public'"
        Dr = Com2.ExecuteReader

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
            If x >= PublicLib.Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = PublicLib.Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > PublicLib.Panel1.Height) Then
                dify = PublicLib.Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub
End Class