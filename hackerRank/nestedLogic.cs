/*Task
Your local library needs your help! Given the expected and actual return dates for a library book, create a program that calculates 
the fine (if any). The fee structure is as follows:

1. If the book is returned on or before the expected return date, no fine will be charged (i.e.: fine = 0) .
2. If the book is returned after the expected return day but still within the same calendar month and year as the expected return date,
fine = 15 Hackos x (the number of days late).
3. If the book is returned after the expected return month but still within the same calendar year as the expected return date, 
the fine = 500 Hackos x (the number of days late).
4. If the book is returned after the calendar year in which it was expected, there is a fixed fine of 10000 Hackos.

Input Format

The first line contains 3 space-separated integers denoting the respective day, month and year  on which the book was actually returned.
The second line contains 3 space-separated integers denoting the respective day, month and year on which the book was expected to 
be returned (due date).

Sample Input

9 6 2015
6 6 2015
Sample Output

45
*/
using System;

class MainClass {
    public static void Main(string[] args) {
        //Console.WriteLine("Actual Date: (e.g. day, month and year)");
        var actual = Console.ReadLine();
        var actualArr = actual.Split(' ');

        //Console.WriteLine("Expected Date: (e.g. day, month and year)");
        var expected = Console.ReadLine();
        var expectedArr = expected.Split(' ');

        var expectedDay = Convert.ToInt32(expectedArr[0]);
        var expectedMonth = Convert.ToInt32(expectedArr[1]);
        var expectedYear = Convert.ToInt32(expectedArr[2]);

        var actualDay = Convert.ToInt32(actualArr[0]);
        var actualMonth = Convert.ToInt32(actualArr[1]);
        var actualYear = Convert.ToInt32(actualArr[2]);

        //Checks if late by days
        if (expectedDay < actualDay)
            Console.WriteLine((actualDay - expectedDay) * 15);

        //check if late by months
        else if (expectedMonth < actualMonth)
            Console.WriteLine((actualMonth - expectedMonth) * 500);

        //check if late by years
        else if (actualYear > expectedYear)
            Console.WriteLine(10000);

        //No late fee
        else
            Console.WriteLine(0);
    }
}
