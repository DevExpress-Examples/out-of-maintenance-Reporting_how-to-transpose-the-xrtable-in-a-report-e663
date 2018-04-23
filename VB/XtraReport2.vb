Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports System.IO

Namespace TransposeXRTable
	Partial Public Class XtraReport2
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private rp As Integer = 0
		Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint

			Dim db As DevExpress.Data.Browsing.DataBrowser = Me.fDataContext(Me.DataSource, Me.DataMember)
			If db.Position * 5 < db.Count Then
				db.Position = rp * 5
				Dim prevpos As Integer = -1

				For i As Integer = 0 To 4

					If (db.Current IsNot Nothing) AndAlso prevpos <> db.Position Then
						Dim dr As DataRowView = TryCast(db.Current, DataRowView)
						Me.xrTable1.Rows(0).Cells(i + 1).Text = dr(0).ToString()
						Me.xrTable1.Rows(1).Cells(i + 1).Text = dr(1).ToString()
						Me.xrTable1.Rows(2).Cells(i + 1).Text = dr(2).ToString()
						Dim byte_Picture() As Byte = CType(dr(3), Byte())
						Dim stream_Picture As New MemoryStream(byte_Picture)
						CType(Me.xrTable1.Rows(3).Cells(i + 1).Controls(0), XRPictureBox).Image = Image.FromStream(stream_Picture)

					Else
						Me.xrTable1.Rows(0).Cells(i + 1).Visible = False
						Me.xrTable1.Rows(1).Cells(i + 1).Visible = False
						Me.xrTable1.Rows(2).Cells(i + 1).Visible = False
						Me.xrTable1.Rows(3).Cells(i + 1).Visible = False

					End If
					prevpos = db.Position
					db.Position += 1
				Next i

				rp += 1
			Else
				e.Cancel = True
			End If
		End Sub
	End Class
End Namespace
