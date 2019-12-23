using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create variables of different data types
            // initialize with a "default" value
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            int zipcode = 0;
            DateTime birthDate;

            // Assign some values
            firstName = "Chris";
            lastName = "Cringle";
            age = 1749;
            street = "325 S. Santa Claus Lane";
            city = "North Pole";
            country = "Alaska";
            zipcode = 99705;
            birthDate = new DateTime(270, 3, 15);

            // output to the console window

            // use simple output with just variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // use placeholder style
            Console.WriteLine("{0} years old.", age);

            // use string concatenation
            Console.WriteLine(street + ", " + city + ", " + country + ", " + zipcode);

            // use string interpolation
            Console.WriteLine($"Born on {birthDate}");

        }
    }
}
