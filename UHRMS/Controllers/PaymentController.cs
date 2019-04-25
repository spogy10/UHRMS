using System.Web.Mvc;

namespace UHRMS.Controllers
{

    [Authorize(Roles = "Student")]
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult MakePayment()
        {
            return View();
        }
    }
}