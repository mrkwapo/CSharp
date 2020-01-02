/* Challenge: Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/
using System;

class MainClass {
    public static void Main(string[] args) {
        Console.WriteLine("Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(number + "!= " + Factorial(number));

    }
    static long Factorial(int n) {
        if (n == 0) {
            return 1;
        }
        return n * Factorial(n - 1);
    }
}
