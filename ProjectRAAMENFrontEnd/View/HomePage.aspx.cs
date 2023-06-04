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
    public partial class HomePage : System.Web.UI.Page
    {
        public static List<User> ListCustomer = new List<User>();
        public static List<User> ListStaff = new List<User>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                if (UserController.GetUserById((int)Session["user"]).RoleId == 1)
                {
                    lblRole.Text = "Admin";
                    ListCustomer = UserController.GetAllCustomer();
                    ListCustomerDIv.Visible = true;
                    ListStaff = UserController.GetAllStaff();
                    ListStaffDiv.Visible = true;
                }
                else if (UserController.GetUserById((int)Session["user"]).RoleId == 2)
                {
                    lblRole.Text = "Staff";
                    ListCustomer = UserController.GetAllCustomer();
                    ListCustomerDIv.Visible = true;
                }
                else
                    lblRole.Text = "Customer";
            }            
        }
    }
}