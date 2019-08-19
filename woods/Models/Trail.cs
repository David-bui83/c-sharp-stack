using System.ComponentModel.DataAnnotations;
namespace woods.Models
{
    public class Trail
    {
        [Key]
        public long Id {get;set;}
        [Required(ErrorMessage="Name cannot empty")]
        [MinLength(2,ErrorMessage="Name must be at least 2 characters")]
        public string Name {get; set;}
        [Required(ErrorMessage="Description cannot be empty")]
        [MinLength(1,ErrorMessage="Description needs to be at least 20 characters")]
        public string Description {get;set;}
        [Required(ErrorMessage="Trail length is required")]
        public double Distance {get;set;}
        [Required(ErrorMessage="Elevation is required")]
        public double Elevation {get;set;}
        [Required(ErrorMessage="Longitude is required")]
        public double Longitude {get;set;}
        [Required(ErrorMessage="Latitude is requried")]
        public double Latitude {get;set;}

        public Trail(){}
    }
}