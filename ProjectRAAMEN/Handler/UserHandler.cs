﻿using ProjectRAAMEN.Model;
using ProjectRAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRAAMEN.Handler
{
    public class UserHandler
    {
        public static string InsertCustomer(String Username, String Email, String Gender, String Password)
        {
            if (UserRepository.GetUserByUsername(Username) != null)
                return "Username taken";
            if (UserRepository.GetUserByEmail(Email) != null)
                return "Email taken";

            UserRepository.InsertCustomer(Username, Email, Gender, Password);
            return "Success. Please Login using the credentials";
        }
        public static string InsertStaff(String Username, String Email, String Gender, String Password)
        {
            if (UserRepository.GetUserByUsername(Username) != null)
                return "Username taken";
            if (UserRepository.GetUserByEmail(Email) != null)
                return "Email taken";

            UserRepository.InsertStaff(Username, Email, Gender, Password);
            return "Success. Please Login using the credentials";
        }

        public static User GetUserByUsernameAndPassword(String Username, String Password)
        {
            User SelectedUser = UserRepository.GetUserByUsernameAndPassword(Username, Password);
            return SelectedUser;
        }

        public static User GetUserById(int Id)
        {
            User SelectedUser = UserRepository.GetUserById(Id);
            return SelectedUser;
        }

        public static String UpdateUserProfile(String Username, String Email, String Gender, int Id)
        {
            return UserRepository.UpdateUserProfile(Username, Email, Gender, Id);
        }

        public static List<User> GetAllCustomer()
        {
            return UserRepository.GetAllCustomer();
        }
        
        public static List<User> GetAllStaff()
        {
            return UserRepository.GetAllStaff();
        }
    }
}