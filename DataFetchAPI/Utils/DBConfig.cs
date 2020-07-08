using System;
using System.Configuration;
using System.Net;
using DataFetchAPI.ODataRef;

namespace DataFetchAPI.Utils
{
    public class DBConfig
    {
        public static NAV ODataObj()
        {
            NAV nav = new NAV(new Uri(ConfigurationManager.AppSettings["ODATA_URI"]))
            {
                Credentials = new NetworkCredential(ConfigurationManager.AppSettings["W_USER"],
                    ConfigurationManager.AppSettings["W_PWD"], ConfigurationManager.AppSettings["DOMAIN"])
            };
            return nav;
        }
       
    }
}