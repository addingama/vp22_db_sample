Imports MySql.Data.MySqlClient

Public Class Form1

    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadData()
    End Sub

    Sub ReloadData()
        Try
            DBConnection.OpenConnection()

            dataAdapter = New MySqlDataAdapter("select * from users", DBConnection.CONN)
            dataSet = New DataSet

            dataAdapter.Fill(dataSet)


            dgv_data.DataSource = dataSet.Tables(0)
            dgv_data.ReadOnly = True
            DBConnection.CloseConnection()
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        DBConnection.OpenConnection()
        Dim command = New MySqlCommand("INSERT INTO users values ('" & tb_username.Text & "', '" & tb_password.Text & "', '" & tb_fullname.Text & "')", DBConnection.CONN)
        command.ExecuteNonQuery()
        DBConnection.CloseConnection()

        ReloadData()
        ClearForm()
    End Sub

    Private Sub ClearForm()
        tb_fullname.Text = ""
        tb_password.Text = ""
        tb_username.Text = ""
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        DBConnection.OpenConnection()
        Dim command = New MySqlCommand("DELETE from users where username = 'addin'", DBConnection.CONN)
        command.ExecuteNonQuery()

        DBConnection.CloseConnection()

        ReloadData()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        DBConnection.OpenConnection()
        Dim command = New MySqlCommand("UPDATE users set name='" & tb_fullname.Text & "', password='" & tb_password.Text & "' where username = '" & tb_username.Text & "'", DBConnection.CONN)
        command.ExecuteNonQuery()

        DBConnection.CloseConnection()

        ReloadData()
        ClearForm()
    End Sub



    Private Sub dgv_data_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data.CellClick
        tb_username.Text = dgv_data.SelectedRows(0).Cells(0).Value.ToString()
        tb_password.Text = dgv_data.SelectedRows(0).Cells(1).Value.ToString()
        tb_fullname.Text = dgv_data.SelectedRows(0).Cells(2).Value.ToString()
    End Sub
End Class
