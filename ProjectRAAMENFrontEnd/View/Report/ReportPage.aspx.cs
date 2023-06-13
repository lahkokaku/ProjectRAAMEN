using ProjectRAAMENFrontEnd.Controller;
using ProjectRAAMENFrontEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectRAAMENFrontEnd.View.Report
{
    public partial class ReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (UserController.GetUserById((int)Session["user"]).RoleId != 1)
                Response.Redirect("~/View/HomePage.aspx");

            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            report.SetDataSource(getData(HeaderController.GetAllHeader()));
        }

        protected DataSet1 getData(List<Header> HeaderList)
        {
            DataSet1 data = new DataSet1();
            var header = data.Header;
            var detail = data.Detail;

            foreach(Header h in HeaderList)
            {
                var hrow = header.NewRow();
                hrow["Id"] = h.Id;
                hrow["CustomerId"] = h.CustomerId;
                hrow["Date"] = h.Date;
                var grandtotal = 0;
                foreach (Detail d in h.Details)
                {
                    var drow = detail.NewRow();
                    drow["HeaderId"] = d.HeaderId;
                    drow["RamenId"] = d.RamenId;
                    drow["Price"] =  "Rp."+ d.Raman.Price.ToString();
                    drow["Quantity"] = d.Quantity;
                    drow["SubTotal"] =  "Rp." + (d.Quantity * Int32.Parse(d.Raman.Price)).ToString();
                    detail.Rows.Add(drow);
                    grandtotal += d.Quantity * Int32.Parse(d.Raman.Price);
                }
                hrow["GrandTotal"] = "Rp." + grandtotal.ToString();
                header.Rows.Add(hrow);
            }
            return data;
        }
    }
}