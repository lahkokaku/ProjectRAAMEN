using ProjectRAAMENFrontEnd.localhost;
using ProjectRAAMENFrontEnd.Model;
using ProjectRAAMENFrontEnd.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRAAMENFrontEnd.Controller
{
    public class MeatController
    {
        public static WebService WebService = new WebService();
        public static List<Meat> GetAllMeat()
        {
            return JsonHandler.Decode<List<Meat>>(WebService.GetAllMeat());
        }
    }
}