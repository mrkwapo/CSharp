/*Challenge: Write a program and ask the user to enter a series of numbers separated by comma. 
Find the maximum of the numbers and display it on the console. 
For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.*/

//Almost Complete working on implementing the max number method

using System;
using System.Linq;
// using static System.Linq.ParallelQuery;
// using System.Linq.ParallelEnumerable.Max<int>;

class MainClass {
    public static void Main(string[] args) {
    
        Console.WriteLine("Enter a series of numbers: (Example of Format: 1,2,3,4,5)";
        var series = Console.ReadLine(); //getting the series string

        string[] split = series.Split(','); //converting the string into an array
        var arr = new int(); //instantiating an array of integers
        
        //Using a foreach loop to convert each string in the array to an integer and storing the values in the array "arr"
        foreach(string item in split)
        {            
            arr = Convert.ToInt32(item);
        }

        //trying to use the .Max Method to find the largest number in the arr array. Recieving errors but will solve errors.
        int maxValue = arr.Max();
        Console.WriteLine(maxValue);

    }
}

