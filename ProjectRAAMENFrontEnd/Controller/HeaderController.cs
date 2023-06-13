using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectRAAMENFrontEnd.localhost;
using ProjectRAAMENFrontEnd.Model;
using ProjectRAAMENFrontEnd.Util;

namespace ProjectRAAMENFrontEnd.Controller
{
    public class HeaderController
    {
        public static WebService WebService = new WebService();
        public static Header InsertHeader(int customerId, int staffId, DateTime date)
        {
            return JsonHandler.Decode<Header>(WebService.InsertHeader(customerId,staffId,date));
        }
        
        public static List<Header> GetAllHeader()
        {
            return JsonHandler.Decode<List<Header>>(WebService.GetAllHeader());
        }
    }
}