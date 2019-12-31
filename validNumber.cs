//This program asks the user for a valid number between 1 and 10. If the number given is inside of the range it will print "valid" otherwise "invalid".
using System;

namespace validNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number > 0 && number < 11)
            {
                Console.WriteLine("Valid");
            }
            else Console.WriteLine("Invalid");
        }
    }
}
