using System.ComponentModel.DataAnnotations;

namespace Gymfito.ViewModels
{
	public class LoginVM
	{
        public int Id { get; set; }
		public string UserName { get; set; } = null!;
		[DataType(DataType.Password)]
		public string Password { get; set; }= null!;
		public bool RememberMe { get; set; }

    }
}
