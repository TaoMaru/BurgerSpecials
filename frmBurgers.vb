'Program name: Burger Specials
'Developer: Maria Jackson
'Date: Feb 11, 2023
'Purpose: This program displays burger menu options (Prime Beef or Veggie Burger)
'         User can click on a burger choice to view a picture of the meal
'         User can select their meal choice and then close the selection window
Public Class frmBurgers
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub btnVeggieBurger_Click(sender As Object, e As EventArgs) Handles btnVeggieBurger.Click
        ' on click, show veggiePic, hide primePic
        ' also enable btnSelectMeal
        picVeggie.Visible = True
        picPrime.Visible = False
        btnSelectMeal.Enabled = True

    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        ' on click, show primepic, hide veggiePic
        'also enable btnSelectMeal
        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelectMeal.Enabled = True

    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        'on click, disable btnSelect, btnPrime, & btnVaggie
        'also enable btnExit, hide lblInstructions, & show lblConfirmation
        btnPrime.Enabled = False
        btnVeggieBurger.Enabled = False
        btnSelectMeal.Enabled = False
        btnExit.Enabled = True
        lblInstructions.Visible = False
        lblConfirmation.Visible = True


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' on click, calls Close() procedure to close program window
        Close()
    End Sub
End Class
