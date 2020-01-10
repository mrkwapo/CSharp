/*Challenge: Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. 
 * So, if the user enters "inadequate", the program should display 6 on the console. */
using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            var input = Console.ReadLine().ToLower();
            
            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error. You must enter a word!");
                return;
            }            
            
            Console.WriteLine("This word contains {0} vowels.", CountVowels(input));
        }

        public static int CountVowels(string input)
        {
            var count = 0;

            foreach (var letter in input)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                        count++;
                        break;
                }
            }

            return count;
        }
    }
}
