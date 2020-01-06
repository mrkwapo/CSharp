/*Challenge: Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
Otherwise, display the 3 smallest numbers in the list. */

using System;
using System.Collections.Generic;

class MainClass {
    public static void Main(string[] args) {
        while (true) {
            try {
                Console.WriteLine("Supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10):");
                var input = Console.ReadLine();

                string[] series = input.Split(',');

                var numbers = new List<int>();

                foreach( var number in series)
                {
                    numbers.Add(Convert.ToInt32(number));
                }

                numbers.Sort();
                if (numbers.Count < 5) {
                    Console.WriteLine("Invalid List. Try Again!");
                    continue;
                }
                else {
                    Console.WriteLine("The 3 smallest numbers are: ");
                    for (var i = 0; i < 3; i++)
                        Console.Write(numbers[i] + " ");
                    break;
                }
            }
            catch (Exception) {
                Console.WriteLine("Invalid List. Try Again!");
                continue;
            }
        }
    }
}
