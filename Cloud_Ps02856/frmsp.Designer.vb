<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsp))
        Dim MA_SANPHAMLabel As System.Windows.Forms.Label
        Dim TEN_SANPHAMLabel As System.Windows.Forms.Label
        Dim LOAI_SANPHAMLabel As System.Windows.Forms.Label
        Dim XUAT_SULabel As System.Windows.Forms.Label
        Dim XN_LSPLabel As System.Windows.Forms.Label
        Dim THONG_TINLabel As System.Windows.Forms.Label
        Dim HINH_ANHLabel As System.Windows.Forms.Label
        Dim CHI_TIETLabel As System.Windows.Forms.Label
        Me.DataSet2 = New Cloud_Ps02856.DataSet2()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New Cloud_Ps02856.DataSet2TableAdapters.DataTable1TableAdapter()
        Me.TableAdapterManager = New Cloud_Ps02856.DataSet2TableAdapters.TableAdapterManager()
        Me.DataTable1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DataTable1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataTable1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MA_SANPHAMTextBox = New System.Windows.Forms.TextBox()
        Me.TEN_SANPHAMTextBox = New System.Windows.Forms.TextBox()
        Me.LOAI_SANPHAMTextBox = New System.Windows.Forms.TextBox()
        Me.XUAT_SUTextBox = New System.Windows.Forms.TextBox()
        Me.XN_LSPTextBox = New System.Windows.Forms.TextBox()
        Me.THONG_TINTextBox = New System.Windows.Forms.TextBox()
        Me.HINH_ANHTextBox = New System.Windows.Forms.TextBox()
        Me.CHI_TIETTextBox = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        MA_SANPHAMLabel = New System.Windows.Forms.Label()
        TEN_SANPHAMLabel = New System.Windows.Forms.Label()
        LOAI_SANPHAMLabel = New System.Windows.Forms.Label()
        XUAT_SULabel = New System.Windows.Forms.Label()
        XN_LSPLabel = New System.Windows.Forms.Label()
        THONG_TINLabel = New System.Windows.Forms.Label()
        HINH_ANHLabel = New System.Windows.Forms.Label()
        CHI_TIETLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataTable1BindingNavigator.SuspendLayout()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSet2
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Cloud_Ps02856.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataTable1BindingNavigator
        '
        Me.DataTable1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DataTable1BindingNavigator.BindingSource = Me.DataTable1BindingSource
        Me.DataTable1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DataTable1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DataTable1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DataTable1BindingNavigatorSaveItem})
        Me.DataTable1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DataTable1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DataTable1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DataTable1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DataTable1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DataTable1BindingNavigator.Name = "DataTable1BindingNavigator"
        Me.DataTable1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DataTable1BindingNavigator.Size = New System.Drawing.Size(943, 25)
        Me.DataTable1BindingNavigator.TabIndex = 0
        Me.DataTable1BindingNavigator.Text = "BindingNavigator1"
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
        'DataTable1BindingNavigatorSaveItem
        '
        Me.DataTable1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DataTable1BindingNavigatorSaveItem.Enabled = False
        Me.DataTable1BindingNavigatorSaveItem.Image = CType(resources.GetObject("DataTable1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DataTable1BindingNavigatorSaveItem.Name = "DataTable1BindingNavigatorSaveItem"
        Me.DataTable1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DataTable1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'DataTable1DataGridView
        '
        Me.DataTable1DataGridView.AutoGenerateColumns = False
        Me.DataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTable1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataTable1DataGridView.DataSource = Me.DataTable1BindingSource
        Me.DataTable1DataGridView.Location = New System.Drawing.Point(12, 222)
        Me.DataTable1DataGridView.Name = "DataTable1DataGridView"
        Me.DataTable1DataGridView.Size = New System.Drawing.Size(908, 220)
        Me.DataTable1DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MA_SANPHAM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MA_SANPHAM"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TEN_SANPHAM"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TEN_SANPHAM"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LOAI_SANPHAM"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LOAI_SANPHAM"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "XUAT_SU"
        Me.DataGridViewTextBoxColumn4.HeaderText = "XUAT_SU"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "XN_LSP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "XN_LSP"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "THONG_TIN"
        Me.DataGridViewTextBoxColumn6.HeaderText = "THONG_TIN"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "HINH_ANH"
        Me.DataGridViewTextBoxColumn7.HeaderText = "HINH_ANH"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CHI_TIET"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CHI_TIET"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'MA_SANPHAMLabel
        '
        MA_SANPHAMLabel.AutoSize = True
        MA_SANPHAMLabel.Location = New System.Drawing.Point(46, 76)
        MA_SANPHAMLabel.Name = "MA_SANPHAMLabel"
        MA_SANPHAMLabel.Size = New System.Drawing.Size(82, 13)
        MA_SANPHAMLabel.TabIndex = 2
        MA_SANPHAMLabel.Text = "MA SANPHAM:"
        '
        'MA_SANPHAMTextBox
        '
        Me.MA_SANPHAMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "MA_SANPHAM", True))
        Me.MA_SANPHAMTextBox.Location = New System.Drawing.Point(142, 73)
        Me.MA_SANPHAMTextBox.Name = "MA_SANPHAMTextBox"
        Me.MA_SANPHAMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MA_SANPHAMTextBox.TabIndex = 3
        '
        'TEN_SANPHAMLabel
        '
        TEN_SANPHAMLabel.AutoSize = True
        TEN_SANPHAMLabel.Location = New System.Drawing.Point(46, 102)
        TEN_SANPHAMLabel.Name = "TEN_SANPHAMLabel"
        TEN_SANPHAMLabel.Size = New System.Drawing.Size(88, 13)
        TEN_SANPHAMLabel.TabIndex = 4
        TEN_SANPHAMLabel.Text = "TEN SANPHAM:"
        '
        'TEN_SANPHAMTextBox
        '
        Me.TEN_SANPHAMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "TEN_SANPHAM", True))
        Me.TEN_SANPHAMTextBox.Location = New System.Drawing.Point(142, 99)
        Me.TEN_SANPHAMTextBox.Name = "TEN_SANPHAMTextBox"
        Me.TEN_SANPHAMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TEN_SANPHAMTextBox.TabIndex = 5
        '
        'LOAI_SANPHAMLabel
        '
        LOAI_SANPHAMLabel.AutoSize = True
        LOAI_SANPHAMLabel.Location = New System.Drawing.Point(46, 128)
        LOAI_SANPHAMLabel.Name = "LOAI_SANPHAMLabel"
        LOAI_SANPHAMLabel.Size = New System.Drawing.Size(90, 13)
        LOAI_SANPHAMLabel.TabIndex = 6
        LOAI_SANPHAMLabel.Text = "LOAI SANPHAM:"
        '
        'LOAI_SANPHAMTextBox
        '
        Me.LOAI_SANPHAMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "LOAI_SANPHAM", True))
        Me.LOAI_SANPHAMTextBox.Location = New System.Drawing.Point(142, 125)
        Me.LOAI_SANPHAMTextBox.Name = "LOAI_SANPHAMTextBox"
        Me.LOAI_SANPHAMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LOAI_SANPHAMTextBox.TabIndex = 7
        '
        'XUAT_SULabel
        '
        XUAT_SULabel.AutoSize = True
        XUAT_SULabel.Location = New System.Drawing.Point(46, 154)
        XUAT_SULabel.Name = "XUAT_SULabel"
        XUAT_SULabel.Size = New System.Drawing.Size(57, 13)
        XUAT_SULabel.TabIndex = 8
        XUAT_SULabel.Text = "XUAT SU:"
        '
        'XUAT_SUTextBox
        '
        Me.XUAT_SUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "XUAT_SU", True))
        Me.XUAT_SUTextBox.Location = New System.Drawing.Point(142, 151)
        Me.XUAT_SUTextBox.Name = "XUAT_SUTextBox"
        Me.XUAT_SUTextBox.Size = New System.Drawing.Size(100, 20)
        Me.XUAT_SUTextBox.TabIndex = 9
        '
        'XN_LSPLabel
        '
        XN_LSPLabel.AutoSize = True
        XN_LSPLabel.Location = New System.Drawing.Point(278, 76)
        XN_LSPLabel.Name = "XN_LSPLabel"
        XN_LSPLabel.Size = New System.Drawing.Size(48, 13)
        XN_LSPLabel.TabIndex = 10
        XN_LSPLabel.Text = "XN LSP:"
        '
        'XN_LSPTextBox
        '
        Me.XN_LSPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "XN_LSP", True))
        Me.XN_LSPTextBox.Location = New System.Drawing.Point(374, 73)
        Me.XN_LSPTextBox.Name = "XN_LSPTextBox"
        Me.XN_LSPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.XN_LSPTextBox.TabIndex = 11
        '
        'THONG_TINLabel
        '
        THONG_TINLabel.AutoSize = True
        THONG_TINLabel.Location = New System.Drawing.Point(278, 102)
        THONG_TINLabel.Name = "THONG_TINLabel"
        THONG_TINLabel.Size = New System.Drawing.Size(70, 13)
        THONG_TINLabel.TabIndex = 12
        THONG_TINLabel.Text = "THONG TIN:"
        '
        'THONG_TINTextBox
        '
        Me.THONG_TINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "THONG_TIN", True))
        Me.THONG_TINTextBox.Location = New System.Drawing.Point(374, 99)
        Me.THONG_TINTextBox.Name = "THONG_TINTextBox"
        Me.THONG_TINTextBox.Size = New System.Drawing.Size(100, 20)
        Me.THONG_TINTextBox.TabIndex = 13
        '
        'HINH_ANHLabel
        '
        HINH_ANHLabel.AutoSize = True
        HINH_ANHLabel.Location = New System.Drawing.Point(278, 128)
        HINH_ANHLabel.Name = "HINH_ANHLabel"
        HINH_ANHLabel.Size = New System.Drawing.Size(63, 13)
        HINH_ANHLabel.TabIndex = 14
        HINH_ANHLabel.Text = "HINH ANH:"
        '
        'HINH_ANHTextBox
        '
        Me.HINH_ANHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "HINH_ANH", True))
        Me.HINH_ANHTextBox.Location = New System.Drawing.Point(374, 125)
        Me.HINH_ANHTextBox.Name = "HINH_ANHTextBox"
        Me.HINH_ANHTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HINH_ANHTextBox.TabIndex = 15
        '
        'CHI_TIETLabel
        '
        CHI_TIETLabel.AutoSize = True
        CHI_TIETLabel.Location = New System.Drawing.Point(278, 154)
        CHI_TIETLabel.Name = "CHI_TIETLabel"
        CHI_TIETLabel.Size = New System.Drawing.Size(55, 13)
        CHI_TIETLabel.TabIndex = 16
        CHI_TIETLabel.Text = "CHI TIET:"
        '
        'CHI_TIETTextBox
        '
        Me.CHI_TIETTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "CHI_TIET", True))
        Me.CHI_TIETTextBox.Location = New System.Drawing.Point(374, 151)
        Me.CHI_TIETTextBox.Name = "CHI_TIETTextBox"
        Me.CHI_TIETTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CHI_TIETTextBox.TabIndex = 17
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(505, 76)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 65)
        Me.btnadd.TabIndex = 18
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(601, 76)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 65)
        Me.btndelete.TabIndex = 18
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(699, 76)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 65)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frmsp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 462)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(MA_SANPHAMLabel)
        Me.Controls.Add(Me.MA_SANPHAMTextBox)
        Me.Controls.Add(TEN_SANPHAMLabel)
        Me.Controls.Add(Me.TEN_SANPHAMTextBox)
        Me.Controls.Add(LOAI_SANPHAMLabel)
        Me.Controls.Add(Me.LOAI_SANPHAMTextBox)
        Me.Controls.Add(XUAT_SULabel)
        Me.Controls.Add(Me.XUAT_SUTextBox)
        Me.Controls.Add(XN_LSPLabel)
        Me.Controls.Add(Me.XN_LSPTextBox)
        Me.Controls.Add(THONG_TINLabel)
        Me.Controls.Add(Me.THONG_TINTextBox)
        Me.Controls.Add(HINH_ANHLabel)
        Me.Controls.Add(Me.HINH_ANHTextBox)
        Me.Controls.Add(CHI_TIETLabel)
        Me.Controls.Add(Me.CHI_TIETTextBox)
        Me.Controls.Add(Me.DataTable1DataGridView)
        Me.Controls.Add(Me.DataTable1BindingNavigator)
        Me.Name = "frmsp"
        Me.Text = "frmsp"
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataTable1BindingNavigator.ResumeLayout(False)
        Me.DataTable1BindingNavigator.PerformLayout()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DataSet2TableAdapters.DataTable1TableAdapter
    Friend WithEvents TableAdapterManager As DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents DataTable1BindingNavigator As BindingNavigator
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
    Friend WithEvents DataTable1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataTable1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents MA_SANPHAMTextBox As TextBox
    Friend WithEvents TEN_SANPHAMTextBox As TextBox
    Friend WithEvents LOAI_SANPHAMTextBox As TextBox
    Friend WithEvents XUAT_SUTextBox As TextBox
    Friend WithEvents XN_LSPTextBox As TextBox
    Friend WithEvents THONG_TINTextBox As TextBox
    Friend WithEvents HINH_ANHTextBox As TextBox
    Friend WithEvents CHI_TIETTextBox As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
End Class
