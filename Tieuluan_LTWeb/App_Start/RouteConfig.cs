using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tieuluan_LTWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            // Dang ky
            routes.MapRoute(
                name: "Dang Ky",
                url: "register",
                defaults: new { controller = "Login", action = "Register", id = UrlParameter.Optional },
                namespaces: new[] { "Tieuluan_LTWeb.Controllers" }
            );


            // Dang nhap
            routes.MapRoute(
                name: "Dang Nhap",
                url: "log-in",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional },
                namespaces: new[] { "Tieuluan_LTWeb.Controllers" }
            );

            //Chu de
            routes.MapRoute(
                name: "Chu de",
                url: "topic/{idcd}",
                defaults: new { controller = "Phim", action = "Film", id = UrlParameter.Optional },
                namespaces: new[] { "Tieuluan_LTWeb.Controllers" }
            );

            // Xem Phim
            routes.MapRoute(
                name: "Xem Phim",
                url: "xem-phim/{id}",
                defaults: new { controller = "Home", action = "XemPhim", id = UrlParameter.Optional },
                namespaces: new[] { "Tieuluan_LTWeb.Controllers" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Tieuluan_LTWeb.Controllers" }
            );
        }
    }
}
