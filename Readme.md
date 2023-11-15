<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597141/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E109)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Reporting for WinForms - How to Add Different Watermarks to Different Pages

This example shows how to assign a unique watermark to different report pages. You can do it the following ways:

*  Assign the [Page.WatermarkId](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.Page.WatermarkId?v=23.2) property to the [Watermark.Id](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.Drawing.Watermark.Id?v=23.2) value. 

* Call the [Page.AssignWatermark](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.Page.AssignWatermark(DevExpress.XtraPrinting.Drawing.PageWatermark)) method for the page whose watermark you want to change, and pass a new watermark to this method as a parameter. 

`Page.AssignWatermark` takes priority over `Page.WatermarkId`.

If you want to remove the watermark from a particular page, pass a new empty watermark to the [AssignWatermark](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.Page.AssignWatermark(DevExpress.XtraPrinting.Drawing.PageWatermark)) method.

![Report with Different Watermark on Different Pages](/Images/different-watermark.png)

## Files to Review

* [Form1.cs](CS/Form1.cs) (VB: [Form1.vb](VB/Form1.vb))

## Documentation

- [Watermarks](https://docs.devexpress.com/WindowsForms/7225/controls-and-libraries/printing-exporting/concepts/miscellaneous/watermarks?v=23.2)
- [Add Watermarks to a Report](https://docs.devexpress.com/XtraReports/16128/detailed-guide-to-devexpress-reporting/add-extra-information/add-watermarks-to-a-report)

