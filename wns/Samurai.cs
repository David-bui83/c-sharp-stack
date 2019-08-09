namespace wns
{
    public class Samurai : Human
    {
        public Samurai(string name):base(name){
            Health = 200;
        }        
        public override int Attack(Human target){
            base.Attack(target);
            if(target.Health < 50){
                target.Health = 0;
                System.Console.WriteLine($"{Name} has slayed {target.Name}");
            }
            return target.Health;
        }
        public int Meditate(){
            Health = 200;
            System.Console.WriteLine($"{Name} meditated and received {Health} health");
            return Health;
        }
    }
}