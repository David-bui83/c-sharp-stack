using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> myList = new List<object>();

            myList.Add(78);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");

            int sum = 0;
            foreach(var item in myList){
                if(item is int){
                    System.Console.WriteLine("Integer: " + item);
                    sum += (int)item;
                }
                if(item is bool){
                    System.Console.WriteLine("Boolean: " +  item);
                }
                if(item is string){
                    System.Console.WriteLine("String: " + item);
                }
            }
            Console.WriteLine("Sum of all integers: " + sum);
            
        }
    }
}
