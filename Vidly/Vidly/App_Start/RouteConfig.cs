using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Construct custom using Attribute route(Newer and cleaner way of defining routes)
            routes.MapMvcAttributeRoutes(); 
           
            //Construct custom using normal route
         
            /*  routes.MapRoute(
                "MoviesByReleaseDate",  //Route name
                "movies/released/{year}/{month}",   //route url 
                new { controller="Movies", action="ByReleaseDate"},  //Specify controller and action
                new { year = @"\d{4}", month = @"\d{2}" }  // Here we specify the parameter constraints year=d{4} means only four digits can be accepted, month=d{2} means only two digits can be accepted
                );
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
