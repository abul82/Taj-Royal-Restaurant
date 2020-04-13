Imports MySql.Data.MySqlClient
Module mdlconnection
    Public Function connectdb()
        Dim myconstr As New MySqlConnection("server=localhost;user id=admin;password=Ayash@123;persistsecurityinfo=True;database=tajdb")
        Return myconstr
    End Function

End Module
