/*Challenge: Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
The list of numbers may include duplicates. Display the unique numbers that the user has entered. */
using System;
using System.Collections.Generic;

namespace ProceduralProgrammingDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //instantiating a new list to hold numbers that will be input by user
            var numbers = new List<int>();
            
            //Using a loop to continue asking for a number or quit
            while (true)
            {
                Console.WriteLine("Enter a number( Or 'Q' to exit):");

                var input = Console.ReadLine();

                if (input.ToLower() == "q")
                    break;
                
                //converting the number to an integer and adding it to the numbers list
                numbers.Add(Convert.ToInt32(input));
            }
            
            //calling the static method that returns unique numbers only
            var unique = GetUniqueNumbers(numbers);
            
            //sorting the unique numbers
            unique.Sort();
            Console.Write("The uniques numbers you added are: ");
             
            //displaying the unique numbers
            foreach (var number in unique)
                Console.Write(number + " ");
                
            Console.WriteLine();
        }
        
        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            //instantiated a new list to store only unique numbers
            var uniques = new List<int>();
            
            //iterating through the given numbers list when this method is called 
            foreach (var number in numbers)
            {
                //if the number does not exist in the new list "uniques" then add it
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            //return the list with unique numbers
            return uniques;
        }
    }
}
