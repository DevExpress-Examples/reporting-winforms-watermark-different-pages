Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Drawing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.UI
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
            report.Watermarks.Add(CreateTextWatermark("Common Watermark", "Watermark1"))
            report.Watermarks.Add(CreateTextWatermark("Second Page", "Watermark2"))
            report.CreateDocument()

            ' Add a custom watermark to the second page.
            Dim myPage As Page = report.Pages(1)
            myPage.WatermarkId = "Watermark2"

            ' Remove a watermark from the third page.
            myPage = report.Pages(2)
            myPage.AssignWatermark(New PageWatermark())

            ' Show the Print Preview.
            report.ShowPreviewDialog()
        End Sub

        ' Create a watermark with the specified text.
        Private Function CreateTextWatermark(ByVal text As String, ByVal id As String) As Watermark
            Dim textWatermark As New Watermark()
            textWatermark.Id = id
            textWatermark.Text = text
            textWatermark.TextDirection = DirectionMode.ForwardDiagonal
            textWatermark.Font = New DXFont(textWatermark.Font.Name, 40)
            textWatermark.ForeColor = Color.DodgerBlue
            textWatermark.TextTransparency = 150
            textWatermark.TextPosition = WatermarkPosition.InFront
            Return textWatermark
        End Function

    End Class
End Namespace