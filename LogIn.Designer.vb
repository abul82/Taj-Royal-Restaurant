<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.txtres = New System.Windows.Forms.Label()
        Me.Btnforgetpass = New System.Windows.Forms.Button()
        Me.Btnsignup = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = Global.Taj_Royal_Restaurant.My.Resources.Resources.pexels_photo_958546__2_
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New System.Drawing.Point(1, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(305, 458)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        '
        'txtres
        '
        Me.txtres.BackColor = System.Drawing.Color.Transparent
        Me.txtres.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtres.ForeColor = System.Drawing.Color.Goldenrod
        Me.txtres.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.txtres.Location = New System.Drawing.Point(358, 57)
        Me.txtres.Name = "txtres"
        Me.txtres.Size = New System.Drawing.Size(308, 57)
        Me.txtres.TabIndex = 3
        Me.txtres.Text = "Taj Royal"
        Me.txtres.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btnforgetpass
        '
        Me.Btnforgetpass.BackColor = System.Drawing.Color.Black
        Me.Btnforgetpass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnforgetpass.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnforgetpass.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Btnforgetpass.Location = New System.Drawing.Point(39, 143)
        Me.Btnforgetpass.Name = "Btnforgetpass"
        Me.Btnforgetpass.Size = New System.Drawing.Size(172, 30)
        Me.Btnforgetpass.TabIndex = 10
        Me.Btnforgetpass.Text = "Forget Password"
        Me.Btnforgetpass.UseVisualStyleBackColor = False
        '
        'Btnsignup
        '
        Me.Btnsignup.BackColor = System.Drawing.Color.Black
        Me.Btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnsignup.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsignup.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Btnsignup.Location = New System.Drawing.Point(217, 143)
        Me.Btnsignup.Name = "Btnsignup"
        Me.Btnsignup.Size = New System.Drawing.Size(109, 30)
        Me.Btnsignup.TabIndex = 11
        Me.Btnsignup.Text = "Sign Up"
        Me.Btnsignup.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(672, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(108, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label4.Location = New System.Drawing.Point(311, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(449, 43)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Restaurant Management System"
        '
        'Btnlogin
        '
        Me.Btnlogin.BackColor = System.Drawing.Color.Black
        Me.Btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnlogin.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogin.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Btnlogin.Location = New System.Drawing.Point(39, 102)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(287, 35)
        Me.Btnlogin.TabIndex = 2
        Me.Btnlogin.Text = "Log In"
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "USERNAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PASSWORD:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Controls.Add(Me.TxtPass)
        Me.Panel1.Controls.Add(Me.Btnsignup)
        Me.Panel1.Controls.Add(Me.Btnforgetpass)
        Me.Panel1.Controls.Add(Me.TxtUser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Btnlogin)
        Me.Panel1.Location = New System.Drawing.Point(366, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 199)
        Me.Panel1.TabIndex = 12
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPass.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.Color.White
        Me.TxtPass.Location = New System.Drawing.Point(142, 58)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(166, 30)
        Me.TxtPass.TabIndex = 1
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUser.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtUser.Location = New System.Drawing.Point(142, 25)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(169, 30)
        Me.TxtUser.TabIndex = 0
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(792, 463)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(PictureBox1)
        Me.Controls.Add(Me.txtres)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "LogIn"
        Me.Text = "Log In"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtres As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Btnforgetpass As System.Windows.Forms.Button
    Friend WithEvents Btnsignup As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Btnlogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox

End Class
