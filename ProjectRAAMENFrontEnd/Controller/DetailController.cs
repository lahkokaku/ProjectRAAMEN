using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectRAAMENFrontEnd.localhost;
using ProjectRAAMENFrontEnd.Model;
using ProjectRAAMENFrontEnd.Util;

namespace ProjectRAAMENFrontEnd.Controller
{
    public class DetailController
    {
            public static WebService WebService = new WebService();
            public static string InsertDetail(int headerId, int ramenId, int quantity)
            {
                return JsonHandler.Decode<string>(WebService.InsertDetail(headerId, ramenId, quantity));
            }

            public static List<Detail> GetDetailById(int Id)
            {
                return JsonHandler.Decode<List<Detail>>(WebService.GetDetailById(Id));
            }
    }
}