using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UHRMS.Controllers
{
    public class ComplaintsController : Controller
    {
        // GET: Complaints
        public ActionResult Index()
        {
            return View();
        }
    }
}