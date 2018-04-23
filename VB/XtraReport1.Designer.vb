Imports Microsoft.VisualBasic
Imports System
Namespace TransposeXRTable
	Partial Public Class XtraReport1
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
			Me.components = New System.ComponentModel.Container()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.winControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New TransposeXRTable.nwindDataSet()
			Me.rowCategoryID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCategoryName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowDescription = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowPicture = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.categoriesTableAdapter = New TransposeXRTable.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.winControlContainer1})
			Me.Detail.Height = 122
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
'			Me.Detail.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.XtraReport1_BeforePrint);
			' 
			' winControlContainer1
			' 
			Me.winControlContainer1.Location = New System.Drawing.Point(17, 8)
			Me.winControlContainer1.Name = "winControlContainer1"
			Me.winControlContainer1.Size = New System.Drawing.Size(583, 97)
			Me.winControlContainer1.WinControl = Me.vGridControl1
			' 
			' vGridControl1
			' 
			Me.vGridControl1.DataSource = Me.categoriesBindingSource
			Me.vGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowCategoryID, Me.rowCategoryName, Me.rowDescription, Me.rowPicture})
			Me.vGridControl1.Size = New System.Drawing.Size(560, 93)
			Me.vGridControl1.TabIndex = 0
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' rowCategoryID
			' 
			Me.rowCategoryID.Name = "rowCategoryID"
			Me.rowCategoryID.Properties.Caption = "CategoryID"
			Me.rowCategoryID.Properties.FieldName = "CategoryID"
			' 
			' rowCategoryName
			' 
			Me.rowCategoryName.Name = "rowCategoryName"
			Me.rowCategoryName.Properties.Caption = "CategoryName"
			Me.rowCategoryName.Properties.FieldName = "CategoryName"
			' 
			' rowDescription
			' 
			Me.rowDescription.Name = "rowDescription"
			Me.rowDescription.Properties.Caption = "Description"
			Me.rowDescription.Properties.FieldName = "Description"
			' 
			' rowPicture
			' 
			Me.rowPicture.Name = "rowPicture"
			Me.rowPicture.Properties.Caption = "Picture"
			Me.rowPicture.Properties.FieldName = "Picture"
			Me.rowPicture.Properties.RowEdit = Me.repositoryItemPictureEdit1
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
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			Me.DrawGrid = False
			Me.Version = "8.2"
'			Me.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.XtraReport1_BeforePrint);
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private winControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private nwindDataSet As nwindDataSet
		Private rowCategoryID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCategoryName As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowDescription As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowPicture As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoriesTableAdapter As TransposeXRTable.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
	End Class
End Namespace
