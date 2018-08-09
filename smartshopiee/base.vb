Public Class base


    Private Sub base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2.51)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            LOGIN.Show()
            Me.Hide()
            Timer1.Stop()

        End If
    End Sub
End Class