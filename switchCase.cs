//Im' using this program to practice the switch method
using System;

class MainClass {
  public static void Main (string[] args) {
    //switch Statement

      Console.WriteLine("What's the connection status? \n");
string response = Console.ReadLine();
switch (response)
{
   case "failed":
      Console.WriteLine("First Case");
      break;
   case "success":
      Console.WriteLine("Second Case");
      break;
   case "error":
      Console.WriteLine("Third Case");
      break;
   default:
      Console.WriteLine("Default Case");
      break;
}
  }
}
