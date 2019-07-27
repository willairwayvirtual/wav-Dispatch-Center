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
        Me.Button72 = New System.Windows.Forms.Button()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
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
        'Button72
        '
        Me.Button72.Location = New System.Drawing.Point(657, 0)
        Me.Button72.Name = "Button72"
        Me.Button72.Size = New System.Drawing.Size(225, 60)
        Me.Button72.TabIndex = 32
        Me.Button72.Text = "Search for Route"
        Me.Button72.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Location = New System.Drawing.Point(4, 558)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(881, 98)
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
        Me.logout.Location = New System.Drawing.Point(-6, 0)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(262, 60)
        Me.logout.TabIndex = 34
        Me.logout.Text = "logout"
        Me.logout.UseVisualStyleBackColor = True
        '
        'fliginfo
        '
        Me.fliginfo.BackColor = System.Drawing.Color.DimGray
        Me.fliginfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fliginfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fliginfo.ForeColor = System.Drawing.Color.DarkRed
        Me.fliginfo.Location = New System.Drawing.Point(-6, 63)
        Me.fliginfo.Name = "fliginfo"
        Me.fliginfo.Size = New System.Drawing.Size(888, 30)
        Me.fliginfo.TabIndex = 35
        Me.fliginfo.Text = "fliginfo"
        Me.fliginfo.UseVisualStyleBackColor = False
        '
        'AircraftType
        '
        Me.AircraftType.BackColor = System.Drawing.Color.DimGray
        Me.AircraftType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AircraftType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AircraftType.ForeColor = System.Drawing.Color.DarkRed
        Me.AircraftType.Location = New System.Drawing.Point(1, 155)
        Me.AircraftType.Name = "AircraftType"
        Me.AircraftType.Size = New System.Drawing.Size(888, 31)
        Me.AircraftType.TabIndex = 36
        Me.AircraftType.Text = "AircraftType"
        Me.AircraftType.UseVisualStyleBackColor = False
        '
        'PAYLOAD
        '
        Me.PAYLOAD.BackColor = System.Drawing.Color.DimGray
        Me.PAYLOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PAYLOAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAYLOAD.ForeColor = System.Drawing.Color.DarkRed
        Me.PAYLOAD.Location = New System.Drawing.Point(0, 259)
        Me.PAYLOAD.Name = "PAYLOAD"
        Me.PAYLOAD.Size = New System.Drawing.Size(882, 31)
        Me.PAYLOAD.TabIndex = 37
        Me.PAYLOAD.Text = "PAYLOAD"
        Me.PAYLOAD.UseVisualStyleBackColor = False
        '
        'Route
        '
        Me.Route.BackColor = System.Drawing.Color.DimGray
        Me.Route.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Route.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Route.ForeColor = System.Drawing.Color.DarkRed
        Me.Route.Location = New System.Drawing.Point(0, 363)
        Me.Route.Name = "Route"
        Me.Route.Size = New System.Drawing.Size(882, 33)
        Me.Route.TabIndex = 38
        Me.Route.Text = "Route"
        Me.Route.UseVisualStyleBackColor = False
        '
        'alternates
        '
        Me.alternates.BackColor = System.Drawing.Color.DimGray
        Me.alternates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.alternates.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alternates.ForeColor = System.Drawing.Color.DarkRed
        Me.alternates.Location = New System.Drawing.Point(0, 514)
        Me.alternates.Name = "alternates"
        Me.alternates.Size = New System.Drawing.Size(889, 38)
        Me.alternates.TabIndex = 39
        Me.alternates.Text = "alternates"
        Me.alternates.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(1, 402)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 106)
        Me.Panel1.TabIndex = 40
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(0, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(882, 61)
        Me.Panel2.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Location = New System.Drawing.Point(-21, 192)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(903, 61)
        Me.Panel3.TabIndex = 42
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Location = New System.Drawing.Point(0, 99)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(882, 50)
        Me.Panel4.TabIndex = 43
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(878, 684)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.alternates)
        Me.Controls.Add(Me.Route)
        Me.Controls.Add(Me.PAYLOAD)
        Me.Controls.Add(Me.AircraftType)
        Me.Controls.Add(Me.fliginfo)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button72)
        Me.Controls.Add(Me.Panel6)
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
    Friend WithEvents Button72 As Button
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
