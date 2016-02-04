Public Class frmdash
    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub msiquanlykhach_Click(sender As Object, e As EventArgs) Handles msiquanlykhach.Click
        frmkhach.Show()
    End Sub

    Private Sub msiquanlysanpham_Click(sender As Object, e As EventArgs) Handles msiquanlysanpham.Click
        frmsp.Show()
    End Sub

    Private Sub msithoat_Click(sender As Object, e As EventArgs) Handles msithoat.Click
        frmhoadon.Show()
    End Sub
End Class