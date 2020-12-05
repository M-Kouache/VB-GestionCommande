<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Commande
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewCo = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumCom = New System.Windows.Forms.NumericUpDown()
        Me.DateCom = New System.Windows.Forms.DateTimePicker()
        Me.BtnSuppr = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnAjoute = New System.Windows.Forms.Button()
        CType(Me.DataGridViewCo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCo
        '
        Me.DataGridViewCo.AllowUserToAddRows = False
        Me.DataGridViewCo.AllowUserToDeleteRows = False
        Me.DataGridViewCo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridViewCo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCo.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewCo.GridColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridViewCo.Location = New System.Drawing.Point(337, 43)
        Me.DataGridViewCo.Name = "DataGridViewCo"
        Me.DataGridViewCo.ReadOnly = True
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        Me.DataGridViewCo.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewCo.Size = New System.Drawing.Size(451, 445)
        Me.DataGridViewCo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "DateCommande"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "NumCommande"
        '
        'NumCom
        '
        Me.NumCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NumCom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCom.ForeColor = System.Drawing.Color.White
        Me.NumCom.Location = New System.Drawing.Point(173, 117)
        Me.NumCom.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumCom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumCom.Name = "NumCom"
        Me.NumCom.ReadOnly = True
        Me.NumCom.Size = New System.Drawing.Size(152, 25)
        Me.NumCom.TabIndex = 12
        Me.NumCom.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DateCom
        '
        Me.DateCom.Location = New System.Drawing.Point(173, 178)
        Me.DateCom.Name = "DateCom"
        Me.DateCom.Size = New System.Drawing.Size(152, 20)
        Me.DateCom.TabIndex = 15
        Me.DateCom.Value = New Date(2020, 12, 3, 18, 26, 0, 0)
        '
        'BtnSuppr
        '
        Me.BtnSuppr.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSuppr.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSuppr.FlatAppearance.BorderSize = 0
        Me.BtnSuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSuppr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuppr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSuppr.Location = New System.Drawing.Point(225, 274)
        Me.BtnSuppr.Name = "BtnSuppr"
        Me.BtnSuppr.Size = New System.Drawing.Size(100, 50)
        Me.BtnSuppr.TabIndex = 18
        Me.BtnSuppr.Text = "Suppr"
        Me.BtnSuppr.UseVisualStyleBackColor = False
        '
        'BtnModifier
        '
        Me.BtnModifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnModifier.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnModifier.FlatAppearance.BorderSize = 0
        Me.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnModifier.Location = New System.Drawing.Point(117, 274)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(100, 50)
        Me.BtnModifier.TabIndex = 17
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = False
        '
        'BtnAjoute
        '
        Me.BtnAjoute.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAjoute.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAjoute.FlatAppearance.BorderSize = 0
        Me.BtnAjoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAjoute.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAjoute.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnAjoute.Location = New System.Drawing.Point(11, 274)
        Me.BtnAjoute.Name = "BtnAjoute"
        Me.BtnAjoute.Size = New System.Drawing.Size(100, 50)
        Me.BtnAjoute.TabIndex = 16
        Me.BtnAjoute.Text = "Ajouter"
        Me.BtnAjoute.UseVisualStyleBackColor = False
        '
        'Commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.BtnSuppr)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnAjoute)
        Me.Controls.Add(Me.DateCom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumCom)
        Me.Controls.Add(Me.DataGridViewCo)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Commande"
        Me.Text = "Commande"
        CType(Me.DataGridViewCo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewCo As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumCom As NumericUpDown
    Friend WithEvents DateCom As DateTimePicker
    Friend WithEvents BtnSuppr As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnAjoute As Button
End Class
