Public Class dashboard
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        orders.Show()
        Me.Close()

    End Sub

    Private Sub btnass_Click(sender As Object, e As EventArgs) Handles btnass.Click
        Users.Show()
        Me.Close()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Customers.Show()
        Me.Close()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        products.Show()
        Me.Close()
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        products.Show()
        Me.Close()
    End Sub
End Class