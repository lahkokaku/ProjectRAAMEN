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
    public partial class ManageRamenInsertPage : System.Web.UI.Page
    {
        public static List<Meat> MeatList = new List<Meat>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserController.GetUserById((int)Session["user"]).RoleId == 3)
                Response.Redirect("~/View/HomePage.aspx");

            MeatList = MeatController.GetAllMeat();
            if(ddlMeatList.Items.Count == 0)
            {
                foreach (var Meat in MeatList)
                {
                    ddlMeatList.Items.Add(new ListItem(Meat.Name, Meat.Id.ToString()));
                }
            }
        }

        protected void btnCreateRamen_Click(object sender, EventArgs e)
        {
            string RamenName = txtRamenName.Text;
            int MeatId = Int32.Parse(ddlMeatList.SelectedValue);
            string Broth = txtBroth.Text;
            int Price =  txtPrice.Text.Equals("") ? 0 : Int32.Parse(txtPrice.Text);

            lblMessage.Text = RamenController.InsertRamen(RamenName, MeatId, Broth, Price);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Manage_Ramen/ManageRamenPage.aspx");
        }
    }
}