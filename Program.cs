using System;

namespace FirstChallenge
{
    class Program
    {
    // Write a function that takes in a number, and adds together all numbers between 1 and 50 that are multiples of that number.
    // Example: Input is 12 -> Result = 12 + 24 + 36 + 48 = 120

        public static int SumOfMultiplesOfNum(int num)
            {
                int sum=0;
                if(num>0 && num<50)
                {
                    for(int i=1;i<=50;i++)
                    {
                     if(i%num==0)
                         sum+=i;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
               return sum;
            }
        
        static void Main(string[] args)
        { 
            Console.WriteLine("Please enter a number");
            int number= Convert.ToInt32(Console.ReadLine());
            int sum= SumOfMultiplesOfNum(number);
            Console.WriteLine($"The sum of numbers between 1 and 50 which are multiples of {number} is {sum}");
        }
    }
}
