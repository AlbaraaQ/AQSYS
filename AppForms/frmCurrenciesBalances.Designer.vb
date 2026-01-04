Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class frmCurrenciesBalances
    Inherits Global.System.Windows.Forms.Form

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCellStyle As DataGridViewCellStyle
    Friend WithEvents ImageList1 As ImageList

    Friend WithEvents dgvItems As DataGridView

    <Global.System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
            If flag Then
                Me.components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <Global.System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCurrenciesBalances))
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        ImageList1 = New ImageList(components)
        dgvItems = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth16Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "color-management-icon.png")
        ' 
        ' dgvItems
        ' 
        dgvItems.AllowUserToAddRows = False
        dgvItems.AllowUserToDeleteRows = False
        dgvItems.BackgroundColor = Color.White
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.ColumnHeadersVisible = False
        dgvItems.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Location = New Point(0, 0)
        dgvItems.Margin = New Padding(4, 5, 4, 5)
        dgvItems.MultiSelect = False
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersVisible = False
        dgvItems.RowHeadersWidth = 51
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Traditional Arabic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        dgvItems.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItems.Size = New Size(472, 552)
        dgvItems.TabIndex = 0
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.LightSteelBlue
        DataGridViewCellStyle1.Font = New Font("Traditional Arabic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        Column1.DefaultCellStyle = DataGridViewCellStyle1
        Column1.HeaderText = "العملة"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 200
        ' 
        ' Column2
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.LightSteelBlue
        DataGridViewCellStyle2.Font = New Font("Traditional Arabic", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.PaleTurquoise
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        Column2.DefaultCellStyle = DataGridViewCellStyle2
        Column2.HeaderText = "الرصيد"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' frmCurrenciesBalances
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(472, 552)
        Controls.Add(dgvItems)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmCurrenciesBalances"
        RightToLeft = RightToLeft.Yes
        RightToLeftLayout = True
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class
