//This program generates a new password using the random, array and string class.
using System;

namespace RandomeClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the Random Class
            var random = new Random();

            //instantiaing an Array Class with memory to hold  8 characters
            var buffer = new char[8];
            
           //Storing a random capital letter in the first index of the array
           buffer[0]=(Convert.ToChar(random.Next(65, 90))); //1 random uppercase letter

            //storing 5 lowercase letters in the array starting at index 1 so we don't overwrite index 0 (capital letter) in the buffer array
            for (var i = 1; i <=5; i++)
            {
                //randomizing ASCII numbers to characters from 'a' to 'z'
                buffer[i] = Convert.ToChar(random.Next(97, 122)); //5 random lowercase letters
            }

            // storing 1 random number in the 6th index to avoid overwriting any existing characters in buffer array
            buffer[6] = Convert.ToChar(random.Next(48, 57));

            // storing 1 random special character in the 7th index to avoid overwriting any existing characters in buffer array
            buffer[7] = Convert.ToChar(random.Next(33, 38));

            //instantiating the buffer array to new string
            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
