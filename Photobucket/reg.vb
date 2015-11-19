Public Class Reg
    Dim gen As String

    Private Sub zipcode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles zipcode.Click
        zipcode.Text = ""
    End Sub

    Private Sub Month_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Month.SelectedIndexChanged
        Month.ForeColor = Color.Black
    End Sub

    Private Sub RichTextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.GotFocus
        RichTextBox1.Text = ""

    End Sub

    Private Sub RichTextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox2.Click
        RichTextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RichTextBox1.Text = "" Then
            Message("Please enter an email address that you use regularily")
            RichTextBox1.Focus()
        ElseIf RichTextBox2.Text = "" Then
            Message("Username must be 3-50 characters long. It can contain a-z, A-Z, 0-9, -, _ and must begin with either a letter, number or underscore. No spaces, please.")
            RichTextBox2.Focus()
        ElseIf TextBox1.Text = "" Then
            Message("Password must contain at least 6 characters: a-z, A-Z, 0-9, - and _ only. No spaces, please.")
            TextBox1.Focus()
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
            Message("Specify your gender")
        Else
            If RadioButton1.Checked = False Then
                gen = RadioButton2.Text
            Else
                gen = RadioButton1.Text
            End If
            Dim Check As Int32
            Check = Getid("tblUser", "ID", "Username='" & RichTextBox2.Text & "'") - 1
            If Check = 0 Then
                Dim ID As Int32
                ID = Getid("tblUser", "ID")
                Com.CommandText = "Insert into tblUser Values(?,?,?,?,?,?,?,?,?)"
                Com.Parameters.Add("@ID", OleDb.OleDbType.Integer).Value = ID
                Com.Parameters.Add("@Email", OleDb.OleDbType.VarChar).Value = RichTextBox1.Text
                Com.Parameters.Add("@Username", OleDb.OleDbType.VarChar).Value = RichTextBox2.Text
                Com.Parameters.Add("@Pass", OleDb.OleDbType.VarChar).Value = TextBox1.Text
                Com.Parameters.Add("@DobMonth", OleDb.OleDbType.VarChar).Value = Month.Text
                Com.Parameters.Add("@DobDay", OleDb.OleDbType.Integer).Value = Day.Text
                Com.Parameters.Add("@DobYear", OleDb.OleDbType.Integer).Value = Year.Text
                Com.Parameters.Add("@Gender", OleDb.OleDbType.VarChar).Value = gen
                Com.Parameters.Add("@Zip code", OleDb.OleDbType.Integer).Value = zipcode.Text
                Com.ExecuteNonQuery()
                Com.Parameters.Clear()
                Message("Registration Successful.Go Back to main page to logIn.")
                RichTextBox1.Text = "Email"
                RichTextBox2.Text = "Username"
                TextBox1.Text = "Password"
                Month.SelectedIndex = -1
                Day.SelectedIndex = -1
                Year.SelectedIndex = -1
            Else
                Message("User Name has already.")
                RichTextBox2.Focus()
                RichTextBox2.SelectAll()
            End If
        End If
    End Sub

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Mainfrm.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Reg_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Mainfrm.Close()
    End Sub

    Private Sub Reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Terms.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Mainfrm.Show()
    End Sub
End Class
