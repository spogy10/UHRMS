﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UHRMS.Controllers
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

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Garvey()
        {
            return View();
        }

        public ActionResult Denis()
        {
            return View();
        }

        public ActionResult Lome()
        { return View(); }

        public ActionResult Farquharson()
        {
            return View();
        }
    }
}