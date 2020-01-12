using System;

namespace classDemo
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, my name is {1}. Nice to meet you!", to, Name); ;
        }
    public static Person Parse(string str)
    {
        var person = new Person();
        person.Name = str;
        return person;
    }
    }


    class Program
    {
        static void Main(string[] args)
        {

            
            var person = Person.Parse("Nate");            

            person.Introduce("Joe");


        }
    }
}
