Public Class FrmMain
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the application
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate the projected sales
        lblStrawberry.Text = Format(Val(txtStrawberry.Text) * Val(txtIncrease.Text) + Val(txtStrawberry.Text), "currency")
        lblBlueberries.Text = Format(Val(txtBlueberries.Text) * Val(txtIncrease.Text) + Val(txtBlueberries.Text), "currency")
        lblRaspberry.Text = Format(Val(txtRaspberry.Text) * Val(txtIncrease.Text) + Val(txtRaspberry.Text), "currency")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Print the Screen
        btnExit.Visible = False
        btnCalc.Visible = False
        btnPrint.Visible = False
        btnClear.Visible = False
        PrintForm1.Print()
        btnExit.Visible = True
        btnCalc.Visible = True
        btnPrint.Visible = True
        btnClear.Visible = True

    End Sub

    Private Sub txtIncrease_TextChanged(sender As Object, e As EventArgs) Handles txtIncrease.TextChanged

    End Sub

    Private Sub lblStrawberry_TextChanged(sender As Object, e As EventArgs) Handles lblStrawberry.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all the text
        txtIncrease.Text = String.Empty
        txtStrawberry.Text = String.Empty
        txtBlueberries.Text = String.Empty
        txtRaspberry.Text = String.Empty
        lblStrawberry.Text = String.Empty
        lblBlueberries.Text = String.Empty
        lblRaspberry.Text = String.Empty
        'Focus thing
        txtIncrease.Focus()
    End Sub
End Class
