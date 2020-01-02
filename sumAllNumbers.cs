/* This program continuously asks the user to enter a number or "ok" to exit. 
Then it calculate the sum of all the previously entered numbers and displays it on the console.*/

using System;

class MainClass {
    public static void Main(string[] args) {
        int total = 0;

        while (true) {
            Console.WriteLine("Enter a number (or enter ok to exit):");
            var input = Console.ReadLine();

            if (input != "ok") {
                total += Convert.ToInt32(input);
                continue;
            }

            Console.WriteLine("The sum is:  " + total);
            break;
        }
    }
}
