//This program counts how many chocalate bars can be made out of a given amount of kilos. 
//It will make as many large bars(5 kilos each) before making small bars (1 kilo each).

using System;

class MainClass {
  public static void Main (string[] args) {
            try
            {
                //asking user for the amount of kilos
                Console.Write("how many kilos?\n");
                int kilos = Convert.ToInt32(Console.ReadLine());
    
                //handling distribution of kilos
                int remainder = kilos % 5;      
      
                Console.WriteLine("We have {0} big bar(s) and {1} small bar(s)\n", kilos / 5, remainder);
                
            }
            catch (FormatException) //using this catch method in case a user doesn't input a number
            {
                Console.WriteLine("Use integers only");
            }               
  }
}
