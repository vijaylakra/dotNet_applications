Public NotInheritable Class SplashScreen1
    Dim Z As Byte


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Timer1.Interval = 50

        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Z += 2
        If Z > 100 Then
            Me.Hide()
            Mainfrm.Show()
            Timer1.Enabled = False
            Exit Sub
        End If
        ProgressBar1.Value = Z
    End Sub

   
End Class
