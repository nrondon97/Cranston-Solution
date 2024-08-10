<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.txtIncrease = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRaspberry = New System.Windows.Forms.TextBox()
        Me.txtBlueberries = New System.Windows.Forms.TextBox()
        Me.txtStrawberry = New System.Windows.Forms.TextBox()
        Me.lblStrawberry = New System.Windows.Forms.TextBox()
        Me.lblBlueberries = New System.Windows.Forms.TextBox()
        Me.lblRaspberry = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'txtIncrease
        '
        Me.txtIncrease.Location = New System.Drawing.Point(235, 15)
        Me.txtIncrease.Name = "txtIncrease"
        Me.txtIncrease.Size = New System.Drawing.Size(47, 20)
        Me.txtIncrease.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Projected &Increase % (In Decimal Form):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Strawberries:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Blueberries:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Raspberries:"
        '
        'txtRaspberry
        '
        Me.txtRaspberry.Location = New System.Drawing.Point(92, 152)
        Me.txtRaspberry.Name = "txtRaspberry"
        Me.txtRaspberry.Size = New System.Drawing.Size(86, 20)
        Me.txtRaspberry.TabIndex = 7
        '
        'txtBlueberries
        '
        Me.txtBlueberries.Location = New System.Drawing.Point(92, 120)
        Me.txtBlueberries.Name = "txtBlueberries"
        Me.txtBlueberries.Size = New System.Drawing.Size(86, 20)
        Me.txtBlueberries.TabIndex = 5
        '
        'txtStrawberry
        '
        Me.txtStrawberry.Location = New System.Drawing.Point(92, 87)
        Me.txtStrawberry.Name = "txtStrawberry"
        Me.txtStrawberry.Size = New System.Drawing.Size(86, 20)
        Me.txtStrawberry.TabIndex = 3
        '
        'lblStrawberry
        '
        Me.lblStrawberry.BackColor = System.Drawing.SystemColors.Control
        Me.lblStrawberry.Location = New System.Drawing.Point(188, 87)
        Me.lblStrawberry.Name = "lblStrawberry"
        Me.lblStrawberry.ReadOnly = True
        Me.lblStrawberry.Size = New System.Drawing.Size(86, 20)
        Me.lblStrawberry.TabIndex = 12
        '
        'lblBlueberries
        '
        Me.lblBlueberries.BackColor = System.Drawing.SystemColors.Control
        Me.lblBlueberries.Location = New System.Drawing.Point(188, 120)
        Me.lblBlueberries.Name = "lblBlueberries"
        Me.lblBlueberries.ReadOnly = True
        Me.lblBlueberries.Size = New System.Drawing.Size(86, 20)
        Me.lblBlueberries.TabIndex = 13
        '
        'lblRaspberry
        '
        Me.lblRaspberry.BackColor = System.Drawing.SystemColors.Control
        Me.lblRaspberry.Location = New System.Drawing.Point(188, 152)
        Me.lblRaspberry.Name = "lblRaspberry"
        Me.lblRaspberry.ReadOnly = True
        Me.lblRaspberry.Size = New System.Drawing.Size(86, 20)
        Me.lblRaspberry.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(89, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Current Sales:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(185, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Projected Sales:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(5, 211)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(86, 211)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(167, 211)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(248, 211)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblStrawberry)
        Me.Controls.Add(Me.lblBlueberries)
        Me.Controls.Add(Me.lblRaspberry)
        Me.Controls.Add(Me.txtStrawberry)
        Me.Controls.Add(Me.txtBlueberries)
        Me.Controls.Add(Me.txtRaspberry)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIncrease)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cranston Berries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIncrease As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRaspberry As TextBox
    Friend WithEvents txtBlueberries As TextBox
    Friend WithEvents txtStrawberry As TextBox
    Friend WithEvents lblStrawberry As TextBox
    Friend WithEvents lblBlueberries As TextBox
    Friend WithEvents lblRaspberry As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
