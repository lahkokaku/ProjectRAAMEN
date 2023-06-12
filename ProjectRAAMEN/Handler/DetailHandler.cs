using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectRAAMEN.Model;
using ProjectRAAMEN.Repository;

namespace ProjectRAAMEN.Handler
{
    public class DetailHandler
    {
        public static string InsertDetail(int headerId, int ramenId, int quantity)
        {
            DetailRepository.InsertDetail(headerId, ramenId, quantity);
            return "successfuly added";
        }
        public static List<Detail> GetDetailById(int Id)
        {
            return DetailRepository.GetDetailById(Id);
        }
    }
}