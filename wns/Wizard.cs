namespace wns
{
    class Wizard : Human
    {
        public Wizard(string name,int health = 50):base(name,health){
            // Health = 50;
            Intelligence = 25;

        }
        public override int Attack(Human target){
            int dmg = 5 * Intelligence;
            target.Health -= dmg;
            Health += 5 * Intelligence;
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} and received {dmg} health.");
            return target.Health;
        }
        public int Heal(Human target){
            int heal = 10 * Intelligence;
            target.Health += heal;
            System.Console.WriteLine($"{Name} performed heal of {heal} health to {target.Name}");
            return target.Health;
        }
    }
}