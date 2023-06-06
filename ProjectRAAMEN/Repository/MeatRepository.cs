using ProjectRAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRAAMEN.Repository
{
    public class MeatRepository
    {
        public static LocalDatabaseEntities db = new LocalDatabaseEntities();
        public static List<Meat> GetAllMeat()
        {
            return (from i in db.Meats select i).ToList();
        }
    }
}