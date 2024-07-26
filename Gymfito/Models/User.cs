﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Gymfito.Models
{
	public class User
	{
		public int Id { get; set; }
		[DisplayName("Full Name")]
		public string FullName { get; set; } = null!;
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; } = null!;
		public string? Phone { get; set; }
		public List<Class> Classes { get; set; }
	}
}