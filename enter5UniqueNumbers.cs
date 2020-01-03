/*Challenge: Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message
and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console. */

using System;
using System.Collections.Generic;

class MainClass {
    public static void Main(string[] args) {
        Console.WriteLine("Enter 5 unique numbers to be sorted: ");

        //instantiating a new list to hold numbers that will be input by user
        var numbers = new List<int>();

        //Initialized a counter track how many numbers have been added
        int count = 0;

        //Used a loop to continue asking the user for unique numbers
        while (true) {
            Console.WriteLine("Number {0}: ", count + 1);

            //Converting the string input to a number and storing it in a variable 
            int input = Convert.ToInt32(Console.ReadLine());

            //created a condition to reject any repeated numbers  
            if (numbers.Contains(input)) {
                Console.WriteLine("You already entered that number. Enter a different number!");
                continue;
            }

            //if the number has not been repeated then add the number to the list "numbers"
            numbers.Add(input);
            //if the list is not full then continue incrementing the counter
            if (numbers.Count != 5) {
                count++;
                continue;
            }

            //when the list is full, sort the list then display the sorted list numbers
            Console.Write("Your numbers have been sorted: ");

            numbers.Sort();

            foreach( var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            break;

        }
    }
}
