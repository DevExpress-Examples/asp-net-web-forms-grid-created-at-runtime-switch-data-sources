<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128537808/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2968)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to bind ASPxGridView created at runtime to different data sources


<p>This example shows how to select and bind ASPxGridView to a data source at runtime. In design mode the page contains ASPxRadioButtonList and three data sources (SqlDataSource), not ASPxGridView. The grid will be added to the page at runtime.<br />
Grid's data source is changed by clicking list items. <br />
Note that the grid's view state is enabled and the grid will restore its columns after it has been appended to the page. Therefore we clean up grid columns just after that and before binding the data source.</p><p>See also<br />
<a href="https://www.devexpress.com/Support/Center/p/E448">How to dynamically switch the grid's data source and recreate columns at runtime</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E2967">How to bind ASPxGridView with manually created columns to different data sources at runtime. The grid is created in design mode.</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E2965">How to bind ASPxGridView with autogenerated columns to different data sources at runtime. The grid is created at design mode</a></p>

<br/>


