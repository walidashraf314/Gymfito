using Gymfito.Models;

namespace Gymfito.Repository.IRepository
{
	public interface IUserRepository
	{
		List<User> GetUsers();
		List<User> GetUsersWithClasses();
		User GetUser(int id);
		void UpdateUser(User user);
		void DeleteUser(int id);
		void CreateUser(User user);
		
	}
}
