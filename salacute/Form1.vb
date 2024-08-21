Public Class OTR
    Dim socialss As Double = 0.05
    Dim philhealth As Double = 150
    Dim pagibig As Double = 0.03
    Dim tax As Double = 0.08




    'may H kase handler tama
    Dim grossSalary, WH, RRH, OTH, OTRH, SSSR, PHH, PIH, NT, ITH, ITR, TDH As Double
    Dim hoursWorked As Double
    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles OTR3.TextChanged

    End Sub

    Private Sub PH_TextChanged(sender As Object, e As EventArgs) Handles PH.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox6.Text = TextBox1.Text
        dpt2.Text = dpt.Text
        WHR2.Text = WHR.Text
        RR2.Text = RR.Text
        OT2.Text = OT.Text
        OTR3.Text = OTR2.Text




        WH = WHR2.Text
        RRH = RR2.Text
        OTH = OT2.Text
        OTRH = OTR3.Text
        'gross salary
        grossSalary = (WH * RRH) + (OTH * OTRH)
        GSS.Text = (grossSalary)
        'SSS
        SSSR = grossSalary * socialss
        SSS.Text = (SSSR)

        'pag ibig ko sayo 
        PIH = grossSalary * pagibig
        PI.Text = (PIH)
        'interest rate 
        ITR = grossSalary * 0.08

        'income tax 
        ITH = grossSalary * tax
        IT.Text = (ITH)
        'phil health
        PH.Text = (philhealth)

        'total deduction
        TDH = SSSR + philhealth + PIH + ITH
        TD.Text = (TDH)

        'net pay 
        NT = grossSalary - TDH
        NP.Text = (NT)








    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles dpt.TextChanged

    End Sub

    Private Sub RR_TextChanged(sender As Object, e As EventArgs) Handles RR.TextChanged

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles dpt2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles WHR.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles WHR2.TextChanged

    End Sub

    Private Sub TD_TextChanged(sender As Object, e As EventArgs) Handles TD.TextChanged

    End Sub
End Class
