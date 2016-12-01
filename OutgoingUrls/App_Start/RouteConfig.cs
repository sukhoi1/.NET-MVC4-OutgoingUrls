﻿using System.Configuration;
using System.Web.Mvc;
using System.Web.Routing;

namespace OutgoingUrls
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            if (bool.Parse(ConfigurationManager.AppSettings["DefaultControllerIsDemo"]) == false)
            {
                routes.MapRoute(
                    name: "NewRoute",
                    url: "App/Do{action}",
                    defaults: new { controller = "Home" },
                    namespaces: new[] { "OutgoingUrls.Controllers" }
                    );
            }
            else
            {
                routes.MapRoute(
                    name: "NewRoute",
                    url: "App/Do{action}",
                    defaults: new { controller = "Demo" },
                    namespaces: new[] { "OutgoingUrls.Controllers" }
                    );
            }

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "OutgoingUrls.Controllers" }
            );
        }
    }
}
