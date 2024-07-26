using System.ComponentModel.DataAnnotations;

namespace Gymfito.Models
{
	public class Trainer
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Job { get; set; } = null!;
		public string? Address { get; set; }
		[DataType(DataType.EmailAddress)]
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public string Specialized { get; set; } = null!;
		public string Img { get; set; }
		public List<Class> Classes { get; set; }
	}
}
