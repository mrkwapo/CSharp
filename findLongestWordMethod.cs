/*Challenge: Write a program that reads a text file and displays the longest word in the file.*/
using System;
using System.IO;

class MainClass {
    public static void Main(string[] args) 
    {

        string path = @"/home/runner/MyTest.txt";

        if (!File.Exists(path)) 
        {
            Console.WriteLine("File does not exist at that location.");
            return;
        }
        Console.WriteLine("Longest word: " + FindLongestWord(path));

    }

    public static string FindLongestWord(string path) 
    {
        var longest = "";
        
        // Open the file to read from.
        string readText = File.ReadAllText(path);
        
        //Converting string to array 
        var arr = readText.Split();

        foreach( var word in arr)
        {
            if (word.Length > longest.Length) 
            {
                longest = word;
            }
        }
        return longest;
    }
}
