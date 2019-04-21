using System.Web.Mvc;

namespace UHRMS.Controllers
{

    [Authorize]
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult MakePayment()
        {
            return View();
        }
    }
}