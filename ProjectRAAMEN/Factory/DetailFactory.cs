using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectRAAMEN.Model;

namespace ProjectRAAMEN.Factory
{
    public class DetailFactory
    {
        public static Detail CreateDetail(int headerId, int ramenId, int quantity)
        {
            Detail d = new Detail();
            d.HeaderId = headerId;
            d.RamenId = ramenId;
            d.Quantity = quantity;
            return d;
        }
    }
}