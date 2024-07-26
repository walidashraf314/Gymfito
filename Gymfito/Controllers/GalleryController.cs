using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Gallery()
        {
            return View();
        }
    }
}
