using System.Collections.Generic;
namespace hungry
{
    abstract class Ninjs
    {
        protected int caloriesIntake;
        public List<IConsumable> FoodHistory;

        public Ninjs(){
            this.caloriesIntake = 0;
            this.FoodHistory = new List<IConsumable>();
        }
        public abstract bool isFull{get;set;}
        public abstract void Consume(IConsumable item);
    }
}