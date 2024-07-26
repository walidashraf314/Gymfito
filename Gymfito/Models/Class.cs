namespace Gymfito.Models
{
	public class Class
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Place { get; set; } = null!;
		public string Schedule { get; set; } = null!;
		public string ShortDescr { get; set; } = null!;
		public string LongDescr { get; set; } = null!;
		public string Duration { get; set; } = null!;
		public string Img { get; set; } 
		public List<User> Users { get; set; }
		public Trainer Trainer { get; set; }
	}
}
