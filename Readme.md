<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128537808/22.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2968)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Grid View for ASP.NET Web Forms - How to bind a grid created at runtime to different data sources
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/128537808/)**
<!-- run online end -->

This example demonstrates how to add a Grid View control to a page at runtime and conditionally switch its data source. 

## Implementation Details

The example application's `Default` page contains an [ASPxRadioButtonList](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxRadioButtonList) and three pre-configured data sources ([SqlDataSource](https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.webcontrols.sqldatasource?view=netframework-4.8)). A Grid View control is added to the page in code and bound to the data source that you select from the Radio Button List.

The grid's view state is enabled in this example. Because of this, when the grid is added to the page, it restores its columns from the view state. To generate the columns from scratch when the data source has been changed, clear the [ASPxGridView.Columns](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView.Columns) collection before you call the [ASPxGridView.DataBind](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxWebControl.DataBind) method. 

## Files to Review

- [Default.aspx](./CS/Solution/Default.aspx) (VB: [Default.aspx](./VB/Solution/Default.aspx))
- [Default.aspx.cs](./CS/Solution/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Solution/Default.aspx.vb))

## Documentation

- [Bind Grid View to Data at Runtime](https://docs.devexpress.com/AspNet/403612/components/grid-view/concepts/bind-to-data/bind-to-data-at-runtime)

## More Examples

- [Grid View for ASP.NET Web Forms - How to dynamically switch the Grid's data source and recreate columns at runtime](https://www.devexpress.com/Support/Center/p/E448)
- [Grid View for ASP.NET Web Forms - How to create columns and bind the control to different data sources at runtime](https://www.devexpress.com/Support/Center/p/E2967)
- [Grid View for ASP.NET Web Forms - How to bind the control created in design mode to different data sources at runtime](https://www.devexpress.com/Support/Center/p/E2965)

