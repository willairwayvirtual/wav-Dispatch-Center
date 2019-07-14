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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.fliginfo = New System.Windows.Forms.Button()
        Me.AircraftType = New System.Windows.Forms.Button()
        Me.PAYLOAD = New System.Windows.Forms.Button()
        Me.Route = New System.Windows.Forms.Button()
        Me.alternates = New System.Windows.Forms.Button()
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
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, -2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 62)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = " Dispatch a new flignt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(1, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(865, 42)
        Me.Panel1.TabIndex = 20
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Location = New System.Drawing.Point(2, 269)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(865, 51)
        Me.Panel5.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(2, 195)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 39)
        Me.Panel2.TabIndex = 25
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Location = New System.Drawing.Point(2, 355)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(867, 101)
        Me.Panel3.TabIndex = 29
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(2, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(253, 39)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "Search for Route"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Location = New System.Drawing.Point(3, 491)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(865, 101)
        Me.Panel6.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 31)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "let's dispatch this flignt"
        '
        'logout
        '
        Me.logout.Location = New System.Drawing.Point(3, 39)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(252, 34)
        Me.logout.TabIndex = 34
        Me.logout.Text = "logout"
        Me.logout.UseVisualStyleBackColor = True
        '
        'fliginfo
        '
        Me.fliginfo.BackColor = System.Drawing.Color.Silver
        Me.fliginfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fliginfo.Location = New System.Drawing.Point(1, 88)
        Me.fliginfo.Name = "fliginfo"
        Me.fliginfo.Size = New System.Drawing.Size(868, 23)
        Me.fliginfo.TabIndex = 35
        Me.fliginfo.Text = "fliginfo"
        Me.fliginfo.UseVisualStyleBackColor = False
        '
        'AircraftType
        '
        Me.AircraftType.BackColor = System.Drawing.Color.Silver
        Me.AircraftType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AircraftType.Location = New System.Drawing.Point(1, 166)
        Me.AircraftType.Name = "AircraftType"
        Me.AircraftType.Size = New System.Drawing.Size(884, 23)
        Me.AircraftType.TabIndex = 36
        Me.AircraftType.Text = "AircraftType"
        Me.AircraftType.UseVisualStyleBackColor = False
        '
        'PAYLOAD
        '
        Me.PAYLOAD.BackColor = System.Drawing.Color.Silver
        Me.PAYLOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PAYLOAD.Location = New System.Drawing.Point(1, 241)
        Me.PAYLOAD.Name = "PAYLOAD"
        Me.PAYLOAD.Size = New System.Drawing.Size(868, 23)
        Me.PAYLOAD.TabIndex = 37
        Me.PAYLOAD.Text = "PAYLOAD"
        Me.PAYLOAD.UseVisualStyleBackColor = False
        '
        'Route
        '
        Me.Route.BackColor = System.Drawing.Color.Silver
        Me.Route.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Route.Location = New System.Drawing.Point(1, 327)
        Me.Route.Name = "Route"
        Me.Route.Size = New System.Drawing.Size(865, 23)
        Me.Route.TabIndex = 38
        Me.Route.Text = "Route"
        Me.Route.UseVisualStyleBackColor = False
        '
        'alternates
        '
        Me.alternates.BackColor = System.Drawing.Color.Silver
        Me.alternates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.alternates.Location = New System.Drawing.Point(2, 462)
        Me.alternates.Name = "alternates"
        Me.alternates.Size = New System.Drawing.Size(867, 23)
        Me.alternates.TabIndex = 39
        Me.alternates.Text = "alternates"
        Me.alternates.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(866, 590)
        Me.Controls.Add(Me.alternates)
        Me.Controls.Add(Me.Route)
        Me.Controls.Add(Me.PAYLOAD)
        Me.Controls.Add(Me.AircraftType)
        Me.Controls.Add(Me.fliginfo)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents logout As Button
    Friend WithEvents fliginfo As Button
    Friend WithEvents AircraftType As Button
    Friend WithEvents PAYLOAD As Button
    Friend WithEvents Route As Button
    Friend WithEvents alternates As Button
End Class
