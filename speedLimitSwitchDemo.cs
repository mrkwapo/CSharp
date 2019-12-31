//Although this is not the most efficient way to code this program, it demonstrates the switch method.
//This program asks the user for the speed limit and the cars speed and returns the amount of demerit points
//For every 5 miles over the speed limit the driver is given 1 demerit point. 
//If the demerit points goes over 5 the driver's license gets suspeded.

using System;

class MainClass {
  public static void Main (string[] args) {
    try
            {
                Console.WriteLine("Speed Limit: ");
                var limit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Car Speed: ");
                var speed = Convert.ToInt32(Console.ReadLine());
                var demerit = (speed - limit) / 5;

                switch(demerit)
                {
                  case 0:
                    Console.WriteLine("Ok! You get {0} demerit points", demerit % 1); //modulo makes result equal zero if  demerit is negative
                    break;                
                
                  case 1:
                  case 2:
                  case 3:
                  case 4:
                  case 5:
                  case 6:
                  case 7:
                  case 8:
                  case 9:
                  case 10:
                  case 11:
                  case 12:
                    Console.WriteLine("{0} demerit point(s).", demerit);
                    break;
                

                default:                
                    Console.WriteLine("License Suspended");
                    break;
                }
            }
            catch (FormatException) //using this catch method in case a user doesn't input a number
            {
                Console.WriteLine("Use integers only");
            }            
        
  }
}
