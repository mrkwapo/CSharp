//This program will ask a user for a string and it will capitalize all letters in the string
using System;

class MainClass {
    public static void Main(string[] args) {
        
        Console.WriteLine("Before: ");
        string s = Console.ReadLine();

        Console.WriteLine("After: ");

        //iterating through each characeter in the given string
        for (int i = 0, n = s.Length; i < n; i++)
        {
            //if character is lowercase convert it to uppercase
            if (s[i] >= 'a' && s[i] <= 'z') {
                Console.Write("{0}", Convert.ToChar(s[i] - 32));
            }
            else {
                //if it is not lowercase it will just print it
                Console.Write("{0}", Convert.ToChar(s[i]));
            }
        }
        Console.WriteLine();


    }
}
