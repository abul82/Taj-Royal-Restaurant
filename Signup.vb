Imports MySql.Data.MySqlClient


Public Class Signup
    Dim concmd As MySqlCommand
    Dim sqlCon As MySql.Data.MySqlClient.MySqlConnection = connectdb()
    Private Sub Btnsubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click
        Dim concmd As New MySqlCommand
        If sqlCon.State = ConnectionState.Closed Then
            sqlCon.Open()
        End If
        Try
            Dim sql As String = String.Format("INSERT INTO user (s_na,s_code,us_na,us_pass,us_conpass) VALUES " _
                                                 & " (@itm1, @itm2 , @itm3 , @itm4 , @itm5)")

            concmd.Connection = sqlCon
            concmd.CommandText = sql

            concmd.Parameters.Add(New MySqlParameter("@itm1", TxtStaffNa.Text))
            concmd.Parameters.AddWithValue("@itm2", SqlDbType.Int).Value = CType(TxtStaffId.Text, Integer)
            concmd.Parameters.AddWithValue("@itm3", TxtUserNa.Text)
            concmd.Parameters.AddWithValue("@itm4", TxtPass.Text)
            concmd.Parameters.AddWithValue("@itm5", TxtCPass.Text)

            concmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ADD New ITEM failed" & ex.ToString(), vbInformation, "Information")
            'concmd.Dispose()
            sqlCon.Close()
        Finally
            concmd.Dispose()
            sqlCon.Close()
            ClearTextBox(Me)
            TxtStaffNa.Focus()
            LogIn.Show()
        End Try
    End Sub

End Class