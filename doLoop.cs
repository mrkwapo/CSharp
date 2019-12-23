//This program was created to practice the do loop
using System;

class MainClass {
    public static void Main(string[] args) {
        Console.WriteLine("What are 5 activities you want to do?");
        string response = Console.ReadLine();
        int count = 0;
        do {
            // Process the data.
            Console.WriteLine("Activity {0}?", ((count + 1)+1));
            response = Console.ReadLine();
            count++;
        }
        while (response != "sleep" && response != "nothing" && count != 4); 
    }
}
