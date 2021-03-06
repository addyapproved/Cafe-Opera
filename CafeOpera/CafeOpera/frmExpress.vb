﻿Public Class frmExpress

    Const decTAX_RATE As Decimal = 0.06

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decDiscounts As Decimal
        Dim decOrderTotal As Decimal


        decSubtotal = Entree() + Sides() + OptionalDressing() + Sauces() + FreshtoOrder() + Drinks()
        decDiscounts -= GradeYear() + Stufacstaff()
        decTax = Calctax(decSubtotal)
        decOrderTotal = decSubtotal + decTax + decDiscounts

        lblSubtotal.Text = decSubtotal.ToString("c")
        lblDiscounts.Text = decDiscounts.ToString("c")
        lblTaxRate.Text = decTax.ToString("c")
        lblTotal.Text = decOrderTotal.ToString("c")

    End Sub
    Function GradeYear() As Decimal
        Dim decSenior As Decimal
        Dim decFreshman As Decimal
        If cboGrade.SelectedIndex = 3 Then
            decSenior = 0.2D
            MessageBox.Show(" Your Senior discount will be applied to this order", "Senior")
            Return decSenior
        ElseIf cboGrade.SelectedIndex = 0 Then
        decFreshman = 0.5D
        MessageBox.Show(" Welcome new student! your discount will be applied to this order", "Welcome Freshman")
        Return decFreshman
        End If
    End Function
    Function Stufacstaff() As Decimal
        Dim decFaculty As Decimal
        Dim decStaff As Decimal
        If cboStufacstaff.SelectedIndex = 1 Then
            decFaculty = 0.15D
            MessageBox.Show(" As a member of our faculty your discount will be applied to this order", "Faculty Member")
            Return decFaculty
        ElseIf cboStufacstaff.SelectedIndex = 2 Then
        decStaff = 0.15D
        MessageBox.Show(" As a member of our Staff your discount will be applied to this order", "Staff")
            Return decStaff
        End If
    End Function
    Function Entree() As Decimal
        Dim decCostofEntree As Decimal = 0

        If chkHamburger.Checked = True Then
            decCostofEntree += 1.89D
        End If
        If chkCheeseburger.Checked = True Then
            decCostofEntree += 1.99D
        End If
        If chkCrispyChix.Checked = True Then
            decCostofEntree += 3.1D
        End If
        If chkSpicyChix.Checked = True Then
            decCostofEntree += 3.8D
        End If
        If chkGrilledChix.Checked = True Then
            decCostofEntree += 3.92D
        End If
        If chkFingers.Checked = True Then
            decCostofEntree += 3.5D
        End If
        Return decCostofEntree
    End Function

    Function Sides() As Decimal
        Dim decCostofSides As Decimal = 0

        If chkFries.Checked = True Then
            decCostofSides += 0.99D
        End If
        If chkOnionRings.Checked = True Then
            decCostofSides += 1.99D
        End If
        If chkCheeseFries.Checked = True Then
            decCostofSides += 2.25D
        End If
        If chkSeasonedFries.Checked = True Then
            decCostofSides += 1.75D
        End If
        Return decCostofSides

    End Function

    Function OptionalDressing() As Decimal
        Dim decCostofDressing As Decimal = 0

        If chkOnions.Checked = True Then
            decCostofDressing += 0.2D
        End If
        If chkTomatoes.Checked = True Then
            decCostofDressing += 0.25D
        End If
        If chkLettuce.Checked = True Then
            decCostofDressing += 0.25D
        End If
        If chkBacon.Checked = True Then
            decCostofDressing += 0.75D
        End If
        If chkCheese.Checked = True Then
            decCostofDressing += 0.75D
        End If
        If chkSwissCheese.Checked = True Then
            decCostofDressing += 0.75D
        End If
        Return decCostofDressing
    End Function

    Function Sauces() As Decimal
        Dim decCostofSauce As Decimal = 0
        If chkMustard.Checked = True Then
            decCostofSauce += 0.5D
        End If
        If chkKetchup.Checked = True Then
            decCostofSauce += 0.5D
        End If
        If chkRanch.Checked = True Then
            decCostofSauce += 0.1D
        End If
        If chkHoneyMustard.Checked = True Then
            decCostofSauce += 0.1D
        End If
        Return decCostofSauce
    End Function

    Function FreshtoOrder() As Decimal
        Dim decfresh As Decimal

        If lstFresh.SelectedIndex = 0 Then
            decfresh += 1.5D
        End If
        If lstFresh.SelectedIndex = 3 Then
            decfresh += 0.99D
        End If
        If lstFresh.SelectedIndex = 4 Then
            decfresh += 0.99D
        End If
        If lstFresh.SelectedIndex = 5 Then
            decfresh += 0.99D
        End If
        If lstFresh.SelectedIndex = 7 Then
            decfresh += 2.89D
        End If
        If lstFresh.SelectedIndex = 8 Then
            decfresh += 2.99D
        End If
        Return decfresh
    End Function
    Function Drinks() As Decimal
        Dim decdrinks As Decimal
        If lstDrinks.SelectedIndex = 0 Then
            decdrinks += 1D
        End If
        If lstDrinks.SelectedIndex = 1 Then
            decdrinks += 1D
        End If
        If lstDrinks.SelectedIndex = 2 Then
            decdrinks += 0.8D
        End If
        If lstDrinks.SelectedIndex = 3 Then
            decdrinks += 0.9D
        End If
        If lstDrinks.SelectedIndex = 4 Then
            decdrinks += 0.8D
        End If
        If lstDrinks.SelectedIndex = 5 Then
            decdrinks += 0.9D
        End If
        If lstDrinks.SelectedIndex = 6 Then
            decdrinks += 0.8D
        End If
        Return decdrinks
    End Function
    Function Calctax(ByVal decAmount As Decimal) As Decimal
        Return decAmount * decTAX_RATE
    End Function
End Class