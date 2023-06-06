using ProjectRAAMEN.Factory;
using ProjectRAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRAAMEN.Repository
{
    public class RamenRepository
    {
        public static LocalDatabaseEntities db = new LocalDatabaseEntities();
        public static void InsertRamen(string RamenName, int MeatId, string Broth, int Price)
        {
            Raman NewRamen = RamenFactory.CreateRamen(RamenName, MeatId, Broth, Price);
            db.Ramen.Add(NewRamen);
            db.SaveChanges();
        }
        public static List<Raman> GetAllRamen()
        {
            return (from i in db.Ramen select i).ToList();
        }
        public static string UpdateRamen(int Id, string RamenName, int MeatId, string Broth, int Price)
        {
            Raman SelectedRamen = (from i in db.Ramen where i.Id == Id select i).FirstOrDefault();
            if(SelectedRamen == null)
            {
                return "Ramen not found";
            }

            SelectedRamen.Name = RamenName;
            SelectedRamen.MeatId = MeatId;
            SelectedRamen.Broth = Broth;
            SelectedRamen.Price = Price.ToString();

            db.SaveChanges();

            return "Successfully Updated";
        }
        public static string DeleteRamen(int Id)
        {
            Raman SelectedRamen = (from i in db.Ramen where i.Id == Id select i).FirstOrDefault();
            if (SelectedRamen == null)
            {
                return "Ramen not found";
            }

            db.Ramen.Remove(SelectedRamen);
            db.SaveChanges();

            return "Successfully Deleted";
        }
        public static Raman GetRamenById(int Id)
        {
            return (from i in db.Ramen where i.Id == Id select i).FirstOrDefault();
        }
    }
}