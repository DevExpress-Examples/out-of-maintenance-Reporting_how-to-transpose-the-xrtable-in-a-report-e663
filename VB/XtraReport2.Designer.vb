Imports Microsoft.VisualBasic
Imports System
Namespace TransposeXRTable
	Partial Public Class XtraReport2
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
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrPictureBox5 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.nwindDataSet1 = New TransposeXRTable.nwindDataSet()
			Me.categoriesTableAdapter = New TransposeXRTable.nwindDataSetTableAdapters.CategoriesTableAdapter()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.Height = 133
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
'			Me.Detail.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.Detail_BeforePrint);
			' 
			' xrTable1
			' 
			Me.xrTable1.Location = New System.Drawing.Point(8, 0)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1, Me.xrTableRow4, Me.xrTableRow3, Me.xrTableRow2})
			Me.xrTable1.Size = New System.Drawing.Size(633, 133)
			Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell4, Me.xrTableCell6, Me.xrTableCell2, Me.xrTableCell5, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTableRow1.Size = New System.Drawing.Size(633, 25)
			Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell1.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell1.Text = "CategoryID"
			Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.Location = New System.Drawing.Point(105, 0)
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell4.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.Location = New System.Drawing.Point(210, 0)
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell6.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Location = New System.Drawing.Point(315, 0)
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell2.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.Location = New System.Drawing.Point(420, 0)
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell5.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell5.Text = "xrTableCell5"
			Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Location = New System.Drawing.Point(525, 0)
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell3.Size = New System.Drawing.Size(108, 25)
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableRow4
			' 
			Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell19, Me.xrTableCell20, Me.xrTableCell21, Me.xrTableCell22, Me.xrTableCell23, Me.xrTableCell24})
			Me.xrTableRow4.Name = "xrTableRow4"
			Me.xrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTableRow4.Size = New System.Drawing.Size(633, 25)
			Me.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell19
			' 
			Me.xrTableCell19.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell19.Name = "xrTableCell19"
			Me.xrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell19.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell19.Text = "CategoryName"
			Me.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell20
			' 
			Me.xrTableCell20.Location = New System.Drawing.Point(105, 0)
			Me.xrTableCell20.Name = "xrTableCell20"
			Me.xrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell20.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell20.Text = "xrTableCell20"
			Me.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell21
			' 
			Me.xrTableCell21.Location = New System.Drawing.Point(210, 0)
			Me.xrTableCell21.Name = "xrTableCell21"
			Me.xrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell21.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell21.Text = "xrTableCell21"
			Me.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell22
			' 
			Me.xrTableCell22.Location = New System.Drawing.Point(315, 0)
			Me.xrTableCell22.Name = "xrTableCell22"
			Me.xrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell22.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell22.Text = "xrTableCell22"
			Me.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell23
			' 
			Me.xrTableCell23.Location = New System.Drawing.Point(420, 0)
			Me.xrTableCell23.Name = "xrTableCell23"
			Me.xrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell23.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell23.Text = "xrTableCell23"
			Me.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell24
			' 
			Me.xrTableCell24.Location = New System.Drawing.Point(525, 0)
			Me.xrTableCell24.Name = "xrTableCell24"
			Me.xrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell24.Size = New System.Drawing.Size(108, 25)
			Me.xrTableCell24.Text = "xrTableCell24"
			Me.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableRow3
			' 
			Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell13, Me.xrTableCell14, Me.xrTableCell15, Me.xrTableCell16, Me.xrTableCell17, Me.xrTableCell18})
			Me.xrTableRow3.Name = "xrTableRow3"
			Me.xrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTableRow3.Size = New System.Drawing.Size(633, 25)
			Me.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell13
			' 
			Me.xrTableCell13.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell13.Name = "xrTableCell13"
			Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell13.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell13.Text = "Description"
			Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell14
			' 
			Me.xrTableCell14.Location = New System.Drawing.Point(105, 0)
			Me.xrTableCell14.Name = "xrTableCell14"
			Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell14.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell14.Text = "xrTableCell14"
			Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell15
			' 
			Me.xrTableCell15.Location = New System.Drawing.Point(210, 0)
			Me.xrTableCell15.Name = "xrTableCell15"
			Me.xrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell15.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell15.Text = "xrTableCell15"
			Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell16
			' 
			Me.xrTableCell16.Location = New System.Drawing.Point(315, 0)
			Me.xrTableCell16.Name = "xrTableCell16"
			Me.xrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell16.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell16.Text = "xrTableCell16"
			Me.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell17
			' 
			Me.xrTableCell17.Location = New System.Drawing.Point(420, 0)
			Me.xrTableCell17.Name = "xrTableCell17"
			Me.xrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell17.Size = New System.Drawing.Size(105, 25)
			Me.xrTableCell17.Text = "xrTableCell17"
			Me.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell18
			' 
			Me.xrTableCell18.Location = New System.Drawing.Point(525, 0)
			Me.xrTableCell18.Name = "xrTableCell18"
			Me.xrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell18.Size = New System.Drawing.Size(108, 25)
			Me.xrTableCell18.Text = "xrTableCell18"
			Me.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10, Me.xrTableCell11, Me.xrTableCell12})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTableRow2.Size = New System.Drawing.Size(633, 58)
			Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell7.Size = New System.Drawing.Size(105, 58)
			Me.xrTableCell7.Text = "Picture"
			Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1})
			Me.xrTableCell8.Location = New System.Drawing.Point(105, 0)
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell8.Size = New System.Drawing.Size(105, 58)
			Me.xrTableCell8.Text = "xrTableCell8"
			Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.Location = New System.Drawing.Point(0, 0)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrPictureBox1.Size = New System.Drawing.Size(100, 58)
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox2})
			Me.xrTableCell9.Location = New System.Drawing.Point(210, 0)
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell9.Size = New System.Drawing.Size(105, 58)
			Me.xrTableCell9.Text = "xrTableCell9"
			Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPictureBox2
			' 
			Me.xrPictureBox2.Location = New System.Drawing.Point(0, 0)
			Me.xrPictureBox2.Name = "xrPictureBox2"
			Me.xrPictureBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrPictureBox2.Size = New System.Drawing.Size(100, 58)
			Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox3})
			Me.xrTableCell10.Location = New System.Drawing.Point(315, 0)
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell10.Size = New System.Drawing.Size(105, 58)
			Me.xrTableCell10.Text = "xrTableCell10"
			Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPictureBox3
			' 
			Me.xrPictureBox3.Location = New System.Drawing.Point(0, 0)
			Me.xrPictureBox3.Name = "xrPictureBox3"
			Me.xrPictureBox3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrPictureBox3.Size = New System.Drawing.Size(100, 58)
			Me.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' xrTableCell11
			' 
			Me.xrTableCell11.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox4})
			Me.xrTableCell11.Location = New System.Drawing.Point(420, 0)
			Me.xrTableCell11.Name = "xrTableCell11"
			Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell11.Size = New System.Drawing.Size(105, 58)
			Me.xrTableCell11.Text = "xrTableCell11"
			Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPictureBox4
			' 
			Me.xrPictureBox4.Location = New System.Drawing.Point(0, 0)
			Me.xrPictureBox4.Name = "xrPictureBox4"
			Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrPictureBox4.Size = New System.Drawing.Size(100, 58)
			Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' xrTableCell12
			' 
			Me.xrTableCell12.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox5})
			Me.xrTableCell12.Location = New System.Drawing.Point(525, 0)
			Me.xrTableCell12.Name = "xrTableCell12"
			Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell12.Size = New System.Drawing.Size(108, 58)
			Me.xrTableCell12.Text = "xrTableCell12"
			Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPictureBox5
			' 
			Me.xrPictureBox5.Location = New System.Drawing.Point(0, 0)
			Me.xrPictureBox5.Name = "xrPictureBox5"
			Me.xrPictureBox5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrPictureBox5.Size = New System.Drawing.Size(100, 58)
			Me.xrPictureBox5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
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
			' GroupFooter1
			' 
			Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.GroupFooter1.Height = 16
			Me.GroupFooter1.Name = "GroupFooter1"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.Coral
			Me.xrLabel1.Location = New System.Drawing.Point(8, 8)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(633, 8)
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' XtraReport2
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupFooter1})
			Me.DataAdapter = Me.categoriesTableAdapter
			Me.DataMember = "Categories"
			Me.DataSource = Me.nwindDataSet1
			Me.DrawGrid = False
			Me.Version = "8.2"
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Private xrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
		Private xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
		Private xrPictureBox5 As DevExpress.XtraReports.UI.XRPictureBox
		Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As TransposeXRTable.nwindDataSetTableAdapters.CategoriesTableAdapter
	End Class
End Namespace
