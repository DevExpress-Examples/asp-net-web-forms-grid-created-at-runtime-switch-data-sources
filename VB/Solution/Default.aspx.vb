Imports DevExpress.Web
Imports System
Imports System.Web.UI.WebControls

Namespace Solution

    Public Partial Class [Default]
        Inherits Web.UI.Page

        Friend Enum DataSourceType
            Products
            Categories
            Shippers
        End Enum

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsPostBack Then Session.Clear()
            CreateGrid()
        End Sub

        Protected Sub grid_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
            TryCast(sender, ASPxGridView).DataSource = GetDataSource()
        End Sub

        Protected Sub grid_CustomCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomCallbackEventArgs)
            Session("selectedDataSource") = Integer.Parse(e.Parameters)
            Dim grid As ASPxGridView = TryCast(sender, ASPxGridView)
            grid.Columns.Clear()
            grid.AutoGenerateColumns = True
            grid.DataBind()
        End Sub

        Private Function GetDataSource() As SqlDataSource
            Dim o As Object = Session("selectedDataSource")
            Dim dsType As DataSourceType = DataSourceType.Products
            If o IsNot Nothing Then dsType = CType(o, DataSourceType)
            Select Case dsType
                Case DataSourceType.Categories
                    Return dsCategories
                Case DataSourceType.Shippers
                    Return dsShippers
                Case Else
                    Return dsProducts
            End Select
        End Function

        Private Sub CreateGrid()
            Dim grid As ASPxGridView = New ASPxGridView()
            grid.ID = "grid"
            AddHandler grid.DataBinding, AddressOf grid_DataBinding
            AddHandler grid.CustomCallback, AddressOf grid_CustomCallback
            phGrid.Controls.Add(grid)
            grid.Columns.Clear()
            grid.AutoGenerateColumns = True
            grid.ClientInstanceName = "grid"
            grid.DataBind()
        End Sub
    End Class
End Namespace
