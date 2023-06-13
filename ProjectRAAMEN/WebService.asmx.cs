using Newtonsoft.Json;
using ProjectRAAMEN.Handler;
using ProjectRAAMEN.Model;
using ProjectRAAMEN.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProjectRAAMEN
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string InsertCustomer(string Username, string Password, string Gender, string Email)
        {
            return JsonHandler.Encode(UserHandler.InsertCustomer(Username, Password, Gender, Email));
        }

        [WebMethod]
        public string InsertStaff(string Username, string Password, string Gender, string Email)
        {
            return JsonHandler.Encode(UserHandler.InsertStaff(Username, Password, Gender, Email));
        }

        [WebMethod]
        public string GetUserByUsernameAndPassword(String Username, String Password)
        {
            return JsonHandler.Encode(UserHandler.GetUserByUsernameAndPassword(Username, Password));
        }

        [WebMethod]
        public string GetUserById(int Id)
        {
            return JsonHandler.Encode(UserHandler.GetUserById(Id));
        }

        [WebMethod]
        public string UpdateUserProfile(String Username, String Email, String Gender, int Id)
        {
            return JsonHandler.Encode(UserHandler.UpdateUserProfile(Username, Email, Gender, Id));
        }

        [WebMethod]
        public string GetAllCustomer()
        {
            return JsonHandler.Encode(UserHandler.GetAllCustomer());
        }

        [WebMethod]
        public string GetAllStaff()
        {
            return JsonHandler.Encode(UserHandler.GetAllStaff());
        }
        [WebMethod]
        public string InsertRamen(string RamenName, int MeatId, string Broth, int Price)
        {
            return JsonHandler.Encode(RamenHandler.InsertRamen(RamenName, MeatId, Broth, Price));
        }
        [WebMethod]
        public string GetAllRamen()
        {
            return JsonHandler.Encode(RamenHandler.GetAllRamen());
        }
        [WebMethod]
        public string UpdateRamen(int Id, string RamenName, int MeatId, string Broth, int Price)
        {
            return JsonHandler.Encode(RamenHandler.UpdateRamen(Id, RamenName, MeatId, Broth, Price));
        }
        [WebMethod]
        public string DeleteRamen(int Id)
        {
            return JsonHandler.Encode(RamenHandler.DeleteRamen(Id));
        }
        [WebMethod]
        public string GetRamenById(int Id)
        {
            return JsonHandler.Encode(RamenHandler.GetRamenById(Id));
        }
        [WebMethod]
        public string GetAllMeat()
        {
            return JsonHandler.Encode(MeatHandler.GetAllMeat());
        }

        [WebMethod]
        public string InsertHeader(int customerId, int staffId, DateTime date)
        {
            return JsonHandler.Encode(HeaderHandler.InsertHeader(customerId, staffId, date));
        }

        [WebMethod]
        public string InsertDetail(int headerId, int ramenId, int quantity)
        {
            return JsonHandler.Encode(DetailHandler.InsertDetail(headerId, ramenId, quantity));
        }

        [WebMethod]
        public string GetAllHeader()
        {
            return JsonHandler.Encode(HeaderHandler.GetAllHeader());
        }
    }
}
