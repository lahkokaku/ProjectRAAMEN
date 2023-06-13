using ProjectRAAMENFrontEnd.Controller;
using ProjectRAAMENFrontEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectRAAMENFrontEnd.View
{
    public partial class TransactionsQueuePage : System.Web.UI.Page
    {
        public static List<Header> UnhandledHeaderList = new List<Header>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserController.GetUserById((int)Session["user"]).RoleId == 3)
                Response.Redirect("~/View/HomePage.aspx");
            
            RefreshHeaderList();
        }

        protected void RefreshHeaderList()
        {
            UnhandledHeaderList = HeaderController.GetAllUnhandledHeader();
            gvHeaderList.DataSource = UnhandledHeaderList;
            gvHeaderList.DataBind();
        }

        protected void gvHeaderList_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow Row = gvHeaderList.Rows[e.RowIndex];
            int Id = Int32.Parse(Row.Cells[0].Text);
            lblMessage.Text = HeaderController.HandleHeader(Id, (int)Session["user"]);
            RefreshHeaderList();
        }
    }
}