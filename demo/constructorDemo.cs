//this is a demo of how to create constructors, overload them and how to use the this keyword

//Program.cs file

using System;

namespace ConstructorsDemo
{    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(100, "Nate");

            var order = new Order();

            customer.Orders.Add(order);

            
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}

//Customer.cs file
/*using System.Collections.Generic;

namespace ConstructorsDemo
{
    public class Customer
    {
        //declaring fields
        public int Id;
        public string Name;
        public List<Order> Orders; // always initial lists with and empty List

        public Customer()
        {
            //it is the responsibility for the CUstomer class to initialize the Orders List
            Orders = new List<Order>();
        }

        public Customer(int id)
                : this() //this is how you get the current cosntructor to inheret the fields of the blank parameter constructor which initializes the Orders List
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // Although it is possible to pass control up using this method it is not clean coding
        {
            this.Name = name;
        }
    }
}

*/

//Order.cs file
/*
namespace ConstructorsDemo
{
    public class Order
    {
    }
}
*/
