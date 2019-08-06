using System;

namespace prac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = {1,2,3,4,5};

            Console.WriteLine("Sigma: " + sum(5));
            Console.WriteLine("Average: " + average(numArr));

        }
        public static int sum(int num){
            int sum=0;
            for(int i = 0; i <= num; i++){
                sum += i;
            }
            return sum;
        }
        public static double average(int[] arr){
            double avg =0;
            int sum = 0;
            for(int i = 0; i < arr.Length; i++){
                sum += arr[i];
            } 
            avg = sum / arr.Length;
            return avg;
        }


    }
}
