Imports MySql.Data.MySqlClient

Module DBConnection

    Public CONN As MySqlConnection = New MySqlConnection()

    Sub OpenConnection()
        CONN.ConnectionString = "server=localhost;user id=root;password=password;database=test"
        CONN.Open()
    End Sub

    Sub CloseConnection()
        CONN.Close()
    End Sub
End Module
