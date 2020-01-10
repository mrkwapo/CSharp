/*Challenge: Write a program and ask the user to enter a few words separated by a space. Use the words to create a
variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make
sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should
still display "NumberOfStudents".*/
using System;

class MainClass {
    public static void Main(string[] args) 
    {
        Console.WriteLine("Enter a few words: ");
        var input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input)) 
        {
            Console.WriteLine("Error. You must enter a few words!");
            return;
        }

        Console.WriteLine(PascalCase(input));
    }

    public static string PascalCase(string input) 
    {
        var words = input.ToLower().Split();
        var pascalCase = "";
        foreach(var word in words)
        {
            pascalCase += Char.ToUpper(word[0]) + word.Substring(1);
        }
        return pascalCase;
    }
}
