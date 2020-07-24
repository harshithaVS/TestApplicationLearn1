﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApplicationLearn1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //test mater rebase
            return View();
        }

        public ActionResult Contact()
        {
            //test push and resettest push and reset
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}