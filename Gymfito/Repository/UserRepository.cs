using Gymfito.Data;
using Gymfito.Models;
using Gymfito.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Gymfito.Repository
{
	public class UserRepository :IUserRepository
	{
		private readonly ApplicationDbContext context;
		public UserRepository(ApplicationDbContext context)
        {
			this.context = context;
        }
        public void CreateUser(User user)
		{
			context.Users.Add(user);
			context.SaveChanges();
		}

		public void DeleteUser(int id)
		{
			var user = context.Users.Find(id);
			context.Users.Remove(user);
			context.SaveChanges();
		}

		public User GetUser(int id)
		{
			var user = context.Users.Find(id);
			return user;
		}
		public List<User> GetUsersWithClasses()
		{
			var listOfUsers = context.Users.Include(e => e.Classes).ToList();
			return listOfUsers; 
		}
		public List<User> GetUsers()
		{
			var listOfUsers = context.Users.ToList();
			return listOfUsers;

		}

		public void UpdateUser(User user)
		{
			context.Users.Update(user);
			context.SaveChanges();
		}
	}
}
