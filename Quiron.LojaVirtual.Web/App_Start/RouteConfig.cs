using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Quiron.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                // controller = "Produtos" irá fazer com que a página inicial
                // seja a do controller fornecido.
                // action = "Index" é o action result a ser exibido
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Produtos", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
