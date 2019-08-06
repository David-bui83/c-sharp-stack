using System;

namespace fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(int i = 1; i<=255; i++){
            //     Console.WriteLine(i);
            // }

            // for(int i = 1; i <=100; i++){
            //     if(i%3==0 && i%5==0){
            //         continue;
            //     }else if((i%3!=0 && i%5==0)||(i%3==0 && i%5!=0)){
            //         Console.WriteLine(i);
            //     }
            // }

            // for(int i = 1; i<=100; i++){
            //     if(i%3==0 && i%5==0){
            //         Console.WriteLine("FizzBuzz");
            //     }else if(i%3==0 && i%5!=0){
            //         Console.WriteLine("Fizz");
            //     }else if(i%3!=0 && i%5==0){
            //         Console.WriteLine("Buzz");
            //     }else{
            //         Console.WriteLine(i);
            //     }
            // }
            
            int i = 1;
            while(i<=100){
                if(i%3==0 && i%5==0){
                    Console.WriteLine("FizzBuzz");
                }else if(i%3==0 && i%5!=0){
                    Console.WriteLine("Fizz");
                }else if(i%3!=0 && i%5==0){
                    Console.WriteLine("Buzz");
                }else{
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
