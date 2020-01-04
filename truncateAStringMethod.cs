//Turning the truncate a string algorithm into a clean reusable method that we can use in different places
using System;
using System.Collections.Generic;


namespace TruncatingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really really long text";
            var summary = SummarizeText(sentence, 25);
            Console.WriteLine(summary);
            
        }
        
        //Making it a static method because our main method is static so in order for us to call that method from main we need to declare this method as static
        static string SummarizeText(string text, int maxLength = 20) // give the caller and option to set maxLength but set the default value to 20
        {            
            if (text.Length < maxLength)
                return text;
            
            //convert the sentence to an array
            var words = text.Split(' ');

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
            return String.Join(" ", summaryWords) + "..."; // arg 1 is the separator and arg 2 is the list

        }

    }
}
