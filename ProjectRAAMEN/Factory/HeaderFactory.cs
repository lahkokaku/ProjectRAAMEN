using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectRAAMEN.Model;


namespace ProjectRAAMEN.Factory
{
    public class HeaderFactory
    {
        public static Header CreateHeader(int customerId, int staffId, DateTime date)
        {
            Header header = new Header();
            header.CustomerId = customerId;
            header.StaffId = staffId;
            header.Date = date;
            return header;
        }
    }
}