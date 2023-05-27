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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("./HomePage.aspx");
            }
            else if (Request.Cookies["user_cookie"] != null)
            {
                int Id = int.Parse(Request.Cookies["user_cookie"].Value);
                Session["user"] = UserController.GetUserById(Id).Id;
                Response.Redirect("./HomePage.aspx");
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String Username = txtUsername.Text;
            String Password = txtPassword.Text;
            Boolean Remember = chkRememberMe.Checked;

            lblMessage.Text = UserController.ValidateLogin(Username, Password);

            if (lblMessage.Text.Equals("Username and Passowrd must be filled"))
                return;

            User SelectedUser = UserController.GetUserByUsernameAndPassword(Username, Password);

            if (SelectedUser == null)
            {
                lblMessage.Text = "User not found";
            }
            else
            {
                lblMessage.Text = "Success";
                Session["user"] = SelectedUser.Id;
                if (Remember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = UserController.GetUserByUsernameAndPassword(Username, Password).Id.ToString();
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("./HomePage.aspx");
            }
        }
    }
}