<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdiTajRoyal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdiTajRoyal))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignupItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogInMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FoodDetailsItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableDetailsItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FoodOrderItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignupItem, Me.LogInMenu, Me.ToolStripSeparator3, Me.FoodDetailsItem, Me.TableDetailsItem, Me.ToolStripSeparator4, Me.FoodOrderItem, Me.SalesInvoice, Me.PrintInvoice, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'SignupItem
        '
        Me.SignupItem.Image = CType(resources.GetObject("SignupItem.Image"), System.Drawing.Image)
        Me.SignupItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SignupItem.Name = "SignupItem"
        Me.SignupItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.SignupItem.Size = New System.Drawing.Size(187, 26)
        Me.SignupItem.Text = "&Signup"
        '
        'LogInMenu
        '
        Me.LogInMenu.Image = CType(resources.GetObject("LogInMenu.Image"), System.Drawing.Image)
        Me.LogInMenu.ImageTransparentColor = System.Drawing.Color.Black
        Me.LogInMenu.Name = "LogInMenu"
        Me.LogInMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.LogInMenu.Size = New System.Drawing.Size(187, 26)
        Me.LogInMenu.Text = "&Login"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(184, 6)
        '
        'FoodDetailsItem
        '
        Me.FoodDetailsItem.Image = CType(resources.GetObject("FoodDetailsItem.Image"), System.Drawing.Image)
        Me.FoodDetailsItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.FoodDetailsItem.Name = "FoodDetailsItem"
        Me.FoodDetailsItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.FoodDetailsItem.Size = New System.Drawing.Size(187, 26)
        Me.FoodDetailsItem.Text = "&Food Details"
        '
        'TableDetailsItem
        '
        Me.TableDetailsItem.Name = "TableDetailsItem"
        Me.TableDetailsItem.Size = New System.Drawing.Size(187, 26)
        Me.TableDetailsItem.Text = "&Table Details"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(184, 6)
        '
        'FoodOrderItem
        '
        Me.FoodOrderItem.Image = CType(resources.GetObject("FoodOrderItem.Image"), System.Drawing.Image)
        Me.FoodOrderItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.FoodOrderItem.Name = "FoodOrderItem"
        Me.FoodOrderItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.FoodOrderItem.Size = New System.Drawing.Size(187, 26)
        Me.FoodOrderItem.Text = "&Order Details"
        '
        'SalesInvoice
        '
        Me.SalesInvoice.Image = CType(resources.GetObject("SalesInvoice.Image"), System.Drawing.Image)
        Me.SalesInvoice.ImageTransparentColor = System.Drawing.Color.Black
        Me.SalesInvoice.Name = "SalesInvoice"
        Me.SalesInvoice.Size = New System.Drawing.Size(187, 26)
        Me.SalesInvoice.Text = "&Invoice"
        '
        'PrintInvoice
        '
        Me.PrintInvoice.Name = "PrintInvoice"
        Me.PrintInvoice.Size = New System.Drawing.Size(187, 26)
        Me.PrintInvoice.Text = "&Print Invoice"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(184, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(116, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(680, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MdiTajRoyal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taj_Royal_Restaurant.My.Resources.Resources.pexels_photo_958546
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 491)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MdiTajRoyal"
        Me.Text = "MdiTajRoyal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents SignupItem As ToolStripMenuItem
    Friend WithEvents LogInMenu As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents FoodDetailsItem As ToolStripMenuItem
    Friend WithEvents TableDetailsItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents FoodOrderItem As ToolStripMenuItem
    Friend WithEvents SalesInvoice As ToolStripMenuItem
    Friend WithEvents PrintInvoice As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenu As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
End Class
