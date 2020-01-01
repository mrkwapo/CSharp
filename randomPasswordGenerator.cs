//This program uses the random class to generate a password with 1 uppercase letter, 5 lowercase letters and one special character.
using System;

namespace RandomeClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            Console.Write(Convert.ToChar(random.Next(65, 90))); //1 random uppercase letter

            for (var i = 0; i < 5; i++)
            {
                //random ASCII characters from 'a' to 'z'
                Console.Write(Convert.ToChar(random.Next(97, 122))); //5 random lowercase letters
            }

            Console.Write(random.Next(1, 9)); // 1 random number
            Console.WriteLine(Convert.ToChar(random.Next(33, 38))); //1 special character
        }
    }
}
