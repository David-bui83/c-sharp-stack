using System;

namespace hungry
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Buffet lux = new Buffet();
            Ninjs jack = new Ninjs();

            jack.Eat(lux.Serve());
            System.Console.WriteLine(jack.isFull);
            
            jack.Eat(lux.Serve());
            System.Console.WriteLine(jack.isFull);
        }
    }
}
