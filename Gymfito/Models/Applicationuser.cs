using Microsoft.AspNetCore.Identity;
namespace Gymfito.Models
{
    public class Applicationuser:IdentityUser
    {
        public string Adress { get; set; }
    }
}
