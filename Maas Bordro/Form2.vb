Public Class frm2
    Dim maas, kesintiler As Double

    Const DAMGA As Double = 0.006
    Const SIGORTA As Double = 0.14
    Const G_VERGI As Double = 0.15
    Const ISSIZLIK As Double = 0.01

    Private Sub frm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim kurus, net, maasHam As Double

        ' form1 de hesaplanan maas tutulur
        maas = frm1.hesapMaas()

        ' kişi bilgileri görüntüler
        idLbl.Text = frm1.idField.Text
        nameLbl.Text = frm1.nameField.Text
        lastLbl.Text = frm1.lastField.Text

        ' brüt maaş hesabı
        maasHam = Val(frm1.workedField.Text) * Val(frm1.wageField.Text)

        ' kesinti oranları görüntüler
        dKes.Text = maasHam * DAMGA         ' damga vergisi
        sKes.Text = maasHam * SIGORTA       ' sigorta
        iKes.Text = maasHam * ISSIZLIK      ' işsizlik sigortası

        ' kesintileri görüntüler
        damOr.Text = DAMGA          ' damga vergisi
        sigOran.Text = SIGORTA      ' sigorta"
        isOran.Text = ISSIZLIK      ' işsizlik sigortası"
        gelOr.Text = G_VERGI        ' gelir vergisi"

        ' matrah
        sigMat.Text = maasHam
        damMat.Text = maasHam
        isMat.Text = maasHam
        gelMat.Text = maasHam - (Val(sKes.Text) + Val(iKes.Text))

        ' gelir vergisi düşümünü hesaplar
        net = (maasHam * SIGORTA) + (maasHam * ISSIZLIK)
        gKes.Text = net * (1 - G_VERGI)

        ' net maaşı hesaplar
        maas = maasHam - (Val(dKes.Text) + Val(sKes.Text) + Val(iKes.Text) + Val(gKes.Text))

        ' kuruş olarak gösterir
        If maas < 1 Then
            kurus = maas * 100
            kalanLbl.Text = kurus
            Label13.Text = "KR"
            maasLbl.Text = Val(frm1.workedField.Text) * Val(frm1.wageField.Text)
        Else

            ' net maaşı görüntüler
            kalanLbl.Text = maas
            maasLbl.Text = Val(frm1.workedField.Text) * Val(frm1.wageField.Text)
            kesinLbl.Text = Val(maasLbl.Text) - Val(kalanLbl.Text)
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' mevcut formu kapatır
        Me.Close()

        ' birinci pencere açılır
        frm1.Show()
        frm1.StartPosition = FormStartPosition.CenterScreen
        frm1.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub indBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles indBut.Click

        ' mevcut formu kapatır
        Me.Close()

        ' birinci pencere açılır
        frm3.Show()
        frm3.StartPosition = FormStartPosition.CenterScreen
        frm3.WindowState = FormWindowState.Normal
    End Sub
End Class