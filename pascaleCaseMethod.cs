/*Challenge: Write a program and ask the user to enter a few words separated by a space. 
Use the words to create a variable name with PascalCase. 
 * For example, if the user types: "number of students", display "NumberOfStudents". 
 * Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", 
 the program should still display "NumberOfStudents". */

using System;

namespace PascalCaseMethod.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a few words: ");
                var input = Console.ReadLine();               

                Console.WriteLine(PascaleCase(input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("You must enter a few words. Try again!", ex.Message);
            }            
        }

        public static String PascaleCase(string input)
        {
            var words = input.ToLower().Split(' ');

            string pascaleCase = "";

            foreach (var word in words)
            {
                pascaleCase += Char.ToUpper(word[0]) + word.Substring(1);
            }

            return pascaleCase;
        }
    }
}
