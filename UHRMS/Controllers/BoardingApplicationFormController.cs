using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UHRMS.Controllers
{
    public class BoardingApplicationFormController : Controller
    {
        // GET: BoardingApplicationForm
        public ActionResult Create()
        {
            return View();
        }
    }
}