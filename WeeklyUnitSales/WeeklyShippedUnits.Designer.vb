<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWeeklyUnitShipped
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbUnits = New System.Windows.Forms.TextBox()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.lbDays = New System.Windows.Forms.Label()
        Me.lbWeekly = New System.Windows.Forms.Label()
        Me.lbShipment = New System.Windows.Forms.Label()
        Me.tbUnitStored1 = New System.Windows.Forms.TextBox()
        Me.tbUnitStored2 = New System.Windows.Forms.TextBox()
        Me.tbUnitStored3 = New System.Windows.Forms.TextBox()
        Me.lbEmployee1 = New System.Windows.Forms.Label()
        Me.lbEmployee2 = New System.Windows.Forms.Label()
        Me.lbEmployee3 = New System.Windows.Forms.Label()
        Me.lbEmployeeAverage1 = New System.Windows.Forms.Label()
        Me.lbEmployeeAverage2 = New System.Windows.Forms.Label()
        Me.lbEmployeeAverage3 = New System.Windows.Forms.Label()
        Me.lbAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(118, 327)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(76, 28)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(200, 327)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 28)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(282, 327)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 28)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbUnits
        '
        Me.tbUnits.Location = New System.Drawing.Point(72, 94)
        Me.tbUnits.Name = "tbUnits"
        Me.tbUnits.Size = New System.Drawing.Size(76, 20)
        Me.tbUnits.TabIndex = 0
        '
        'lbUnits
        '
        Me.lbUnits.AutoSize = True
        Me.lbUnits.Location = New System.Drawing.Point(32, 97)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(34, 13)
        Me.lbUnits.TabIndex = 6
        Me.lbUnits.Text = "Units:"
        '
        'lbDays
        '
        Me.lbDays.AutoSize = True
        Me.lbDays.Location = New System.Drawing.Point(173, 97)
        Me.lbDays.Name = "lbDays"
        Me.lbDays.Size = New System.Drawing.Size(35, 13)
        Me.lbDays.TabIndex = 8
        Me.lbDays.Text = "Day 1"
        '
        'lbWeekly
        '
        Me.lbWeekly.AutoSize = True
        Me.lbWeekly.Font = New System.Drawing.Font("Times New Roman", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lbWeekly.Location = New System.Drawing.Point(65, 9)
        Me.lbWeekly.Name = "lbWeekly"
        Me.lbWeekly.Size = New System.Drawing.Size(123, 38)
        Me.lbWeekly.TabIndex = 10
        Me.lbWeekly.Text = "Weekly"
        '
        'lbShipment
        '
        Me.lbShipment.AutoSize = True
        Me.lbShipment.Font = New System.Drawing.Font("Times New Roman", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lbShipment.Location = New System.Drawing.Point(148, 48)
        Me.lbShipment.Name = "lbShipment"
        Me.lbShipment.Size = New System.Drawing.Size(157, 38)
        Me.lbShipment.TabIndex = 10
        Me.lbShipment.Text = "Shipment"
        '
        'tbUnitStored1
        '
        Me.tbUnitStored1.Location = New System.Drawing.Point(12, 142)
        Me.tbUnitStored1.Multiline = True
        Me.tbUnitStored1.Name = "tbUnitStored1"
        Me.tbUnitStored1.ReadOnly = True
        Me.tbUnitStored1.Size = New System.Drawing.Size(111, 119)
        Me.tbUnitStored1.TabIndex = 11
        '
        'tbUnitStored2
        '
        Me.tbUnitStored2.Location = New System.Drawing.Point(129, 142)
        Me.tbUnitStored2.Multiline = True
        Me.tbUnitStored2.Name = "tbUnitStored2"
        Me.tbUnitStored2.ReadOnly = True
        Me.tbUnitStored2.Size = New System.Drawing.Size(111, 119)
        Me.tbUnitStored2.TabIndex = 12
        '
        'tbUnitStored3
        '
        Me.tbUnitStored3.Location = New System.Drawing.Point(246, 142)
        Me.tbUnitStored3.Multiline = True
        Me.tbUnitStored3.Name = "tbUnitStored3"
        Me.tbUnitStored3.ReadOnly = True
        Me.tbUnitStored3.Size = New System.Drawing.Size(112, 119)
        Me.tbUnitStored3.TabIndex = 13
        '
        'lbEmployee1
        '
        Me.lbEmployee1.AutoSize = True
        Me.lbEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmployee1.Location = New System.Drawing.Point(43, 126)
        Me.lbEmployee1.Name = "lbEmployee1"
        Me.lbEmployee1.Size = New System.Drawing.Size(72, 13)
        Me.lbEmployee1.TabIndex = 14
        Me.lbEmployee1.Text = "Employee 1"
        '
        'lbEmployee2
        '
        Me.lbEmployee2.AutoSize = True
        Me.lbEmployee2.Location = New System.Drawing.Point(158, 126)
        Me.lbEmployee2.Name = "lbEmployee2"
        Me.lbEmployee2.Size = New System.Drawing.Size(62, 13)
        Me.lbEmployee2.TabIndex = 15
        Me.lbEmployee2.Text = "Employee 2"
        '
        'lbEmployee3
        '
        Me.lbEmployee3.AutoSize = True
        Me.lbEmployee3.Location = New System.Drawing.Point(269, 126)
        Me.lbEmployee3.Name = "lbEmployee3"
        Me.lbEmployee3.Size = New System.Drawing.Size(62, 13)
        Me.lbEmployee3.TabIndex = 16
        Me.lbEmployee3.Text = "Employee 3"
        '
        'lbEmployeeAverage1
        '
        Me.lbEmployeeAverage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeAverage1.Location = New System.Drawing.Point(12, 264)
        Me.lbEmployeeAverage1.Name = "lbEmployeeAverage1"
        Me.lbEmployeeAverage1.Size = New System.Drawing.Size(111, 23)
        Me.lbEmployeeAverage1.TabIndex = 17
        Me.lbEmployeeAverage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbEmployeeAverage2
        '
        Me.lbEmployeeAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeAverage2.Location = New System.Drawing.Point(129, 264)
        Me.lbEmployeeAverage2.Name = "lbEmployeeAverage2"
        Me.lbEmployeeAverage2.Size = New System.Drawing.Size(111, 23)
        Me.lbEmployeeAverage2.TabIndex = 18
        Me.lbEmployeeAverage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbEmployeeAverage3
        '
        Me.lbEmployeeAverage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbEmployeeAverage3.Location = New System.Drawing.Point(246, 264)
        Me.lbEmployeeAverage3.Name = "lbEmployeeAverage3"
        Me.lbEmployeeAverage3.Size = New System.Drawing.Size(112, 23)
        Me.lbEmployeeAverage3.TabIndex = 19
        Me.lbEmployeeAverage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbAverage
        '
        Me.lbAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverage.Location = New System.Drawing.Point(12, 297)
        Me.lbAverage.Name = "lbAverage"
        Me.lbAverage.Size = New System.Drawing.Size(346, 20)
        Me.lbAverage.TabIndex = 20
        Me.lbAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWeeklyUnitShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(373, 367)
        Me.Controls.Add(Me.lbAverage)
        Me.Controls.Add(Me.lbEmployeeAverage3)
        Me.Controls.Add(Me.lbEmployeeAverage2)
        Me.Controls.Add(Me.lbEmployeeAverage1)
        Me.Controls.Add(Me.lbEmployee3)
        Me.Controls.Add(Me.lbEmployee2)
        Me.Controls.Add(Me.lbEmployee1)
        Me.Controls.Add(Me.tbUnitStored3)
        Me.Controls.Add(Me.tbUnitStored2)
        Me.Controls.Add(Me.tbUnitStored1)
        Me.Controls.Add(Me.lbShipment)
        Me.Controls.Add(Me.lbWeekly)
        Me.Controls.Add(Me.lbDays)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.tbUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWeeklyUnitShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbUnits As TextBox
    Friend WithEvents lbUnits As Label
    Friend WithEvents lbDays As Label
    Friend WithEvents lbWeekly As Label
    Friend WithEvents lbShipment As Label
    Friend WithEvents tbUnitStored1 As TextBox
    Friend WithEvents tbUnitStored2 As TextBox
    Friend WithEvents tbUnitStored3 As TextBox
    Friend WithEvents lbEmployee1 As Label
    Friend WithEvents lbEmployee2 As Label
    Friend WithEvents lbEmployee3 As Label
    Friend WithEvents lbEmployeeAverage1 As Label
    Friend WithEvents lbEmployeeAverage2 As Label
    Friend WithEvents lbEmployeeAverage3 As Label
    Friend WithEvents lbAverage As Label
End Class
