<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampus
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
        Me.mnuOpera = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileReset = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOperasCampus = New System.Windows.Forms.ToolStripMenuItem
        Me.CampusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOperasExpress = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOperasCatering = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lstDorm = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboGrade = New System.Windows.Forms.ComboBox
        Me.txtGPA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.datetimeDelivery = New System.Windows.Forms.DateTimePicker
        Me.radNo = New System.Windows.Forms.RadioButton
        Me.radYes = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblSubtotal = New System.Windows.Forms.Label
        Me.lblService = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblTaxRate = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblDiscounts = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.chkHamburger = New System.Windows.Forms.CheckBox
        Me.chkCheeseburger = New System.Windows.Forms.CheckBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.chkCrispyChix = New System.Windows.Forms.CheckBox
        Me.chkGrilledChix = New System.Windows.Forms.CheckBox
        Me.chkSpicyChix = New System.Windows.Forms.CheckBox
        Me.chkFingers = New System.Windows.Forms.CheckBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.chkFries = New System.Windows.Forms.CheckBox
        Me.chkOnionRings = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.chkHoneyMustard = New System.Windows.Forms.CheckBox
        Me.chkRanch = New System.Windows.Forms.CheckBox
        Me.chkKetchup = New System.Windows.Forms.CheckBox
        Me.chkMustard = New System.Windows.Forms.CheckBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.chkSwissCheese = New System.Windows.Forms.CheckBox
        Me.chkCheese = New System.Windows.Forms.CheckBox
        Me.chkLettuce = New System.Windows.Forms.CheckBox
        Me.chkTomatoes = New System.Windows.Forms.CheckBox
        Me.chkBacon = New System.Windows.Forms.CheckBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.chkOnions = New System.Windows.Forms.CheckBox
        Me.chkSeasonedFries = New System.Windows.Forms.CheckBox
        Me.chkCheeseFries = New System.Windows.Forms.CheckBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lstFresh = New System.Windows.Forms.ListBox
        Me.lstDrinks = New System.Windows.Forms.ListBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblDelivery = New System.Windows.Forms.Label
        Me.mnuOpera.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuOpera
        '
        Me.mnuOpera.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuOpera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mnuOperasCampus, Me.AboutToolStripMenuItem})
        Me.mnuOpera.Location = New System.Drawing.Point(0, 0)
        Me.mnuOpera.Name = "mnuOpera"
        Me.mnuOpera.Size = New System.Drawing.Size(968, 26)
        Me.mnuOpera.TabIndex = 0
        Me.mnuOpera.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileReset, Me.mnuFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuFileReset
        '
        Me.mnuFileReset.Name = "mnuFileReset"
        Me.mnuFileReset.Size = New System.Drawing.Size(107, 22)
        Me.mnuFileReset.Text = "&Reset"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(107, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuOperasCampus
        '
        Me.mnuOperasCampus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CampusToolStripMenuItem, Me.mnuOperasExpress, Me.mnuOperasCatering})
        Me.mnuOperasCampus.Name = "mnuOperasCampus"
        Me.mnuOperasCampus.Size = New System.Drawing.Size(59, 22)
        Me.mnuOperasCampus.Text = "&Operas"
        '
        'CampusToolStripMenuItem
        '
        Me.CampusToolStripMenuItem.Name = "CampusToolStripMenuItem"
        Me.CampusToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CampusToolStripMenuItem.Text = "Campus"
        '
        'mnuOperasExpress
        '
        Me.mnuOperasExpress.Name = "mnuOperasExpress"
        Me.mnuOperasExpress.Size = New System.Drawing.Size(122, 22)
        Me.mnuOperasExpress.Text = "Express"
        '
        'mnuOperasCatering
        '
        Me.mnuOperasCatering.Name = "mnuOperasCatering"
        Me.mnuOperasCatering.Size = New System.Drawing.Size(122, 22)
        Me.mnuOperasCatering.Text = "Catering"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(53, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'lstDorm
        '
        Me.lstDorm.FormattingEnabled = True
        Me.lstDorm.ItemHeight = 16
        Me.lstDorm.Items.AddRange(New Object() {"Marcy Hall", "Gables Hall", "Post Woods Villiage", "Shawn Carter Hall"})
        Me.lstDorm.Location = New System.Drawing.Point(81, 157)
        Me.lstDorm.Name = "lstDorm"
        Me.lstDorm.Size = New System.Drawing.Size(133, 36)
        Me.lstDorm.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(81, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(127, 20)
        Me.txtName.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lstDorm)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboGrade)
        Me.GroupBox2.Controls.Add(Me.txtGPA)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 238)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Select Dorm"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Grade Year"
        '
        'cboGrade
        '
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.Items.AddRange(New Object() {"Freshman", "Sophmore", "Junior", "Senior"})
        Me.cboGrade.Location = New System.Drawing.Point(81, 61)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(127, 24)
        Me.cboGrade.TabIndex = 9
        '
        'txtGPA
        '
        Me.txtGPA.Location = New System.Drawing.Point(81, 102)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(58, 20)
        Me.txtGPA.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "GPA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Select Delivery Date"
        '
        'datetimeDelivery
        '
        Me.datetimeDelivery.Location = New System.Drawing.Point(23, 83)
        Me.datetimeDelivery.Name = "datetimeDelivery"
        Me.datetimeDelivery.Size = New System.Drawing.Size(206, 20)
        Me.datetimeDelivery.TabIndex = 10
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Location = New System.Drawing.Point(130, 32)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(39, 20)
        Me.radNo.TabIndex = 9
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(81, 32)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(44, 20)
        Me.radYes.TabIndex = 8
        Me.radYes.TabStop = True
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Delivery:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblDelivery)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.lblSubtotal)
        Me.GroupBox4.Controls.Add(Me.lblService)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.lblTaxRate)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.lblDiscounts)
        Me.GroupBox4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(677, 224)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(245, 198)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totals"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(85, 173)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(127, 171)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(99, 21)
        Me.lblTotal.TabIndex = 16
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(126, 28)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(101, 20)
        Me.lblSubtotal.TabIndex = 9
        '
        'lblService
        '
        Me.lblService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblService.Location = New System.Drawing.Point(127, 58)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(99, 20)
        Me.lblService.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(85, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Tax"
        '
        'lblTaxRate
        '
        Me.lblTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxRate.Location = New System.Drawing.Point(127, 139)
        Me.lblTaxRate.Name = "lblTaxRate"
        Me.lblTaxRate.Size = New System.Drawing.Size(99, 21)
        Me.lblTaxRate.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(63, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Discounts"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Service Charges"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Subtotal"
        '
        'lblDiscounts
        '
        Me.lblDiscounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscounts.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscounts.ForeColor = System.Drawing.Color.Red
        Me.lblDiscounts.Location = New System.Drawing.Point(127, 111)
        Me.lblDiscounts.Name = "lblDiscounts"
        Me.lblDiscounts.Size = New System.Drawing.Size(99, 20)
        Me.lblDiscounts.TabIndex = 8
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.datetimeDelivery)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.radYes)
        Me.GroupBox6.Controls.Add(Me.radNo)
        Me.GroupBox6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(23, 281)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(291, 141)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Select Delivery"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(835, 424)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(87, 21)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'chkHamburger
        '
        Me.chkHamburger.AutoSize = True
        Me.chkHamburger.Location = New System.Drawing.Point(20, 45)
        Me.chkHamburger.Name = "chkHamburger"
        Me.chkHamburger.Size = New System.Drawing.Size(121, 20)
        Me.chkHamburger.TabIndex = 0
        Me.chkHamburger.Text = "Hamburger ($1.89)"
        Me.chkHamburger.UseVisualStyleBackColor = True
        '
        'chkCheeseburger
        '
        Me.chkCheeseburger.AutoSize = True
        Me.chkCheeseburger.Location = New System.Drawing.Point(196, 45)
        Me.chkCheeseburger.Name = "chkCheeseburger"
        Me.chkCheeseburger.Size = New System.Drawing.Size(136, 20)
        Me.chkCheeseburger.TabIndex = 1
        Me.chkCheeseburger.Text = "Cheeseburger ($1.99)"
        Me.chkCheeseburger.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 18)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Meat"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(17, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 18)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Chicken"
        '
        'chkCrispyChix
        '
        Me.chkCrispyChix.AutoSize = True
        Me.chkCrispyChix.Location = New System.Drawing.Point(20, 88)
        Me.chkCrispyChix.Name = "chkCrispyChix"
        Me.chkCrispyChix.Size = New System.Drawing.Size(141, 20)
        Me.chkCrispyChix.TabIndex = 4
        Me.chkCrispyChix.Text = "Crispy Chicken ($3.10)"
        Me.chkCrispyChix.UseVisualStyleBackColor = True
        '
        'chkGrilledChix
        '
        Me.chkGrilledChix.AutoSize = True
        Me.chkGrilledChix.Location = New System.Drawing.Point(196, 88)
        Me.chkGrilledChix.Name = "chkGrilledChix"
        Me.chkGrilledChix.Size = New System.Drawing.Size(140, 20)
        Me.chkGrilledChix.TabIndex = 5
        Me.chkGrilledChix.Text = "Grilled Chicken ($3.92)"
        Me.chkGrilledChix.UseVisualStyleBackColor = True
        '
        'chkSpicyChix
        '
        Me.chkSpicyChix.AutoSize = True
        Me.chkSpicyChix.Location = New System.Drawing.Point(20, 108)
        Me.chkSpicyChix.Name = "chkSpicyChix"
        Me.chkSpicyChix.Size = New System.Drawing.Size(135, 20)
        Me.chkSpicyChix.TabIndex = 6
        Me.chkSpicyChix.Text = "Spicy Chicken ($3.80)"
        Me.chkSpicyChix.UseVisualStyleBackColor = True
        '
        'chkFingers
        '
        Me.chkFingers.AutoSize = True
        Me.chkFingers.Location = New System.Drawing.Point(196, 109)
        Me.chkFingers.Name = "chkFingers"
        Me.chkFingers.Size = New System.Drawing.Size(149, 20)
        Me.chkFingers.TabIndex = 7
        Me.chkFingers.Text = "Chicken Fingers  ($3.50)"
        Me.chkFingers.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 137)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(37, 18)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Sides"
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(20, 157)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(85, 20)
        Me.chkFries.TabIndex = 9
        Me.chkFries.Text = "Fries ($.99)"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkOnionRings
        '
        Me.chkOnionRings.AutoSize = True
        Me.chkOnionRings.Location = New System.Drawing.Point(20, 177)
        Me.chkOnionRings.Name = "chkOnionRings"
        Me.chkOnionRings.Size = New System.Drawing.Size(124, 20)
        Me.chkOnionRings.TabIndex = 10
        Me.chkOnionRings.Text = "Onion Rings ($1.99)"
        Me.chkOnionRings.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkHoneyMustard)
        Me.GroupBox5.Controls.Add(Me.chkRanch)
        Me.GroupBox5.Controls.Add(Me.chkKetchup)
        Me.GroupBox5.Controls.Add(Me.chkMustard)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.chkSwissCheese)
        Me.GroupBox5.Controls.Add(Me.chkCheese)
        Me.GroupBox5.Controls.Add(Me.chkLettuce)
        Me.GroupBox5.Controls.Add(Me.chkTomatoes)
        Me.GroupBox5.Controls.Add(Me.chkBacon)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.chkOnions)
        Me.GroupBox5.Controls.Add(Me.chkSeasonedFries)
        Me.GroupBox5.Controls.Add(Me.chkCheeseFries)
        Me.GroupBox5.Controls.Add(Me.chkOnionRings)
        Me.GroupBox5.Controls.Add(Me.chkFries)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.chkFingers)
        Me.GroupBox5.Controls.Add(Me.chkSpicyChix)
        Me.GroupBox5.Controls.Add(Me.chkGrilledChix)
        Me.GroupBox5.Controls.Add(Me.chkCrispyChix)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.chkCheeseburger)
        Me.GroupBox5.Controls.Add(Me.chkHamburger)
        Me.GroupBox5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(320, 41)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(351, 381)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Opera Menu"
        '
        'chkHoneyMustard
        '
        Me.chkHoneyMustard.AutoSize = True
        Me.chkHoneyMustard.Location = New System.Drawing.Point(202, 316)
        Me.chkHoneyMustard.Name = "chkHoneyMustard"
        Me.chkHoneyMustard.Size = New System.Drawing.Size(135, 20)
        Me.chkHoneyMustard.TabIndex = 35
        Me.chkHoneyMustard.Text = "Honey Mustard ($.10)"
        Me.chkHoneyMustard.UseVisualStyleBackColor = True
        '
        'chkRanch
        '
        Me.chkRanch.AutoSize = True
        Me.chkRanch.Location = New System.Drawing.Point(202, 290)
        Me.chkRanch.Name = "chkRanch"
        Me.chkRanch.Size = New System.Drawing.Size(90, 20)
        Me.chkRanch.TabIndex = 34
        Me.chkRanch.Text = "Ranch ($.10)"
        Me.chkRanch.UseVisualStyleBackColor = True
        '
        'chkKetchup
        '
        Me.chkKetchup.AutoSize = True
        Me.chkKetchup.Location = New System.Drawing.Point(202, 264)
        Me.chkKetchup.Name = "chkKetchup"
        Me.chkKetchup.Size = New System.Drawing.Size(95, 20)
        Me.chkKetchup.TabIndex = 33
        Me.chkKetchup.Text = "Ketchup ($.5)"
        Me.chkKetchup.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(202, 238)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(95, 20)
        Me.chkMustard.TabIndex = 32
        Me.chkMustard.Text = "Mustard ($.5)"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(199, 211)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(101, 18)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "Optional Sauces:"
        '
        'chkSwissCheese
        '
        Me.chkSwissCheese.AutoSize = True
        Me.chkSwissCheese.Location = New System.Drawing.Point(20, 355)
        Me.chkSwissCheese.Name = "chkSwissCheese"
        Me.chkSwissCheese.Size = New System.Drawing.Size(125, 20)
        Me.chkSwissCheese.TabIndex = 28
        Me.chkSwissCheese.Text = "Swiss Cheese ($.75)"
        Me.chkSwissCheese.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(20, 333)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(96, 20)
        Me.chkCheese.TabIndex = 27
        Me.chkCheese.Text = "Cheese ($.75)"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(20, 284)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(100, 20)
        Me.chkLettuce.TabIndex = 26
        Me.chkLettuce.Text = "Lettuce ($.25)"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomatoes
        '
        Me.chkTomatoes.AutoSize = True
        Me.chkTomatoes.Location = New System.Drawing.Point(20, 258)
        Me.chkTomatoes.Name = "chkTomatoes"
        Me.chkTomatoes.Size = New System.Drawing.Size(108, 20)
        Me.chkTomatoes.TabIndex = 22
        Me.chkTomatoes.Text = "Tomatoes ($.25)"
        Me.chkTomatoes.UseVisualStyleBackColor = True
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Location = New System.Drawing.Point(20, 310)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(90, 20)
        Me.chkBacon.TabIndex = 25
        Me.chkBacon.Text = "Bacon( $.75)"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(17, 211)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 18)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "Optional Dressing:"
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Location = New System.Drawing.Point(20, 232)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(97, 20)
        Me.chkOnions.TabIndex = 21
        Me.chkOnions.Text = "Onions  ($.20)"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'chkSeasonedFries
        '
        Me.chkSeasonedFries.AutoSize = True
        Me.chkSeasonedFries.Location = New System.Drawing.Point(196, 177)
        Me.chkSeasonedFries.Name = "chkSeasonedFries"
        Me.chkSeasonedFries.Size = New System.Drawing.Size(143, 20)
        Me.chkSeasonedFries.TabIndex = 12
        Me.chkSeasonedFries.Text = "Seasoned Fries  ($1.75)"
        Me.chkSeasonedFries.UseVisualStyleBackColor = True
        '
        'chkCheeseFries
        '
        Me.chkCheeseFries.AutoSize = True
        Me.chkCheeseFries.Location = New System.Drawing.Point(196, 157)
        Me.chkCheeseFries.Name = "chkCheeseFries"
        Me.chkCheeseFries.Size = New System.Drawing.Size(133, 20)
        Me.chkCheeseFries.TabIndex = 11
        Me.chkCheeseFries.Text = "Cheese Fries  ($2.25)"
        Me.chkCheeseFries.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(33, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(130, 18)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Fresh to Order Menu:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lstFresh)
        Me.GroupBox1.Controls.Add(Me.lstDrinks)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(677, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 171)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opera Menu"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(33, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 18)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Drinks:"
        '
        'lstFresh
        '
        Me.lstFresh.FormattingEnabled = True
        Me.lstFresh.ItemHeight = 16
        Me.lstFresh.Items.AddRange(New Object() {"Fresh Bread" & Global.Microsoft.VisualBasic.ChrW(9) & "$1.50", "Cookies" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$.99  Each", "- Macadamia Nut", "- Chocolate Chip", "- Double Chocolate", "Brownies", "- Regular" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$2.89", "- Double Fudge" & Global.Microsoft.VisualBasic.ChrW(9) & "$2.99"})
        Me.lstFresh.Location = New System.Drawing.Point(36, 41)
        Me.lstFresh.Name = "lstFresh"
        Me.lstFresh.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstFresh.Size = New System.Drawing.Size(163, 36)
        Me.lstFresh.TabIndex = 29
        '
        'lstDrinks
        '
        Me.lstDrinks.FormattingEnabled = True
        Me.lstDrinks.ItemHeight = 16
        Me.lstDrinks.Items.AddRange(New Object() {"Coke" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$ 1.00", "Sprite" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$ 1.00", "Lemonade" & Global.Microsoft.VisualBasic.ChrW(9) & "$.80", "Pink Lemonade" & Global.Microsoft.VisualBasic.ChrW(9) & "$.90", "Fruit Punch" & Global.Microsoft.VisualBasic.ChrW(9) & "$.80", "Sweet Tea" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$.90", "Unsweet Tea" & Global.Microsoft.VisualBasic.ChrW(9) & "$.80"})
        Me.lstDrinks.Location = New System.Drawing.Point(36, 101)
        Me.lstDrinks.Name = "lstDrinks"
        Me.lstDrinks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstDrinks.Size = New System.Drawing.Size(161, 36)
        Me.lstDrinks.TabIndex = 30
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Control
        Me.btnReset.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(731, 424)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 21)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Delivery"
        '
        'lblDelivery
        '
        Me.lblDelivery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDelivery.Location = New System.Drawing.Point(126, 85)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(99, 20)
        Me.lblDelivery.TabIndex = 21
        '
        'frmCampus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(968, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.mnuOpera)
        Me.MainMenuStrip = Me.mnuOpera
        Me.Name = "frmCampus"
        Me.Text = "Cafe Opera: Opera Campus"
        Me.mnuOpera.ResumeLayout(False)
        Me.mnuOpera.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuOpera As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOperasCampus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CampusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOperasExpress As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOperasCatering As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstDorm As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGPA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents datetimeDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents radNo As System.Windows.Forms.RadioButton
    Friend WithEvents radYes As System.Windows.Forms.RadioButton
    Friend WithEvents lblDiscounts As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboGrade As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblService As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTaxRate As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents chkHamburger As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheeseburger As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chkCrispyChix As System.Windows.Forms.CheckBox
    Friend WithEvents chkGrilledChix As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpicyChix As System.Windows.Forms.CheckBox
    Friend WithEvents chkFingers As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chkFries As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnionRings As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCheeseFries As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents chkSeasonedFries As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkTomatoes As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
    Friend WithEvents chkBacon As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents chkSwissCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents lstDrinks As System.Windows.Forms.ListBox
    Friend WithEvents lstFresh As System.Windows.Forms.ListBox
    Friend WithEvents chkHoneyMustard As System.Windows.Forms.CheckBox
    Friend WithEvents chkRanch As System.Windows.Forms.CheckBox
    Friend WithEvents chkKetchup As System.Windows.Forms.CheckBox
    Friend WithEvents chkMustard As System.Windows.Forms.CheckBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
