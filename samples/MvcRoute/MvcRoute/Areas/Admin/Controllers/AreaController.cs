﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRoute.Areas.Admin.Controllers
{
    public class AreaController : Controller
    {
        // GET: Admin/Area
        public ActionResult Index()
        {
            return View();
        }
    }
}