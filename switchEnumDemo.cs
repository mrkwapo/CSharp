//This program demonstrates using the switch statement on an enum
using System;

namespace ConditionalsDemo
{
    class Program
    {
        //this enum was separated to another file but brought onto this file dor demo purposes
        public enum Season
        {
            Spring, //0
            Summer, //1
            Fall, //2
            Winter //3
        }
        static void Main(string[] args)
        {
            Console.WriteLine("what season:");
            //Getting value for season using dot notation
            /*var season = Season.Fall;*/

            //Getting value for season using enum numbers given by user. Had to cast the cases to integers
            var season = Convert.ToInt32(Console.ReadLine());

            switch (season)
            {
                case (int)Season.Spring:
                case (int)Season.Summer:
                    Console.WriteLine("We've got a promotion!");
                    break;
                default:
                    Console.WriteLine("Sorry no promotion.");
                    break;
                
            }
        }
    }
}
