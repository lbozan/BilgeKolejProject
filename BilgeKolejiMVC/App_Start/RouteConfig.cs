using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BilgeKolejProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "Yonetim",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Yonetim", action = "Index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
             name: "Ogrenci",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Ogrenci", action = "Index", id = UrlParameter.Optional }
            );

         

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Anasayfa", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
