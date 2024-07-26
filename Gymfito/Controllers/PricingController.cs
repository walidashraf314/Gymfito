using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Pricing()
        {
            return View();
        }
    }
}
