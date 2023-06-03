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
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshUserProfile();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string Username = txtNewUsername.Text;
            string Email = txtNewEmail.Text;
            string Gender = "Unselected";
            if (rdbtnMale.Checked)
                Gender = "Male";
            else if (rdbtnFemale.Checked)
                Gender = "Female";
            string Password = txtPassword.Text;
            int Id = (int)Session["user"];
            lblUpdateMessage.Text = UserController.ValidateUpdateUserProfile(Username, Email, Gender, Password, Id);
            RefreshUserProfile();
        }

        protected void RefreshUserProfile()
        {
            User CurrentUser = new User();
            CurrentUser = UserController.GetUserById((int)Session["user"]);
            lblUsername.Text = CurrentUser.Username;
            lblEmail.Text = CurrentUser.Email;
            lblGender.Text = CurrentUser.Gender;
            if (CurrentUser.RoleId == 1)
                lblRole.Text = "Admin";
            else if (CurrentUser.RoleId == 2)
                lblRole.Text = "Staff";
            else
                lblRole.Text = "Customer";
        }
    }
}