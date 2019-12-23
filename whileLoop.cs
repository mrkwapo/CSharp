//This program was created to practice the while loop
using System;

class MainClass {
    public static void Main(string[] args) {
        Console.WriteLine("What are 5 activities you want to do?");
        string response = Console.ReadLine();
        int count = 0;
        while (response != "sleep" && response != "nothing" && count != 4) {
            // Continue asking up to 5 activities unless the respond with sleep or nothing as an activity
            Console.WriteLine("Activity {0}?", ((count + 1)+1));
            response = Console.ReadLine();
            count++;
        }
    }
}
