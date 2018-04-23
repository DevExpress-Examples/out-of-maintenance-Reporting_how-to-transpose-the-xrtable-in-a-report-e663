Namespace TransposeXRTable
    Partial Public Class XtraReport3
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.NorthWindDataSet1 = New TransposeXRTable.NorthWindDataSet()
            Me.categoriesTableAdapter = New TransposeXRTable.NorthWindDataSetTableAdapters.CategoriesTableAdapter()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.NorthWindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Location = New System.Drawing.Point(0, 8)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.Size = New System.Drawing.Size(646, 75)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow1.Size = New System.Drawing.Size(646, 75)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryID", "")})
            Me.xrTableCell1.Location = New System.Drawing.Point(0, 0)
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.Size = New System.Drawing.Size(162, 75)
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName", "")})
            Me.xrTableCell2.Location = New System.Drawing.Point(162, 0)
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.Size = New System.Drawing.Size(162, 75)
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description", "")})
            Me.xrTableCell3.Location = New System.Drawing.Point(324, 0)
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell3.Size = New System.Drawing.Size(162, 75)
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1})
            Me.xrTableCell4.Location = New System.Drawing.Point(486, 0)
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell4.Size = New System.Drawing.Size(160, 75)
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture", "")})
            Me.xrPictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox1.Size = New System.Drawing.Size(150, 75)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Height = 30
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageFooter
            ' 
            Me.PageFooter.Height = 30
            Me.PageFooter.Name = "PageFooter"
            Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' NorthWindDataSet1
            ' 
            Me.NorthWindDataSet1.DataSetName = "NorthWindDataSet"
            Me.NorthWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' categoriesTableAdapter
            ' 
            Me.categoriesTableAdapter.ClearBeforeFill = True
            ' 
            ' XtraReport3
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
            Me.DataAdapter = Me.categoriesTableAdapter
            Me.DataMember = "Categories"
            Me.DataSource = Me.NorthWindDataSet1
            Me.DrawGrid = False
            Me.Version = "8.2"
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.NorthWindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private NorthWindDataSet1 As NorthWindDataSet
        Private categoriesTableAdapter As TransposeXRTable.NorthWindDataSetTableAdapters.CategoriesTableAdapter
    End Class
End Namespace
