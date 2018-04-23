Imports Microsoft.VisualBasic
Imports System
Namespace TransposeXRTable
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint, MyBase.BeforePrint
			categoriesTableAdapter.Fill(nwindDataSet.Categories)
		End Sub

	End Class
End Namespace
