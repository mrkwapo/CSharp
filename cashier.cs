/*Task
Given the meal price (base cost of a meal), tip percent (the percentage of the meal price being added as tip), and tax percent 
(the percentage of the meal price being added as tax) for a meal, find and print the meal's total cost.
Print the total meal cost, where  the result is a rounded integer( with added tax and tip).*/


using System;

class Solution {

    static double solve(double meal_cost, int tip_percent, int tax_percent) 
    {
        var tipPercent = tip_percent * .01;
        var taxPercent = tax_percent * .01;
        var tip = meal_cost * tipPercent;
        var tax = meal_cost * taxPercent;
        var total = meal_cost + tip + tax;

        return Math.Round(total);
    }

    static void Main(string[] args) 
    {
        Console.WriteLine("Meal cost:");
        double meal_cost = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("tip rate:");
        int tip_percent = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("tax rate:");
        int tax_percent = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Amount Due: " + solve(meal_cost, tip_percent, tax_percent));
    }
}
