using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectRAAMEN.Factory;
using ProjectRAAMEN.Model;

namespace ProjectRAAMEN.Repository
{
    public class DetailRepository
    {
        public static LocalDatabaseEntities db = new LocalDatabaseEntities();
        public static void InsertDetail(int headerId, int ramenId, int quantity)
        {
            Detail newDetail = DetailFactory.CreateDetail(headerId, ramenId, quantity);
            db.Details.Add(newDetail);
            db.SaveChanges();
        }
    }
}