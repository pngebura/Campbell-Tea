' Project name:     Campbell Tea Shoppe
' Project purpose:  Display the total price
' Created by:       Peter Gebura on 11/25/17

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        ' declare variables
        Dim breakfast As Integer
        Dim chamomile As Integer
        Dim citrus As Integer
        Dim earl As Integer
        Dim spiced As Integer
        Dim totalBoxes As Integer
        Dim totalPrice As Double
        Dim salesTax As Double
        Dim finalPrice As Double
        Const Price1To5 As Double = 6.95
        Const Price6To10 As Double = 5.95
        Const PriceOver10 As Double = 4.95
        Const TaxRate As Double = 0.05
        Dim button As DialogResult

        ' store input to variables
        Integer.TryParse(breakfastTextBox.Text, breakfast)
        Integer.TryParse(chamomileTextBox.Text, chamomile)
        Integer.TryParse(citrusTextBox.Text, citrus)
        Integer.TryParse(earlTextBox.Text, earl)
        Integer.TryParse(spicedTextBox.Text, spiced)

        ' calculate total boxes
        totalBoxes = breakfast + chamomile + citrus + earl + spiced
        boxesLabel.Text = totalBoxes.ToString("N0")

        Select Case totalBoxes
            Case 1 To 5
                totalPrice = Price1To5 * totalBoxes
            Case 6 To 10
                totalPrice = Price6To10 * totalBoxes
            Case Is > 10
                totalPrice = PriceOver10 * totalBoxes
        End Select

        ' if necessary, add sales tax
        button = MessageBox.Show("Sales Tax?", "Campbell Tea Shoppe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If button = DialogResult.Yes Then
            salesTax = totalPrice * TaxRate
            finalPrice = totalPrice + salesTax
        Else
            salesTax = 0
            finalPrice = totalPrice
        End If

        taxLabel.Text = salesTax.ToString("C2")
        priceLabel.Text = finalPrice.ToString("C2")

    End Sub

    Private Sub breakfastTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles breakfastTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub chamomileTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chamomileTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub citrusTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles citrusTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub earlTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles earlTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub spicedTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles spicedTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
