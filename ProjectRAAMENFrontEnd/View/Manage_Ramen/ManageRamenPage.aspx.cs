using ProjectRAAMENFrontEnd.Controller;
using ProjectRAAMENFrontEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectRAAMENFrontEnd.View.Manage_Ramen
{
    public partial class ManageRamenPage : System.Web.UI.Page
    {
        public static List<Raman> RamenList = new List<Raman>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserController.GetUserById((int)Session["user"]).RoleId == 3)
                Response.Redirect("~/View/HomePage.aspx");

            RefreshRamenList();
        }
        protected void RefreshRamenList()
        {
            RamenList = RamenController.GetAllRamen();
            gvRamenList.DataSource = RamenList;
            gvRamenList.DataBind();
        }

        protected void btnCreateNewRamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Manage_Ramen/ManageRamenInsertPage.aspx");
        }

        protected void gvRamenList_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow Row = gvRamenList.Rows[e.NewEditIndex];
            string Id = Row.Cells[0].Text.ToString();
            Response.Redirect("~/View/Manage_Ramen/ManageRamenUpdatePage.aspx?Id="+ Id);
        }

        protected void gvRamenList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow Row = gvRamenList.Rows[e.RowIndex];
            int Id = Int32.Parse(Row.Cells[0].Text.ToString());
            lblRamenMessage.Text = RamenController.DeleteRamen(Id);
            RefreshRamenList();
        }
    }
}