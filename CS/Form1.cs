using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
// ...

namespace DifferentWatermarks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a report and assign a watermark to it.
            XtraReport1 report = new XtraReport1();
            report.Watermarks.Add(CreateTextWatermark("Common Watermark", "Watermark1"));
            report.Watermarks.Add(CreateTextWatermark("Second Page", "Watermark2"));
            report.CreateDocument();

            // Add a custom watermark to the second page.
            Page myPage = report.Pages[1];
            myPage.WatermarkId = "Watermark2";

            // Remove a watermark from the third page.
            myPage = report.Pages[2];
            myPage.AssignWatermark(new PageWatermark());

            // Show the Print Preview.
            report.ShowPreviewDialog();
        }

        // Create a watermark with the specified text.
        private Watermark CreateTextWatermark(string text, string id) {
            Watermark textWatermark = new Watermark();
            textWatermark.Id = id;
            textWatermark.Text = text;
            textWatermark.TextDirection = DirectionMode.ForwardDiagonal;
            textWatermark.Font = new DXFont(textWatermark.Font.Name, 40);
            textWatermark.ForeColor = Color.DodgerBlue;
            textWatermark.TextTransparency = 150;
            textWatermark.TextPosition = WatermarkPosition.InFront;
            return textWatermark;
        }

    }
}