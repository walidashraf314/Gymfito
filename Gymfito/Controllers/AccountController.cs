using Gymfito.Models;
using Gymfito.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gymfito.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Applicationuser> userManager;
		private readonly SignInManager<Applicationuser>signInManager;
		public AccountController(UserManager<Applicationuser>userManager,SignInManager<Applicationuser>signInManager)
        {

            this.userManager = userManager;
            this.signInManager=signInManager;   
                 
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Register(ApplicationuserVM userVM)
        {
            if (ModelState.IsValid)
            {
                Applicationuser user = new Applicationuser()
                {
                    UserName = userVM.Name,
                    Email = userVM.Email,
                    PhoneNumber = userVM.phoneNumber,
                    Adress = userVM.Adress,

                };

                var result = await userManager.CreateAsync(user, userVM.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Password", "Don't match constrine");
                }
                
            }
            return View();
        }
        public IActionResult Login() 
        {
            return View();
        }

        [HttpPost]
		public async Task< IActionResult > Login(LoginVM uservm)
		{
            if(ModelState.IsValid) 
            {
              var user= await userManager.FindByNameAsync(uservm.UserName);
                if (user != null)
                {
                    //check password
                 var check=  await userManager.CheckPasswordAsync(user, uservm.Password);
                    if (check)
                    {
                        //login
                        await signInManager.SignInAsync(user, uservm.RememberMe);
                        return RedirectToAction("Index" , "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("Password", "invalid Password");
                    }
                }
                else
                {
                    ModelState.AddModelError("user", "invalid username");
                }
            }
			return View();
		}
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}

	}
}
