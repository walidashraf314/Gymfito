using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gymfito.ViewModels
{
    public class ApplicationuserVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [DataType(DataType.Password)]
        public string Password { get; set;}= null!;
        [DataType(DataType.EmailAddress)]
        public string Email { get; set;}=null!;
        [DataType(DataType.Password)]
        [Compare("Password")]
        [DisplayName("PasswordConfirmed")]
        public string confirmPassword { get; set;} = null!;
        public string ?phoneNumber { get; set;}
        public string Adress { get; set; } = null!;
        }
}
