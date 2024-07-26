using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
