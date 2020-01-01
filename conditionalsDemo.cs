//This program demonstrates how to use if/else conditional statements and conditional operators.
using System;

namespace ConditionalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = false;
            /*float price;

            if (isGoldCustomer)
                price = 19.95f;
            else 
                price = 29.95f;*/


            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
        }
    }
}
