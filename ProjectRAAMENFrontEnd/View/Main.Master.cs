using ProjectRAAMENFrontEnd.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectRAAMENFrontEnd.View
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
            else if (Session["user"] == null)
            {
                int id = Int32.Parse(Request.Cookies["user_cookie"].Value);
                Session["user"] = UserController.GetUserById(id).Id;
            }

            if (UserController.GetUserById((int)Session["user"]).RoleId != 1)
                navbarAdmin.Visible = false;
            if (UserController.GetUserById((int)Session["user"]).RoleId != 2)
                navbarStaff.Visible = false;
            if (UserController.GetUserById((int)Session["user"]).RoleId != 3)
                navbarCustomer.Visible = false;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            if (Response.Cookies["user_cookie"] != null)
                Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void btnOrderRamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/OrderPage.aspx");
        }

        protected void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/History/HeaderPage.aspx");
        }

        protected void btnManageRamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Manage_Ramen/ManageRamenPage.aspx");
        }

        protected void btnOrderQueue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionsQueuePage.aspx");
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ReportPage.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ProfilePage.aspx");
        }
    }
}