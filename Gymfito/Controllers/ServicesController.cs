using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Services()
        {
            return View();
        }
    }
}
