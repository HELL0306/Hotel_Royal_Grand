using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hotel_Management_Project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
     name: "Reservation",
      url:"{id}/ShoppingManagment/{action}",
      new { controller = "Reservation", action = "Index", id = UrlParameter.Optional }              
                
            );

            routes.MapRoute(
     name: "Bill",
      url: "{id}/ShoppingManagment/{action}",
      new { controller = "Bill", action = "Index", id = UrlParameter.Optional }

            );
        }
    }
}
