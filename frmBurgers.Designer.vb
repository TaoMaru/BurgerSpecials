﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurgers
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picPrime = New System.Windows.Forms.PictureBox()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.btnFalafel = New System.Windows.Forms.Button()
        Me.btnSelectMeal = New System.Windows.Forms.Button()
        Me.btnVeggieBurger = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(179, 45)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(354, 38)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Farm Burger Specials"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picPrime
        '
        Me.picPrime.Location = New System.Drawing.Point(20, 111)
        Me.picPrime.Name = "picPrime"
        Me.picPrime.Size = New System.Drawing.Size(300, 250)
        Me.picPrime.TabIndex = 1
        Me.picPrime.TabStop = False
        '
        'picVeggie
        '
        Me.picVeggie.Location = New System.Drawing.Point(393, 111)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(300, 250)
        Me.picVeggie.TabIndex = 2
        Me.picVeggie.TabStop = False
        '
        'btnFalafel
        '
        Me.btnFalafel.Location = New System.Drawing.Point(99, 392)
        Me.btnFalafel.Name = "btnFalafel"
        Me.btnFalafel.Size = New System.Drawing.Size(141, 38)
        Me.btnFalafel.TabIndex = 3
        Me.btnFalafel.Text = "Prime Beef"
        Me.btnFalafel.UseVisualStyleBackColor = True
        '
        'btnSelectMeal
        '
        Me.btnSelectMeal.Location = New System.Drawing.Point(285, 392)
        Me.btnSelectMeal.Name = "btnSelectMeal"
        Me.btnSelectMeal.Size = New System.Drawing.Size(141, 38)
        Me.btnSelectMeal.TabIndex = 4
        Me.btnSelectMeal.Text = "Select Meal"
        Me.btnSelectMeal.UseVisualStyleBackColor = True
        '
        'btnVeggieBurger
        '
        Me.btnVeggieBurger.Location = New System.Drawing.Point(472, 392)
        Me.btnVeggieBurger.Name = "btnVeggieBurger"
        Me.btnVeggieBurger.Size = New System.Drawing.Size(141, 38)
        Me.btnVeggieBurger.TabIndex = 5
        Me.btnVeggieBurger.Text = "Veggie Burger"
        Me.btnVeggieBurger.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(286, 574)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 38)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(169, 466)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(374, 23)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Choose a burger and then click the Select Meal button"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(270, 514)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(172, 18)
        Me.lblConfirmation.TabIndex = 8
        Me.lblConfirmation.Text = "Enjoy your burger special"
        Me.lblConfirmation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmBurgers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 653)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnVeggieBurger)
        Me.Controls.Add(Me.btnSelectMeal)
        Me.Controls.Add(Me.btnFalafel)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picPrime)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBurgers"
        Me.Text = "Burger Specials"
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPrime As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnFalafel As Button
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents btnVeggieBurger As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
End Class
