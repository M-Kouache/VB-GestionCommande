Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    Dim mySqlConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Public Sub LoadForm()
        mySqlConn = New SqlConnection("Data Source=SQL5063.site4now.net;Initial Catalog=DB_A6BA02_GestionCommande;User Id=DB_A6BA02_GestionCommande_admin;Password=Gcommande123;")

        Try
            mySqlConn.Open()
            mySqlConn.Close()
        Catch ex As Exception
            If MsgBox("La connexion au serveur a échoué, veuillez vérifier votre connexion et cliquez sur 'Retry'.", MsgBoxStyle.RetryCancel) = MsgBoxResult.Retry Then
                LoadForm()
            Else
                Me.Close()
            End If
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Home
            .TopLevel = False
            Panel3.Controls.Add(Home)
            .BringToFront()
            .Show()
        End With
        LoadForm()
        Button1.BackColor = Nothing
        Button2.BackColor = Nothing
        Button3.BackColor = Nothing
        Button4.BackColor = ColorTranslator.FromHtml("20, 25, 50")
    End Sub


    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Size() = New Size(35, 35)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size() = New Size(32, 32)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Size() = New Size(35, 35)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Size() = New Size(32, 32)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Article
            .LoadDataArt()
            .TopLevel = False
            Panel3.Controls.Add(Article)
            .BringToFront()
            .Show()
        End With
        Button1.BackColor = ColorTranslator.FromHtml("20, 25, 50")
        Button2.BackColor = Nothing
        Button3.BackColor = Nothing
        Button4.BackColor = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Commande
            .LoadDataCom()
            .TopLevel = False
            Panel3.Controls.Add(Commande)
            .BringToFront()
            .Show()
        End With
        Button1.BackColor = Nothing
        Button2.BackColor = ColorTranslator.FromHtml("20, 25, 50")
        Button3.BackColor = Nothing
        Button4.BackColor = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With LigneCommande
            .LoadDataLc()
            .DisplayArticle()
            .DisplayCommande()
            .ClearFields()
            .TopLevel = False
            Panel3.Controls.Add(LigneCommande)
            .BringToFront()
            .Show()
        End With
        Button1.BackColor = Nothing
        Button2.BackColor = Nothing
        Button3.BackColor = ColorTranslator.FromHtml("20, 25, 50")
        Button4.BackColor = Nothing
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With Home
            .TopLevel = False
            Panel3.Controls.Add(Home)
            .BringToFront()
            .Show()
        End With
        Button1.BackColor = Nothing
        Button2.BackColor = Nothing
        Button3.BackColor = Nothing
        Button4.BackColor = ColorTranslator.FromHtml("20, 25, 50")
    End Sub
End Class
