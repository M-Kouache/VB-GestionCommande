Imports System.Data.SqlClient

Public Class Commande

    Dim mySqlConn As New SqlConnection("Data Source=SQL5063.site4now.net;Initial Catalog=DB_A6BA02_GestionCommande;User Id=DB_A6BA02_GestionCommande_admin;Password=Gcommande123;")
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim CheckExistance As Boolean
    Dim LCommande As New LigneCommande

    Public Sub LoadDataCom()

        Dim table As New DataTable
        Try
            Dim myCmdd = New SqlDataAdapter("select * from Commande", mySqlConn)
            mySqlConn.Open()
            myCmdd.Fill(table)
            DataGridViewCo.DataSource = table
            mySqlConn.Close()
        Catch errex As Exception
            MsgBox(errex.Message)
            LoadDataCom()
        End Try

    End Sub
    Public Sub ClearFields()
        NumCom.Value = DataGridViewCo.RowCount() + 1
        DateCom.Value = DateCom.MaxDate
    End Sub

    Private Sub Commande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataCom()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateCom.ValueChanged

        DateCom.MaxDate = Date.Today
        DateCom.MinDate = "1/1/1753"

    End Sub

    Private Sub BtnAjoute_Click(sender As Object, e As EventArgs) Handles BtnAjoute.Click
        CheckExistance = False

        For i = 0 To DataGridViewCo.RowCount() - 1
            'Check condition
            If DataGridViewCo.Rows(i).Cells("NumCom").Value = NumCom.Value Then
                CheckExistance = True
            End If
        Next

        Try
            If CheckExistance = False Then

                Dim command As New SqlCommand("insert into Commande(NumCom,DatCom) values(@NumCom,@DatCom)", mySqlConn)

                command.Parameters.Add("@NumCom", SqlDbType.Int).Value = NumCom.Value
                command.Parameters.Add("@DatCom", SqlDbType.VarChar).Value = DateCom.Value


                mySqlConn.Open()
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Commande ajouté avec succès")

                Else

                    MessageBox.Show("Commade n'a pas été ajouté, Merci d'essayer plus tard.")

                End If
                mySqlConn.Close()
                LoadDataCom()
                ClearFields()
            Else
                MsgBox("existait déjà")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        CheckExistance = False

        For i = 0 To DataGridViewCo.RowCount() - 1
            'Check condition
            If DataGridViewCo.Rows(i).Cells("NumCom").Value = NumCom.Value Then
                CheckExistance = True
            End If
        Next

        Try

            If CheckExistance = True Then

                Dim command As New SqlCommand("UPDATE Commande SET DatCom = @DatCom  WHERE NumCom = @NumCom", mySqlConn)

                command.Parameters.Add("@NumCom", SqlDbType.Int).Value = NumCom.Value
                command.Parameters.Add("@DatCom", SqlDbType.VarChar).Value = DateCom.Value


                mySqlConn.Open()
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Commande est mis à jour")

                Else

                    MessageBox.Show("Commade n'est pas à jour, Merci d'essayer plus tard.")

                End If
                mySqlConn.Close()
                LoadDataCom()
                ClearFields()
            Else
                MsgBox("Cet Commande n'existait pas")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewCo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCo.CellClick
        Dim index = DataGridViewCo.CurrentCell.RowIndex

        NumCom.Value = DataGridViewCo.Rows(index).Cells(0).Value.ToString()
        DateCom.Value = DataGridViewCo.Rows(index).Cells(1).Value.ToString()
    End Sub

    Private Sub BtnSuppr_Click(sender As Object, e As EventArgs) Handles BtnSuppr.Click
        CheckExistance = False
        LCommande.LoadDataLc()
        Dim index = DataGridViewCo.CurrentCell.RowIndex
        Dim CheckRow = False

        For i = 0 To DataGridViewCo.RowCount() - 1
            'Check condition
            If DataGridViewCo.Rows(i).Cells("NumCom").Value = NumCom.Value Then
                CheckRow = True
            End If
        Next


        For i = 0 To LCommande.DataGridViewLC.RowCount() - 1
            'Check condition
            If LCommande.DataGridViewLC.Rows(i).Cells("NumCom").Value = DataGridViewCo.Rows(index).Cells("NumCom").Value Then
                CheckExistance = True
            End If
        Next

        Try
            If CheckRow = True Then
                If CheckExistance = False Then
                    Dim command As New SqlCommand("DELETE FROM Commande WHERE NumCom = @NumCom", mySqlConn)

                    command.Parameters.Add("@NumCom", SqlDbType.Int).Value = DataGridViewCo.Rows(index).Cells("NumCom").Value
                    mySqlConn.Open()
                    If command.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Commande a été supprimé avec succès")

                    Else

                        MessageBox.Show("Commande n'a pas été supprimé, Merci d'essayer plus tard.")

                    End If
                    mySqlConn.Close()
                Else
                    If MsgBox("Cet Commande est associé à commande dans la table LigneCommande ! Cliquez sur Yes pour supprimer cette commande sur les deux tables ", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then

                        Dim commandCom As New SqlCommand("DELETE FROM Commande WHERE NumCom = @NumCom", mySqlConn)
                        Dim commandLc As New SqlCommand("DELETE FROM LigneCommande WHERE NumCom = @NumCom", mySqlConn)

                        commandCom.Parameters.Add("@NumCom", SqlDbType.Int).Value = DataGridViewCo.Rows(index).Cells("NumCom").Value
                        commandLc.Parameters.Add("@NumCom", SqlDbType.Int).Value = DataGridViewCo.Rows(index).Cells("NumCom").Value

                        mySqlConn.Open()
                        commandLc.ExecuteNonQuery()
                        commandCom.ExecuteNonQuery()
                        mySqlConn.Close()

                    End If

                End If
            Else
                MsgBox("Cet Commande n'existe pas")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        LoadDataCom()

    End Sub
End Class