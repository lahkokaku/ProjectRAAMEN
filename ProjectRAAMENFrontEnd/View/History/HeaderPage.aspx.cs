using System;
using System.Collections.Generic;
using ProjectRAAMENFrontEnd.Model;
using ProjectRAAMENFrontEnd.Controller;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectRAAMENFrontEnd.View.History
{
    public partial class HeaderPage : System.Web.UI.Page
    {
        public static List<Header> ListHeader = new List<Header>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserController.GetUserById((int)Session["user"]).RoleId == 2)
                Response.Redirect("~/View/HomePage.aspx");

            if (UserController.GetUserById((int)Session["user"]).RoleId == 1)
            {
                ListHeader = HeaderController.GetAllHeader();
                ListHeaderDivAdmin.Visible = true;
            }

            if (UserController.GetUserById((int)Session["user"]).RoleId == 3)
            {
                ListHeader = HeaderController.GetAllHeaderByUserId((int)Session["user"]);
                ListHeaderDivCustomer.Visible = true;
            }
        }

    }
}