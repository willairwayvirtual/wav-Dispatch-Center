<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RepfltdeckBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WillairwayvirtualDbv1DataSet = New wav_Dispatch_2.willairwayvirtualDbv1DataSet()
        Me.RepfltdeckTableAdapter = New wav_Dispatch_2.willairwayvirtualDbv1DataSetTableAdapters.repfltdeckTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        CType(Me.RepfltdeckBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WillairwayvirtualDbv1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.DateTimePicker1)
        Me.Panel5.Location = New System.Drawing.Point(-1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1231, 47)
        Me.Panel5.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(542, 37)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Welcome to the wav Dispatch Center"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.AllowDrop = True
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(939, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(273, 40)
        Me.DateTimePicker1.TabIndex = 82
        '
        'RepfltdeckBindingSource
        '
        Me.RepfltdeckBindingSource.DataMember = "repfltdeck"
        Me.RepfltdeckBindingSource.DataSource = Me.WillairwayvirtualDbv1DataSet
        '
        'WillairwayvirtualDbv1DataSet
        '
        Me.WillairwayvirtualDbv1DataSet.DataSetName = "willairwayvirtualDbv1DataSet"
        Me.WillairwayvirtualDbv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepfltdeckTableAdapter
        '
        Me.RepfltdeckTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(396, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(406, 39)
        Me.Button2.TabIndex = 86
        Me.Button2.Text = "go to  Flight Briefing Center"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-1, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(411, 39)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Create new FlightPlan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(799, 46)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(431, 39)
        Me.Button3.TabIndex = 88
        Me.Button3.Text = "logout"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 80)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "wav Dispatch menu"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.RepfltdeckBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WillairwayvirtualDbv1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents WillairwayvirtualDbv1DataSet As willairwayvirtualDbv1DataSet
    Friend WithEvents RepfltdeckBindingSource As BindingSource
    Friend WithEvents RepfltdeckTableAdapter As willairwayvirtualDbv1DataSetTableAdapters.repfltdeckTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
End Class
