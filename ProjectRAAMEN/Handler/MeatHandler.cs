using ProjectRAAMEN.Model;
using ProjectRAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRAAMEN.Handler
{
    public class MeatHandler
    {
        public static List<Meat> GetAllMeat()
        {
            return MeatRepository.GetAllMeat();
        }
    }
}