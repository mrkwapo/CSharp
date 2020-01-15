/*In this challenge, we're getting started with conditional statements. Check out the Tutorial tab for learning materials and an 
instructional video!

Task
Given an integer, , perform the following conditional actions:

If  is odd, print Weird
If  is even and in the inclusive range of  to , print Not Weird
If  is even and in the inclusive range of  to , print Weird
If  is even and greater than , print Not Weird
Complete the stub code provided in your editor to print whether or not  is weird.*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Number:");
    int N = Convert.ToInt32(Console.ReadLine());

    
      if(N%2 != 0)
      {
      Console.WriteLine("Weird");
      }

      if(N%2 == 0 && N >= 2 && N <=5)
      {
      Console.WriteLine("Not Weird");
      }

      if(N%2 == 0 && N >= 6 && N <=20)
      {
      Console.WriteLine("Weird");
      }

      if(N%2 == 0 &&  N > 20)
      {
      Console.WriteLine("Not Weird");
      }
      

    
  }
}
