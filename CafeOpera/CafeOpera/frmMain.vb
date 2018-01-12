Public Class frmMain

    Private Sub btnCampus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCampus.Click
        Dim CampusForm As New frmCampus() ' Declare an instance

        CampusForm.ShowDialog()                ' Display the form
    End Sub

    Private Sub btnExpress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpress.Click
        Dim ExpressForm As New frmExpress() ' Declare an instance

        ExpressForm.ShowDialog()                ' Display the form
    End Sub

    Private Sub btnCatering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCatering.Click
        Dim CateringForm As New frmCatering() ' Declare an instance

        CateringForm.ShowDialog()                ' Display the form
    End Sub
End Class
