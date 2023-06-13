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
            Header newHeader = HeaderFactory.CreateHeader(customerId, staffId, date);
            db.Headers.Add(newHeader);
            db.SaveChanges();
            return newHeader;
        }
        public static List<Header> GetAllHeader()
        {
            return (from i in db.Headers select i).ToList();
        }
        
        public static List<Header> GetAllHeaderByUserId(int UserId)
        {
            return (from i in db.Headers where i.User.Id == UserId select i).ToList();
        }

        public static List<Header> GetAllUndhadledHeader()
        {
            return (from i in db.Headers where i.StaffId == 0 select i).ToList();
        }

        public static string HandleHeader(int Id, int StaffId)
        {
            Header SelectedHeader = (from i in db.Headers where i.Id == Id select i).FirstOrDefault();

            if (SelectedHeader == null)
                return "Transaction not found";

            SelectedHeader.StaffId = StaffId;
            db.SaveChanges();

            return "Transaction " + Id.ToString() + " handled";
        }
    }
}