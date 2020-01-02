/*Challenge: Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
Display the count on the console.*/
using System;

namespace divisibleByThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //For loop

            /*for(var i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            //Do-while loop
            /*int j = 1;
            do
            {
                if (j % 3 == 0)
                {
                    Console.WriteLine(j);                    
                }
                j++;
            } while (j <= 100);*/

            //While Loop
            int k = 1;
            while(k < 100)
            {
                if(k % 3 == 0)
                {
                Console.WriteLine(k);
                }
                k++;
            }
        }
    }
}
