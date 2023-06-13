using ProjectRAAMENFrontEnd.Model;
using ProjectRAAMENFrontEnd.View.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectRAAMENFrontEnd.Controller;


namespace ProjectRAAMENFrontEnd.View.Report
{
    public partial class ReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport report = new CrystalReport();
            CrystalReportViewer1.ReportSource = report;
            DataSet data = getData(HeaderController.GetAllHeader());
            report.SetDataSource(data);
        }

        private DataSet getData(List<Header> transactions)
        {
            DataSet data = new DataSet();
            var headertable = data.TransactionHeader;
            var detailtable = data.TransactionDetail;

            foreach(Header h in transactions)
            {
                var hrow = headertable.NewRow();
                hrow["Id"] = h.Id;
                hrow["CustomerId"] = h.CustomerId;
                hrow["StaffId"] = h.StaffId;
                hrow["Date"] = h.Date;
                headertable.Rows.Add(hrow);

                foreach (Detail d in h.Details)
                {
                    var drow = detailtable.NewRow();
                    drow["HeaderId"] = d.HeaderId;
                    drow["RamenId"] = d.HeaderId;
                    drow["Quantity"] = d.Quantity;
                    detailtable.Rows.Add(drow);
                }
            }
            return data;
        }

    }
}