//This program asks the user for 2 numbers and returns the largest one
using System;

namespace validNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("First Number: ");
                var number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Second Number: ");
                var number2 = Convert.ToInt32(Console.ReadLine());

                if (number1 > number2)
                {
                    Console.WriteLine("{0} is larger.", number1);
                }
                else if (number2 > number1)
                {
                    Console.WriteLine("{0} is larger.", number2);
                }
                else Console.WriteLine("Same. Use different numbers"); //in case the user doesn't give two different numbers
            }
            catch (FormatException) //using this catch method in case a user doesn't input a number
            {

                Console.WriteLine("Use numbers only");
            }
            
        }
    }
}
