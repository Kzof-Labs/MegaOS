Public Class UpdateBoost
    Private Sub BoostSetup_Tick(sender As Object, e As EventArgs) Handles BoostSetup.Tick


        If Label1.Visible = False Then
            Label1.Visible = True
        ElseIf Label2.Visible = True Then
            Label2.Visible = True
        ElseIf Label3.Visible = True Then
            Label3.Visible = False



        ElseIf Label3.Visible = False Then
            MsgBox("Nenhuma Atualização Encontrada! Mas para ter certeza, acesse MegaOS.weebly.com/Update")
        End If


    End Sub

    Private Sub UpdateBoost_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lbl1_Tick(sender As Object, e As EventArgs) Handles lbl1.Tick

    End Sub

    Private Sub lbl2_Tick(sender As Object, e As EventArgs) Handles lbl2.Tick


    End Sub
End Class