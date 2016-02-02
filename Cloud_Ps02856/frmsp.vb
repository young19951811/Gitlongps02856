Public Class frmsp
    Private Sub frmsp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet2.DataTable1)

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Me.DataTable1BindingSource.AddNew()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.DataTable1BindingSource.RemoveCurrent()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.Validate()
        Me.DataTable1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet2)
    End Sub
End Class