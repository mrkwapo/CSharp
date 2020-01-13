using System;

namespace AccessModifiersDemo
{
    public class Person
    {
        private DateTime _birthdate; // you cant access this outside the Person class so you need a method to set or get it

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1984,08,04));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
