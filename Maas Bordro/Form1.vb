Imports System.IO
Public Class frm1
    Dim sys As New FileStream("oran.txt", FileMode.Create, FileAccess.Write)
    Dim maas, salt As Double
    Dim j As Integer
    Dim prop(), str(9) As String
    Dim lines(8), neu(8), consts(8), token(8) As String

    Public Function saltMaas()

        ' maaşı hesaplar gün x günlük ücret
        salt = Val(wageField.Text) * Val(workedField.Text)

        Return salt
    End Function
    Public Function hesapMaas()

        ' maaşı hesaplar gün x günlük ücret
        maas = Val(wageField.Text) * Val(workedField.Text)

        ' vergiler sigorta ve damga pulunu maaştan düşer
        maas -= maas * 0.156
        maas -= maas * 0.15
        Return maas
    End Function

    Private Sub clearField()

        ' tüm alanları temizler
        nameField.Text = ""
        lastField.Text = ""
        idField.Text = ""
        wageField.Text = ""
        workedField.Text = ""
    End Sub

    Private Sub frm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nameField.Focus()
        str = acDosya()
        a1.Text = str(0)
        a2.Text = str(1)
        a3.Text = str(2)
        a4.Text = str(3)
        a6.Text = str(4)
        a7.Text = str(5)
        a8.Text = str(6)
        a9.Text = str(7)
        a5.Text = str(8)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Button2.Visible = False
        Button4.Visible = True
        Button4.Left = 309
        Button4.Top = 411

        a1.Visible = True
        a2.Visible = True
        a3.Visible = True
        a4.Visible = True
        a5.Visible = True
        a6.Visible = True
        a7.Visible = True
        a8.Visible = True
        a9.Visible = True

        l1.Visible = True
        l2.Visible = True
        l3.Visible = True
        l4.Visible = True
        l5.Visible = True
        l6.Visible = True
        l7.Visible = True
        l8.Visible = True
        l9.Visible = True

        kayit.Visible = True

        GroupBox1.Visible = False
        Label4.BackColor = Color.ForestGreen
        Label3.BackColor = Color.DarkGreen
        GroupBox4.Visible = True

        GroupBox4.Text = ""
        GroupBox4.Top = 131
        GroupBox4.Left = 12
        GroupBox4.Width = 760
        GroupBox4.Height = 254

        ' label
        l1.Top = 50
        l1.Left = 44

        ' label
        l2.Top = 88
        l2.Left = 44

        ' label
        l3.Top = 128
        l3.Left = 44

        'textbox
        l4.Top = 50
        l4.Left = 260

        ' label
        l5.Top = 88
        l5.Left = 260

        ' label
        l6.Top = 128
        l6.Left = 260

        ' label
        l7.Top = 50
        l7.Left = 488

        ' label
        l8.Top = 88
        l8.Left = 488

        ' label
        l9.Top = 124
        l9.Left = 488

        ' textbox
        a1.Top = 46
        a1.Left = 130

        ' textbox
        a2.Top = 85
        a2.Left = 130

        ' textbox
        a3.Top = 124
        a3.Left = 130

        ' textbox
        a4.Top = 46
        a4.Left = 366

        ' textbox
        a5.Top = 85
        a5.Left = 366

        ' textbox
        a6.Top = 124
        a6.Left = 366

        ' textbox
        a7.Top = 46
        a7.Left = 616

        ' textbox
        a8.Top = 85
        a8.Left = 616

        ' textbox
        a9.Top = 124
        a9.Left = 616

        kayit.Top = 168
        kayit.Left = 343

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        GroupBox1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = False
        GroupBox4.Visible = False
        a1.Visible = False
        a2.Visible = False
        a3.Visible = False
        a4.Visible = False
        a5.Visible = False
        a6.Visible = False
        a7.Visible = False
        a8.Visible = False
        a9.Visible = False

        Label4.BackColor = Color.DarkGreen
        Label3.BackColor = Color.ForestGreen
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ' tüm alanları temizler
        clearField()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'mevcut formu kapatır
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' eğer bir ya da birden fazla alan boş bırakılmış mı
        If (nameField.Text = "") Then
            MsgBox("İsim alanı boş bırakılamaz", MsgBoxStyle.Exclamation, "Hata")
            nameField.Focus()

            ' boş bırakılan soyisim alanı
        ElseIf (lastField.Text = "") Then
            MsgBox("Soyisim alanı boş bırakılamaz", MsgBoxStyle.Exclamation, "Hata")
            lastField.Focus()

            ' boş bırakılan kimlik numarası alanı
        ElseIf (idField.Text = "") Then
            MsgBox("Kimlik numarası alanı boş bırakılamaz", MsgBoxStyle.Exclamation, "Hata")
            idField.Focus()

            ' boş bırakılan çalışılan gün sayısı alanı
        ElseIf (workedField.Text = "") Then
            MsgBox("Çalışılan gün sayısı alanı boş bırakılamaz", MsgBoxStyle.Exclamation, "Hata")
            workedField.Focus()

            ' boş bırakılan günlük ücret alanı
        ElseIf (wageField.Text = "") Then
            MsgBox("Günlük ücret alanı boş bırakılamaz", MsgBoxStyle.Exclamation, "Hata")
            wageField.Focus()

            ' isim alanına sayı girişi
        ElseIf (IsNumeric(nameField.Text)) Then
            MsgBox("İsim alanına sayı girilemez, kontrol edin", MsgBoxStyle.Exclamation, "Hata")
            nameField.Focus()

            ' soyisim alanına sayı girişi
        ElseIf (IsNumeric(lastField.Text)) Then
            MsgBox("Soyisim alanına sayı girilemez, kontrol edin", MsgBoxStyle.Exclamation, "Hata")
            lastField.Focus()

            ' sayı olmayan giriş
        ElseIf (Not (IsNumeric(idField.Text))) Then
            MsgBox("TC Kimlik numarası alanına harf girilemez, kontrol edin", MsgBoxStyle.Exclamation, "Hata")
            idField.Focus()

            'tc kimlik no'nun 11den az bsamaklı olması
        ElseIf (idField.Text.Count) < 11 Then
            MsgBox("TC Kimlik numarası alanına eksik giriş yapılamaz, kontrol edin", MsgBoxStyle.Exclamation, "Hata")
            idField.Focus()

            ' tc kimlik no'nun 0 ile başlaması
        ElseIf (idField.Text.StartsWith("0")) Then
            MsgBox("TC Kimlik numarası alanına yanlış giriş, kontrol edin", MsgBoxStyle.Exclamation, "Hata")
            idField.Focus()

            ' sayı olmayan giriş
        ElseIf (Not (IsNumeric(workedField.Text))) Then
            MsgBox("Çalışılan gün alanına harf girilemez, kontrol edin", MsgBoxStyle.Exclamation, "Hata")

            ' gün kontrolü
        ElseIf Val(workedField.Text) > 30 Then
            MsgBox("Çalışılan gün alanına 30 günden fazla giriş yapılamaz, kontrol edin", MsgBoxStyle.Exclamation, "Hata")
            workedField.Focus()

            ' hatalı giriş
        ElseIf (Not (IsNumeric(wageField.Text))) Then
            MsgBox("Günlük ücret alanına karakter girilemez, kontrol edin", MsgBoxStyle.Exclamation, "Hata")

        ElseIf Val(wageField.Text) < 22 Then
            MsgBox("Günlük ücret asgari ücretten az girilemez, kontrol edin", MsgBoxStyle.Exclamation, "Hata")

        ElseIf Val(wageField.Text).Equals(22) And Val(krField.Text) < 200 Then
            MsgBox("Günlük ücret asgari ücretten az girilemez, kontrol edin", MsgBoxStyle.Exclamation, "Hata")

            If Val(krField.Text).Equals(2) Or Val(krField.Text).Equals(20) Then
                krField.Text = 200
            End If

        ElseIf (Not (IsNumeric(krField.Text))) Then
            MsgBox("Günlük ücret alanına karakter girilemez, kontrol edin", MsgBoxStyle.Exclamation, "Hata")

        Else

            ' mevcut form kapanır
            Me.Hide()

            ' ikinci form açılır
            frm2.Show()
        End If
    End Sub

    Private Sub kayit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kayit.Click
        Try
            Dim writ As New StreamWriter(sys)

            If a1.Text = "" Then

                ' dosyaya 014 yaz
                prop(1) = "si" & 0.14
            ElseIf a2.Text = "" Then

                ' dosyaya 001 yaz
                prop(2) = "is" & 0.01
            ElseIf a3.Text = "" Then

                ' dosyaya 0006 yaz
                prop(3) = "dp" & 0.006
            ElseIf a4.Text = "" Then

                ' dosyaya 015 yaz
                prop(4) = "gv" & 0.15
            ElseIf a9.Text = "" Then

                ' dosyaya 05 yaz
                prop(5) = "ke" & 0.5
            ElseIf a6.Text = "" Then

                ' dosyaya 01 yaz
                prop(6) = "es" & 0.1
            ElseIf a7.Text = "" Then

                ' dosyaya 0075 yaz
                prop(7) = "ci" & 0.075
            ElseIf a8.Text = "" Then

                ' dosyaya 005 yaz
                prop(8) = "cc" & 0.05
            ElseIf a5.Text = "" Then

                ' dosyaya 693 yaz
                prop(9) = "au" & 693

            Else
                writ.WriteLine("si  " & a1.Text _
                    & "is  " & a2.Text & "dp  " & a3.Text _
                    & "gv  " & a4.Text & "ke  " & a6.Text _
                    & "es  " & a7.Text & "ci  " & a8.Text _
                    & "cc  " & a9.Text & "au  " & a5.Text)
            End If
            writ.Close()
        Catch ex As FileNotFoundException
            MsgBox("Hata oluştu" & vbCrLf & ex.Message)
        End Try
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        a1.Text = ""
        a2.Text = ""
        a3.Text = ""
        a4.Text = ""
        a5.Text = ""
        a6.Text = ""
        a7.Text = ""
        a8.Text = ""
        a9.Text = ""
    End Sub

    Public Function acDosya()
        Try
            Dim stream As New FileStream("oran - Kopya.txt", FileMode.Open, FileAccess.Read)
            Dim reader As New StreamReader(stream)
            j = 0
            While (reader.Peek() > 1)
                lines(j) = lines(j) & reader.ReadLine() & vbCrLf
                neu = lines(j).Split(vbTab)
                token(j) = neu(1)
                j += 1
            End While
        Catch ex As FileNotFoundException
            MsgBox(ex.Message, MsgBoxStyle.Information, "File")
        End Try
        Return (token)
    End Function
End Class
