﻿using Newtonsoft.Json;
using ProjectRAAMENFrontEnd.localhost;
using ProjectRAAMENFrontEnd.Model;
using ProjectRAAMENFrontEnd.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ProjectRAAMENFrontEnd.Controller
{
    public class UserController
    {
        public static WebService WebService = new WebService();
        public static String ValidateRegistration(String Username, String Email, String Gender, String Password, String ConfirmPassword, int Role)
        {
            if (Username.Length < 5 || Username.Length > 15)
                return "Username's lenght must be between 5 and 15 characters";
            if (!Username.Any(Char.IsLetter) || !Username.Any(Char.IsWhiteSpace))
                return "Username must and can only consists of Alphabet and Space only";
            
            foreach(char c in Username)
            {
                if (!Char.IsLetter(c) && !Char.IsWhiteSpace(c))
                    return "Username must and can only consists of Alphabet and Space only";
                else
                    continue;
            }

            if (!Email.EndsWith(".com"))
                return "Email must end with '.com'";
            if (Gender.Equals("Unselected"))
                return "Gender must be selected";
            if (Password.Equals(""))
                return "Password must be filled";
            if (!Password.Equals(ConfirmPassword))
                return "Password and Confirm Password didn't match";

            if (Role == 3)
                return JsonHandler.Decode<string>(WebService.InsertCustomer(Username, Email, Gender, Password));
            if (Role == 2)
                return JsonHandler.Decode<string>(WebService.InsertStaff(Username, Email, Gender, Password));

            return "Uncaught";
        }

        public static String ValidateLogin(String Username, String Password)
        {
            if (Username.Trim().Equals("") || Password.Trim().Equals(""))
                return "Username and Passowrd must be filled";

            return "";
        }

        public static String ValidateUpdateUserProfile(String Username, String Email, String Gender, String Password, int Id)
        {
            if (Username.Length < 5 || Username.Length > 15)
                return "Username's lenght must be between 5 and 15 characters";
            if (!Username.Any(Char.IsLetter) || !Username.Any(Char.IsWhiteSpace))
                return "Username must consists of Alphabet and Space only";
            if (!Email.EndsWith(".com"))
                return "Email must end with '.com'";
            if (Gender.Equals("Unselected"))
                return "Gender must be selected";
            if (Password != GetUserById(Id).Password)
                return "Password doesn't match your credentials";
            else
                return JsonHandler.Decode<string>(WebService.UpdateUserProfile(Username, Email, Gender, Id));

        }

            public static User GetUserByUsernameAndPassword(String Username, String Password)
        {
            return JsonHandler.Decode<User>(WebService.GetUserByUsernameAndPassword(Username, Password));
        }

        public static User GetUserById(int Id)
        {
            return JsonHandler.Decode<User>(WebService.GetUserById(Id));
        }

        public static List<User> GetAllCustomer()
        {
            return JsonHandler.Decode<List<User>>(WebService.GetAllCustomer());
        }

        public static List<User> GetAllStaff()
        {
            return JsonHandler.Decode<List<User>>(WebService.GetAllStaff());
        }
    }
}