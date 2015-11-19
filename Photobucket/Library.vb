Imports System.IO
Public Class Library
    Dim Dr As OleDb.OleDbDataReader
    Dim pic As PictureBox
    Dim x, y, diff, dify, i As Int32

    Private Sub Library_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "'"
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
            End If
            Panel1.Controls.Add(pic)
            arrImage = Nothing
        End While
        Dr.Close()
        Cnn1.Close()
        x = 0
        y = 0
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel2.Text & "'"
        Dr = Com2.ExecuteReader
        'i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel3.Text & "'"
        Dr = Com2.ExecuteReader
        'i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel4.Text & "'"
        Dr = Com2.ExecuteReader
        'i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel5.Text & "'"
        Dr = Com2.ExecuteReader
        'i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel6.Text & "'"
        Dr = Com2.ExecuteReader
        i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel7.Text & "'"
        Dr = Com2.ExecuteReader
        i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel8.Text & "'"
        Dr = Com2.ExecuteReader
        i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel9.Text & "'"
        Dr = Com2.ExecuteReader
        i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel10.Text & "'"
        Dr = Com2.ExecuteReader
        i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel11.Text & "'"
        Dr = Com2.ExecuteReader
        i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel12.Text & "'"
        Dr = Com2.ExecuteReader
        i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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
        Panel1.Controls.Clear()
        OpenConnect1()
        Com2.CommandText = "select Images from Pics where Username='" & Home.user_name.Text & "' and Category='" & LinkLabel13.Text & "'"
        Dr = Com2.ExecuteReader
        i = 0
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
            If x >= Panel1.Width Or (x + 150) > Panel1.Width Then
                diff = Panel1.Width - x
                'if no enough space, start a new line below
                y += 150
                x = 0
            End If

            If ((y + 150) > Panel1.Height) Then
                dify = Panel1.Height - y
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