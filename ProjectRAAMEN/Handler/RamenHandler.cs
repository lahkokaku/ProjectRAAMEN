using ProjectRAAMEN.Model;
using ProjectRAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRAAMEN.Handler
{
    public class RamenHandler
    {
        public static string InsertRamen(string RamenName, int MeatId, string Broth, int Price)
        {
            RamenRepository.InsertRamen(RamenName, MeatId, Broth, Price);
            return "Successfully created";
        }

        public static List<Raman> GetAllRamen()
        {
            return RamenRepository.GetAllRamen();
        }

        public static string UpdateRamen(int Id, string RamenName, int MeatId, string Broth, int Price)
        {
            return RamenRepository.UpdateRamen(Id, RamenName, MeatId, Broth, Price);
        }

        public static string DeleteRamen(int Id)
        {
            return RamenRepository.DeleteRamen(Id);
        }
        public static Raman GetRamenById(int Id)
        {
            return RamenRepository.GetRamenById(Id);
        }
    }
}