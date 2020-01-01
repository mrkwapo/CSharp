//This program demonstrates iteration on an array
using System;

namespace IterationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating an array using new operator because it is a Class/ Reference Type
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
