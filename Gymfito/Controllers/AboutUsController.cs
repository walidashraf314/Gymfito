using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
