using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bán_Hàng_Onl_WebForm
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Catelogy", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "them-gio-hang",
                url: "them-gio-hang",
                defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
                namespaces: new[] {"Bán_Hàng_Onl_WebForm.Controllers"}
            );

            routes.MapRoute(
               name: "Cart",
               url: "gio-hang",
               defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "Bán_Hàng_Onl_WebForm.Controllers" }
           );

        }
    }
}
