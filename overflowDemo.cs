//This program demonstrates how overflowing can occur and how to prevent it from crashing your program
using System;

namespace OverFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {

           try
            {
                //using checked so overflow will not happen and an exception will be thrown
                checked
                {
                    byte number = 255; // the range of a byte is from 0 to 255 so adding 1 to it would give you 0 instead of 256

                    number += 1;

                    Console.WriteLine(number);
                }
               
            }
            
            //this catches the exception and prints a readable error message
            catch (OverflowException)
            {
                Console.WriteLine("An overflow exception occured");
                
            }

        }
    }
}
