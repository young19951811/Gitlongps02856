﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Dim MA_SANPHAMLabel As System.Windows.Forms.Label
        Dim MA_KHLabel As System.Windows.Forms.Label
        Dim CHITIET_HDLabel As System.Windows.Forms.Label
        Dim NGAY_THANHTOANLabel As System.Windows.Forms.Label
        Dim HINH_THUCLabel As System.Windows.Forms.Label
        Dim XN_CHITIETHDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhoadon))
        Me.DataSet3 = New Cloud_Ps02856.DataSet3()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New Cloud_Ps02856.DataSet3TableAdapters.DataTable1TableAdapter()
        Me.TableAdapterManager = New Cloud_Ps02856.DataSet3TableAdapters.TableAdapterManager()
        Me.DataTable1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataTable1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataTable1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MA_SANPHAMTextBox = New System.Windows.Forms.TextBox()
        Me.MA_KHTextBox = New System.Windows.Forms.TextBox()
        Me.CHITIET_HDTextBox = New System.Windows.Forms.TextBox()
        Me.NGAY_THANHTOANTextBox = New System.Windows.Forms.TextBox()
        Me.HINH_THUCTextBox = New System.Windows.Forms.TextBox()
        Me.XN_CHITIETHDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        MA_SANPHAMLabel = New System.Windows.Forms.Label()
        MA_KHLabel = New System.Windows.Forms.Label()
        CHITIET_HDLabel = New System.Windows.Forms.Label()
        NGAY_THANHTOANLabel = New System.Windows.Forms.Label()
        HINH_THUCLabel = New System.Windows.Forms.Label()
        XN_CHITIETHDLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataTable1BindingNavigator.SuspendLayout()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MA_SANPHAMLabel
        '
        MA_SANPHAMLabel.AutoSize = True
        MA_SANPHAMLabel.Location = New System.Drawing.Point(28, 50)
        MA_SANPHAMLabel.Name = "MA_SANPHAMLabel"
        MA_SANPHAMLabel.Size = New System.Drawing.Size(82, 13)
        MA_SANPHAMLabel.TabIndex = 2
        MA_SANPHAMLabel.Text = "MA SANPHAM:"
        '
        'MA_KHLabel
        '
        MA_KHLabel.AutoSize = True
        MA_KHLabel.Location = New System.Drawing.Point(28, 76)
        MA_KHLabel.Name = "MA_KHLabel"
        MA_KHLabel.Size = New System.Drawing.Size(44, 13)
        MA_KHLabel.TabIndex = 4
        MA_KHLabel.Text = "MA KH:"
        '
        'CHITIET_HDLabel
        '
        CHITIET_HDLabel.AutoSize = True
        CHITIET_HDLabel.Location = New System.Drawing.Point(28, 102)
        CHITIET_HDLabel.Name = "CHITIET_HDLabel"
        CHITIET_HDLabel.Size = New System.Drawing.Size(71, 13)
        CHITIET_HDLabel.TabIndex = 6
        CHITIET_HDLabel.Text = "CHITIET HD:"
        '
        'NGAY_THANHTOANLabel
        '
        NGAY_THANHTOANLabel.AutoSize = True
        NGAY_THANHTOANLabel.Location = New System.Drawing.Point(274, 50)
        NGAY_THANHTOANLabel.Name = "NGAY_THANHTOANLabel"
        NGAY_THANHTOANLabel.Size = New System.Drawing.Size(111, 13)
        NGAY_THANHTOANLabel.TabIndex = 8
        NGAY_THANHTOANLabel.Text = "NGAY THANHTOAN:"
        '
        'HINH_THUCLabel
        '
        HINH_THUCLabel.AutoSize = True
        HINH_THUCLabel.Location = New System.Drawing.Point(274, 76)
        HINH_THUCLabel.Name = "HINH_THUCLabel"
        HINH_THUCLabel.Size = New System.Drawing.Size(70, 13)
        HINH_THUCLabel.TabIndex = 10
        HINH_THUCLabel.Text = "HINH THUC:"
        '
        'XN_CHITIETHDLabel
        '
        XN_CHITIETHDLabel.AutoSize = True
        XN_CHITIETHDLabel.Location = New System.Drawing.Point(274, 102)
        XN_CHITIETHDLabel.Name = "XN_CHITIETHDLabel"
        XN_CHITIETHDLabel.Size = New System.Drawing.Size(86, 13)
        XN_CHITIETHDLabel.TabIndex = 12
        XN_CHITIETHDLabel.Text = "XN CHITIETHD:"
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSet3
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Cloud_Ps02856.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.DataTable1BindingNavigator.Size = New System.Drawing.Size(672, 25)
        Me.DataTable1BindingNavigator.TabIndex = 0
        Me.DataTable1BindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.DataTable1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataTable1DataGridView.DataSource = Me.DataTable1BindingSource
        Me.DataTable1DataGridView.Location = New System.Drawing.Point(12, 180)
        Me.DataTable1DataGridView.Name = "DataTable1DataGridView"
        Me.DataTable1DataGridView.Size = New System.Drawing.Size(648, 220)
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MA_KH"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MA_KH"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CHITIET_HD"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CHITIET_HD"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NGAY_THANHTOAN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NGAY_THANHTOAN"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HINH_THUC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "HINH_THUC"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "XN_CHITIETHD"
        Me.DataGridViewTextBoxColumn6.HeaderText = "XN_CHITIETHD"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'MA_SANPHAMTextBox
        '
        Me.MA_SANPHAMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "MA_SANPHAM", True))
        Me.MA_SANPHAMTextBox.Location = New System.Drawing.Point(145, 47)
        Me.MA_SANPHAMTextBox.Name = "MA_SANPHAMTextBox"
        Me.MA_SANPHAMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MA_SANPHAMTextBox.TabIndex = 3
        '
        'MA_KHTextBox
        '
        Me.MA_KHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "MA_KH", True))
        Me.MA_KHTextBox.Location = New System.Drawing.Point(145, 73)
        Me.MA_KHTextBox.Name = "MA_KHTextBox"
        Me.MA_KHTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MA_KHTextBox.TabIndex = 5
        '
        'CHITIET_HDTextBox
        '
        Me.CHITIET_HDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "CHITIET_HD", True))
        Me.CHITIET_HDTextBox.Location = New System.Drawing.Point(145, 99)
        Me.CHITIET_HDTextBox.Name = "CHITIET_HDTextBox"
        Me.CHITIET_HDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CHITIET_HDTextBox.TabIndex = 7
        '
        'NGAY_THANHTOANTextBox
        '
        Me.NGAY_THANHTOANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "NGAY_THANHTOAN", True))
        Me.NGAY_THANHTOANTextBox.Location = New System.Drawing.Point(391, 47)
        Me.NGAY_THANHTOANTextBox.Name = "NGAY_THANHTOANTextBox"
        Me.NGAY_THANHTOANTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NGAY_THANHTOANTextBox.TabIndex = 9
        '
        'HINH_THUCTextBox
        '
        Me.HINH_THUCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "HINH_THUC", True))
        Me.HINH_THUCTextBox.Location = New System.Drawing.Point(391, 73)
        Me.HINH_THUCTextBox.Name = "HINH_THUCTextBox"
        Me.HINH_THUCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HINH_THUCTextBox.TabIndex = 11
        '
        'XN_CHITIETHDTextBox
        '
        Me.XN_CHITIETHDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "XN_CHITIETHD", True))
        Me.XN_CHITIETHDTextBox.Location = New System.Drawing.Point(391, 99)
        Me.XN_CHITIETHDTextBox.Name = "XN_CHITIETHDTextBox"
        Me.XN_CHITIETHDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.XN_CHITIETHDTextBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(567, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(567, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(567, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 37)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 420)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(MA_SANPHAMLabel)
        Me.Controls.Add(Me.MA_SANPHAMTextBox)
        Me.Controls.Add(MA_KHLabel)
        Me.Controls.Add(Me.MA_KHTextBox)
        Me.Controls.Add(CHITIET_HDLabel)
        Me.Controls.Add(Me.CHITIET_HDTextBox)
        Me.Controls.Add(NGAY_THANHTOANLabel)
        Me.Controls.Add(Me.NGAY_THANHTOANTextBox)
        Me.Controls.Add(HINH_THUCLabel)
        Me.Controls.Add(Me.HINH_THUCTextBox)
        Me.Controls.Add(XN_CHITIETHDLabel)
        Me.Controls.Add(Me.XN_CHITIETHDTextBox)
        Me.Controls.Add(Me.DataTable1DataGridView)
        Me.Controls.Add(Me.DataTable1BindingNavigator)
        Me.Name = "frmhoadon"
        Me.Text = "frmhoadon"
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataTable1BindingNavigator.ResumeLayout(False)
        Me.DataTable1BindingNavigator.PerformLayout()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DataSet3TableAdapters.DataTable1TableAdapter
    Friend WithEvents TableAdapterManager As DataSet3TableAdapters.TableAdapterManager
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
    Friend WithEvents MA_SANPHAMTextBox As TextBox
    Friend WithEvents MA_KHTextBox As TextBox
    Friend WithEvents CHITIET_HDTextBox As TextBox
    Friend WithEvents NGAY_THANHTOANTextBox As TextBox
    Friend WithEvents HINH_THUCTextBox As TextBox
    Friend WithEvents XN_CHITIETHDTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
