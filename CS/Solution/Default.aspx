<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Solution.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to bind ASPxGridView with autocreated columns to different data sources at runtime. The grid is created in runtime mode</title>
</head>
<body>
	<form id="form1" runat="server">
		<table>
			<tr>
				<td valign="top">
					<asp:PlaceHolder ID="phGrid" runat="server"></asp:PlaceHolder>
				</td>
				<td valign="top">
					<dx:ASPxRadioButtonList ID="rblDatasources" runat="server">
						<ClientSideEvents SelectedIndexChanged="function(s, e) { grid.PerformCallback(s.GetSelectedIndex()); }" />
						<Items>
							<dx:ListEditItem Selected="True" Text="Products" />
							<dx:ListEditItem Text="Categories" />
							<dx:ListEditItem Text="Shippers" />
						</Items>
					</dx:ASPxRadioButtonList>
				</td>
			</tr>
		</table>
		<asp:SqlDataSource ID="dsProducts" runat="server" ConnectionString="Data Source=(local);Initial Catalog=Northwind;Integrated Security=True"
			ProviderName="System.Data.SqlClient" SelectCommand="SELECT [ProductID], [ProductName], [QuantityPerUnit], [UnitPrice] FROM [Products]">						
		</asp:SqlDataSource>
		<asp:SqlDataSource ID="dsCategories" runat="server" ConnectionString="Data Source=(local);Initial Catalog=Northwind;Integrated Security=True"
			ProviderName="System.Data.SqlClient" SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]">						
		</asp:SqlDataSource>
		<asp:SqlDataSource ID="dsShippers" runat="server" ConnectionString="Data Source=(local);Initial Catalog=Northwind;Integrated Security=True"
			ProviderName="System.Data.SqlClient" SelectCommand="SELECT [ShipperID], [CompanyName], [Phone] FROM [Shippers]">
		</asp:SqlDataSource>
	</form>
</body>
</html>
