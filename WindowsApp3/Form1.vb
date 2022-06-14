Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        DBConnection.OpenConnection()

        Dim command = New MySqlCommand("INSERT INTO users values ('" & tb_username.Text & "', '" & tb_password.Text & "', '" & tb_fullname.Text & "')", DBConnection.CONN)
        command.ExecuteNonQuery()


        DBConnection.CloseConnection()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        DBConnection.OpenConnection()
        Dim command = New MySqlCommand("DELETE from users where username = 'addin'", DBConnection.CONN)
        command.ExecuteNonQuery()

        DBConnection.CloseConnection()
    End Sub
End Class
