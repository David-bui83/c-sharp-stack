using System.ComponentModel.DataAnnotations;
using System;
namespace submission.Models
{
    public class User
    {
        [Required(ErrorMessage="Please enter first name.")]
        [MinLength(2,ErrorMessage="First name must be at least 2 characters")]
        
        public string FirstName {get;set;}

        [Required(ErrorMessage="Please enter last name.")]
        [MinLength(2,ErrorMessage="Last name must be at least 2 characters")]
        public string LastName {get;set;}

        [Required(ErrorMessage="Age cannot be empty")]
        [Range(1,100,ErrorMessage="Age must be greater than zero.")]
        public int Age {get;set;}

        [Required(ErrorMessage="Please enter an email address.")]
        [EmailAddress(ErrorMessage="Please enter a valid email address")]
        public string Email {get;set;}

        [Required(ErrorMessage="Password cannot be empty")]
        [MinLength(8,ErrorMessage="Password must be at least 8 characters.")]
        public string Password {get; set;}

        [Required]
        [FutureDate]
        public string Date {get;set;}


        public User() {}
    }

    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToDateTime(value)>DateTime.Now)
                return new ValidationResult("Date must be in the past!");
            return ValidationResult.Success;
        }
    }
}