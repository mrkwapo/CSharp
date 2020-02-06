/*Given a string, S, of length N  that is indexed from 0 to N-1, print its even-indexed and odd-indexed characters as 2 space-separated strings 
on a single line (See the Sample below for more detail).*/

using System;
using System.Collections.Generic;

class MainClass {
    public static void Main(string[] args) {
        Console.WriteLine("Enter the number of Test Cases: ");
        var T = Convert.ToInt32(Console.ReadLine());

        List < string > S = new List<string>();

        var total = 0;

        while (total < T) 
        {

            Console.WriteLine("Words: ");
            var words = Console.ReadLine();

            S.Add(words);

            total++;
        }
        
        for (var i = 0; i < S.Count; i++) 
        {
            var count = 0;
            var word = S[i];

            foreach(var letter in word)
            {
                if (count % 2 == 0) 
                {
                    Console.Write(letter);
                }
                count++;
            }
            Console.Write(" ");

            foreach(var letter in word)
            {
                if (count % 2 != 0) {
                    Console.Write(letter);
                }
                count++;
            }
            Console.WriteLine("");
        }
    }
}
