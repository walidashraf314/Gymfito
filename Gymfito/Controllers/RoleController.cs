using Gymfito.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
	public class RoleController : Controller
	{
		private readonly RoleManager<IdentityRole> roleManager;

		public RoleController(RoleManager<IdentityRole>roleManager)
        {
            this.roleManager = roleManager;

		}
		//Account Admin
		//username:Walid AND Passward Aa@12345
        public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(RoleVM roleVM)
		{
			if (ModelState.IsValid) 
			{
				IdentityRole role = new IdentityRole()
				{ 
					Name = roleVM.Name,
				};
				await roleManager.CreateAsync(role);
				return RedirectToAction("index","Home");
			}
			return View();
		}
	}
}
