using System.ComponentModel.DataAnnotations;
using System;
namespace crudelicious.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId {get;set;}
        [Required(ErrorMessage="Recipe name cannot be empty")]
        public string Name {get;set;}
        [Required(ErrorMessage="Chef name cannot be empty")]
        public string Chef {get;set;}
        [Required(ErrorMessage="Rating for Tastiness is required")]
        [Range(1,5,ErrorMessage="Rating must be between 1 and 5")]
        public int Tastiness {get;set;}
        [Required(ErrorMessage="Calories is required")]

        [PositiveCalories]
        public int? Calories {get;set;}
        [Required(ErrorMessage="Description is required")]
        public string Description {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }

    public class PositiveCaloriesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
        ValidationContext validationContext)
        {
            if (value == null || value.ToString().Length == 0 || (int)value<=0)
                return new ValidationResult("Calories must be greater than 0.");
            return ValidationResult.Success;
        }
    }
}