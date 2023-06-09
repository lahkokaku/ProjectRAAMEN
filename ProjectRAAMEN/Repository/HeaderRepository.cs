using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectRAAMEN.Factory;
using ProjectRAAMEN.Model;

namespace ProjectRAAMEN.Repository
{
    public class HeaderRepository
    {
        public static LocalDatabaseEntities db = new LocalDatabaseEntities();

        public static Header InsertHeader(int customerId, int staffId, DateTime date)
        {
            Header newHeader = HeaderFactory.CreateHeader(customerId, staffId,date);
            db.Headers.Add(newHeader);
            db.SaveChanges();
            return newHeader;
        }


    }
}