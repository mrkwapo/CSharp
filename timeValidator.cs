/*Challenge: Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
If the user doesn't provide any values, consider it as invalid time. */

using System;

class MainClass {
    public static void Main(string[] args) 
    {
        Console.WriteLine("Enter time (e.g. 19:00): ");
        var input = Console.ReadLine();

        if (String.IsNullOrEmpty(input)) 
        {
            Console.WriteLine("Invalid Time");
            System.Environment.Exit(0);
        }
        TimeValidator(input);
    }
    public static void TimeValidator(string input) 
    {
        var arr = input.Split(':');

        for (var i = 0; i < arr.Length; i++) 
        {
            if (Convert.ToInt32(arr[0]) >= 24 || Convert.ToInt32(arr[0]) < 0 || Convert.ToInt32(arr[1]) < 0 || Convert.ToInt32(arr[1]) >= 60) 
            {
                Console.WriteLine("Invalid Time");
                break;
            }
            else 
            {
                Console.WriteLine("Ok");
                break;
            }
        }
    }
}
