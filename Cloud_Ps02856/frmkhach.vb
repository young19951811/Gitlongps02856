Public Class frmkhach
    Private Sub KHACH_HANGBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles KHACH_HANGBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KHACH_HANGBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub frmkhach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.KHACH_HANG' table. You can move, or remove it, as needed.
        Me.KHACH_HANGTableAdapter.Fill(Me.DataSet1.KHACH_HANG)

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Me.KHACH_HANGBindingSource.AddNew()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.Validate()
        Me.KHACH_HANGBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.KHACH_HANGBindingSource.RemoveCurrent()
    End Sub
End Class