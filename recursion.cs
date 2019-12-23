//This program Factorializes a number using recursion
using System;

class MainClass {
    public static void Main(string[] args) {
        Console.WriteLine("");
        Console.WriteLine("Recursion\n");
        Console.WriteLine("What number do you want Factorialized?");
        int fact = Convert.ToInt32(Console.ReadLine());
        long value = Factorial(fact);
        Console.WriteLine(fact + " factorialized equals " + value);
    }
    static long Factorial(int n) {
        if (n == 0) {
            return 1;
        }
        return n * Factorial(n - 1);
    }



}
