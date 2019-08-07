namespace hungry
{
    public class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int calories, bool isSpicy, bool isSweet){
            this.Name = name;
            this.Calories = calories;
            this.IsSpicy = isSpicy;
            this.IsSweet = isSweet;
        }
    }
}