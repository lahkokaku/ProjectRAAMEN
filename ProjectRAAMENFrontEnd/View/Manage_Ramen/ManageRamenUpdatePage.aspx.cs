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
    public partial class ManageRamenEditPage : System.Web.UI.Page
    {
        public static List<Meat> MeatList = new List<Meat>();
        public int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserController.GetUserById((int)Session["user"]).RoleId == 3)
                Response.Redirect("~/View/HomePage.aspx");

            MeatList = MeatController.GetAllMeat();
            if (ddlMeatList.Items.Count == 0)
            {
                foreach (var Meat in MeatList)
                {
                    ddlMeatList.Items.Add(new ListItem(Meat.Name, Meat.Id.ToString()));
                }
            }
            Id = Request.QueryString["Id"].Equals("") ? 0 : Int32.Parse(Request.QueryString["Id"]);
            lblRamenId.Text = Id.ToString();
            Raman SelectedRamen = RamenController.GetRamenById(Id);
            txtRamenName.Text = SelectedRamen.Name;
            txtBroth.Text = SelectedRamen.Broth;
            txtPrice.Text = SelectedRamen.Price;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Manage_Ramen/ManageRamenPage.aspx");
        }

        protected void btnUpdateRamen_Click(object sender, EventArgs e)
        {
            string RamenName = txtRamenName.Text;
            int MeatId = Int32.Parse(ddlMeatList.SelectedValue);
            string Broth = txtBroth.Text;
            int Price = txtPrice.Text.Equals("") ? 0 : Int32.Parse(txtPrice.Text);

            lblMessage.Text = RamenController.UpdateRamen(Id, RamenName, MeatId, Broth, Price);
        }
    }
}