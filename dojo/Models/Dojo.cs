using System.ComponentModel.DataAnnotations;
namespace dojo.Models
{
    public class Dojo
    {
        [Required(ErrorMessage="Name cannot be empty")]
        [MinLength(2,ErrorMessage="Name must be at least 2 characters")]
        public string Name{get;set;}
        [Required(ErrorMessage="Must choose a location")]
        public string Location{get;set;}
        [Required(ErrorMessage="Must choose a location")]
        public string Language{get;set;}
        [MinLength(20,ErrorMessage="Comment must be at least 20 characters")]
        public string Comment{get; set;}

        public Dojo(){}
    }
}