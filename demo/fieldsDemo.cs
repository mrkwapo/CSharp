using System;

namespace FieldsDemo
{       
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count); //2
        }
    }
}

//Customer.cs file
/*using System.Collections.Generic;

namespace FieldsDemo
{
    public class Customer
    {
        public int Id;
        public string Name;
        //created a list of Order class and named it Orders 
        //In situations where you know a field should only be initialized once, you use the read only modifier to avoid it being overwritten
        public readonly List<Order> Orders = new List<Order>(); //very important to initialize the List field here so it will work in any constructor

        //constructor
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
        //method
        public void Promote()
        {
            //Orders = new List<Order>();//the error is because of the readonly modifier used on line 15 
            //....
        }
    }
}*/

//Order.cs file
/*namespace FieldsDemo
{
    public class Order
    {

    }
}*/
