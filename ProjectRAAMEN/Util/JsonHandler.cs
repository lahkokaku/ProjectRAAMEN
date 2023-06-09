using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectRAAMEN.Model;


namespace ProjectRAAMEN.Util
{
    public class JsonHandler
    {
        public static String Encode(object Data)
        {
            return JsonConvert.SerializeObject(Data, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
        }
      
        public static T Decode<T>(String Data)
        {
            return JsonConvert.DeserializeObject<T>(Data);
        }
    }
}