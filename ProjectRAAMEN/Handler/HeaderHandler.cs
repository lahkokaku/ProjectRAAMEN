using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectRAAMEN.Model;
using ProjectRAAMEN.Repository;
 
namespace ProjectRAAMEN.Handler
{
    public class HeaderHandler
    {
        public static Header InsertHeader(int customerId, int staffId, DateTime date)
        {
            Header header = HeaderRepository.InsertHeader(customerId, staffId, date);
            return header;

        }
        public static List<Header> GetAllHeader()
        {
            return HeaderRepository.GetAllHeader();
        }

        public static List<Header> GetAllHeaderByUserId(int UserId)
        {
            return HeaderRepository.GetAllHeaderByUserId(UserId);
        }

        public static List<Header> GetAllHandledHeader()
        {
            return HeaderRepository.GetAllHandledHeader();
        }

        public static List<Header> GetAllUnhandledHeader()
        {
            return HeaderRepository.GetAllUnhandledHeader();
        }

        public static string HandleHeader(int Id, int StaffId)
        {
            return HeaderRepository.HandleHeader(Id, StaffId);
        }
    }
}