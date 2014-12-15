﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcTest
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



      routes.MapRoute(
        name: "MyRoute",
        url: "Blog/{day}/{month}/{year}",
        defaults: new
        {
          controller = "Route",
          action = "Test",
          day = DateTime.Now.Day,
          month = DateTime.Now.Month,
          year = DateTime.Now.Year
        }
      );

      routes.MapRoute(
          name: "Default",
          url: "{controller}/{action}/{id}",
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
      );
    }
  }
}