namespace human
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;

        public Human(string name,  int strength, int intelligence){
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Dexterity = 3;
            this.Health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health){
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Dexterity = dexterity;
            this.Health = health;
        }

        public int Attack(Human target){
            return target.Health -= (5 * this.Strength);
        }
    }
}