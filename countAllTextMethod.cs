/*Challenge: Write a program that reads a text file and displays the number of words. */

using System;
using System.IO;
using System.Text;

class MainClass {
    public static void Main(string[] args) 
    {

        string path = @"/home/runner/MyTest.txt";

        if (!File.Exists(path)) 
        {
            Console.WriteLine("File does not exist at that location.");
            return;
        }
        Console.WriteLine(CountWords(path));

    }

    public static int CountWords(string path) 
    {
        // Open the file to read from.
        string readText = File.ReadAllText(path);
        //Converting string to array and using Length method to give the count
        return readText.Split().Length;
    }
}
