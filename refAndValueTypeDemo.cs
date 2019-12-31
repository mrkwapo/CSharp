//This program demonstrates the difference in memory management of reference types versus Value Types
using System;

namespace ReferenceTypeandValueTypeDemo2
{    
    public class Person
    {
        public int Age;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number); //prints 1 because var number is a value type so only a copy is passed to increment method

            //creating new Person objects and using object initialization syntax to set their field, "Age".
            //then using the MakeOld method to modify the age field
            var person = new Person() { Age = 35 };
            MakeOld(person);
            
            var man = new Person() { Age = 20 };
            MakeOld(man);
            
            //demonstrating the Age field can be changed in the class objects because they are refrence types
            Console.WriteLine(person.Age); 
            Console.WriteLine(man.Age);
        }

        //Method which only accepts integers as an arguement
        public static void Increment(int integerVariableName)
        {
            integerVariableName += 10;
        }

        //Method which only accepts Person class object and adds 10 to the Age field
        public static void MakeOld(Person newObjectname)
        {
            newObjectname.Age += 10;
        }
    }
}
