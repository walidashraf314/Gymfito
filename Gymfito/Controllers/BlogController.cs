using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
