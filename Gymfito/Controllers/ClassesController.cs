using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class ClassesController : Controller
    {
        public IActionResult Classes()
        {
            return View();
        }
    }
}
