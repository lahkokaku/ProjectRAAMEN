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
            ListHeader = HeaderController.GetAllHeader();
        }

    }
}