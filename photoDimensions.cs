//This program asks the user for height and width and returns if it is a landscape or portrait photo
using System;


namespace photoDimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Height: ");
                var height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Width: ");
                var width = Convert.ToInt32(Console.ReadLine());

                if (height > width)
                {
                    Console.WriteLine("Portrait");
                }
                else if (width > height)
                {
                    Console.WriteLine("Landscape");
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
