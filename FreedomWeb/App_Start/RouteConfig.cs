﻿using FreedomWeb.ViewModels.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FreedomWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ErrorRoute",
                url: "Error/Oops/{code}/{errInfo}",
                defaults: new { controller = "Error", action = "Oops", code = ErrorCode.ErrDefault, errInfo = (HandleErrorInfo)null }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
