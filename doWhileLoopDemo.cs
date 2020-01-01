//This program demonstrates how a do while loop can be used. And how a break and continue keyword is used. 
using System;

namespace DoWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*//Better to use a while loop when you don't know how many times you will need to iterate
            Console.WriteLine("Name:");
            var name = Console.ReadLine();
            var i = 0;
            while(i < name.Length)
            {
                Console.WriteLine(name[i]);
                i++;
            }*/

            while(true)
            {
                Console.WriteLine("Name:");
                var input = Console.ReadLine();
                
                if (String.IsNullOrWhiteSpace(input))
                {
                    
                    continue; //will continue to the beginning of the loop
                }

                Console.WriteLine("Age:");
                var age = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(age))
                {
                    Console.WriteLine("must add age too");
                    continue; //will continue to the beginning of the loop
                }

                Console.WriteLine( input + " is " + age + " years old.");
                    break;
                
            }


        }
    }
}
