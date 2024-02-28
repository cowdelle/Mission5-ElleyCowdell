using Microsoft.AspNetCore.Mvc;
using Mission5_ElleyCowdell.Models;

namespace Mission5_ElleyCowdell.Controllers
{
    public class TutoringController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculateTotal(double hours)
        {
            // Assuming hourly rate is $20
            double rate = 20.0;
            double total = hours * rate;
            return Json(total);
        }
    }
}

