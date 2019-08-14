using System.ComponentModel.DataAnnotations;
namespace multiple.Models
{
    public class Registration
    {
        [Required(ErrorMessage="First name cannot be empty.")]
        [MinLength(2,ErrorMessage="First name must be at least 2 characters.")]
        public string FirstName {get;set;}

        [Required(ErrorMessage="Last name cannt be empty.")]
        [MinLength(2,ErrorMessage="last name must be at least 2 characters.")]
        public string LastName {get;set;}

        [Required(ErrorMessage="Email cannot be empty.")]
        [EmailAddress(ErrorMessage="Email needs be in a valid format.")]
        public string Email {get; set;}
        
        [Required(ErrorMessage="Password cannot be empty.")]
        [MinLength(8,ErrorMessage="Password must be at least 8 characters.")]
        public string Password {get;set;}

        [Required(ErrorMessage="Confirm password cannot be empty.")]
        [Compare("Password",ErrorMessage = "Confirm password does not match password")]
        public string Confirm {get; set;}
        public Registration(){}
    }
}