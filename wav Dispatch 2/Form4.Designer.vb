<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportingtimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlightNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepArptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepGateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrArptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrGateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeOfOperationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepfltdeckBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WillairwayvirtualDbv1DataSet = New wav_Dispatch_2.willairwayvirtualDbv1DataSet()
        Me.RepfltdeckTableAdapter = New wav_Dispatch_2.willairwayvirtualDbv1DataSetTableAdapters.repfltdeckTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepfltdeckBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WillairwayvirtualDbv1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.ReportingtimeDataGridViewTextBoxColumn, Me.FlightNumberDataGridViewTextBoxColumn, Me.DepArptDataGridViewTextBoxColumn, Me.DepGateDataGridViewTextBoxColumn, Me.ArrArptDataGridViewTextBoxColumn, Me.ArrGateDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TypeOfOperationDataGridViewTextBoxColumn, Me.OperationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RepfltdeckBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(2, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1362, 300)
        Me.DataGridView1.TabIndex = 0
        '
        'UnameDataGridViewTextBoxColumn
        '
        Me.UnameDataGridViewTextBoxColumn.DataPropertyName = "Uname"
        Me.UnameDataGridViewTextBoxColumn.HeaderText = "Uname"
        Me.UnameDataGridViewTextBoxColumn.Name = "UnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'ReportingtimeDataGridViewTextBoxColumn
        '
        Me.ReportingtimeDataGridViewTextBoxColumn.DataPropertyName = "reportingtime"
        Me.ReportingtimeDataGridViewTextBoxColumn.HeaderText = "reportingtime"
        Me.ReportingtimeDataGridViewTextBoxColumn.Name = "ReportingtimeDataGridViewTextBoxColumn"
        '
        'FlightNumberDataGridViewTextBoxColumn
        '
        Me.FlightNumberDataGridViewTextBoxColumn.DataPropertyName = "flightNumber"
        Me.FlightNumberDataGridViewTextBoxColumn.HeaderText = "flightNumber"
        Me.FlightNumberDataGridViewTextBoxColumn.Name = "FlightNumberDataGridViewTextBoxColumn"
        '
        'DepArptDataGridViewTextBoxColumn
        '
        Me.DepArptDataGridViewTextBoxColumn.DataPropertyName = "DepArpt"
        Me.DepArptDataGridViewTextBoxColumn.HeaderText = "DepArpt"
        Me.DepArptDataGridViewTextBoxColumn.Name = "DepArptDataGridViewTextBoxColumn"
        '
        'DepGateDataGridViewTextBoxColumn
        '
        Me.DepGateDataGridViewTextBoxColumn.DataPropertyName = "DepGate"
        Me.DepGateDataGridViewTextBoxColumn.HeaderText = "DepGate"
        Me.DepGateDataGridViewTextBoxColumn.Name = "DepGateDataGridViewTextBoxColumn"
        '
        'ArrArptDataGridViewTextBoxColumn
        '
        Me.ArrArptDataGridViewTextBoxColumn.DataPropertyName = "ArrArpt"
        Me.ArrArptDataGridViewTextBoxColumn.HeaderText = "ArrArpt"
        Me.ArrArptDataGridViewTextBoxColumn.Name = "ArrArptDataGridViewTextBoxColumn"
        '
        'ArrGateDataGridViewTextBoxColumn
        '
        Me.ArrGateDataGridViewTextBoxColumn.DataPropertyName = "ArrGate"
        Me.ArrGateDataGridViewTextBoxColumn.HeaderText = "ArrGate"
        Me.ArrGateDataGridViewTextBoxColumn.Name = "ArrGateDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'TypeOfOperationDataGridViewTextBoxColumn
        '
        Me.TypeOfOperationDataGridViewTextBoxColumn.DataPropertyName = "type of operation"
        Me.TypeOfOperationDataGridViewTextBoxColumn.HeaderText = "type of operation"
        Me.TypeOfOperationDataGridViewTextBoxColumn.Name = "TypeOfOperationDataGridViewTextBoxColumn"
        '
        'OperationDataGridViewTextBoxColumn
        '
        Me.OperationDataGridViewTextBoxColumn.DataPropertyName = "operation"
        Me.OperationDataGridViewTextBoxColumn.HeaderText = "operation"
        Me.OperationDataGridViewTextBoxColumn.Name = "OperationDataGridViewTextBoxColumn"
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(432, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Dispatch a new flignt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(440, 307)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(476, 54)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Flight Briefing Package"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(922, 307)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(442, 54)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "log out"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 382)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepfltdeckBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WillairwayvirtualDbv1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents WillairwayvirtualDbv1DataSet As willairwayvirtualDbv1DataSet
    Friend WithEvents RepfltdeckBindingSource As BindingSource
    Friend WithEvents RepfltdeckTableAdapter As willairwayvirtualDbv1DataSetTableAdapters.repfltdeckTableAdapter
    Friend WithEvents UnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportingtimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlightNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepArptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepGateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArrArptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArrGateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeOfOperationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OperationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
