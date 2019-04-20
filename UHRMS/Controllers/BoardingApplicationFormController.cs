using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UHRMS.Models;

namespace UHRMS.Controllers
{
    public class BoardingApplicationFormController : Controller
    {
        // GET: BoardingApplicationForm
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BoardingApplicationForm form)
        {
            //todo:add form to database

            return RedirectToAction("Index", "Home");
        }
    }
}