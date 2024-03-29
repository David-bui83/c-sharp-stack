﻿using System;
using System.Collections.Generic;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumber();
            PrintOdds();
            PrintSum();
            int[] myNumArr = {1,2,3,4,5};
            LoopArray(myNumArr);
            Console.WriteLine("Find max: " + FinMax(myNumArr));
            GetAverage(myNumArr);
            foreach(var num in OddArray()){
                Console.WriteLine("Odd number: " + num);
            }
            Console.WriteLine("Greater than Y: " + GreaterThanY(myNumArr,3));
            SquareArrayValues(myNumArr);
            int[] myNumArr2 = {1,2,3,-1,4,5};
            EliminateNegative(myNumArr2);
            MinMaxAverage(myNumArr);
            ShiftValues(myNumArr);

            int[] myNumArr3 = {1,2,3,-1,4,5};
            foreach(var num in NumToString(myNumArr3)){
                if(num is int){
                    System.Console.WriteLine("NumToString: " + num.ToString());
                }
                if(num is string){
                    System.Console.WriteLine("NumToString: " + num.ToString());
                }
            };
        }
        // Print 1-255
        public static void PrintNumber(){
            for(int i=1; i<=255; i++){
                System.Console.WriteLine(i);
            }
        }
        // Print odd numbers between 1-255
        public static void PrintOdds(){
            for(int i=0; i<=255; i++){
                if(i%2!=0){
                    System.Console.WriteLine(i);
                }
            }
        }
        // Print Sum
        public static void PrintSum(){
            int sum = 0;
            for(int i=0; i<=255; i++){
                sum+=i;
                System.Console.WriteLine("New Number: " + i.ToString() + ", Sum: " + sum.ToString());
            }
        }
        // Iterating through an array
        public static void LoopArray(int[] numbers){
            foreach(var item in numbers){
                System.Console.WriteLine(item);
            }
        }
        // Fin Max
        public static int FinMax(int[] numbers){
            int max = numbers[0];
            for(int i=0; i<numbers.Length; i++){
                if(max < numbers[i]){
                    max=numbers[i];
                }
            }
            System.Console.WriteLine("max number: " + max);
            return max;
        }
        // Get Average
        public static void GetAverage(int[] numbers){
            int sum = 0;
            int average = 0;
            foreach(var num in numbers){
                sum += num;
            }
            average = sum / numbers.Length;
            System.Console.WriteLine("Average : " + average);
        }
        // Array with Odd Numbers
        public static int[] OddArray(){
            List<int> myList = new List<int>();
            for(int i = 1; i<=255; i++){
                if(i%2!=0){
                    myList.Add(i);
                }
            } 
            return myList.ToArray();
        }
        // Greater than Y
        public static int GreaterThanY(int[] numbers, int y){
            int num = 0;
            foreach(var n in numbers){
                if(n > y){
                    num++;
                }
            }
            return num;
        }
        // Square the Values
        public static void SquareArrayValues(int[] numbers){
            for(var i=0; i<numbers.Length; i++){
                Console.WriteLine("Square: " + (numbers[i] * numbers[i]).ToString());
            }
        }
        // Eliminate Negative Numbers
        public static void EliminateNegative(int[] numbers){
            for(int i = 0;  i< numbers.Length; i++){
                if(numbers[i] < 0){
                    numbers[i] = 0;
                    System.Console.WriteLine(numbers[i]);
                }else{
                    System.Console.WriteLine(numbers[i]);
                }
            }
        }
        // Min, Max, and Average
        public static void MinMaxAverage(int[] numbers){
            int min = numbers[0];
            int max = numbers[0];
            int sum  = 0;
            int average = 0;
            foreach(var num in numbers){
                if(max < num){
                    max = num;
                }
                if(min > num){
                    min = num;
                }
                sum += num;
            }
            average = sum / numbers.Length;
            System.Console.WriteLine("Max: " + max.ToString() + ", Min: " + min.ToString() + ", Average: " + average.ToString());
        }
        // Shifting the values in an array
        public static void ShiftValues(int[] numbers){
            List<int> newNumbers = new List<int>();
            for(var i  = 1; i <numbers.Length; i++){
                newNumbers.Add(numbers[i]);
            }
            newNumbers.Add(0);
            foreach(var num in newNumbers){
                System.Console.WriteLine("ShiftValues: " + num.ToString());
            }
        }
        // Number to String
        public static object[] NumToString(int[] numbers){
            // List<object> newNumbers = new List<object>();
            // for(int i = 0; i<numbers.Length; i++){
            //     if(numbers[i]<0){
            //         newNumbers.Add("Dojo");
            //     }else{
            //         newNumbers.Add(numbers[i]);
            //     }
            // }
            // return newNumbers.ToArray();
            object[] newNumbers = new object[numbers.Length];
            for(int i  = 0; i< numbers.Length; i++){
                if(numbers[i] < 0){
                    newNumbers[i] = "Dojo";
                }else{
                    newNumbers[i] = numbers[i];
                }
            }
            return newNumbers;
        }
    }
}
