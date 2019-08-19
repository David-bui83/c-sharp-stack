using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chef.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required(ErrorMessage="Dish name cannot be empty")]
        [MinLength(2,ErrorMessage="Dish name must be 2 characters or more")]
        public string DishName {get;set;}

        [Required(ErrorMessage="Calories cannot be empty")]
        [Calories]
        public int? Calories {get;set;}

        [Required(ErrorMessage="Tastiness cannot be empty")]
        [Range(1,5,ErrorMessage="Tastiness must be from 1 to 5")]
        public int? Tastiness {get;set;}

        [Required(ErrorMessage="Description cannot be zero")]
        public string Description {get;set;}    

        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}   

        [Required(ErrorMessage="Need to have a chef id")]
        public int ChefId {get;set;}
         
        public Chef Creator {get;set;}
    }

    public class CaloriesAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value==null || value.ToString().Length == 0 || (int)value < 0)
            {
                return new ValidationResult("Colories must be greater than zero");
            }
            return ValidationResult.Success;
        }
    }
}