Imports MySql.Data.MySqlClient

Public Class FrmFoodDetails
    Dim cmdfood As MySqlCommand
    Dim dafood As MySqlDataAdapter
    Dim dtfood As DataTable
    Dim reader As MySqlDataReader
    Dim rdrfood As MySqlDataReader
    Dim sqlCon As MySql.Data.MySqlClient.MySqlConnection = connectdb()

    Dim intID As Integer = 100000
    Private Sub FrmFoodDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auto()
        TxtFoodID.Enabled = False
        TxtFoodNa.Focus()

    End Sub

    Private Function GenerateID() As String
        Try
            ' Fetch the latest ID from the database
            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If
            Dim dafood As New MySqlDataAdapter("SELECT max(f_id)  FROM fooddetails ", sqlCon)
            Dim dsfood As New DataSet
            dafood.Fill(dsfood)
            'For i As Integer = dsinv.Tables(0).Rows.Count() 

            'While dsinv.Tables(0).Rows.Count <> 0
            If dsfood.Tables(0).Rows.Count <> 0 Then 'This will check whether any records are there or not
                '    intID = "1" ' If records are not there then this id will be returned
                'Else
                intID = dsfood.Tables(0).Rows(0)(0)  'This will store your id in string format
                intID += 1    ' Increment id by 1

            End If
            'End While
            'Next
            If intID <= 9 Then 'Value is between 0 and 10
                intID = "000" & intID
            ElseIf intID <= 99 Then 'Value is between 9 and 100
                intID = "00" & intID
            ElseIf intID <= 999 Then 'Value is between 999 and 1000
                intID = "0" & intID
            ElseIf intID < 9999 Then 'Value is between 999 and 1000
                intID = intID
            End If
            'txtinvno.Text = String.Concat("SI-", intID)

        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            MsgBox(ErrorToString)
            sqlCon.Close()

            intID = "100001"
        End Try
        Return intID
    End Function
    Sub auto()
        Try
            'txtID.Text = GenerateID()
            TxtFoodID.Text = GenerateID()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim cmdfood As New MySqlCommand
        If sqlCon.State = ConnectionState.Closed Then
            sqlCon.Open()
        End If
        Try
            Dim sql As String = String.Format("INSERT INTO fooddetails (f_id,f_na,f_cat,f_pr,f_avail) VALUES " _
                                                 & " (@itm1, @itm2 , @itm3 , @itm4 , @itm5)")

            cmdfood.Connection = sqlCon
            cmdfood.CommandText = sql

            cmdfood.Parameters.Add(New MySqlParameter("@itm2", TxtFoodNa.Text))
            cmdfood.Parameters.AddWithValue("@itm1", SqlDbType.Int).Value = CType(TxtFoodID.Text, Integer)
            cmdfood.Parameters.AddWithValue("@itm3", CboCat.Text)
            cmdfood.Parameters.AddWithValue("@itm4", SqlDbType.Decimal).Value = CType(TxtFoodPr.Text, Double)
            cmdfood.Parameters.AddWithValue("@itm5", SqlDbType.Int).Value = CType(TxtFoodAvail.Text, Integer)

            cmdfood.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ADD New FOOD ITEM failed" & ex.ToString(), vbInformation, "Information")
            'cmdfood.Dispose()
            sqlCon.Close()
        Finally
            cmdfood.Dispose()
            sqlCon.Close()
            ClearTextBox(Me)
            TxtFoodNa.Focus()
            auto()
        End Try
    End Sub
End Class