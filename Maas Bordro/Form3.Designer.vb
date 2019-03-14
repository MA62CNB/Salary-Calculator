<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.medeniBox = New System.Windows.Forms.ComboBox
        Me.esLab = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cocSay = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.agiOran = New System.Windows.Forms.Label
        Me.cocOran = New System.Windows.Forms.Label
        Me.esOran = New System.Windows.Forms.Label
        Me.calOran = New System.Windows.Forms.Label
        Me.agiRes = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cocRes = New System.Windows.Forms.Label
        Me.esRes = New System.Windows.Forms.Label
        Me.calRes = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.hesapBut = New System.Windows.Forms.Button
        Me.termBut = New System.Windows.Forms.Button
        Me.geriBut = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.medeniBox)
        Me.GroupBox1.Controls.Add(Me.esLab)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Eş"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Medeni Hal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'medeniBox
        '
        Me.medeniBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.medeniBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.medeniBox.FormattingEnabled = True
        Me.medeniBox.Items.AddRange(New Object() {"Bekar", "Evli"})
        Me.medeniBox.Location = New System.Drawing.Point(37, 75)
        Me.medeniBox.Name = "medeniBox"
        Me.medeniBox.Size = New System.Drawing.Size(121, 21)
        Me.medeniBox.TabIndex = 3
        '
        'esLab
        '
        Me.esLab.AutoSize = True
        Me.esLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.esLab.Location = New System.Drawing.Point(177, 49)
        Me.esLab.Name = "esLab"
        Me.esLab.Size = New System.Drawing.Size(146, 15)
        Me.esLab.TabIndex = 2
        Me.esLab.Text = "Eşin Çalışma Durumu"
        Me.esLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(262, 79)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Çalışmıyor"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(180, 79)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Çalışıyor"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cocSay)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(383, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 139)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Çocuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Çocuk Sayısı"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cocSay
        '
        Me.cocSay.Enabled = False
        Me.cocSay.Location = New System.Drawing.Point(172, 70)
        Me.cocSay.MaxLength = 2
        Me.cocSay.Name = "cocSay"
        Me.cocSay.Size = New System.Drawing.Size(22, 20)
        Me.cocSay.TabIndex = 1
        Me.cocSay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(52, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "On sekiz yaşından küçük çocuklarınız için doldurunuz."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(760, 540)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.agiOran)
        Me.GroupBox5.Controls.Add(Me.cocOran)
        Me.GroupBox5.Controls.Add(Me.esOran)
        Me.GroupBox5.Controls.Add(Me.calOran)
        Me.GroupBox5.Controls.Add(Me.agiRes)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.cocRes)
        Me.GroupBox5.Controls.Add(Me.esRes)
        Me.GroupBox5.Controls.Add(Me.calRes)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(384, 254)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(364, 197)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'agiOran
        '
        Me.agiOran.AutoSize = True
        Me.agiOran.BackColor = System.Drawing.Color.DarkGreen
        Me.agiOran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.agiOran.Location = New System.Drawing.Point(207, 128)
        Me.agiOran.Name = "agiOran"
        Me.agiOran.Size = New System.Drawing.Size(2, 15)
        Me.agiOran.TabIndex = 11
        Me.agiOran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cocOran
        '
        Me.cocOran.AutoSize = True
        Me.cocOran.BackColor = System.Drawing.Color.DarkGreen
        Me.cocOran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cocOran.Location = New System.Drawing.Point(207, 104)
        Me.cocOran.Name = "cocOran"
        Me.cocOran.Size = New System.Drawing.Size(2, 15)
        Me.cocOran.TabIndex = 10
        Me.cocOran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'esOran
        '
        Me.esOran.AutoSize = True
        Me.esOran.BackColor = System.Drawing.Color.DarkGreen
        Me.esOran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.esOran.Location = New System.Drawing.Point(207, 77)
        Me.esOran.Name = "esOran"
        Me.esOran.Size = New System.Drawing.Size(2, 15)
        Me.esOran.TabIndex = 9
        Me.esOran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calOran
        '
        Me.calOran.AutoSize = True
        Me.calOran.BackColor = System.Drawing.Color.DarkGreen
        Me.calOran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.calOran.Location = New System.Drawing.Point(207, 50)
        Me.calOran.Name = "calOran"
        Me.calOran.Size = New System.Drawing.Size(2, 15)
        Me.calOran.TabIndex = 8
        Me.calOran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'agiRes
        '
        Me.agiRes.AutoSize = True
        Me.agiRes.BackColor = System.Drawing.Color.DarkGreen
        Me.agiRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.agiRes.Location = New System.Drawing.Point(292, 128)
        Me.agiRes.Name = "agiRes"
        Me.agiRes.Size = New System.Drawing.Size(2, 15)
        Me.agiRes.TabIndex = 7
        Me.agiRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(51, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Asgari Geçim İndirimi:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cocRes
        '
        Me.cocRes.AutoSize = True
        Me.cocRes.BackColor = System.Drawing.Color.DarkGreen
        Me.cocRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cocRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cocRes.Location = New System.Drawing.Point(292, 102)
        Me.cocRes.Name = "cocRes"
        Me.cocRes.Size = New System.Drawing.Size(2, 17)
        Me.cocRes.TabIndex = 5
        Me.cocRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'esRes
        '
        Me.esRes.AutoSize = True
        Me.esRes.BackColor = System.Drawing.Color.DarkGreen
        Me.esRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.esRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.esRes.Location = New System.Drawing.Point(292, 75)
        Me.esRes.Name = "esRes"
        Me.esRes.Size = New System.Drawing.Size(2, 17)
        Me.esRes.TabIndex = 4
        Me.esRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calRes
        '
        Me.calRes.AutoSize = True
        Me.calRes.BackColor = System.Drawing.Color.DarkGreen
        Me.calRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.calRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.calRes.Location = New System.Drawing.Point(292, 48)
        Me.calRes.Name = "calRes"
        Me.calRes.Size = New System.Drawing.Size(2, 17)
        Me.calRes.TabIndex = 3
        Me.calRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Çocuklar:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Eş:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Çalışan:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.hesapBut)
        Me.GroupBox4.Controls.Add(Me.termBut)
        Me.GroupBox4.Controls.Add(Me.geriBut)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 254)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(365, 198)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'hesapBut
        '
        Me.hesapBut.ForeColor = System.Drawing.Color.Black
        Me.hesapBut.Location = New System.Drawing.Point(54, 88)
        Me.hesapBut.Name = "hesapBut"
        Me.hesapBut.Size = New System.Drawing.Size(75, 23)
        Me.hesapBut.TabIndex = 2
        Me.hesapBut.Text = "HESAPLA"
        Me.hesapBut.UseVisualStyleBackColor = True
        '
        'termBut
        '
        Me.termBut.ForeColor = System.Drawing.Color.Black
        Me.termBut.Location = New System.Drawing.Point(236, 88)
        Me.termBut.Name = "termBut"
        Me.termBut.Size = New System.Drawing.Size(75, 23)
        Me.termBut.TabIndex = 1
        Me.termBut.Text = "ÇIKIŞ"
        Me.termBut.UseVisualStyleBackColor = True
        '
        'geriBut
        '
        Me.geriBut.ForeColor = System.Drawing.Color.Black
        Me.geriBut.Location = New System.Drawing.Point(145, 88)
        Me.geriBut.Name = "geriBut"
        Me.geriBut.Size = New System.Drawing.Size(75, 23)
        Me.geriBut.TabIndex = 0
        Me.geriBut.Text = "GERİ"
        Me.geriBut.UseVisualStyleBackColor = True
        '
        'frm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(784, 564)
        Me.Controls.Add(Me.GroupBox3)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm3"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maaş Bordro Programı"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents esLab As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cocSay As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents termBut As System.Windows.Forms.Button
    Friend WithEvents geriBut As System.Windows.Forms.Button
    Friend WithEvents hesapBut As System.Windows.Forms.Button
    Friend WithEvents cocRes As System.Windows.Forms.Label
    Friend WithEvents esRes As System.Windows.Forms.Label
    Friend WithEvents calRes As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents agiRes As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents medeniBox As System.Windows.Forms.ComboBox
    Friend WithEvents calOran As System.Windows.Forms.Label
    Friend WithEvents agiOran As System.Windows.Forms.Label
    Friend WithEvents cocOran As System.Windows.Forms.Label
    Friend WithEvents esOran As System.Windows.Forms.Label
End Class
