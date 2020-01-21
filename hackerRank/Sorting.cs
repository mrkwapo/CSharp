//incomplete. Still working on this one.


using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("array length:");
    int n = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Array: ");
    var b = Console.ReadLine();
    var c = b.Split();
    var a = Array.ConvertAll(c, int.Parse);

    var numSwaps = 0;

    for(var i = 0; i < b.Length; i++)
    {
      if(Array.IndexOf(a, a[i]) > Array.IndexOf(a, a[i]+1))
      {
        SwapInts(a, a[i], a[i] + 1 );
        numSwaps++;
      }
    }
  var firstElement = a[0];
  var lastElement = a[n];
  
    Console.WriteLine ("Array is sorted in {0} swaps", numSwaps);

    Console.WriteLine ("First Element: {0}", firstElement);

    Console.WriteLine ("Last Element: {0}", lastElement);
  }

  static void SwapInts(int[] array, int position1, int position2)
    {
        //
        // Swaps elements in an array.
        //
        int temp = array[position1]; // Copy the first position's element
        array[position1] = array[position2]; // Assign to the second element
        array[position2] = temp; // Assign to the first element
    }
}
