using System;

namespace FourthChallenge
{
    class Program
    {

       // Write a function that takes in a number and a string. Return a substring of the original 
       //string of the size of the number.
  // Example: Input is "Hello world" and 7. Output should be "Hello w".
   // If the number is greater than then length of the string, pad the string with dots so that 
   //it matches the length
  //  Example: Input is "Hello" and 10. Output should be "Hello....."
  
        static string MakeSubstring(int number,string str)
        {
           
            if(str.Length>number)
            {
                str= str.Remove(number);
            }
            else
            {
                for(int i=str.Length;i<number;i++)
                {
                    str+='.';                                     
                }                       
            }
            return str;
        }
          static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str= Console.ReadLine();
            Console.WriteLine("Enter a number");
            int n= Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Result is "+ MakeSubstring(n,str));

        }
    }
}
