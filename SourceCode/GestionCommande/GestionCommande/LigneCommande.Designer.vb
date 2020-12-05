<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LigneCommande
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Qtn = New System.Windows.Forms.NumericUpDown()
        Me.DataGridViewLC = New System.Windows.Forms.DataGridView()
        Me.BtnSuppr = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnAjoute = New System.Windows.Forms.Button()
        Me.DisplayArt = New System.Windows.Forms.DataGridView()
        Me.DisplayCom = New System.Windows.Forms.DataGridView()
        Me.NumArt = New System.Windows.Forms.TextBox()
        Me.NumCom = New System.Windows.Forms.TextBox()
        CType(Me.Qtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewLC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 24)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "NumCommande"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "NumArticle"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Qtn"
        '
        'Qtn
        '
        Me.Qtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Qtn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Qtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qtn.ForeColor = System.Drawing.Color.White
        Me.Qtn.Location = New System.Drawing.Point(176, 53)
        Me.Qtn.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Qtn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Qtn.Name = "Qtn"
        Me.Qtn.ReadOnly = True
        Me.Qtn.Size = New System.Drawing.Size(152, 25)
        Me.Qtn.TabIndex = 19
        Me.Qtn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DataGridViewLC
        '
        Me.DataGridViewLC.AllowUserToAddRows = False
        Me.DataGridViewLC.AllowUserToDeleteRows = False
        Me.DataGridViewLC.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridViewLC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewLC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLC.GridColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridViewLC.Location = New System.Drawing.Point(363, 43)
        Me.DataGridViewLC.Name = "DataGridViewLC"
        Me.DataGridViewLC.ReadOnly = True
        Me.DataGridViewLC.Size = New System.Drawing.Size(425, 445)
        Me.DataGridViewLC.TabIndex = 17
        '
        'BtnSuppr
        '
        Me.BtnSuppr.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSuppr.FlatAppearance.BorderSize = 0
        Me.BtnSuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSuppr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuppr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSuppr.Location = New System.Drawing.Point(228, 438)
        Me.BtnSuppr.Name = "BtnSuppr"
        Me.BtnSuppr.Size = New System.Drawing.Size(100, 50)
        Me.BtnSuppr.TabIndex = 27
        Me.BtnSuppr.Text = "Suppr"
        Me.BtnSuppr.UseVisualStyleBackColor = False
        '
        'BtnModifier
        '
        Me.BtnModifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnModifier.FlatAppearance.BorderSize = 0
        Me.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnModifier.Location = New System.Drawing.Point(122, 438)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(100, 50)
        Me.BtnModifier.TabIndex = 26
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = False
        '
        'BtnAjoute
        '
        Me.BtnAjoute.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAjoute.FlatAppearance.BorderSize = 0
        Me.BtnAjoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAjoute.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAjoute.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnAjoute.Location = New System.Drawing.Point(16, 438)
        Me.BtnAjoute.Name = "BtnAjoute"
        Me.BtnAjoute.Size = New System.Drawing.Size(100, 50)
        Me.BtnAjoute.TabIndex = 25
        Me.BtnAjoute.Text = "Ajouter"
        Me.BtnAjoute.UseVisualStyleBackColor = False
        '
        'DisplayArt
        '
        Me.DisplayArt.AllowUserToAddRows = False
        Me.DisplayArt.AllowUserToDeleteRows = False
        Me.DisplayArt.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DisplayArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DisplayArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DisplayArt.GridColor = System.Drawing.SystemColors.HighlightText
        Me.DisplayArt.Location = New System.Drawing.Point(176, 144)
        Me.DisplayArt.Name = "DisplayArt"
        Me.DisplayArt.ReadOnly = True
        Me.DisplayArt.Size = New System.Drawing.Size(152, 107)
        Me.DisplayArt.TabIndex = 30
        '
        'DisplayCom
        '
        Me.DisplayCom.AllowUserToAddRows = False
        Me.DisplayCom.AllowUserToDeleteRows = False
        Me.DisplayCom.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DisplayCom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DisplayCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DisplayCom.GridColor = System.Drawing.SystemColors.HighlightText
        Me.DisplayCom.Location = New System.Drawing.Point(176, 307)
        Me.DisplayCom.Name = "DisplayCom"
        Me.DisplayCom.ReadOnly = True
        Me.DisplayCom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DisplayCom.Size = New System.Drawing.Size(152, 107)
        Me.DisplayCom.TabIndex = 31
        '
        'NumArt
        '
        Me.NumArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NumArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumArt.ForeColor = System.Drawing.SystemColors.Window
        Me.NumArt.Location = New System.Drawing.Point(176, 107)
        Me.NumArt.Name = "NumArt"
        Me.NumArt.ReadOnly = True
        Me.NumArt.Size = New System.Drawing.Size(152, 29)
        Me.NumArt.TabIndex = 32
        '
        'NumCom
        '
        Me.NumCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NumCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCom.ForeColor = System.Drawing.SystemColors.Window
        Me.NumCom.Location = New System.Drawing.Point(176, 270)
        Me.NumCom.Name = "NumCom"
        Me.NumCom.ReadOnly = True
        Me.NumCom.Size = New System.Drawing.Size(152, 29)
        Me.NumCom.TabIndex = 34
        '
        'LigneCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.NumCom)
        Me.Controls.Add(Me.NumArt)
        Me.Controls.Add(Me.DisplayCom)
        Me.Controls.Add(Me.DisplayArt)
        Me.Controls.Add(Me.BtnSuppr)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnAjoute)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Qtn)
        Me.Controls.Add(Me.DataGridViewLC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LigneCommande"
        Me.Text = "LigneCommande"
        CType(Me.Qtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewLC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Qtn As NumericUpDown
    Friend WithEvents DataGridViewLC As DataGridView
    Friend WithEvents BtnSuppr As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnAjoute As Button
    Friend WithEvents DisplayArt As DataGridView
    Friend WithEvents DisplayCom As DataGridView
    Friend WithEvents NumArt As TextBox
    Friend WithEvents NumCom As TextBox
End Class
