<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Article
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridViewAr = New System.Windows.Forms.DataGridView()
        Me.DesArt = New System.Windows.Forms.TextBox()
        Me.NumArt = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnAjout = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnSuppr = New System.Windows.Forms.Button()
        Me.QtnSArt = New System.Windows.Forms.NumericUpDown()
        Me.SminArt = New System.Windows.Forms.NumericUpDown()
        Me.SmaxArt = New System.Windows.Forms.NumericUpDown()
        Me.PuArt = New System.Windows.Forms.NumericUpDown()
        Me.PuArtRest = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewAr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtnSArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SminArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmaxArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuArtRest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewAr
        '
        Me.DataGridViewAr.AllowUserToAddRows = False
        Me.DataGridViewAr.AllowUserToDeleteRows = False
        Me.DataGridViewAr.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridViewAr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewAr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAr.GridColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridViewAr.Location = New System.Drawing.Point(342, 37)
        Me.DataGridViewAr.Name = "DataGridViewAr"
        Me.DataGridViewAr.ReadOnly = True
        Me.DataGridViewAr.Size = New System.Drawing.Size(446, 451)
        Me.DataGridViewAr.TabIndex = 0
        '
        'DesArt
        '
        Me.DesArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DesArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DesArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesArt.ForeColor = System.Drawing.SystemColors.Window
        Me.DesArt.Location = New System.Drawing.Point(173, 104)
        Me.DesArt.Multiline = True
        Me.DesArt.Name = "DesArt"
        Me.DesArt.Size = New System.Drawing.Size(152, 39)
        Me.DesArt.TabIndex = 1
        Me.DesArt.Text = "No Description"
        '
        'NumArt
        '
        Me.NumArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NumArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumArt.ForeColor = System.Drawing.Color.White
        Me.NumArt.Location = New System.Drawing.Point(173, 57)
        Me.NumArt.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumArt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumArt.Name = "NumArt"
        Me.NumArt.ReadOnly = True
        Me.NumArt.Size = New System.Drawing.Size(152, 25)
        Me.NumArt.TabIndex = 6
        Me.NumArt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NumArticle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "DesArticle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "PUArticle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "QteEnStock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "SeuilMin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "SeuilMax"
        '
        'BtnAjout
        '
        Me.BtnAjout.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAjout.FlatAppearance.BorderSize = 0
        Me.BtnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAjout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAjout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnAjout.Location = New System.Drawing.Point(12, 411)
        Me.BtnAjout.Name = "BtnAjout"
        Me.BtnAjout.Size = New System.Drawing.Size(100, 50)
        Me.BtnAjout.TabIndex = 13
        Me.BtnAjout.Text = "Ajouter"
        Me.BtnAjout.UseVisualStyleBackColor = False
        '
        'BtnModifier
        '
        Me.BtnModifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnModifier.FlatAppearance.BorderSize = 0
        Me.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnModifier.Location = New System.Drawing.Point(118, 411)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(100, 50)
        Me.BtnModifier.TabIndex = 14
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = False
        '
        'BtnSuppr
        '
        Me.BtnSuppr.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSuppr.FlatAppearance.BorderSize = 0
        Me.BtnSuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSuppr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuppr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSuppr.Location = New System.Drawing.Point(226, 411)
        Me.BtnSuppr.Name = "BtnSuppr"
        Me.BtnSuppr.Size = New System.Drawing.Size(100, 50)
        Me.BtnSuppr.TabIndex = 15
        Me.BtnSuppr.Text = "Suppr"
        Me.BtnSuppr.UseVisualStyleBackColor = False
        '
        'QtnSArt
        '
        Me.QtnSArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.QtnSArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QtnSArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtnSArt.ForeColor = System.Drawing.Color.White
        Me.QtnSArt.Location = New System.Drawing.Point(173, 222)
        Me.QtnSArt.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.QtnSArt.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.QtnSArt.Name = "QtnSArt"
        Me.QtnSArt.ReadOnly = True
        Me.QtnSArt.Size = New System.Drawing.Size(152, 25)
        Me.QtnSArt.TabIndex = 17
        Me.QtnSArt.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'SminArt
        '
        Me.SminArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SminArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SminArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SminArt.ForeColor = System.Drawing.Color.White
        Me.SminArt.Location = New System.Drawing.Point(173, 287)
        Me.SminArt.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.SminArt.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SminArt.Name = "SminArt"
        Me.SminArt.ReadOnly = True
        Me.SminArt.Size = New System.Drawing.Size(152, 25)
        Me.SminArt.TabIndex = 18
        Me.SminArt.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'SmaxArt
        '
        Me.SmaxArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SmaxArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SmaxArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmaxArt.ForeColor = System.Drawing.Color.White
        Me.SmaxArt.Location = New System.Drawing.Point(173, 345)
        Me.SmaxArt.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.SmaxArt.Minimum = New Decimal(New Integer() {11, 0, 0, 0})
        Me.SmaxArt.Name = "SmaxArt"
        Me.SmaxArt.ReadOnly = True
        Me.SmaxArt.Size = New System.Drawing.Size(152, 25)
        Me.SmaxArt.TabIndex = 19
        Me.SmaxArt.Value = New Decimal(New Integer() {11, 0, 0, 0})
        '
        'PuArt
        '
        Me.PuArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PuArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PuArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PuArt.ForeColor = System.Drawing.Color.White
        Me.PuArt.Location = New System.Drawing.Point(173, 159)
        Me.PuArt.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.PuArt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PuArt.Name = "PuArt"
        Me.PuArt.ReadOnly = True
        Me.PuArt.Size = New System.Drawing.Size(62, 25)
        Me.PuArt.TabIndex = 20
        Me.PuArt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PuArtRest
        '
        Me.PuArtRest.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PuArtRest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PuArtRest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PuArtRest.ForeColor = System.Drawing.Color.White
        Me.PuArtRest.Location = New System.Drawing.Point(262, 159)
        Me.PuArtRest.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.PuArtRest.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PuArtRest.Name = "PuArtRest"
        Me.PuArtRest.ReadOnly = True
        Me.PuArtRest.Size = New System.Drawing.Size(63, 25)
        Me.PuArtRest.TabIndex = 21
        Me.PuArtRest.Value = New Decimal(New Integer() {99, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(241, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 31)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = ":"
        '
        'Article
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PuArtRest)
        Me.Controls.Add(Me.PuArt)
        Me.Controls.Add(Me.SmaxArt)
        Me.Controls.Add(Me.SminArt)
        Me.Controls.Add(Me.QtnSArt)
        Me.Controls.Add(Me.BtnSuppr)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnAjout)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumArt)
        Me.Controls.Add(Me.DesArt)
        Me.Controls.Add(Me.DataGridViewAr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Article"
        Me.Text = "Article"
        CType(Me.DataGridViewAr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtnSArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SminArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmaxArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuArtRest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewAr As DataGridView
    Friend WithEvents DesArt As TextBox
    Friend WithEvents NumArt As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnAjout As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnSuppr As Button
    Friend WithEvents QtnSArt As NumericUpDown
    Friend WithEvents SminArt As NumericUpDown
    Friend WithEvents SmaxArt As NumericUpDown
    Friend WithEvents PuArt As NumericUpDown
    Friend WithEvents PuArtRest As NumericUpDown
    Friend WithEvents Label7 As Label
End Class
