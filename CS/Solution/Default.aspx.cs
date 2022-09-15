using DevExpress.Web;
using System;
using System.Web.UI.WebControls;

namespace Solution {
    public partial class Default : System.Web.UI.Page { 
		enum DataSourceType {
			Products,
			Categories,
			Shippers
		}

		protected void Page_Load(object sender, EventArgs e) {
			if (!this.IsPostBack)
				Session.Clear();

			CreateGrid();
		}
		protected void grid_DataBinding(object sender, EventArgs e) {
			(sender as ASPxGridView).DataSource = GetDataSource();
		}
		protected void grid_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
			Session["selectedDataSource"] = Int32.Parse(e.Parameters);

			ASPxGridView grid = sender as ASPxGridView;
			grid.Columns.Clear();
			grid.AutoGenerateColumns = true;
			grid.DataBind();
		}
		private SqlDataSource GetDataSource() {
			object o = Session["selectedDataSource"];
			DataSourceType dsType = DataSourceType.Products;
			if (o != null)
				dsType = (DataSourceType)o;

			switch (dsType) {
				case DataSourceType.Categories:
					return dsCategories;
				case DataSourceType.Shippers:
					return dsShippers;
				default:
					return dsProducts;
			}
		}
		private void CreateGrid() {
			ASPxGridView grid = new ASPxGridView();
			grid.ID = "grid";
			grid.DataBinding += grid_DataBinding;
			grid.CustomCallback += grid_CustomCallback;
			phGrid.Controls.Add(grid);
			grid.Columns.Clear();
			grid.AutoGenerateColumns = true;
			grid.ClientInstanceName = "grid";
			grid.DataBind();
		}
	}
}