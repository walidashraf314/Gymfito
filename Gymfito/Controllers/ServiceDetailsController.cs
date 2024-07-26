using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class ServiceDetailsController : Controller
    {
        public IActionResult ServiceDetails()
        {
            return View();
        }
    }
}
