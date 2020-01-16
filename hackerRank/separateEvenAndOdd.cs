/*Given a string, S, of length N  that is indexed from 0 to N-1, print its even-indexed and odd-indexed characters as 2 space-separated strings 
on a single line (see the Sample below for more detail).*/

using System;
using System.Collections.Generic;

class Solution {
    static void Main(String[] args) 
    {        
        int count = 0;
        var words = new List<string>();
        while (count < 3) 
        {
            Console.WriteLine ("String:");
            var S = Console.ReadLine();
            if (!Char.IsNumber(S[0]))
                words.Add(S);
            count++;
        }

        foreach(var word in words)
        {
            foreach(var letter in word)
            {
                if (word.IndexOf(letter) % 2 == 0 && !Char.IsNumber(letter)) 
                {
                    Console.Write(letter);
                }
            }
            Console.Write(" ");

            foreach(var letter in word)
            {
                if (word.IndexOf(letter) % 2 != 0 && !Char.IsNumber(letter)) 
                {
                    Console.Write(letter);
                }
            }
            Console.WriteLine("");
        }
    }
}
