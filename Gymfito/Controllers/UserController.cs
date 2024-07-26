using Gymfito.Data;
using Gymfito.Models;
using Gymfito.Repository;
using Gymfito.Repository.IRepository;
using Gymfito.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gymfito.Controllers
{
	public class UserController : Controller
	{
		private readonly ApplicationDbContext context;
		private readonly IUserRepository userRepository;
		private readonly User user;
		public UserController(ApplicationDbContext context, IUserRepository userRepository,User user)
        {
			this.userRepository = userRepository;
			this.context = context;
			this.user = user;
		}
		
	
		// GET: UserController
		public ActionResult Index()
		{
			var listOfUsers = userRepository.GetUsers();
			return View(listOfUsers);
		}

		// GET: UserController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: UserController/Create
		[HttpPost]
		public ActionResult Create(UserVM userVM)
		{
			if (ModelState.IsValid)
			{
				// Mapping
				User user = new User()
				{

					FullName = userVM.FullName,
					Email = userVM.Email,
					Phone = userVM.Phone,
				};
			
				userRepository.CreateUser(user);
				//context.Users.Add(user);
				context.SaveChanges();

				TempData["alert"] = "Done !";
			}

			return View();
		}

		// GET
		public ActionResult Edit(int id)
		{
			var listOfUsers = userRepository.UpdateUser;
			return View(listOfUsers);
		}
		//Post
		[HttpPost]
		public ActionResult Edit(UserVM userVM)
		{

			if (ModelState.IsValid)
			{
				// Mapping

				User user = new User()
				{
					Id = userVM.Id,
					FullName = userVM.FullName,
					Email = userVM.Email,
					Phone = userVM.Phone
				};
				userRepository.UpdateUser(user);
				//context.Users.Update(user);
				//context.SaveChanges();

				TempData["alert"] = "Updated successfuly";

				return RedirectToAction("Index");
			}
			return View();
		}

		// GET
		[HttpPost]
		public ActionResult Delete(int id)
		{
			var user = userRepository.DeleteUser;
			return View(user);
		}


	//	[HttpPost]
		
	//	public ActionResult Delete(int id)
	//		try
	//		{
	//			return RedirectToAction(nameof(Index));
	//		}
	//		catch
	//		{
	//			return View();
	//		}
	//	}
	}
}
