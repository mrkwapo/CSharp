/*CHALLENGE: Write a program and ask the user to enter a few numbers separated by a hyphen. 
If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. 
If so, display "Duplicate" on the console. */

using System;
using System.Collections.Generic;


class MainClass {
    public static void Main(string[] args) {

        Console.WriteLine("Hyphenated numbers: ");
        var input = Console.ReadLine();

        if (String.IsNullOrEmpty(input)) {
            System.Environment.Exit(0);
        }
        FindDuplicate(input);

    }

    public static List<int> FindDuplicate(string input) {
        var split = input.Split('-');

        var numbers = new List<int>();

        foreach(var number in split)
        {
            if (numbers.Contains(Convert.ToInt32(number))) {
                Console.WriteLine("Duplicate: " + number);
                break;
            }
            numbers.Add(Convert.ToInt32(number));
        }
        return numbers;
    }
}
