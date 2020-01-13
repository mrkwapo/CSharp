using System;

namespace PropertiesDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1984, 8, 4));
            Console.WriteLine(person.Age);//35
        }
    }
}

//Person.cs file
/*using System;

namespace PropertiesDemo
{
    public class Person
    {
        //Auto Implemented Properties should always go on the top
        //internally a private field is set for us doing this get/set method
        //when we don't need set so we use the private set accessor so it becomes readonly and set it in the ctor
        public DateTime Birthdate { get; private set; } 
        public string Name { get; set; }
        public string Username { get; set; }

        //Constructor
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        
        //Calculated properties should always go on the bottom
        public int Age
        {
            get 
            {
                var timeSpan = DateTime.Today - Birthdate; //when you subtract 1 date time from another you get a TimeSpan 
                //12945.00:00:00 (days)
                var year = timeSpan.Days / 365; //12945/365 = 35 (years) see properties 10:10

                return year;
            } 
             
        }
    }
}*/
