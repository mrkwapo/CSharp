/* Given an array, A, of N integers, print A's elements in reverse order as a single line of space-separated numbers.*/
using System;

class Solution {

    static void Main(string[] args) {
        
        Console.WriteLine ("Size of Array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine ("Array: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        
        for(var i = n - 1; i >= 0; i--)        
          Console.Write(arr[i] + " ");
        
    }
}
