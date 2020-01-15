/*Given an integer, , print its first  multiples. */

using System;

class MainClass 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Number:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (var i = 1; i <= 10; i++) 
        {
            Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
        }
    }
}
