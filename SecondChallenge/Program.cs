using System;

namespace SecondChallenge
{
    class Program
    {
        // Write a function that takes in the price of an item and a "discount" flag. 
        //Apply a 15% tax to the price. 
        // If the discount flag is toggled, then take $2 off the price.

        public static double CalculatePrice(double price,string discount)
        {
           bool flag= Convert.ToBoolean(discount.ToUpper());
            price= price + price * .15;
            if(flag)
            {
                Console.WriteLine(flag);
                price= price - price * .02;
            }
            return price;
        }
        static void Main(string[] args)
        {
           Console.WriteLine("Please enter the price and if discount is True of false");
           double price= Convert.ToDouble(Console.ReadLine());
           string flag = Console.ReadLine();
           double finalPrice= CalculatePrice(price,flag);
           Console.WriteLine($"The final price is {finalPrice}");
        }
    }
}
