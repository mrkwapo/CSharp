//This program is known as Viginere. Like Caesar's Cipher it encrypts a word but uses a keyword instead of a number for the key.
using System;

class MainClass {
    public static void Main(string[] args) {

        //Initializing a counter to itereate through the length of the keyword
        int count = 0;

        Console.Write("plaintext: ");
        string plaintext = Console.ReadLine();

        Console.Write("keyword: ");
        string keyword = Console.ReadLine();

        Console.Write("ciphertext: ");

        for (int i = 0; i < plaintext.Length; i++)
        {
            //Declared a variable so we can use each letter in the keyword as a key
            int key = Shift(keyword[count]);

            //if no wrap around needed this just prints plaintext plus key for lowercase and uppercase letters
            if (Char.IsLower(plaintext[i]) && plaintext[i] + key <= 122) {
                Console.Write("{0}", Convert.ToChar((plaintext[i] + key)));
            }
            if (Char.IsUpper(plaintext[i]) && plaintext[i] + key <= 90) {
                Console.Write("{0}", Convert.ToChar((plaintext[i] + key)));
            }

            //handles plaintext characters that need a wrap around  for lowercase and uppercase letters    
            if (Char.IsLower(plaintext[i]) && plaintext[i] + key > 122) {
                Console.Write("{0}", Convert.ToChar((plaintext[i] - 26) + key));
            }
            if (Char.IsUpper(plaintext[i]) && plaintext[i] + key > 90) {
                Console.Write("{0}", Convert.ToChar((plaintext[i] - 26) + key));
            }

            //preserves spaces and punctuation and does not count itself to shift the value of the keyword letter
            if (Char.IsPunctuation(plaintext[i]) || Char.IsWhiteSpace(plaintext[i])) {
                Console.Write("{0}", plaintext[i]);
                count--;
            }
            //if we reach the last index character in the keyword this resets the counter to zero so we start back at the beginning of the keyword
            if (count + 1 == keyword.Length) {
                count = (count + 1) % keyword.Length;
                count--;
            }

            count++;

        }
        Console.WriteLine();
    }

    //this method converts the values of lowercase and uppercase characters to numbers from 0 to 25. For example, 'A' or 'a' = 0. 'B' or 'b' = 1. 'Z' or 'z' = 25
    public static int Shift(char c) {
        if (Char.IsLower(c)) {
            int value = c - 97;
            return value;
        }
        if (Char.IsUpper(c)) {
            int value = c - 65;
            return value;
        }
        return 1;
    }
}
