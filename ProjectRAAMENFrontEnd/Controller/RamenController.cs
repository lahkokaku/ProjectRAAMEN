using ProjectRAAMENFrontEnd.localhost;
using ProjectRAAMENFrontEnd.Model;
using ProjectRAAMENFrontEnd.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRAAMENFrontEnd.Controller
{
    public class RamenController
    {
        public static WebService WebService = new WebService();
        public static List<Raman> GetAllRamen()
        {
            return JsonHandler.Decode<List<Raman>>(WebService.GetAllRamen());
        }
        public static string InsertRamen(string RamenName, int MeatId, string Broth, int Price)
        {
            if (RamenName.Contains("Ramen") == false)
                return "Ramen Name must contain Ramen";
            if (Broth.Equals(""))
                return "Broth must not be empty";
            if (Price < 3000)
                return "Price must at least be 3000";

            return JsonHandler.Decode<string>(WebService.InsertRamen(RamenName, MeatId, Broth, Price));
        }
        public static string UpdateRamen(int Id, string RamenName, int MeatId, string Broth, int Price)
        {
            if (RamenName.Contains("Ramen") == false)
                return "Ramen Name must contain Ramen";
            if (Broth.Equals(""))
                return "Broth must not be empty";
            if (Price < 3000)
                return "Price must at least be 3000";

            return JsonHandler.Decode<string>(WebService.UpdateRamen(Id, RamenName, MeatId, Broth, Price));
        }
        public static string DeleteRamen(int Id)
        {
            return JsonHandler.Decode<string>(WebService.DeleteRamen(Id));
        }
        public static Raman GetRamenById(int Id)
        {
            return JsonHandler.Decode<Raman>(WebService.GetRamenById(Id));
        }
    }
}