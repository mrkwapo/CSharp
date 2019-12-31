//This program is known as Caesar's Cipher. It encrypts a plain text message that will shift each letter in the message by the key(a number) given by the user
using System;

class MainClass {
  public static void Main (string[] args) {
    try{
    //getting the plain text and returning the ciphertext
    Console.Write("plaintext: ");
    string p = Console.ReadLine();

    //Getting key from user and using modulo to handle ASCII wrap around
    Console.Write("key: ");
    int key = Convert.ToInt32(Console.ReadLine()) % 26;

    Console.Write("ciphertext: ");    

    //iterating through each character in the plaintext
    for (int i = 0, n = p.Length; i < n; i++)
    {        
        //Declaring a variable that combines the value of each letter plus the key to determine how to handle encryption
        int encrypt = key + p[i];

        //handling encryption for lowercase letters
        if (Char.IsLower(p[i]))
        {         
            //if no wrap around needed encrypt
            if (encrypt < 122)
            {
                Console.Write("{0}", Convert.ToChar(key + p[i]));    
            }
            // if wrap around needed handle wrap around and encrypt
            else if (encrypt > 122)
            {
                Console.Write("{0}",  Convert.ToChar(p[i] - (26 - key)));    
            }

        }
        //handling uppercase letters        
        if (Char.IsUpper(p[i]))
        {
            //if no wrap around needed encrypt
            if (encrypt < 90)
            {
                Console.Write("{0}", Convert.ToChar(key + p[i]));    
            }
            // if wrap around needed handle wrap around and encrypt
            else if (encrypt > 90)
            {
                Console.Write("{0}",  Convert.ToChar(p[i] - (26 - key)));    
            }
            
        }

        // if character is not an alphabet do not shift, just print
        if (!Char.IsLetter(p[i]))
        {
            Console.Write("{0}", p[i]);
        }
    }
    Console.WriteLine();
    }
    catch (Exception)
    {
      Console.WriteLine("The key must be a number");
    }
  }
}
