using Newtonsoft.Json;
using ProjectRAAMEN.Handler;
using ProjectRAAMEN.Model;
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
            return UserHandler.InsertCustomer(Username, Password, Gender, Email);
        }

        [WebMethod]
        public string InsertStaff(string Username, string Password, string Gender, string Email)
        {
            return UserHandler.InsertStaff(Username, Password, Gender, Email);
        }

        [WebMethod]
        public string GetUserByUsernameAndPassword(String Username, String Password)
        {
            return JsonConvert.SerializeObject(UserHandler.GetUserByUsernameAndPassword(Username, Password), new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
        }

        [WebMethod]
        public string GetUserById(int Id)
        {
            return JsonConvert.SerializeObject(UserHandler.GetUserById(Id), new JsonSerializerSettings { ReferenceLoopHandling= ReferenceLoopHandling.Ignore });
        }
    }
}
