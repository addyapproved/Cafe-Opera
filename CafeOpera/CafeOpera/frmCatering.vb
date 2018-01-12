Public Class frmCatering

    Const decTAX_RATE As Decimal = 0.06

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim decSubtotal As Decimal
        Dim decService As Decimal = 5D
        Dim decTax As Decimal
        Dim decDiscounts As Decimal
        Dim decOrderTotal As Decimal


        decSubtotal = Entree() + Sides() + OptionalDressing() + Sauces() + FreshtoOrder() + Drinks()
        decDiscounts -= StudentOrganization()
        decTax = Calctax(decSubtotal)
        decOrderTotal = decSubtotal + decTax + decService + decDiscounts

        lblSubtotal.Text = decSubtotal.ToString("c")
        lblService.Text = decService.ToString("c")
        lblDiscounts.Text = decDiscounts.ToString("c")
        lblTaxRate.Text = decTax.ToString("c")
        lblTotal.Text = decOrderTotal.ToString("c")

    End Sub
    Function StudentOrganization() As Decimal
        Dim decStudent As Decimal
        If cboGroup.SelectedIndex = 0 Then
            decStudent = 0.1D
            MessageBox.Show(" As an Organization at our University a discount will be applied to this order", "Student Organization")
            Return decStudent
        End If
    End Function
    Function Entree() As Decimal
        Dim decCostofCase As Decimal = 0

        If chkHamburgerCase.Checked = True Then
            decCostofCase += 10.9D
        End If
        If chkCheeseburgerCase.Checked = True Then
            decCostofCase += 14.9D
        End If
        If chkCrispyChixCase.Checked = True Then
            decCostofCase += 15.9D
        End If
        If chkSpicyChixCase.Checked = True Then
            decCostofCase += 17.9D
        End If
        If chkGrilledChixCase.Checked = True Then
            decCostofCase += 15.9D
        End If
        If chkFingersPlatter.Checked = True Then
            decCostofCase += 25.5D
        End If
        Return decCostofCase
    End Function

    Function Sides() As Decimal
        Dim decCostofSides As Decimal = 0

        If chkFries.Checked = True Then
            decCostofSides += 5D
        End If
        If chkOnionRings.Checked = True Then
            decCostofSides += 5D
        End If
        If chkCheeseFries.Checked = True Then
            decCostofSides += 5D
        End If
        If chkSeasonedFries.Checked = True Then
            decCostofSides += 5D
        End If
        Return decCostofSides

    End Function

    Function OptionalDressing() As Decimal
        Dim decCostofDressing As Decimal = 0

        If chkOnions.Checked = True Then
            decCostofDressing += 3.99D
        End If
        If chkTomatoes.Checked = True Then
            decCostofDressing += 3.99D
        End If
        If chkLettuce.Checked = True Then
            decCostofDressing += 3.99D
        End If
        If chkBacon.Checked = True Then
            decCostofDressing += 5.99D
        End If
        If chkCheese.Checked = True Then
            decCostofDressing += 6.99D
        End If
        If chkSwissCheese.Checked = True Then
            decCostofDressing += 6.99D
        End If
        Return decCostofDressing
    End Function

    Function Sauces() As Decimal
        Dim decCostofSauce As Decimal = 0
        If chkMustard.Checked = True Then
            decCostofSauce += 3.99D
        End If
        If chkKetchup.Checked = True Then
            decCostofSauce += 3.99D
        End If
        If chkRanch.Checked = True Then
            decCostofSauce += 3.99D
        End If
        If chkHoneyMustard.Checked = True Then
            decCostofSauce += 3.99D
        End If
        Return decCostofSauce
    End Function

    Function FreshtoOrder() As Decimal
        Dim decfresh As Decimal

        If lstFresh.SelectedIndex = 0 Then
            decfresh += 10D
        End If
        If lstFresh.SelectedIndex = 3 Then
            decfresh += 10D
        End If
        If lstFresh.SelectedIndex = 4 Then
            decfresh += 10D
        End If
        If lstFresh.SelectedIndex = 5 Then
            decfresh += 10D
        End If
        If lstFresh.SelectedIndex = 7 Then
            decfresh += 15.5D
        End If
        If lstFresh.SelectedIndex = 8 Then
            decfresh += 20.5D
        End If
        Return decfresh
    End Function
    Function Drinks() As Decimal
        Dim decdrinks As Decimal
        If lstDrinks.SelectedIndex = 0 Then
            decdrinks += 5D
        End If
        If lstDrinks.SelectedIndex = 1 Then
            decdrinks += 5D
        End If
        If lstDrinks.SelectedIndex = 2 Then
            decdrinks += 5D
        End If
        If lstDrinks.SelectedIndex = 3 Then
            decdrinks += 3.5D
        End If
        If lstDrinks.SelectedIndex = 4 Then
            decdrinks += 2.5D
        End If
        If lstDrinks.SelectedIndex = 5 Then
            decdrinks += 2.5D
        End If
        If lstDrinks.SelectedIndex = 6 Then
            decdrinks += 0.8D
        End If
        Return decdrinks
    End Function
    Function Calctax(ByVal decAmount As Decimal) As Decimal
        Return decAmount * decTAX_RATE
    End Function

    Private Sub radYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radYes.CheckedChanged
        Dim decDelivery As Decimal
        If radYes.Checked = True Then
            decDelivery += 10D
        ElseIf decDelivery < 10 = True Then
            MessageBox.Show(" Delivery is a $10 minimum", "Error")
        End If
    End Sub


    Private Sub radNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNo.CheckedChanged
        Dim decDelivery As Decimal
        If radNo.Checked = True Then
            decDelivery = 0D
        ElseIf decDelivery >= 25D Then
            decDelivery = 0D
            MessageBox.Show("You Qualify for free delivery,", "Note")
        End If
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuFileReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileReset.Click
        ' Reset the form
        lblSubtotal.Text = String.Empty
        lblDiscounts.Text = String.Empty
        lblTaxRate.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub CampusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CampusToolStripMenuItem.Click
        Dim CampusForm As New frmCampus()

        ' Display the scuba package form.
        CampusForm.ShowDialog()
    End Sub

    Private Sub mnuOperasExpress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOperasExpress.Click
        Dim ExpressForm As New frmExpress()

        ' Display the scuba package form.
        ExpressForm.ShowDialog()
    End Sub

    Private Sub mnuOperasCatering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOperasCatering.Click
        Dim CateringForm As New frmCatering()

        ' Display the scuba package form.
        CateringForm.ShowDialog()
    End Sub
End Class