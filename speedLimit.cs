//This program asks the user for the speed limit and the cars speed and returns the amount of demerit points
//For every 5 miles over the speed limit the driver is given 1 demerit point. 
//If the demerit points goes over 5 the driver's license gets suspeded.
using System;

namespace photoDimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Speed Limit: ");
                var limit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Car Speed: ");
                var speed = Convert.ToInt32(Console.ReadLine());

                var difference = speed - limit;
                var demerit = difference / 5;

                if (demerit < 1)
                {
                    Console.WriteLine("Ok! You get {0} demerit points", demerit % 1); //modulo makes result equal zero if  demerit is negative
                }
                else if (demerit <= 12)
                {                    
                    Console.WriteLine("{0} demerit point(s).", demerit);
                }

                else if( demerit > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
            catch (FormatException) //using this catch method in case a user doesn't input a number
            {
                Console.WriteLine("Use integers only");
            }            
        }
    }
}
