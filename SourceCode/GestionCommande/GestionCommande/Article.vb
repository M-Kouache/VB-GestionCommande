Imports System.Data.SqlClient

Public Class Article

    Dim mySqlConn As New SqlConnection("Data Source=SQL5063.site4now.net;Initial Catalog=DB_A6BA02_GestionCommande;User Id=DB_A6BA02_GestionCommande_admin;Password=Gcommande123;")
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim CheckExistance As Boolean
    Dim LCommande As New LigneCommande



    Public Sub LoadDataArt()

        Dim table As New DataTable
        Try
            Dim myCmdd = New SqlDataAdapter("select * from Article", mySqlConn)
            mySqlConn.Open()
            myCmdd.Fill(table)
            DataGridViewAr.DataSource = table
            mySqlConn.Close()
        Catch errex As Exception
            MsgBox(errex.Message)
            LoadDataArt()
        End Try

    End Sub

    Public Sub ClearFields()
        NumArt.Value = DataGridViewAr.RowCount() + 1
        DesArt.Text = "No Description"
        PuArt.Text = 100
        PuArtRest.Text = 99
        QtnSArt.Text = 10
        SminArt.Text = 10
        SmaxArt.Text = 10
    End Sub



    Private Sub Article_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataArt()
        ClearFields()

    End Sub

    Private Sub BtnAjout_Click(sender As Object, e As EventArgs) Handles BtnAjout.Click

        CheckExistance = False

        Try

            For i = 0 To DataGridViewAr.RowCount() - 1
                'Check condition
                If DataGridViewAr.Rows(i).Cells("NumArt").Value = NumArt.Value Then
                    CheckExistance = True
                End If
            Next

            If CheckExistance = False Then

                Dim command As New SqlCommand("insert into Article(NumArt,DesArt,PUArt,QteEnStock,SeuilMin,SeuilMax) values(@NumArt,@DesArt,@PUArt,@QteEnStock,@SeuilMin,@SeuilMax)", mySqlConn)

                command.Parameters.Add("@NumArt", SqlDbType.Int).Value = NumArt.Value
                command.Parameters.Add("@DesArt", SqlDbType.VarChar).Value = DesArt.Text
                command.Parameters.Add("@PUArt", SqlDbType.VarChar).Value = PuArt.Text + " : " + PuArtRest.Text
                command.Parameters.Add("@QteEnStock", SqlDbType.Int).Value = QtnSArt.Value
                command.Parameters.Add("@SeuilMin", SqlDbType.Int).Value = SminArt.Value
                command.Parameters.Add("@SeuilMax", SqlDbType.Int).Value = SmaxArt.Value

                mySqlConn.Open()
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("article ajouté avec succès")

                Else

                    MessageBox.Show("l'article n'a pas été ajouté, Merci d'essayer plus tard.")

                End If
                mySqlConn.Close()
                LoadDataArt()
                ClearFields()
            Else
                MsgBox("existait déjà")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub DataGridViewAr_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAr.CellClick



        Dim index = DataGridViewAr.CurrentCell.RowIndex

        NumArt.Value = DataGridViewAr.Rows(index).Cells(0).Value.ToString()
        DesArt.Text = DataGridViewAr.Rows(index).Cells(1).Value.ToString()
        PuArt.Text = DataGridViewAr.Rows(index).Cells(2).Value.ToString()
        QtnSArt.Value = DataGridViewAr.Rows(index).Cells(3).Value.ToString()
        SminArt.Value = DataGridViewAr.Rows(index).Cells(4).Value.ToString()
        SmaxArt.Value = DataGridViewAr.Rows(index).Cells(5).Value.ToString()


        'Dim i = 0

        'While True

        'MsgBox(LCommande.DataGridViewLC.Rows(0).Cells("NumArt").Value)



        'Check condition
        'If LCommande.DataGridViewLC.Rows(i).Cells("NumArt").Value = DataGridViewAr.Rows(index).Cells("NumArt").Value Then
        'CheckExistance = True
        'MsgBox("hi there im here")
        'End If
        '
        'If i = LCommande.DataGridViewLC.RowCount() Then
        'Exit While
        'End If

        'i += i
        'End While


    End Sub

    Private Sub BtnSuppr_Click(sender As Object, e As EventArgs) Handles BtnSuppr.Click
        CheckExistance = False
        LCommande.LoadDataLc()
        Dim index = DataGridViewAr.CurrentCell.RowIndex

        Dim CheckRow = False

        For i = 0 To DataGridViewAr.RowCount() - 1
            'Check condition
            If DataGridViewAr.Rows(i).Cells("NumArt").Value = NumArt.Value Then
                CheckRow = True
            End If
        Next

        For i = 0 To LCommande.DataGridViewLC.RowCount() - 1
            'Check condition
            If LCommande.DataGridViewLC.Rows(i).Cells("NumArt").Value = DataGridViewAr.Rows(index).Cells("NumArt").Value Then
                CheckExistance = True
            End If
        Next

        Try



            If CheckRow = True Then
                If CheckExistance = False Then
                    Dim command As New SqlCommand("DELETE FROM Article WHERE NumArt = @NumArt", mySqlConn)

                    command.Parameters.Add("@NumArt", SqlDbType.Int).Value = DataGridViewAr.Rows(index).Cells("NumArt").Value
                    mySqlConn.Open()
                    If command.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("l'article a été supprimé avec succès")

                    Else

                        MessageBox.Show("l'article n'a pas été supprimé, Merci d'essayer plus tard.")

                    End If
                    mySqlConn.Close()
                Else
                    If MsgBox("Cet article est associé à article dans la table LigneCommande ! Cliquez sur Yes pour supprimer cette article sur les deux tables ", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then

                        Dim commandArt As New SqlCommand("DELETE FROM Article WHERE NumArt = @NumArt", mySqlConn)
                        Dim commandLc As New SqlCommand("DELETE FROM LigneCommande WHERE NumArt = @NumArt", mySqlConn)

                        commandArt.Parameters.Add("@NumArt", SqlDbType.Int).Value = DataGridViewAr.Rows(index).Cells("NumArt").Value
                        commandLc.Parameters.Add("@NumArt", SqlDbType.Int).Value = DataGridViewAr.Rows(index).Cells("NumArt").Value
                        mySqlConn.Open()
                        commandLc.ExecuteNonQuery()
                        commandArt.ExecuteNonQuery()
                        mySqlConn.Close()
                    End If
                End If
            Else
                MsgBox("Cet article n'existe pas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        LoadDataArt()

    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click

        CheckExistance = False

        Try

            For i = 0 To DataGridViewAr.RowCount() - 1
                'Check condition
                If DataGridViewAr.Rows(i).Cells("NumArt").Value = NumArt.Value Then
                    CheckExistance = True
                End If
            Next

            If CheckExistance = True Then
                Dim command As New SqlCommand("UPDATE Article SET DesArt = @DesArt,PUArt = @PUArt,QteEnStock = @QteEnStock,SeuilMin = @SeuilMin,SeuilMax = @SeuilMax WHERE NumArt = @NumArt", mySqlConn)
                command.Parameters.Add("@NumArt", SqlDbType.Int).Value = NumArt.Value
                command.Parameters.Add("@DesArt", SqlDbType.VarChar).Value = DesArt.Text
                command.Parameters.Add("@PUArt", SqlDbType.VarChar).Value = PuArt.Text + " : " + PuArtRest.Text
                command.Parameters.Add("@QteEnStock", SqlDbType.Int).Value = QtnSArt.Value
                command.Parameters.Add("@SeuilMin", SqlDbType.Int).Value = SminArt.Value
                command.Parameters.Add("@SeuilMax", SqlDbType.Int).Value = SmaxArt.Value

                mySqlConn.Open()
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("L'article est mis à jour")

                Else

                    MessageBox.Show("L'article n'est pas à jour, Merci d'essayer plus tard.")

                End If
                mySqlConn.Close()
                LoadDataArt()
                ClearFields()
            Else
                MessageBox.Show("Cet Article n'existait pas")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class