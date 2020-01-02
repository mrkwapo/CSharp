/* Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
If the user guesses the number, display “You won"; otherwise, display “You lost". */
using System;

class MainClass {
    public static void Main(string[] args) {

        var random = new Random().Next(1, 10);
        int count = 0;

        //Uncomment the following line to see the winning number
        //Console.WriteLine(random);
        do {
            Console.WriteLine("Guess #{0}: ", count + 1);
            var guess = Convert.ToInt32(Console.ReadLine());
            count++;
            if (count == 4 && guess != random) {
                Console.WriteLine("You lost!");
            }
            else if (guess == random) {
                Console.WriteLine("You Win!");
                break;
            }
        } while (count != 4);
    }

}
