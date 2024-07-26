using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult Schedule()
        {
            return View();
        }
    }
}
