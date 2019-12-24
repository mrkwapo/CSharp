//This is a simple program that will tell the user if the number entered is even or odd using modulo and the if & else statemant
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1 {
    class Program {
        static void Main(string[] args) {
            // Request user input with WriteLine() and ReadLine()
            Console.WriteLine("Please enter an integer value and press Enter.");

            // Assign the entered value to the variable input
            // Because readline accepts string input we convert the input to integer before using
            int input = Int32.Parse(Console.ReadLine());

            // Check to see if the number is even or odd using modulo

            if (input % 2 == 0) {
                Console.WriteLine("{0} is an even number.", input);
            }
            else  // the remainder was not 0 so the value entere is an odd number.
            {
                Console.WriteLine("{0} is an odd number.", input);
            }
        }
    }
}
