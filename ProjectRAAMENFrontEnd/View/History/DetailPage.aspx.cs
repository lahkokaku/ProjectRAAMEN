using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectRAAMENFrontEnd.Model;
using ProjectRAAMENFrontEnd.Controller;

namespace ProjectRAAMENFrontEnd.View.History
{
    public partial class DetailPage : System.Web.UI.Page
    {
        public static int id;
        public static List<Detail> details;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"].Equals(""))
                Response.Redirect("~/View/History/HeaderPage.aspx");
            else id = Int32.Parse(Request.QueryString["id"]);
            details = DetailController.GetDetailById(id);
                
        }
    }
}