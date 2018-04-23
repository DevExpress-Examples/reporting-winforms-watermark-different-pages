Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Drawing
' ...

Namespace DifferentWatermarks
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create a report and assign a watermark to it.
			Dim report As New XtraReport1()
			report.Watermark.CopyFrom(CreateTextWatermark("Common Watermark"))
			report.CreateDocument()

			' Add a custom watermark to the second page.
			Dim myPage As Page = report.Pages(1)
			myPage.AssignWatermark(CreateTextWatermark("Second Page"))

			' Remove a watermark from the third page.
			myPage = report.Pages(2)
			myPage.AssignWatermark(New PageWatermark())

			' Show the Print Preview.
			report.ShowPreviewDialog()
		End Sub

		' Create a watermark with the specified text.
		Private Function CreateTextWatermark(ByVal text As String) As Watermark
			Dim textWatermark As New Watermark()

			textWatermark.Text = text
			textWatermark.TextDirection = DirectionMode.ForwardDiagonal
			textWatermark.Font = New Font(textWatermark.Font.FontFamily, 40)
			textWatermark.ForeColor = Color.DodgerBlue
			textWatermark.TextTransparency = 150
			textWatermark.ShowBehind = False

			Return textWatermark
		End Function

	End Class
End Namespace