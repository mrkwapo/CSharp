//Created this program to demonstrate a for each loop
using System;

class MainClass {
    public static void Main(string[] args) {
        string[] names = new string[10];
        int count = 0;

        // Process each name in the array.
        foreach(string name in names)
        {
            Console.WriteLine("Iteration: " + (count + 1));
            count++;

        }
    }
}
