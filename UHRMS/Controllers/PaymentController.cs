using System.Web.Mvc;

namespace UHRMS.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult MakePayment()
        {
            return View();
        }
    }
}