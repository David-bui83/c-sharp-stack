using System;
using System.Collections.Generic;

namespace hungry
{
    public class Buffet
    {
        public List<Food> Menu;
        public Buffet(){
            Menu = new List<Food>(){
                new Food("Lobster", 1000,false,false),
                new Food("Steak", 900,false,false),
                new Food("King Crab", 850,false,false),
                new Food("Spicy Chicken", 1000,true,false),
                new Food("Mashed Potatoes", 800,false,false),
                new Food("Baked Fish", 500,false,false),
                new Food("Steamed Vegitables", 200,false,false)
            };
        }
        public Food Serve(){
            Random rand = new Random();
            return this.Menu[rand.Next(0,Menu.Count)];
        }
    }
}