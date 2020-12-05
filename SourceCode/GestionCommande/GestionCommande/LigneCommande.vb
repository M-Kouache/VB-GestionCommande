Imports System.Data.SqlClient


Public Class LigneCommande
    Dim mySqlConn As New SqlConnection("Data Source=SQL5063.site4now.net;Initial Catalog=DB_A6BA02_GestionCommande;User Id=DB_A6BA02_GestionCommande_admin;Password=Gcommande123;")
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim CheckExistance As New Boolean


    Public Sub LoadDataLc()

        Dim table As New DataTable
        Try
            Dim myCmdd = New SqlDataAdapter("select * from LigneCommande", mySqlConn)
            mySqlConn.Open()
            myCmdd.Fill(table)
            DataGridViewLC.DataSource = table
            mySqlConn.Close()
        Catch errex As Exception
            MsgBox(errex.Message)
            LoadDataLc()
        End Try

    End Sub

    Public Sub DisplayArticle()

        Dim table As New DataTable
        Try
            Dim myCmdd = New SqlDataAdapter("select NumArt from Article", mySqlConn)
            mySqlConn.Open()
            myCmdd.Fill(table)
            DisplayArt.DataSource = table
            mySqlConn.Close()
        Catch errex As Exception
            MsgBox(errex.Message)
            DisplayArticle()
        End Try

    End Sub

    Public Sub DisplayCommande()

        Dim table As New DataTable
        Try
            Dim myCmdd = New SqlDataAdapter("select NumCom from Commande", mySqlConn)
            mySqlConn.Open()
            myCmdd.Fill(table)
            DisplayCom.DataSource = table
            mySqlConn.Close()
        Catch errex As Exception
            MsgBox(errex.Message)
            DisplayCommande()
        End Try

    End Sub

    Public Sub ClearFields()
        Qtn.Value = DataGridViewLC.RowCount() + 1
        If DisplayArt.RowCount() Or DisplayArt.RowCount() <> 0 Then
            BtnAjoute.Enabled = True
            NumArt.Text = DisplayArt.Rows(0).Cells(0).Value
            NumCom.Text = DisplayArt.Rows(0).Cells(0).Value
        Else
            NumArt.Text = Nothing
            NumCom.Text = Nothing
            BtnAjoute.Enabled = False
        End If

    End Sub


    Private Sub LigneCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataLc()
        DisplayArticle()
        DisplayCommande()
        ClearFields()
    End Sub

    Private Sub DataGridViewLC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLC.CellContentClick



    End Sub

    Private Sub DisplayArt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisplayArt.CellClick
        Dim index = DisplayArt.CurrentCell.RowIndex
        NumArt.Text = DisplayArt.Rows(index).Cells(0).Value.ToString()
    End Sub

    Private Sub DisplayCom_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisplayCom.CellClick
        Dim index = DisplayCom.CurrentCell.RowIndex
        NumCom.Text = DisplayCom.Rows(index).Cells(0).Value.ToString()
    End Sub

    Private Sub BtnAjoute_Click(sender As Object, e As EventArgs) Handles BtnAjoute.Click
        CheckExistance = False

        Dim NumArticle = CInt(NumArt.Text)
        Dim NumCommande = CInt(NumCom.Text)

        For i = 0 To DataGridViewLC.RowCount() - 1
            'Check condition
            If DataGridViewLC.Rows(i).Cells("NumArt").Value = NumArt.Text And DataGridViewLC.Rows(i).Cells("NumCom").Value = NumCom.Text Then
                CheckExistance = True
            End If
        Next

        Try
            If CheckExistance = False Then

                Dim command As New SqlCommand("insert into LigneCommande(QteCommande,NumArt,NumCom) values(@QteCommande,@NumArt,@NumCom)", mySqlConn)

                command.Parameters.Add("@QteCommande", SqlDbType.Int).Value = Qtn.Value
                command.Parameters.Add("@NumArt", SqlDbType.Int).Value = NumArticle
                command.Parameters.Add("@NumCom", SqlDbType.Int).Value = NumCommande


                mySqlConn.Open()
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("LigneCommande ajouté avec succès")

                Else

                    MessageBox.Show("LigneCommande l'article n'a pas été ajouté, Merci d'essayer plus tard.")

                End If
                mySqlConn.Close()
                LoadDataLc()
                ClearFields()
            Else
                MsgBox("existait déjà")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewLC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLC.CellClick
        Dim index = DataGridViewLC.CurrentCell.RowIndex
        Qtn.Text = DataGridViewLC.Rows(index).Cells(0).Value.ToString()
        NumCom.Text = DataGridViewLC.Rows(index).Cells(1).Value.ToString()
        NumArt.Text = DataGridViewLC.Rows(index).Cells(2).Value.ToString()
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        CheckExistance = False

        Dim NumArticle = CInt(NumArt.Text)
        Dim NumCommande = CInt(NumCom.Text)

        For i = 0 To DataGridViewLC.RowCount() - 1
            'Check condition
            If DataGridViewLC.Rows(i).Cells("NumArt").Value = NumArt.Text And DataGridViewLC.Rows(i).Cells("NumCom").Value = NumCom.Text Then
                CheckExistance = True
            End If
        Next

        Try
            If CheckExistance = True Then

                Dim command As New SqlCommand("UPDATE LigneCommande SET QteCommande = @QteCommande WHERE (NumArt = @NumArt and NumCom = @NumCom)", mySqlConn)

                command.Parameters.Add("@QteCommande", SqlDbType.Int).Value = Qtn.Value
                command.Parameters.Add("@NumArt", SqlDbType.Int).Value = NumArticle
                command.Parameters.Add("@NumCom", SqlDbType.Int).Value = NumCommande


                mySqlConn.Open()
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("LigneCommande est mis à jour")

                Else

                    MessageBox.Show("LigneCommande n'est pas à jour, Merci d'essayer plus tard.")

                End If
                mySqlConn.Close()
                LoadDataLc()
                ClearFields()
            Else
                MsgBox("Cet LigneCommande n'existait pas")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnSuppr_Click(sender As Object, e As EventArgs) Handles BtnSuppr.Click
        CheckExistance = False

        Dim NumArticle = CInt(NumArt.Text)
        Dim NumCommande = CInt(NumCom.Text)

        For i = 0 To DataGridViewLC.RowCount() - 1
            'Check condition
            If DataGridViewLC.Rows(i).Cells("NumArt").Value = NumArt.Text And DataGridViewLC.Rows(i).Cells("NumCom").Value = NumCom.Text Then
                CheckExistance = True
            End If
        Next

        If CheckExistance = True Then

            Dim command As New SqlCommand("DELETE FROM  LigneCommande  WHERE (NumArt = @NumArt and NumCom = @NumCom)", mySqlConn)

            command.Parameters.Add("@QteCommande", SqlDbType.Int).Value = Qtn.Value
            command.Parameters.Add("@NumArt", SqlDbType.Int).Value = NumArticle
            command.Parameters.Add("@NumCom", SqlDbType.Int).Value = NumCommande


            mySqlConn.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("LigneCommande a été supprimé avec succès")

            Else

                MessageBox.Show("LigneCommande n'a pas été supprimé, Merci d'essayer plus tard.")

            End If
            mySqlConn.Close()
            LoadDataLc()
            ClearFields()
        Else
            MsgBox("Cet LigneCommande n'existe pas")
        End If
    End Sub
End Class