//Turn a string of hyphenated numbers by numbers into a List containing each number
using System;
using System.Collections.Generic;

class MainClass {  

  public static void Main (string[] args) {
    Console.WriteLine ("Supply a list of hyphen separated numbers (e.g 5-6-7-8-9):");
    var input = Console.ReadLine();  

      foreach(var number in Listify(input))
      Console.WriteLine(number);
    
  }

  public static List<int> Listify(string input)
  {
    string[] series = input.Split('-');

    var numbers = new List<int>();

    foreach(var number in series)
    {
      numbers.Add(Convert.ToInt32(number));
    }
    numbers.Sort();
    return numbers;

  }
}
