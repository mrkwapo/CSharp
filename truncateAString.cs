//This program summarizes a sentence or paragraph

using System;
using System.Collections.Generic;

namespace TruncatingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really really long text";
            const int maxLength = 2;

            if (sentence.Length < maxLength)
                Console.WriteLine(sentence);
            else
            {
                //convert the sentence to an array
                var words = sentence.Split(' ');

                //initialize a variabe wo count characters
                var totalCharacters = 0;

                //Instantiate a List to hold each word that doesnt surpass the maxlength
                var summaryWords = new List<string>();

                //iterating through each word
                foreach (var word in words)
                {
                    //add the word to the list
                    summaryWords.Add(word);

                    //counting the characters in each word by using the length of each word +1 to account for the space
                    totalCharacters += word.Length + 1;

                    //if the total characters counter is larger than the designated maxLength then stop
                    if (totalCharacters > maxLength)
                        break;
                }

                //Convert the list to a string
                var summary = String.Join(" ", summaryWords) + "..."; // arg 1 is the separator and arg 2 is the list
                Console.WriteLine(summary);
            }
        }
    }
}
