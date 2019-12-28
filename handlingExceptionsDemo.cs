//This program demostrates exception handling with multiple catch blocks
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                string number = "12345"; 
                byte b = Convert.ToByte(number); //12345 is too large to store in a byte which can only hold a mazimum of 255, therefore an exception will occur
                Console.WriteLine(b);
            }
            //this catch block will catch the OverflowException and display the following error message
            catch (OverflowException)
            {
                Console.WriteLine("An overflow exception occured");

            }
            catch (Exception)
            {

                Console.WriteLine("Another exception was caught");
            }
        }
    }
}
