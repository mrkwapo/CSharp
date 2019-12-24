//this program simply asks the user for a size of coffee they would like to order and returns the price using the switch statement
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab2 {
    class Program {
        static void Main(string[] args) {
            //Showing the user the size options for coffee 
            Console.WriteLine("Choose your coffee sizes: 1=small 2=medium 3=large");
            Console.Write("Please enter your selection: ");

            //Storing the user input in the variable size
            string size = Console.ReadLine();

            //initializing the cost of the coffee to zero
            int cost = 0;

            //Using the switch method to handle the cost of the coffee. 
            //Once a size is selected the value of the variable cost will change accordingly
            switch (size) {
                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 50;
                    break;
                case "3":
                case "large":
                    cost += 75;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                    break;
            }

            //Once the size is successfully selected the cost will change from zero and the program returns a message stating how much the coffee costs
            if (cost != 0) {
                Console.WriteLine("Please insert {0} cents.", cost);
                //After the size is selected and the cost is displayed, the following thank you message is displayed
                Console.WriteLine("Thank you for your business.");
            }


        }
    }
}
