//not done yet!
/*Challenge: Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
The list of numbers may include duplicates. Display the unique numbers that the user has entered. */

using System;
using System.Collections.Generic;

class MainClass {
    public static void Main(string[] args) {

        var numbers = new List<string>();

        while (true) {
            Console.WriteLine("Enter a number:");
            var input = Console.ReadLine();

            if (input == "Quit" || input == "quit" || input == "q" || input == "Q") {
                break;
            }
            numbers.Add(input);


        }

        foreach(var number in numbers)
        {
            if (!numbers.Contains(number))
                Console.Write(number + " ");
        }


    }
}
