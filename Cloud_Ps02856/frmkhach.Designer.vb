<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkhach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmkhach))
        Dim MA_KHLabel As System.Windows.Forms.Label
        Dim DIA_CHILabel As System.Windows.Forms.Label
        Dim TEN_KHLabel As System.Windows.Forms.Label
        Dim QUANLabel As System.Windows.Forms.Label
        Dim SDTLabel As System.Windows.Forms.Label
        Dim QUOC_GIALabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Me.KHACH_HANGBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.KHACH_HANGBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.KHACH_HANGDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KHACH_HANGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Cloud_Ps02856.DataSet1()
        Me.KHACH_HANGTableAdapter = New Cloud_Ps02856.DataSet1TableAdapters.KHACH_HANGTableAdapter()
        Me.TableAdapterManager = New Cloud_Ps02856.DataSet1TableAdapters.TableAdapterManager()
        Me.MA_KHTextBox = New System.Windows.Forms.TextBox()
        Me.DIA_CHITextBox = New System.Windows.Forms.TextBox()
        Me.TEN_KHTextBox = New System.Windows.Forms.TextBox()
        Me.QUANTextBox = New System.Windows.Forms.TextBox()
        Me.SDTTextBox = New System.Windows.Forms.TextBox()
        Me.QUOC_GIATextBox = New System.Windows.Forms.TextBox()
        Me.EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        MA_KHLabel = New System.Windows.Forms.Label()
        DIA_CHILabel = New System.Windows.Forms.Label()
        TEN_KHLabel = New System.Windows.Forms.Label()
        QUANLabel = New System.Windows.Forms.Label()
        SDTLabel = New System.Windows.Forms.Label()
        QUOC_GIALabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        CType(Me.KHACH_HANGBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KHACH_HANGBindingNavigator.SuspendLayout()
        CType(Me.KHACH_HANGDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KHACH_HANGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KHACH_HANGBindingNavigator
        '
        Me.KHACH_HANGBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KHACH_HANGBindingNavigator.BindingSource = Me.KHACH_HANGBindingSource
        Me.KHACH_HANGBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KHACH_HANGBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KHACH_HANGBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KHACH_HANGBindingNavigatorSaveItem})
        Me.KHACH_HANGBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.KHACH_HANGBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KHACH_HANGBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KHACH_HANGBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KHACH_HANGBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KHACH_HANGBindingNavigator.Name = "KHACH_HANGBindingNavigator"
        Me.KHACH_HANGBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KHACH_HANGBindingNavigator.Size = New System.Drawing.Size(774, 25)
        Me.KHACH_HANGBindingNavigator.TabIndex = 0
        Me.KHACH_HANGBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'KHACH_HANGBindingNavigatorSaveItem
        '
        Me.KHACH_HANGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KHACH_HANGBindingNavigatorSaveItem.Image = CType(resources.GetObject("KHACH_HANGBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KHACH_HANGBindingNavigatorSaveItem.Name = "KHACH_HANGBindingNavigatorSaveItem"
        Me.KHACH_HANGBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.KHACH_HANGBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KHACH_HANGDataGridView
        '
        Me.KHACH_HANGDataGridView.AutoGenerateColumns = False
        Me.KHACH_HANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KHACH_HANGDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.KHACH_HANGDataGridView.DataSource = Me.KHACH_HANGBindingSource
        Me.KHACH_HANGDataGridView.Location = New System.Drawing.Point(12, 172)
        Me.KHACH_HANGDataGridView.Name = "KHACH_HANGDataGridView"
        Me.KHACH_HANGDataGridView.Size = New System.Drawing.Size(742, 220)
        Me.KHACH_HANGDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MA_KH"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MA_KH"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DIA_CHI"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DIA_CHI"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TEN_KH"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TEN_KH"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "QUAN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "QUAN"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SDT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SDT"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "QUOC_GIA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "QUOC_GIA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'KHACH_HANGBindingSource
        '
        Me.KHACH_HANGBindingSource.DataMember = "KHACH_HANG"
        Me.KHACH_HANGBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KHACH_HANGTableAdapter
        '
        Me.KHACH_HANGTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KHACH_HANGTableAdapter = Me.KHACH_HANGTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cloud_Ps02856.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MA_KHLabel
        '
        MA_KHLabel.AutoSize = True
        MA_KHLabel.Location = New System.Drawing.Point(47, 44)
        MA_KHLabel.Name = "MA_KHLabel"
        MA_KHLabel.Size = New System.Drawing.Size(44, 13)
        MA_KHLabel.TabIndex = 2
        MA_KHLabel.Text = "MA KH:"
        '
        'MA_KHTextBox
        '
        Me.MA_KHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACH_HANGBindingSource, "MA_KH", True))
        Me.MA_KHTextBox.Location = New System.Drawing.Point(115, 41)
        Me.MA_KHTextBox.Name = "MA_KHTextBox"
        Me.MA_KHTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MA_KHTextBox.TabIndex = 3
        '
        'DIA_CHILabel
        '
        DIA_CHILabel.AutoSize = True
        DIA_CHILabel.Location = New System.Drawing.Point(47, 70)
        DIA_CHILabel.Name = "DIA_CHILabel"
        DIA_CHILabel.Size = New System.Drawing.Size(49, 13)
        DIA_CHILabel.TabIndex = 4
        DIA_CHILabel.Text = "DIA CHI:"
        '
        'DIA_CHITextBox
        '
        Me.DIA_CHITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACH_HANGBindingSource, "DIA_CHI", True))
        Me.DIA_CHITextBox.Location = New System.Drawing.Point(115, 67)
        Me.DIA_CHITextBox.Name = "DIA_CHITextBox"
        Me.DIA_CHITextBox.Size = New System.Drawing.Size(100, 20)
        Me.DIA_CHITextBox.TabIndex = 5
        '
        'TEN_KHLabel
        '
        TEN_KHLabel.AutoSize = True
        TEN_KHLabel.Location = New System.Drawing.Point(47, 96)
        TEN_KHLabel.Name = "TEN_KHLabel"
        TEN_KHLabel.Size = New System.Drawing.Size(50, 13)
        TEN_KHLabel.TabIndex = 6
        TEN_KHLabel.Text = "TEN KH:"
        '
        'TEN_KHTextBox
        '
        Me.TEN_KHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACH_HANGBindingSource, "TEN_KH", True))
        Me.TEN_KHTextBox.Location = New System.Drawing.Point(115, 93)
        Me.TEN_KHTextBox.Name = "TEN_KHTextBox"
        Me.TEN_KHTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TEN_KHTextBox.TabIndex = 7
        '
        'QUANLabel
        '
        QUANLabel.AutoSize = True
        QUANLabel.Location = New System.Drawing.Point(263, 44)
        QUANLabel.Name = "QUANLabel"
        QUANLabel.Size = New System.Drawing.Size(41, 13)
        QUANLabel.TabIndex = 8
        QUANLabel.Text = "QUAN:"
        '
        'QUANTextBox
        '
        Me.QUANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACH_HANGBindingSource, "QUAN", True))
        Me.QUANTextBox.Location = New System.Drawing.Point(331, 41)
        Me.QUANTextBox.Name = "QUANTextBox"
        Me.QUANTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUANTextBox.TabIndex = 9
        '
        'SDTLabel
        '
        SDTLabel.AutoSize = True
        SDTLabel.Location = New System.Drawing.Point(263, 70)
        SDTLabel.Name = "SDTLabel"
        SDTLabel.Size = New System.Drawing.Size(32, 13)
        SDTLabel.TabIndex = 10
        SDTLabel.Text = "SDT:"
        '
        'SDTTextBox
        '
        Me.SDTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACH_HANGBindingSource, "SDT", True))
        Me.SDTTextBox.Location = New System.Drawing.Point(331, 67)
        Me.SDTTextBox.Name = "SDTTextBox"
        Me.SDTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SDTTextBox.TabIndex = 11
        '
        'QUOC_GIALabel
        '
        QUOC_GIALabel.AutoSize = True
        QUOC_GIALabel.Location = New System.Drawing.Point(263, 96)
        QUOC_GIALabel.Name = "QUOC_GIALabel"
        QUOC_GIALabel.Size = New System.Drawing.Size(62, 13)
        QUOC_GIALabel.TabIndex = 12
        QUOC_GIALabel.Text = "QUOC GIA:"
        '
        'QUOC_GIATextBox
        '
        Me.QUOC_GIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACH_HANGBindingSource, "QUOC_GIA", True))
        Me.QUOC_GIATextBox.Location = New System.Drawing.Point(331, 93)
        Me.QUOC_GIATextBox.Name = "QUOC_GIATextBox"
        Me.QUOC_GIATextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUOC_GIATextBox.TabIndex = 13
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(263, 122)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(42, 13)
        EMAILLabel.TabIndex = 14
        EMAILLabel.Text = "EMAIL:"
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KHACH_HANGBindingSource, "EMAIL", True))
        Me.EMAILTextBox.Location = New System.Drawing.Point(331, 119)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EMAILTextBox.TabIndex = 15
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(474, 70)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(63, 43)
        Me.btnadd.TabIndex = 16
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(565, 70)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(63, 43)
        Me.btnsave.TabIndex = 16
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(651, 70)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(63, 43)
        Me.btndelete.TabIndex = 16
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'frmkhach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 403)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(MA_KHLabel)
        Me.Controls.Add(Me.MA_KHTextBox)
        Me.Controls.Add(DIA_CHILabel)
        Me.Controls.Add(Me.DIA_CHITextBox)
        Me.Controls.Add(TEN_KHLabel)
        Me.Controls.Add(Me.TEN_KHTextBox)
        Me.Controls.Add(QUANLabel)
        Me.Controls.Add(Me.QUANTextBox)
        Me.Controls.Add(SDTLabel)
        Me.Controls.Add(Me.SDTTextBox)
        Me.Controls.Add(QUOC_GIALabel)
        Me.Controls.Add(Me.QUOC_GIATextBox)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.EMAILTextBox)
        Me.Controls.Add(Me.KHACH_HANGDataGridView)
        Me.Controls.Add(Me.KHACH_HANGBindingNavigator)
        Me.Name = "frmkhach"
        Me.Text = "frmkhach"
        CType(Me.KHACH_HANGBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KHACH_HANGBindingNavigator.ResumeLayout(False)
        Me.KHACH_HANGBindingNavigator.PerformLayout()
        CType(Me.KHACH_HANGDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KHACH_HANGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents KHACH_HANGBindingSource As BindingSource
    Friend WithEvents KHACH_HANGTableAdapter As DataSet1TableAdapters.KHACH_HANGTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents KHACH_HANGBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents KHACH_HANGBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents KHACH_HANGDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents MA_KHTextBox As TextBox
    Friend WithEvents DIA_CHITextBox As TextBox
    Friend WithEvents TEN_KHTextBox As TextBox
    Friend WithEvents QUANTextBox As TextBox
    Friend WithEvents SDTTextBox As TextBox
    Friend WithEvents QUOC_GIATextBox As TextBox
    Friend WithEvents EMAILTextBox As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btndelete As Button
End Class
