using ProjectRAAMENFrontEnd.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectRAAMENFrontEnd.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                if (UserController.GetUserById((int)Session["user"]).RoleId == 1)
                    lblRole.Text = "Admin";
                else if (UserController.GetUserById((int)Session["user"]).RoleId == 2)
                    lblRole.Text = "Staff";
                else
                    lblRole.Text = "Customer";
            }
        }
    }
}