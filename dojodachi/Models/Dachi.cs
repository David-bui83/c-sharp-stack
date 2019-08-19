using System.ComponentModel.DataAnnotations;
namespace dojodachi.Models
{
    public class Dachi
    {
        [Required(ErrorMessage="Name cannot be empty.")]
        [MinLength(2,ErrorMessage="Name must be at least 2 characters.")]
        public string Name {get;set;}
        public int Fullness {get;set;}
        public int Happiness {get;set;}
        public int Meals {get;set;}
        public int Energy {get;set;}

        public string Msg {get;set;}
        
        public Dachi(){}
        public Dachi(int fullness, int happiness, int meals, int energy, string msg)
        {  
            Fullness=fullness;
            Happiness=happiness;
            Meals=meals;
            Energy=energy;
            Msg=msg;
        }
    }
}