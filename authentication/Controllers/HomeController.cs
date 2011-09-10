﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cuatro.Common;

namespace Cuatro.MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profile(FoursquareUser user)
        {
            if (user != null)
                return View(user);
            else
                return View();
        }
    }
}
