'Project    Star ducks Nocti Practice Project
'Purpose    Ordering application for star ducks
'Name   Cody Becker on 3/30/21

Option Strict On
Option Explicit On
Option Infer Off
Public Class frmStarDucks
    Dim intAmount As Integer = 0
    Dim dblBerryCost As Double
    Dim dblBerryRetail As Double
    Dim dblBerryProfit As Double
    Dim dblMangoCost As Double
    Dim dblMangoRetail As Double
    Dim dblMangoProfit As Double
    Dim dblStrawberryCost As Double
    Dim dblStrawBerryRetail As Double
    Dim dblStrawBerryProfit As Double
    Dim dblCoconutRetail As Double = 0.72
    Dim dblFeatherRetail As Double = 3.29
    Dim dblHersheyRetail As Double = 4.29
    Dim dblLemonadeRetail As Double = 0.6
    Dim dblOreoRetail As Double = 4.39
    Dim dblBerrySub As Double
    Dim dblMangoSub As Double
    Dim dblStrawberrySub As Double
    Dim dblOreoSub As Double
    Dim dblHersheySub As Double
    Dim dblFeatherSub As Double
    Dim dblLemonadeSub As Double
    Dim dblCoconutSub As Double
    Dim dblSubtotal As Double
    Dim dblSalesTax As Double
    Dim dblNonMemFee As Double
    Dim dblTotal As Double
    Dim dblCuDrinks As Double
    Dim dblPreviousCuDrinks As Double
    Dim dblPreviousCuProfit As Double
    Private Sub frmStarDucks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Do Until intAmount = 100
            cboBerry.Items.Add(intAmount)
            cboCoconut.Items.Add(intAmount)
            cboFeather.Items.Add(intAmount)
            cboHershey.Items.Add(intAmount)
            cboLemonade.Items.Add(intAmount)
            cboMango.Items.Add(intAmount)
            cboOreo.Items.Add(intAmount)
            cboStrawberry.Items.Add(intAmount)
            intAmount += 1
        Loop
        cboBerrySize.Items.Add("Tall")
        cboBerrySize.Items.Add("Grande")
        cboBerrySize.Items.Add("Venti")
        cboMangoSize.Items.Add("Tall")
        cboMangoSize.Items.Add("Grande")
        cboMangoSize.Items.Add("Venti")
        cboStrawberrySize.Items.Add("Tall")
        cboStrawberrySize.Items.Add("Grande")
        cboStrawberrySize.Items.Add("Venti")
        cboOreoSize.Items.Add("Regular")
        cboCoconutSize.Items.Add("Regular")
        cboFeatherSize.Items.Add("Regular")
        cboHersheySize.Items.Add("Regular")
        cboLemonadeSize.Items.Add("Regular")
        cboBerry.SelectedIndex = 0
        cboBerrySize.SelectedIndex = 0
        cboCoconut.SelectedIndex = 0
        cboCoconutSize.SelectedIndex = 0
        cboFeather.SelectedIndex = 0
        cboFeatherSize.SelectedIndex = 0
        cboHershey.SelectedIndex = 0
        cboHersheySize.SelectedIndex = 0
        cboLemonade.SelectedIndex = 0
        cboLemonadeSize.SelectedIndex = 0
        cboMango.SelectedIndex = 0
        cboMangoSize.SelectedIndex = 0
        cboOreo.SelectedIndex = 0
        cboOreoSize.SelectedIndex = 0
        cboStrawberry.SelectedIndex = 0
        cboStrawberrySize.SelectedIndex = 0
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboBerry.SelectedIndex = 0
        cboBerrySize.SelectedIndex = 0
        cboCoconut.SelectedIndex = 0
        cboCoconutSize.SelectedIndex = 0
        cboFeather.SelectedIndex = 0
        cboFeatherSize.SelectedIndex = 0
        cboHershey.SelectedIndex = 0
        cboHersheySize.SelectedIndex = 0
        cboLemonade.SelectedIndex = 0
        cboLemonadeSize.SelectedIndex = 0
        cboMango.SelectedIndex = 0
        cboMangoSize.SelectedIndex = 0
        cboOreo.SelectedIndex = 0
        cboOreoSize.SelectedIndex = 0
        cboStrawberry.SelectedIndex = 0
        cboStrawberrySize.SelectedIndex = 0

        lblBerrySub.Text = String.Empty
        lblCoconutSub.Text = String.Empty
        lblFeatherSub.Text = String.Empty
        lblHersheySub.Text = String.Empty
        lblLemonadeSub.Text = String.Empty
        lblMangoSub.Text = String.Empty
        lblOreoSub.Text = String.Empty
        lblStrawberrySub.Text = String.Empty
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dblCuDrinks = cboBerry.SelectedIndex + cboCoconut.SelectedIndex + cboMango.SelectedIndex + cboOreo.SelectedIndex +
            cboStrawberry.SelectedIndex + cboLemonade.SelectedIndex + cboHershey.SelectedIndex + cboFeather.SelectedIndex
        dblPreviousCuDrinks = Val(lblCuDrinks.Text)
        dblPreviousCuProfit = Val(lblCuProfit.Text)
        lblCuDrinks.Text = dblCuDrinks.ToString + dblPreviousCuDrinks.ToString
        lblCuProfit.Text = dblTotal.ToString("C2") + dblPreviousCuProfit.ToString
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        dblBerrySub = dblBerryRetail * cboBerry.SelectedIndex
        dblCoconutSub = dblCoconutRetail * cboCoconut.SelectedIndex
        dblMangoSub = dblMangoRetail * cboMango.SelectedIndex
        dblOreoSub = dblOreoRetail * cboOreo.SelectedIndex
        dblStrawberrySub = dblStrawBerryRetail * cboStrawberry.SelectedIndex
        dblLemonadeSub = dblLemonadeRetail * cboLemonade.SelectedIndex
        dblHersheySub = dblHersheyRetail * cboHershey.SelectedIndex
        dblFeatherSub = dblFeatherRetail * cboFeather.SelectedIndex

        lblBerrySub.Text = dblBerrySub.ToString("C2")
        lblCoconutSub.Text = dblCoconutSub.ToString("C2")
        lblFeatherSub.Text = dblFeatherSub.ToString("C2")
        lblHersheySub.Text = dblHersheySub.ToString("C2")
        lblLemonadeSub.Text = dblLemonadeSub.ToString("C2")
        lblMangoSub.Text = dblMangoSub.ToString("C2")
        lblOreoSub.Text = dblOreoSub.ToString("C2")
        lblStrawberrySub.Text = dblStrawberrySub.ToString("C2")
        dblSubtotal = dblStrawberrySub + dblOreoSub + dblMangoSub + dblLemonadeSub + dblHersheySub _
            + dblFeatherSub + dblCoconutSub + dblBerrySub
        dblSalesTax = dblSubtotal * 0.06
        If chkMember.Checked = True Then
            dblNonMemFee = 0
        Else
            dblNonMemFee = dblSubtotal * 0.012
        End If
        Math.Round(dblSubtotal, 2)
        Math.Round(dblSalesTax, 2)
        Math.Round(dblNonMemFee, 2)
        dblTotal = dblNonMemFee + dblSalesTax + dblSubtotal
        lblSubtotal.Text = dblSubtotal.ToString("C2")
        lblSalesTax.Text = dblSalesTax.ToString("C2")
        lblMember.Text = dblNonMemFee.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub
    Private Sub CalcCostAndRetail(sender As Object, e As EventArgs) Handles cboBerry.SelectedIndexChanged,
                                    cboBerrySize.SelectedIndexChanged, cboCoconut.SelectedIndexChanged,
                                    cboFeather.SelectedIndexChanged, cboHershey.SelectedIndexChanged,
                                    cboLemonade.SelectedIndexChanged, cboMango.SelectedIndexChanged,
                                    cboMangoSize.SelectedIndexChanged, cboOreo.SelectedIndexChanged,
                                    cboStrawberry.SelectedIndexChanged, cboStrawberrySize.SelectedIndexChanged
        Select Case True
            Case cboBerrySize.SelectedIndex = 0
                dblBerryCost = 2.33
                dblBerryRetail = 2.79
            Case cboBerrySize.SelectedIndex = 1
                dblBerryCost = 2.82
                dblBerryRetail = 3.39
            Case cboBerrySize.SelectedIndex = 2
                dblBerryCost = 3.32
                dblBerryRetail = 3.99
        End Select
        Select Case True
            Case cboMangoSize.SelectedIndex = 0
                dblMangoCost = 2.33
                dblMangoRetail = 2.79
            Case cboMangoSize.SelectedIndex = 1
                dblMangoCost = 2.82
                dblMangoRetail = 3.39
            Case cboMangoSize.SelectedIndex = 2
                dblMangoCost = 3.32
                dblMangoRetail = 3.99
        End Select
        Select Case True
            Case cboStrawberrySize.SelectedIndex = 0
                dblStrawberryCost = 2.33
                dblStrawBerryRetail = 2.79
            Case cboStrawberrySize.SelectedIndex = 1
                dblStrawberryCost = 2.82
                dblStrawBerryRetail = 3.39
            Case cboStrawberrySize.SelectedIndex = 2
                dblStrawberryCost = 3.32
                dblStrawBerryRetail = 3.99
        End Select
        dblBerryProfit = dblBerryRetail - dblBerryCost
        dblMangoProfit = dblMangoRetail - dblMangoCost
        dblStrawBerryProfit = dblStrawBerryRetail - dblStrawberryCost
        lblBerryCost.Text = dblBerryCost.ToString("C2")
        lblBerryRetail.Text = dblBerryRetail.ToString("C2")
        lblBerryProfit.Text = dblBerryProfit.ToString("C2")
        lblMangoCost.Text = dblMangoCost.ToString("C2")
        lblMangoRetail.Text = dblMangoRetail.ToString("C2")
        lblMangoProfit.Text = dblMangoProfit.ToString("C2")
        lblStrawberryCost.Text = dblStrawberryCost.ToString("C2")
        lblStrawberryRetail.Text = dblStrawBerryRetail.ToString("C2")
        lblStrawberryProfit.Text = dblStrawBerryProfit.ToString("C2")
    End Sub
End Class
