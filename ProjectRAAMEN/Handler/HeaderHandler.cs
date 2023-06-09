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
    }
}