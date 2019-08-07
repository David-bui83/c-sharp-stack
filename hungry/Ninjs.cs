using System.Collections.Generic;
namespace hungry
{
    public class Ninjs
    {
        private int caloriesIntake;
        public List<Food> FoodHistory;

        public Ninjs(){
            this.caloriesIntake = 0;
            this.FoodHistory = new List<Food>();
        }
        public bool isFull{
            get{
                if(this.caloriesIntake > 1200){
                    return true;
                }
                return false;
            }
        }
        public void Eat(Food item){
            this.caloriesIntake += item.Calories;
        }
    }
}