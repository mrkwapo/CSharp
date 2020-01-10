/*Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("English Word: ");
    var input = Console.ReadLine();

    if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error. You must enter a word!");
                return;
            }  

    Console.WriteLine("The word \"{0}\" contains {1} vowels.", input, CountVowels(input.ToLower()));

  }
  public static int CountVowels(string input)
  {
    var count = 0;

    foreach (var letter in input)
    {
      switch(letter)
      {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
        case 'y':
          count++;
          break;

      }
    }
    return count;

  }
}
