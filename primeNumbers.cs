
// This program uses a nested loop to find prime numbers less than 100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab3 {
    class Program {
        static void Main(string[] args) {
        
            //Declaring variables
            int outer;
            int inner;

            //// Create a nested for loop and initializing the variables with the value of 2 because 2 is the first prime number
            for (outer = 2; outer < 100; outer++) {
                for (inner = 2; inner <= (outer / inner); inner++)
                    if ((outer % inner) == 0) break; // if factor found, not prime
                if (inner > (outer / inner))
                    Console.WriteLine("{0} is prime", outer);
            }
        }
    }
}
