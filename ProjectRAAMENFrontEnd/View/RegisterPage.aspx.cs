using ProjectRAAMENFrontEnd.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectRAAMENFrontEnd.View
{
    public partial class RegisterPage : System.Web.UI.Page
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
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            String Username = txtUsername.Text;
            String Email = txtEmail.Text;
            String Gender;
            if (rdbtnMale.Checked)
                Gender = rdbtnMale.Text;
            else if (rdbtnFemale.Checked)
                Gender = rdbtnFemale.Text;
            else
                Gender = "Unselected";
            String Password = txtPassword.Text;
            String ConfirmPassword = txtConfirmPassword.Text;
            int Role = Int32.Parse(listRole.SelectedValue);

            lblMessage.Text = UserController.ValidateRegistration(Username, Email, Gender, Password, ConfirmPassword, Role);

            return;
        }
    }
}