using System;
namespace wns
{
    public class Ninja : Human
    {
        public Ninja(string name):base(name){
            Dexterity = 175;
        }
        public override int Attack(Human target){
            Random rand = new Random();
            int dmg;
            if(rand.Next(1,5)==1){
                dmg = (5 * Dexterity) + 10;
                target.Health -= 10;
            }else{
                dmg = 5 * Dexterity;
            }
            target.Health -= dmg;
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public int Steal(Human target){
            target.Health -= 5;
            int steal = Health + 5;
            System.Console.WriteLine($"{Name} stole {steal} health from {target.Name}");
            return target.Health;
        }
    }
}