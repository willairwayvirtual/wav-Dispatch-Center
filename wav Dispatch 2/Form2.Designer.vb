<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(411, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 74)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = " Dispatch a new flignt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(-19, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(887, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "fliginfo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(1, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(865, 42)
        Me.Panel1.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(865, 24)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "AircraftType"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(1, 242)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(865, 51)
        Me.Panel5.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(2, 168)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 39)
        Me.Panel2.TabIndex = 25
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(2, 213)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(865, 23)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "PAYLOAD"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1, 299)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(865, 23)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "Route"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(1, 328)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(865, 101)
        Me.Panel3.TabIndex = 29
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(2, 435)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(866, 23)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "alternates"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(2, 464)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(865, 101)
        Me.Panel6.TabIndex = 31
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(2, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(159, 45)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "Search for Route"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(884, 557)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button7 As Button
End Class
