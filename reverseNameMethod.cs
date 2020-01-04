//Transformed the algorithm to a method.
using System;

namespace ProceduralProgrammingDemo
{
    class Program
    {
        //The main method is responsible for getting the info from the user and displaying the result
        static void Main(string[] args)
        { 
            Console.WriteLine("Please Enter your First and Last Name (Ex: John Smith): ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine(reversed);
        }

        //this method is responsible for reversing the input
        public static string ReverseName(string name)
        {
            string[] arr = name.Split(' ');
            Array.Reverse(arr);
            return string.Join(", ", arr);
            
        }
    }
}
