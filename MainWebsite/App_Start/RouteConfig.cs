using System.Web.Mvc;
using System.Web.Routing;

namespace MainWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{action}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "500Error",
                url: "{controller}/{action}",
                defaults: new { controller = "Error", action = "InternalServerError", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "400Error",
                url: "{controller}/{action}",
                defaults: new { controller = "Error", action = "NotFound", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Error",
                url: "{*url}",
                defaults: new { controller = "Error", action = "Default", id = UrlParameter.Optional }
            );
        }
    }
}
