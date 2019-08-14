using System.ComponentModel.DataAnnotations;
namespace multiple.Models
{
    public class Login
    {
        [Required(ErrorMessage="Email cannot be empty.")]
        [EmailAddress(ErrorMessage="Email needs be in a valid format.")]
        public string LoginEmail {get; set;}
        
        [Required(ErrorMessage="Password cannot be empty.")]
        [MinLength(8,ErrorMessage="Password must be at least 8 characters.")]
        public string LoginPassword {get;set;}

        public Login(){}
    }
}