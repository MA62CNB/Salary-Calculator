Imports System.IO
Public Class frm3
    Dim maas, cal, es, coc, res As Double

    Dim lines(8), neu(8), consts(8), token(8) As String
    Dim j As Integer
    Dim k As Integer = 0
    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles termBut.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles geriBut.Click

        ' mevcut formu kapatır
        Me.Close()

        ' birinci pencere açılır
        frm2.Show()
        frm2.StartPosition = FormStartPosition.CenterScreen
        frm2.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hesapBut.Click

        cal = consts(7)
        calRes.Text = cal * consts(8)

        ' radio button kontrol
        If (RadioButton1.Checked) Then
            es = 0
            esRes.Text = es * consts(8)
            esOran.Text = 0
        ElseIf (RadioButton2.Checked) Then
            es = consts(5)
            esRes.Text = es * consts(8)
            esOran.Text = consts(5)
        End If

        ' çocuk sayısı kontrol
        If Val(cocSay.Text).Equals(0) Then
            coc = 0
            cocRes.Text = coc * consts(8)
            cocOran.Text = 0
        ElseIf (Val(cocSay.Text) < 3) Then
            coc = consts(6) * Val(cocSay.Text)
            cocRes.Text = coc * consts(8)
            cocOran.Text = consts(6) * Val(cocSay.Text)
        ElseIf Val(cocSay.Text).Equals(3) Then
            coc = (consts(6) * (Val(cocSay.Text) - 1) + consts(7))
            cocRes.Text = coc * consts(8)
            cocOran.Text = consts(7) + (consts(6) * (Val(cocSay.Text) - 1))
        ElseIf Val(cocSay.Text).Equals(4) Then
            coc = (consts(7) * (Val(cocSay.Text) / 2) + (Val(cocSay.Text) / 2) * consts(6))
            cocRes.Text = coc * consts(8)
            cocOran.Text = consts(7) * (Val(cocSay.Text) / 2) + (Val(cocSay.Text) / 2) * consts(6)
        ElseIf Val(cocSay.Text) > 4 Then
            coc = (consts(7) * (Val(cocSay.Text) - 2) + (2 * consts(6)))
            cocRes.Text = coc * consts(8)
            cocOran.Text = consts(7) * (Val(cocSay.Text) - 2) + (2 * consts(6))
        End If
        res = (cal + es + coc) * consts(8)
        agiRes.Text = res * consts(3)
    End Sub

    Private Sub medeniBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles medeniBox.SelectedIndexChanged
        If medeniBox.SelectedItem = "Evli" Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            cocSay.Enabled = True
        Else
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            es = maas * 0
        End If
    End Sub

    Private Sub frm3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        consts = frm1.acDosya()
        maas = frm1.hesapMaas()

        ' tanımlamalar gösterge
        calOran.Text = consts(4)
        esOran.Text = 0
        cocOran.Text = 0
        agiOran.Text = consts(3)


    End Sub
End Class