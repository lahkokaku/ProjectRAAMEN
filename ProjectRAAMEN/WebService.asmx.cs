﻿using Newtonsoft.Json;
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
    }
}
