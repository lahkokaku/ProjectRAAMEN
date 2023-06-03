using ProjectRAAMEN.Factory;
using ProjectRAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRAAMEN.Repository
{
    public class UserRepository
    {
        public static LocalDatabaseEntities db = new LocalDatabaseEntities();
        public static void InsertCustomer(String Username, String Email, String Gender, String Password)
        {
            User newCustomer = UserFactory.CreateCustomer(Username, Email, Gender, Password);
            db.Users.Add(newCustomer);
            db.SaveChanges();
        }
        public static void InsertStaff(String Username, String Email, String Gender, String Password)
        {
            User newStaff = UserFactory.CreateStaff(Username, Email, Gender, Password);
            db.Users.Add(newStaff);
            db.SaveChanges();
        }
        public static User GetUserByUsernameAndPassword(String Username, String Password)
        {
            User SelectedUser = (from i in db.Users 
                                 where i.Username.Equals(Username) && i.Password.Equals(Password) 
                                 select i).FirstOrDefault();
            return SelectedUser;
        }

        public static User GetUserById(int Id)
        {
            User SelectedUser = (from i in db.Users 
                                 where i.Id == Id 
                                 select i).FirstOrDefault();
            return SelectedUser;
        }

        public static String UpdateUserProfile(String Username, String Email, String Gender, int Id)
        {
            User SelectedUser = (from i in db.Users where i.Id == Id select i).FirstOrDefault();

            if (SelectedUser != null)
            {
                SelectedUser.Username = Username;
                SelectedUser.Email = Email;
                SelectedUser.Gender = Gender;
                return "Successfuly Updated";
            }
            return "User not found";
        }
    }
}