<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnCatering = New System.Windows.Forms.Button
        Me.btnExpress = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCampus = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cafe Opera:  New Concept in Food"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Where the food sings for itself"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnCatering)
        Me.GroupBox1.Controls.Add(Me.btnExpress)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnCampus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(68, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 311)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select your Opera:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 69)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "In order to better serve our students and faculty we’re now offering Opera cateri" & _
            "ng for student organizations or businesses."
        '
        'btnCatering
        '
        Me.btnCatering.BackColor = System.Drawing.SystemColors.Control
        Me.btnCatering.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatering.Location = New System.Drawing.Point(297, 203)
        Me.btnCatering.Name = "btnCatering"
        Me.btnCatering.Size = New System.Drawing.Size(141, 36)
        Me.btnCatering.TabIndex = 4
        Me.btnCatering.Text = "Op&era Catering"
        Me.ToolTip1.SetToolTip(Me.btnCatering, "Open Opera Catering")
        Me.btnCatering.UseVisualStyleBackColor = False
        '
        'btnExpress
        '
        Me.btnExpress.BackColor = System.Drawing.SystemColors.Control
        Me.btnExpress.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpress.Location = New System.Drawing.Point(297, 132)
        Me.btnExpress.Name = "btnExpress"
        Me.btnExpress.Size = New System.Drawing.Size(141, 36)
        Me.btnExpress.TabIndex = 3
        Me.btnExpress.Text = "O&pera Express"
        Me.ToolTip1.SetToolTip(Me.btnExpress, "Open Opera Express")
        Me.btnExpress.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 69)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Café Opera also caters to students and  faculty who commute daily, known as the O" & _
            "pera Express (Hours 11am-8pm)."
        '
        'btnCampus
        '
        Me.btnCampus.BackColor = System.Drawing.SystemColors.Control
        Me.btnCampus.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCampus.Location = New System.Drawing.Point(297, 57)
        Me.btnCampus.Name = "btnCampus"
        Me.btnCampus.Size = New System.Drawing.Size(141, 36)
        Me.btnCampus.TabIndex = 1
        Me.btnCampus.Text = "&Opera Campus"
        Me.ToolTip1.SetToolTip(Me.btnCampus, "Open Opera Campus")
        Me.btnCampus.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 69)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "The Opera Campus offers student residents delicious food at a reasonable cost, so" & _
            " if you have some time before class stop by to taste how we sing!"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(608, 411)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmMain"
        Me.Text = "Welcome to Cafe Opera!"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCampus As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnExpress As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCatering As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
