using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three basic arrays
            int[] intArray = {0,1,2,3,4,5,6,7,8,9};
            string[] nameArray = {"Tim","Martin","Nikki","Sara"};
            bool[] booArray = {true,false,true,false,true,false,true,false,true,false};
            
            // List of Flavors
            List<string> flavors = new List<string>();
            flavors.Add("chocolate");
            flavors.Add("vanilla");
            flavors.Add("strawberry");
            flavors.Add("rocky road");
            flavors.Add("mint");

            System.Console.WriteLine(flavors.Count);
            System.Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            System.Console.WriteLine(flavors.Count);

            // User Info Dictionary
            Dictionary<string,string> user = new Dictionary<string,string>();
            user.Add("Tim","chocolate");
            user.Add("Martin","vanilla");
            user.Add("Nikki","strawberry");
            user.Add("sara","rocky road");

            foreach(var item in user){
                System.Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
