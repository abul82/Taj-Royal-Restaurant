Imports MySql.Data.MySqlClient

Public Class LogIn
    Dim concmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sqlCon As MySql.Data.MySqlClient.MySqlConnection = connectdb()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim sSQL As String = String.Empty
        Try
            'get connection string declared in the Module1.vb and assing it to conn variable
            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If
            Dim concmd As New MySqlCommand
            concmd.Connection = sqlCon
            concmd.CommandType = CommandType.Text
            sSQL = "SELECT s_na fROM user Where us_na ='" & TxtUser.Text & "' and us_pass = '" & TxtPass.Text & "'"
            concmd.CommandText = sSQL
            da.SelectCommand = concmd
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("User Not Found", vbInformation, "Information")
            Else
                Me.Close()
                enabforms()
                MdiTajRoyal.Show()

            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            sqlCon.Close()

        End Try
    End Sub
    Private Sub Btnsignup_Click(sender As Object, e As EventArgs) Handles Btnsignup.Click
        Me.Hide()
        Signup.Show()
    End Sub
    Private Sub enabforms()
        'MdiTajRoyal.MenuStrip.Enabled = True
        MdiTajRoyal.SignupItem.Enabled = True
        MdiTajRoyal.FoodDetailsItem.Enabled = True
        MdiTajRoyal.FoodOrderItem.Enabled = True
        MdiTajRoyal.SalesInvoice.Enabled = True
        MdiTajRoyal.PrintInvoice.Enabled = True
        MdiTajRoyal.TableDetailsItem.Enabled = True
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUser.Focus()
    End Sub
End Class
