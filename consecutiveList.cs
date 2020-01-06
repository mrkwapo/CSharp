/*Challenge: Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. 
For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive". */
using System;
using System.Collections.Generic;

class MainClass {
    public static void Main(string[] args) {
        Console.WriteLine("Supply a list of hyphen separated numbers (e.g 5-6-7-8-9):");
        var input = Console.ReadLine();

        string[] series = input.Split('-');

        var numbers = new List<int>();

        foreach(var number in series)
        {
            numbers.Add(Convert.ToInt32(number));
        }

        for (var i = 1; i < numbers.Count; i++) {
            if (numbers[i] > numbers[i + 1]) {
                Console.WriteLine("Not Consecutive");
                break;
            }
            else
                Console.WriteLine("Consecutive");
            break;
        }
    }
}
