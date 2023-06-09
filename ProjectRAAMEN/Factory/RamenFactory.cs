    using ProjectRAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectRAAMEN.Factory
{
    public class RamenFactory
    {
        public static Raman CreateRamen(string RamenName, int MeatId, string Broth, int Price)
        {
            Raman NewRamen = new Raman();
            NewRamen.Name = RamenName;
            NewRamen.MeatId = MeatId;
            NewRamen.Broth = Broth;
            NewRamen.Price = Price.ToString();

            return NewRamen;
        }
    }
}