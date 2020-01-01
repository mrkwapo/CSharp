//This program demonstrates 4 ways of iteration
using System;

namespace IterationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Smith";

            Console.WriteLine(" For Loop:");
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("\n ForEach Loop:");
            
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            
            Console.WriteLine("\n While Loop:");

            var j = 0;
            while (j < name.Length)
            {
                Console.WriteLine(name[j]);
                j++;
            }
            
            Console.WriteLine("\n Do-While Loop:");
            
            var k = 0;
            do
            {
                Console.WriteLine(name[k]);
                k++;
            } while (k < name.Length);

        }
    }
}
