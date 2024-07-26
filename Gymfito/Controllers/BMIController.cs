using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult BMI()
        {
            return View();
        }
    }
}
