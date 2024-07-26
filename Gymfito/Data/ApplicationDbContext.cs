using Gymfito.Models;
using Microsoft.EntityFrameworkCore;
using Gymfito.ViewModels;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Gymfito.Data
{
	public class ApplicationDbContext:IdentityDbContext<Applicationuser>
	{
		public DbSet<Class> Classes { get; set; }
		public DbSet<Trainer> Trainers { get; set; }
		public DbSet<User> Users { get; set; }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	   : base(options)
		{
		}
	    public DbSet<Gymfito.ViewModels.UserVM> UserVM { get; set; } = default!;
	    public DbSet<Gymfito.ViewModels.ApplicationuserVM> ApplicationuserVM { get; set; } = default!;
	    public DbSet<Gymfito.ViewModels.LoginVM> LoginVM { get; set; } = default!;
	    public DbSet<Gymfito.ViewModels.RoleVM> RoleVM { get; set; } = default!;
	}
}
