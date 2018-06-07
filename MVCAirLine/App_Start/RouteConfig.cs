using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCAirLine
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.IgnoreRoute("{*allashx}", new{allashx=@".*\.ashx(/.*)?"});
            //routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");
            //routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");

            //routes.Ignore("{*legecy}", new { legecy = @".*\.(aspx|ashx|asmx|axd|svc)([/\?].*)?" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AirLine", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
