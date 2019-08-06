using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            System.Console.WriteLine("Coin Toss: " + TossCoin());
            int num = 5;
            System.Console.WriteLine("Multiple Toss ratio: " + TossMultipleCoins(num).ToString());

            string[] names = {"Todd","Tiffany","Charlie","Geneva","Sydney"};
            foreach(var name in FuncNames(names)){
                System.Console.WriteLine("Names with more than 5 characters: " + name);
            }
        }   

        // Random Array
        public static void RandomArray(){
            int[] numArr = new int[10];
            int sum = 0;
            Random rand = new Random();
            for(var i = 0; i<numArr.Length; i++){
                numArr[i]=(rand.Next(5,25));
                System.Console.WriteLine("numArr[i]" + numArr[i].ToString());
            }
            int min = numArr[0];
            int max = numArr[0];
            
            for(var i = 0; i<numArr.Length; i++){
                if(min>numArr[i]){
                    min=numArr[i];
                }
                if(max<numArr[i]){
                    max=numArr[i];
                }
                sum += numArr[i];
            }
            // foreach(var num in numArr){
            //     if(min > num){
            //         min = num;
            //     }
            //     if(max < num){
            //         max = num;
            //     }
            //     sum += num;
            // }
            System.Console.WriteLine("Min: " + min + " Max: " + max);
            System.Console.WriteLine("sum: " + sum.ToString());
        } 
        // Coin Flip
        public static string TossCoin(){
            string result = "heads";
            Random rand = new Random();
            int coin = rand.Next(10);
            if(coin%2==0){
                result = "tails";
            }
            return result;
        }
        // Multiple toss
        public static double TossMultipleCoins(int num){
            double ratio = 0;
            double heads = 0;
            double tails = 0;
            string side = "";
            System.Console.WriteLine("num: " + num);
            for(var i=0; i<num; i++){
                side = TossCoin();
                System.Console.WriteLine("side: " + side);
                if(side == "heads"){
                    heads++; 
                    System.Console.WriteLine("head count: " + heads);
                }else{
                    tails++; 
                    System.Console.WriteLine("tail count: " + tails);
                }
            }
            if(tails == 0){
                ratio = 1;
            }else{
                ratio = heads/tails;
            }
            System.Console.WriteLine("ratio: " + ratio);
            return Math.Round(ratio,2);
        }
        // Names 
        public static string[] FuncNames(string[] names){
            List<string> newNames = new List<string>();
            Array.Sort(names);
            foreach(var name in names){
                System.Console.WriteLine(name);
            }
            foreach(var name in names){
                if(name.Length>5){
                    newNames.Add(name);
                }
            }
            return newNames.ToArray();
        }
    }
}
