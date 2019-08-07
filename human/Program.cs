using System;

namespace human
{
    class Program
    {
        // class Human {
        //     public string Name = "test";
        // }
        static void Main(string[] args)
        {
            Human bob = new Human("bob",5,3);
            // Human2 bob2 = new Human2();
            // Console.WriteLine(bob.Name);
            Console.WriteLine("New instance's name: " + bob.Name );
            Console.WriteLine($"{bob.Name}'s strength: " + bob.Strength);
            Console.WriteLine($"{bob.Name}'s intelligence: " + bob.Intelligence);
        }
    }

}
    // class Human2 {
    //     public string Name = "test2";
    // }
