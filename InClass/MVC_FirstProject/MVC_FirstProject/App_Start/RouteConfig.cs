using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_FirstProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // new method, attribute routing
            // enable this first then go to the actions
            routes.MapMvcAttributeRoutes();

            /* old method - custom routes
            // custom customers route
            routes.MapRoute(
                name: "CustomerIndex",
                url: "Customer/Index/{pageIndex}/{sortby}",
                defaults: new { controller = "Customer", action = "Index" }
                // custom constrains for inputs
                //constraints: new {index= @"^[0-9]{1,2}$" } find a working regex...
                // constraints: new { inputName = reg exp }
            );
            */
            // default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            
        }
    }
}
