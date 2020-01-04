/*Challenge: Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a 
new string. Display the reversed name on the console. */

using System;

class MainClass {
    public static void Main(string[] args) {

        Console.WriteLine("Please Enter your First and Last Name (Ex: John Smith): ");
        var name = Console.ReadLine();

        string[] arr = name.Split(' ');

        Array.Reverse(arr);

        var newString = string.Join(", ", arr);

        Console.WriteLine(newString);
    }
}
