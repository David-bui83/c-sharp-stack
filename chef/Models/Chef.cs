using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace chef.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        
        [Required(ErrorMessage="First name cannot be empty")]
        [MinLength(2,ErrorMessage="First name must be 2 characters or more")]
        public string FirstName {get;set;}

        [Required(ErrorMessage="Last name cannot be empty")]
        [MinLength(2,ErrorMessage="Last name must be 2 characters or more")]
        public string LastName {get;set;}

        [Required(ErrorMessage="Date of birth cannot be empty")]
        [FutureDate]
        [Age]
        public DateTime? DOB {get;set;}

        public DateTime CreatedAt {get;set;}

        public DateTime UpdatedAt {get;set;}

        public List<Dish> CreateDishes {get;set;}
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
    public class AgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ( DateTime.Today.Year - Convert.ToDateTime(value).Year < 18)
                return new ValidationResult("Chef age must be 18 or over!");
            return ValidationResult.Success;
        }
    }

}