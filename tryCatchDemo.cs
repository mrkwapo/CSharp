//This program demonstrates a try/ catch method to handle exceptions/errors
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Initializing variables
            double a = 98, b = 0;
            double result = 0;

            try
            {
                //First, try to run the SafeDivision method and if no exceptions occur it will store  the value into a variable called result.
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1}  = {2}.", a, b, result);
            }catch (DivideByZeroException)
            {
                //if the DivideByZeroException occurs it will be caught here then print the following message to console.
                Console.WriteLine("Attempted to divide by 0.");
            }
        }

        static double SafeDivision(double x, double y)
        {
            //if the program attempts a divide by zero exception, throw error to the the DivideByZero catch block; Otherwise divide x by y
            if(y == 0)            
                throw new System.DivideByZeroException();
            return x / y;
        }
    }
}
