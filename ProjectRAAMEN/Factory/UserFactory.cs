using ProjectRAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRAAMEN.Factory
{
    public class UserFactory
    {
        public static User CreateCustomer(String Username, String Email, String Gender, String Password)
        {
            User newCustomer = new User();
            newCustomer.RoleId = 3;
            newCustomer.Username = Username;
            newCustomer.Email = Email;
            newCustomer.Gender = Gender;
            newCustomer.Password = Password;

            return newCustomer;
        }
        public static User CreateStaff(String Username, String Email, String Gender, String Password)
        {
            User newStaff = new User();
            newStaff.RoleId = 2;
            newStaff.Username = Username;
            newStaff.Email = Email;
            newStaff.Gender = Gender;
            newStaff.Password = Password;

            return newStaff;
        }
    }
}