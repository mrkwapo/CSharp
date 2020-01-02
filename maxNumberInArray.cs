/*Challenge: Write a program and ask the user to enter a series of numbers separated by comma. 
Find the maximum of the numbers and display it on the console. 
For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.*/

using System;

class MainClass {
    public static void Main(string[] args) {

        Console.WriteLine("Enter a series of numbers (Example format: 1,2,6,3,4 ): ");
        var series = Console.ReadLine();


        //converting the "series" string to an array 
        string[] split = series.Split(',');

        //instantiating a new array to store integers
        var arr = new int();

        //initializing a variable to store the largest number 
        int maxValue = 0;

        //iterating through each string element in the "split" array 
        foreach(string item in split)
        {
            //converting each element in the split array to an integer and storing it in the "arr" array
            arr = Convert.ToInt32(item);

            //to find the largest number we store the value in a variable called maxValue and overwrite the value if the arr integer is larger than the previous value.
            if (arr > maxValue) {
                maxValue = arr;
            }
        }
        Console.WriteLine("The largest number is: " + maxValue);

    }
}
