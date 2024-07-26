using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class TrainerController : Controller
    {
        public IActionResult Trainer()
        {
            return View();
        }
    }
}
