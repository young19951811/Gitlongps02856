Public Class frmloading
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer.Start()

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        prbloading.Increment(10)
        If prbloading.Value = 100 Then
            timer.Stop()
            frmdash.Show()
            Me.Close()

        End If
    End Sub
End Class